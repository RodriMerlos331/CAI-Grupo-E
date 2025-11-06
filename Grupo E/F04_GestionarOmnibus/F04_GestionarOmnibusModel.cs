using Grupo_E.Almacenes;
using Grupo_E.F04_GestionarOmnibus;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Grupo_E.GestionarOmnibus
{
    internal class F04_GestionarOmnibusModel
    {

        private Dictionary<string, List<EncomiendasABajar>> EncomiendasARecepcionarPorPatente = new Dictionary<string, List<EncomiendasABajar>>();
        private Dictionary<string, List<EncomiendasASubir>> EncomiendasAEntregarPorPatente = new Dictionary<string, List<EncomiendasASubir>>();



        // Conversión de tipo de bulto a equivalentes XL

        private decimal EquivalenteXL(TipoBultoEnum tipo)
        {
            switch (tipo)
            {
                case TipoBultoEnum.S: return 0.125m;  // 2.5 kg
                case TipoBultoEnum.M: return 0.25m;   // 5 kg
                case TipoBultoEnum.L: return 0.5m;    // 10 kg
                case TipoBultoEnum.XL: return 1.0m;    // 20 kg
                default: return 0;
            }
        }

        //Capacidad máxima (en equivalentes XL) según arrendamiento
        private decimal CapacidadMaximaXLPorArrendamiento(TipoArrendamientoEnum tipo)
        {
            switch (tipo)
            {
                case TipoArrendamientoEnum.A: return 20m;
                case TipoArrendamientoEnum.B: return 10m;
                case TipoArrendamientoEnum.C: return 7m;
                case TipoArrendamientoEnum.D: return 3m;
                default: return 0m;
            }
        }


        //  Selección por capacidad (prioriza por fecha de imposición)

        private List<EncomiendaEntidad> SeleccionarPorCapacidad(List<EncomiendaEntidad> candidatas, decimal capacidadXL)
        {
            var seleccionadas = new List<EncomiendaEntidad>();
            decimal acumulado = 0;

            foreach (var e in candidatas.OrderBy(x => x.FechaImposicion))
            {
                var pesoXL = EquivalenteXL(e.TipoBulto);

                if (acumulado + pesoXL <= capacidadXL)
                {
                    seleccionadas.Add(e);
                    acumulado += pesoXL;
                }
                else
                {
                    break; // cuando se supera la capacidad, corta
                }
            }

            return seleccionadas;
        }

        internal List<EncomiendasASubir> EncomiendasASubir(string patente)
        {
            var pat = (patente ?? "").Trim().ToUpperInvariant();
            var cdActual = CentroDeDistribucionAlmacen.CentroDistribucionActual?.CodigoCD;

            var omni = OmnibusAlmacen.Omnibus
                .FirstOrDefault(o => (o.Patente ?? "").Trim().ToUpperInvariant() == pat);

            if (omni == null || string.IsNullOrEmpty(cdActual))
            {
                MessageBox.Show("No se encontró el ómnibus o el CD actual no está configurado.");
                return null;
            }

            // Paradas del servicio para el CD actual
            var paradas = omni.Paradas.Where(p => p.CodigoCD == cdActual).ToList();


            // Estados de HDR válidos para embarcar
            var codParadasSet = paradas.Select(p => p.CodigoParada).ToList();
            var hdrsServicio = HDR_Distribucion_MDAlmacen.HDR_Distribucion_MD
                .Where(h => (h.estadoHDR == EstadoHDREnum.Asignada || h.estadoHDR == EstadoHDREnum.EnTransito)
                            && codParadasSet.Contains(h.CodigoParada))
                .ToList();

            // Conjunto de trackings ruteados en alguna HDR del servicio
            var trackingsRuteados = hdrsServicio
                .SelectMany(h => (h.Encomiendas ?? new List<string>()).Select(n => n.ToString()))
                .ToList();

            // Capacidad máxima del ómnibus
            var capacidadXL = CapacidadMaximaXLPorArrendamiento(omni.Tipo);

            // validaciones a cumplir:
            //  Estado Admitida
            //  Su ruta contiene alguna parada del servicio
            //  Y su tracking aparece en alguna HDR del servicio
            var candidatas = EncomiendaAlmacen.Encomienda
                .Where(e => e.Estado == EstadoEncomiendaEnum.Admitida
                            && e.ParadasRuta != null
                            && e.ParadasRuta.Any(r => codParadasSet.Contains(r))
                            && trackingsRuteados.Contains(e.Tracking))
                .ToList();

            // Selección por capacidad con prioridad por FechaImposicion
            var seleccionadas = SeleccionarPorCapacidad(candidatas, capacidadXL);


            var resultado = new List<EncomiendasASubir>();
            foreach (var e in seleccionadas.OrderBy(x => x.FechaImposicion))
            {
                var hdr = hdrsServicio.FirstOrDefault(h => (h.Encomiendas ?? new List<string>())
                                                           .Any(n => n.ToString() == e.Tracking));
                if (hdr != null)
                {
                    resultado.Add(new EncomiendasASubir
                    {
                        IdHdr = hdr.NumeroHDRMD.ToString(),
                        Tracking = e.Tracking,
                        TipoDeBulto = e.TipoBulto.ToString()
                    });
                }
            }

            EncomiendasAEntregarPorPatente[pat] = resultado;
            return resultado.Count > 0 ? resultado : null;
        }



        internal List<EncomiendasABajar> EncomiendasABajar(string patente)
        {

            // Normalizo la patente
            var pat = (patente ?? "").Trim().ToUpperInvariant();
            var cdActual = CentroDeDistribucionAlmacen.CentroDistribucionActual?.CodigoCD;

            // Busco el omnibus con esa patente
            var omni = OmnibusAlmacen.Omnibus.FirstOrDefault(o => o.Patente.ToUpperInvariant() == pat);

            if (omni == null || string.IsNullOrEmpty(cdActual))
            {
                MessageBox.Show("No se encontró el ómnibus o el CD actual no está configurado.");
                return null;
            }

            // Paradas en el CD actual
            var paradas = omni.Paradas
                .Where(p => p.CodigoCD == cdActual)
                .ToList();

            // Armo la lista de encomiendas a bajar
            var resultado = paradas
        .SelectMany(p => HDR_Distribucion_MDAlmacen.HDR_Distribucion_MD
            .Where(h => h.estadoHDR == EstadoHDREnum.EnTransito && h.CodigoParada == p.CodigoParada)
            .SelectMany(h =>
                (p.ABajar ?? new List<string>())
                    .Where(t => (h.Encomiendas ?? new List<string>()).Select(n => n.ToString()).Contains(t))
                    .Select(t => EncomiendaAlmacen.Encomienda.FirstOrDefault(e => e.Tracking == t))
                    .Where(e => e != null && e.Estado == EstadoEncomiendaEnum.EnTransitoMD)
                    .Select(e => new EncomiendasABajar
                    {
                        IdHdr = h.NumeroHDRMD.ToString(),
                        Tracking = e.Tracking,
                        TipoDeBulto = e.TipoBulto.ToString()
                    })
            )
        )
        .ToList();

            EncomiendasARecepcionarPorPatente[pat] = resultado;

            return resultado.Count > 0 ? resultado : null;


        }


        internal bool AceptarGestionOmnibus(List<EncomiendasASubir> EncomiendasASubir, List<EncomiendasABajar> EncomiendasABajar)
        {

            var bajarSet = EncomiendasABajar;
            var subirSet = EncomiendasASubir;
            var trackingsBajar = bajarSet.Select(e => e.Tracking).ToList();
            var trackingsSubir = subirSet.Select(e => e.Tracking).ToList();

            foreach (var tracking in trackingsBajar)
            {
                //tengo que ir al almacen de HDr comparo las listas de encomiendas con mi tracking sicoincide lo tomo a esa hdr y hago el cambio de estado a cumplida
                var encomienda = EncomiendaAlmacen.Encomienda.FirstOrDefault(e => e.Tracking == tracking);
                if (encomienda != null)
                {
                    encomienda.HistorialCambios 
                        .Add(new Historial
                        {
                            Tracking = encomienda.Tracking,
                            EstadoPrevio = encomienda.Estado,
                            FechaPrevia = DateTime.Now,
                            UbicacionPrevia = encomienda.CodCDActual,
                        });
                    encomienda.Estado = !string.IsNullOrEmpty(encomienda.DireccionDestinatario)
                                     ? EstadoEncomiendaEnum.PendienteEntregaDomicilio
                                     :!string.IsNullOrEmpty(encomienda.AgenciaDestino)
                                     ? EstadoEncomiendaEnum.PendienteEntregaAgencia
                                     :EstadoEncomiendaEnum.PendienteRetiroCD;

                    encomienda.CodCDActual = CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoCD;

                }
            }


        }
    }
}

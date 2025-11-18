using Grupo_E.Almacenes;
using Grupo_E.F04_GestionarOmnibus;
using Grupo_E.F05_GestionarFletero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Grupo_E.GestionarOmnibus
{
    internal class F04_GestionarOmnibusModel
    {
        
        private List<HDR_Distribucion_MDEntidad> HDRsASubirPendientes = new List<HDR_Distribucion_MDEntidad>();

        
        private List<HDR_Distribucion_MDEntidad> hdrsParaEsteCD = new List<HDR_Distribucion_MDEntidad>(); //A BAJAR

        internal List<EncomiendasABajar> EncomiendasABajar(string patente)
        {
            var omnibusActual = OmnibusAlmacen.Omnibus
                .FirstOrDefault(o => o.Patente == patente);

            var cdActual = CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoCD;

            hdrsParaEsteCD = HDR_Distribucion_MDAlmacen.HDR_Distribucion_MD
                .Where(hdr =>
                    hdr.ServicioID == omnibusActual.ServicioID &&
                    hdr.CdHasta == cdActual &&
                    hdr.estadoHDR == EstadoHDREnum.EnTransito
                )
                .ToList();


            var encomiendasABajarEntidad = EncomiendaAlmacen.Encomienda
                .Where(e => hdrsParaEsteCD.Any(h => h.Encomiendas.Contains(e.Tracking)))
                .ToList();

            var encomiendasABajar = hdrsParaEsteCD
                .SelectMany(hdr => hdr.Encomiendas.Select(tracking =>
                {
                    var encomienda = encomiendasABajarEntidad
                        .FirstOrDefault(e => e.Tracking == tracking);

                    return new EncomiendasABajar
                    {
                        IdHdr = hdr.NumeroHDRMD.ToString(),
                        Tracking = encomienda?.Tracking,
                        TipoDeBulto = encomienda?.TipoBulto.ToString()
                    };
                }))
                .ToList();

            return encomiendasABajar;
        }
        internal List<EncomiendasASubir> EncomiendasASubir(string patente)
        {
            var omnibusActual = OmnibusAlmacen.Omnibus
                .FirstOrDefault(o => o.Patente == patente);

            var cdActual = CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoCD;
            var encomiendasASubir = new List<EncomiendasASubir>();

            var encomiendasASubirEntidad = EncomiendaAlmacen.Encomienda
                .Where(e =>
                    e.CodCDActual == cdActual &&
                    e.RecorridoPlanificado.Any(rp =>
                        rp.ServicioId.ToString() == omnibusActual.ServicioID &&
                        rp.CodigoCDOrigen == cdActual
                    )
                )
                .ToList();

            // Agrupar encomiendas por destino (para un HDR por destino)
            var gruposPorDestino = encomiendasASubirEntidad
                .GroupBy(e =>
                    e.RecorridoPlanificado
                     .First(rp => rp.CodigoCDOrigen == cdActual).CodigoCDDestino
                );

            // Último número HDR existente
            int ultimoNumeroHDR = HDR_Distribucion_MDAlmacen.HDR_Distribucion_MD
                .Select(h => h.NumeroHDRMD)
                .DefaultIfEmpty(1000)
                .Max();

            // *** IMPORTANTE ***
            // Limpiamos los HDR pendientes antes de generar nuevos, así cada busqueda no me pisa la anterior generada
            HDRsASubirPendientes.Clear();

            foreach (var grupo in gruposPorDestino)
            {
                var hdr = new HDR_Distribucion_MDEntidad
                {
                    NumeroHDRMD = ++ultimoNumeroHDR,
                    estadoHDR = EstadoHDREnum.Asignada,
                    ServicioID = omnibusActual.ServicioID,
                    CdDesde = cdActual,
                    CdHasta = grupo.Key,
                    Encomiendas = grupo.Select(e => e.Tracking).ToList()
                };

                // NO persistimos aún → guardamos temporalmente
                HDRsASubirPendientes.Add(hdr);
            }

            // Construir lista visual para el form
            encomiendasASubir = HDRsASubirPendientes
                .SelectMany(hdr => hdr.Encomiendas.Select(tracking =>
                {
                    var encomienda = encomiendasASubirEntidad.First(e => e.Tracking == tracking);

                    return new EncomiendasASubir
                    {
                        IdHdr = hdr.NumeroHDRMD.ToString(),
                        Tracking = encomienda.Tracking,
                        TipoDeBulto = encomienda.TipoBulto.ToString()
                    };
                }))
                .ToList();

            return encomiendasASubir;
        }




        /*
        public OmnibusEntidad BuscarOmnibus(string patente)
        {
            return OmnibusAlmacen.Omnibus
                .FirstOrDefault(o => o.Patente == patente);
        }
        */

        public bool ValidarOmnibus(string patente)
        {
            var omnibus = OmnibusAlmacen.Omnibus
                .FirstOrDefault(o => o.Patente == patente);

            if (omnibus == null)
            {
                MessageBox.Show(
                    "El ómnibus con la patente ingresada no existe.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            var cdActual = CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoCD;

            bool pasaPorCD = omnibus.Paradas.Any(p => p.CodigoCD == cdActual);

            if (!pasaPorCD)
            {
                MessageBox.Show(
                    $"El ómnibus {patente} no pasa por el Centro de Distribución actual ({cdActual}).",
                    "Recorrido inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            return true;
        }





        // SOLO acá se persiste TODO lo pendiente
        public bool AceptarGestionOmnibus()
        {
            var cdActual = CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoCD;
            

            //A SUBIR
            
            foreach (var hdr in HDRsASubirPendientes)
            {
                hdr.estadoHDR = EstadoHDREnum.EnTransito;

                var encomiendas = EncomiendaAlmacen.Encomienda
                    .Where(e => hdr.Encomiendas.Contains(e.Tracking))
                    .ToList();

                foreach (var encomienda in encomiendas)
                {
                    var estadoPrevio = encomienda.Estado;

                    encomienda.Estado = EstadoEncomiendaEnum.EnTransitoMD;
                    encomienda.CodCDActual = null;

                    encomienda.HistorialCambios.Add(new Historial
                    {
                        Tracking = encomienda.Tracking,
                        FechaPrevia = (DateTime)encomienda.FechaAdmision,
                        UbicacionPrevia = cdActual,
                        FleteroAsignado = 0,
                        NumeroHDRUM = 0,
                        NumeroHDRMD = hdr.NumeroHDRMD,
                        EstadoPrevio = estadoPrevio
                    });
                }
            }
            foreach (var hdr in HDRsASubirPendientes)
            {
                HDR_Distribucion_MDAlmacen.HDR_Distribucion_MD.Add(hdr);
            }

            HDRsASubirPendientes.Clear();

            

            //A BAJAR
  
            foreach (var hdr in hdrsParaEsteCD)
            {
                hdr.estadoHDR = EstadoHDREnum.Cumplida;

                var encomiendas = EncomiendaAlmacen.Encomienda
                    .Where(e => hdr.Encomiendas.Contains(e.Tracking))
                    .ToList();

                foreach (var encomienda in encomiendas)
                {
                    encomienda.CodCDActual = cdActual;

                    bool esDestinoFinal = encomienda.CodCentroDistribucionDestino == cdActual;

                    if (esDestinoFinal)
                    {
                        if (string.IsNullOrEmpty(encomienda.AgenciaDestino) &&
                            string.IsNullOrEmpty(encomienda.DireccionDestinatario))
                        {
                            encomienda.Estado = EstadoEncomiendaEnum.PendienteRetiroCD;
                        }
                        else if (!string.IsNullOrEmpty(encomienda.DireccionDestinatario))
                        {
                            encomienda.Estado = EstadoEncomiendaEnum.PendienteEntregaDomicilio;
                        }
                        else if (!string.IsNullOrEmpty(encomienda.AgenciaDestino))
                        {
                            encomienda.Estado = EstadoEncomiendaEnum.PendienteEntregaAgencia;
                        }
                    }
                    else
                    {
                        encomienda.Estado = EstadoEncomiendaEnum.EnTransitoMD;
                    }
                }
            }

            return true;
        }
    }
}

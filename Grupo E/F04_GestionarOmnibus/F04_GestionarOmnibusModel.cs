using Grupo_E.Almacenes;
using Grupo_E.F04_GestionarOmnibus;
using Grupo_E.F05_GestionarFletero;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Grupo_E.GestionarOmnibus
{
    internal class F04_GestionarOmnibusModel
    {

 
        string patenteActual = "";

        internal List<EncomiendasASubir> EncomiendasASubir(string patente)
        {
            var omnibusActual = OmnibusAlmacen.Omnibus
          .FirstOrDefault(o => o.Patente == patente);

            var cdActual = CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoCD;

            var paradaActual = omnibusActual.Paradas
                    .FirstOrDefault(p => p.CodigoCD == cdActual);

            var encomiendasASubirEntidad = EncomiendaAlmacen.Encomienda
         .Where(e =>
             e.CodCDActual == cdActual &&
             e.RecorridoPlanificado.Any(rp =>
                 rp.ServicioId.ToString() == omnibusActual.ServicioID &&
                 rp.CodigoCDOrigen == cdActual
             )
         )
         .ToList();

            var gruposPorDestino = encomiendasASubirEntidad
        .GroupBy(e =>
            e.RecorridoPlanificado
             .First(rp => rp.CodigoCDOrigen == cdActual).CodigoCDDestino
        );
            var hdrsGeneradas = new List<HDR_Distribucion_MDEntidad>();

            int ultimoNumeroHDR = HDR_Distribucion_MDAlmacen.HDR_Distribucion_MD
       .Select(h => h.NumeroHDRMD)
       .DefaultIfEmpty(1000)
       .Max();

            //Creo HDR para cada destino del servicioID al cual estoy subiendo la encomienda

            foreach (var grupo in gruposPorDestino)
            {
                var hdr = new HDR_Distribucion_MDEntidad
                {
                    NumeroHDRMD = ++ultimoNumeroHDR,
                    estadoHDR = EstadoHDREnum.Asignada, // al darle aceptar debería pasar a EnTransito
                    ServicioID = omnibusActual.ServicioID,
                    CdDesde = cdActual,
                    CdHasta = grupo.Key,
                    Encomiendas = grupo.Select(e => e.Tracking).ToList()
                };

                hdrsGeneradas.Add(hdr);
                HDR_Distribucion_MDAlmacen.HDR_Distribucion_MD.Add(hdr);
            }

            var encomiendasASubir = hdrsGeneradas
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

        internal List<EncomiendasABajar> EncomiendasABajar(string patente)
        {
            var omnibusActual = OmnibusAlmacen.Omnibus
        .FirstOrDefault(o => o.Patente == patente);

            
            var cdActual = CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoCD;

            var hdrsParaEsteCD = HDR_Distribucion_MDAlmacen.HDR_Distribucion_MD
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
                    var encomienda = encomiendasABajarEntidad.FirstOrDefault(e => e.Tracking == tracking);

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

        public bool AceptarGestionOmnibus()
        {
            var cdActual = CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoCD;

            var hdrsQueSalen = HDR_Distribucion_MDAlmacen.HDR_Distribucion_MD
                .Where(h => h.CdDesde == cdActual && h.estadoHDR == EstadoHDREnum.Asignada)
                .ToList();

            foreach (var hdr in hdrsQueSalen)
            {
                hdr.estadoHDR = EstadoHDREnum.EnTransito;

                var encomiendas = EncomiendaAlmacen.Encomienda
                    .Where(e => hdr.Encomiendas.Contains(e.Tracking))
                    .ToList();

                foreach (var encomienda in encomiendas)
                {
                    var estadoPrevio = encomienda.Estado;
                    encomienda.Estado = EstadoEncomiendaEnum.EnTransitoMD; 
                    encomienda.CodCDActual =null;  //null mientras está en transito

                    encomienda.HistorialCambios.Add(new Historial
                    {
                        Tracking = encomienda.Tracking,
                        FechaPrevia = (DateTime)encomienda.FechaAdmision,
                        UbicacionPrevia = cdActual,
                        FleteroAsignado = 0,
                        NumeroHDRUM = 0,
                        NumeroHDRMD = 0,
                        EstadoPrevio = estadoPrevio
                    }); 
                }
            }

            var hdrsQueLlegan = HDR_Distribucion_MDAlmacen.HDR_Distribucion_MD
                .Where(h => h.CdHasta == cdActual && h.estadoHDR == EstadoHDREnum.EnTransito)
                .ToList();

            foreach (var hdr in hdrsQueLlegan)
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

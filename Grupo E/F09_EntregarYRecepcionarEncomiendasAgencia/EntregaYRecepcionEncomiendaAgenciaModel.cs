using Grupo_E.Almacenes;
using Grupo_E.ConsultarEstadoEncomienda;
using Grupo_E.EntregarYRecepcionarEncomiendaAgencia;
using Grupo_E.F05_GestionarFletero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.F09_EntregarYRecepcionarEncomiendasAgencia
{
	internal class EntregaYRecepcionEncomiendaAgenciaModel
	{
        public Dictionary<string, GuiaDeEncomiendas> data;
        public List<GuiaDeEncomiendas> encomiendasAEntregar;
        public List<GuiaDeEncomiendas> encomiendasARecibir;

        internal Dictionary<string, GuiaDeEncomiendas> BuscarEncomiendaFletero (int dni)
        {
            data = new Dictionary<string, GuiaDeEncomiendas>();

            foreach (EncomiendaEntidad encomienda in EncomiendaAlmacen.Encomienda)
            {
                data.Add(encomienda.Tracking, new GuiaDeEncomiendas
                {
                    TrackingId = encomienda.Tracking,
                    EstadoEnvio = (EstadoDeEnvio)encomienda.Estado,
                    AgenciaDestino = encomienda.AgenciaDestino,
                    AgenciaOrigen = encomienda.AgenciaOrigen,
                    TamañoBulto = encomienda.TipoBulto.ToString(),
                    FleteroAsignado = FleteroAlmacen.Fletero
                        .FirstOrDefault(f =>
                            HDRDistribucionUMAlmacen.HDRDistribucionUM.Any(hdr =>
                                hdr.DniFleteroAsignado == f.DniFletero &&
                                hdr.Encomiendas.Contains(encomienda.Tracking)))
                        ?.DniFletero ?? 0


                });

            }

            return data;    
        }

        public List<GuiaDeEncomiendas> EncomiendasAEntregar(int dni)
        {

            List<GuiaDeEncomiendas> encomiendasAEntregar = new List<GuiaDeEncomiendas>();

            foreach (var encomienda in BuscarEncomiendaFletero(dni))
            {
                if (encomienda.Value.EstadoEnvio == EstadoDeEnvio.EnTransitoUMOrigen && AgenciaAlmacen.AgenciaActual.CodigoAgencia == encomienda.Value.AgenciaOrigen)
                {
                    encomiendasAEntregar.Add 
                    (
                        new GuiaDeEncomiendas
                        {
                            TrackingId = encomienda.Value.TrackingId,
                            EstadoEnvio = encomienda.Value.EstadoEnvio,
                            AgenciaDestino = encomienda.Value.AgenciaDestino,
                            AgenciaOrigen = encomienda.Value.AgenciaOrigen,
                            TamañoBulto = encomienda.Value.TamañoBulto,
                            FleteroAsignado = encomienda.Value.FleteroAsignado
                        }
                    );
                }
            }

            return encomiendasAEntregar;
        }

        public List<GuiaDeEncomiendas> EncomiendasARecibir(int dni)
        {
            List<GuiaDeEncomiendas> encomiendasARecibir = new List<GuiaDeEncomiendas>();

            foreach (var encomienda in BuscarEncomiendaFletero(dni))
            {
                if (encomienda.Value.EstadoEnvio == EstadoDeEnvio.EnTransitoUMDestino && AgenciaAlmacen.AgenciaActual.CodigoAgencia == encomienda.Value.AgenciaOrigen 
                 
                    && HDRDistribucionUMAlmacen.HDRDistribucionUM.Any(hdr => hdr.Encomiendas.Contains(encomienda.Value.TrackingId) && hdr.Tipo == Tipo.Retiro))
                {
                    encomiendasARecibir.Add
                    (
                        new GuiaDeEncomiendas
                        {
                            TrackingId = encomienda.Value.TrackingId,
                            EstadoEnvio = encomienda.Value.EstadoEnvio,
                            AgenciaDestino = encomienda.Value.AgenciaDestino,
                            AgenciaOrigen = encomienda.Value.AgenciaOrigen,
                            TamañoBulto = encomienda.Value.TamañoBulto,
                            FleteroAsignado = encomienda.Value.FleteroAsignado
                        }

                    );
                }
            }

            return encomiendasARecibir;
        }

        public void AceptarCambiosEncomiendas ()
        {
            if(encomiendasAEntregar == null && encomiendasARecibir == null)
            {
                MessageBox.Show("No hay encomiendas para recibir o entregar.");
                return;
            }
            else
            {
                foreach (var encomienda in encomiendasAEntregar)
                {
                    var encomiendaAlmacen = EncomiendaAlmacen.Encomienda
                        .FirstOrDefault(e => e.Tracking == encomienda.TrackingId);
                      
                    var nuevoHistorial = new Historial
                    {
                        Tracking = encomiendaAlmacen.Tracking,
                        FechaPrevia = DateTime.Now,
                        UbicacionPrevia = AgenciaAlmacen.AgenciaActual.NombreAgencia,
                        FleteroAsignado = encomienda.FleteroAsignado,
                        NumeroHDRUM = HDRDistribucionUMAlmacen.HDRDistribucionUM
                            .FirstOrDefault(h => h.Encomiendas.Contains(encomienda.TrackingId))?.NumeroHDRUM ?? 0,
                        NumeroHDRMD = 0, 
                        EstadoPrevio = encomiendaAlmacen.Estado
                    };

                    encomiendaAlmacen.HistorialCambios.Add(nuevoHistorial);

                    encomiendaAlmacen.Estado = EstadoEncomiendaEnum.RetiradaAgenciaFletero;
                   
                }

                foreach (var encomienda in encomiendasARecibir)
                {
                    var encomiendaAlmacen = EncomiendaAlmacen.Encomienda
                        .FirstOrDefault(e => e.Tracking == encomienda.TrackingId);

                    var nuevoHistorial = new Historial
                    {
                        Tracking = encomiendaAlmacen.Tracking,
                        FechaPrevia = DateTime.Now,
                        UbicacionPrevia = encomiendaAlmacen.CodCDActual,
                        FleteroAsignado = encomienda.FleteroAsignado,
                        NumeroHDRUM = HDRDistribucionUMAlmacen.HDRDistribucionUM
                            .FirstOrDefault(h => h.Encomiendas.Contains(encomienda.TrackingId))?.NumeroHDRUM ?? 0,
                        NumeroHDRMD = 0,
                        EstadoPrevio = encomiendaAlmacen.Estado
                    };

                    encomiendaAlmacen.HistorialCambios.Add(nuevoHistorial);

                    encomiendaAlmacen.Estado = EstadoEncomiendaEnum.PendienteRetiroAgencia;
                }

            }
                

        }
    }
}

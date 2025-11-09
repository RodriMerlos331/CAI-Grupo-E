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
                if (encomienda.Value.EstadoEnvio == EstadoDeEnvio.EnTransitoUMOrigen && AgenciaAlmacen.AgenciaActual.CodigoAgencia == encomienda.Value.AgenciaOrigen)
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
    }
}

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
        public List<GuiaDeEncomiendas> encomAEntregar;
        public List<GuiaDeEncomiendas> encomARecibir;

        internal Dictionary<string, GuiaDeEncomiendas> BuscarEncomiendaFletero (int dni)
        {
            data = new Dictionary<string, GuiaDeEncomiendas>();

            if (FleteroAlmacen.Fletero.All(f => f.DniFletero != dni))
            {
                MessageBox.Show("El DNI ingresado no corresponde a ningún fletero.");
                return null;
            }
            
            

            var trackingsAsignados = HDRDistribucionUMAlmacen.HDRDistribucionUM
                .Where(hdr => hdr.DniFleteroAsignado == dni)
                .SelectMany(hdr => hdr.Encomiendas)
                .ToList();

            foreach (EncomiendaEntidad encomienda in EncomiendaAlmacen.Encomienda
                .Where(e => trackingsAsignados.Contains(e.Tracking)))
            {
                data.Add(encomienda.Tracking, new GuiaDeEncomiendas
                {
                      TrackingId = encomienda.Tracking,
                      EstadoEnvio = (EstadoDeEnvio)encomienda.Estado,
                      AgenciaDestino = encomienda.AgenciaDestino,
                      AgenciaOrigen = encomienda.AgenciaOrigen,
                      TamañoBulto = encomienda.TipoBulto.ToString(),
                      FleteroAsignado = dni
                });

            }     

            return data;    
        }

        public List<GuiaDeEncomiendas> EncomiendasAEntregar(int dni)
        {

            List<GuiaDeEncomiendas> encomiendasAEntregar = new List<GuiaDeEncomiendas>();

            foreach (var encomienda in BuscarEncomiendaFletero(dni) ?? Enumerable.Empty<KeyValuePair<string, GuiaDeEncomiendas>>())
            {
                if (encomienda.Value.EstadoEnvio == EstadoDeEnvio.EnTransitoUMOrigen && AgenciaAlmacen.AgenciaActual.CodigoAgencia == encomienda.Value.AgenciaOrigen
                    && HDRDistribucionUMAlmacen.HDRDistribucionUM.Any(hdr => hdr.Encomiendas.Contains(encomienda.Value.TrackingId) && hdr.Tipo == TipoHDREnum.Retiro))
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

            encomAEntregar = encomiendasAEntregar;

            return encomiendasAEntregar;
        }

        public List<GuiaDeEncomiendas> EncomiendasARecibir(int dni)
        {
            List<GuiaDeEncomiendas> encomiendasARecibir = new List<GuiaDeEncomiendas>();

            foreach (var encomienda in BuscarEncomiendaFletero(dni) ?? Enumerable.Empty<KeyValuePair<string, GuiaDeEncomiendas>>())
            {
                if (encomienda.Value.EstadoEnvio == EstadoDeEnvio.EnTransitoUMDestino && AgenciaAlmacen.AgenciaActual.CodigoAgencia == encomienda.Value.AgenciaDestino
                 
                    && HDRDistribucionUMAlmacen.HDRDistribucionUM.Any(hdr => hdr.Encomiendas.Contains(encomienda.Value.TrackingId) && hdr.Tipo == TipoHDREnum.Entrega))
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

           encomARecibir = encomiendasARecibir;

            return encomiendasARecibir;
        }

        public void AceptarCambiosEncomiendas ()
        {
            if(encomAEntregar == null && encomARecibir == null)
            {
                MessageBox.Show("No hay encomiendas para recibir o entregar.");
                return;
            }
            else
            {
                foreach (var encomienda in encomAEntregar)
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

                foreach (var encomienda in encomARecibir)
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
                var mensaje = "";

                if (encomAEntregar != null && encomAEntregar.Count > 0)
                {
                    var entregadas = string.Join(", ", encomAEntregar.Select(e => e.TrackingId));
                    mensaje += $"Se entregaron las siguientes encomiendas:\n{entregadas}\n\n";
                }

                if (encomARecibir != null && encomARecibir.Count > 0)
                {
                    var recibidas = string.Join(", ", encomARecibir.Select(e => e.TrackingId));
                    mensaje += $"Se recibieron las siguientes encomiendas:\n{recibidas}\n";
                }

                if (mensaje != "")
                {
                    MessageBox.Show(mensaje, "Operación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
                encomAEntregar?.Clear();
                encomARecibir?.Clear();
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.ConsultarEstadoEncomienda
{
    internal class EstadoDeEncomiendaModel
    {
            public readonly Dictionary<int, EstadoDeEncomienda> data =
                new Dictionary<int, EstadoDeEncomienda>
                {
                {
                    1001, new EstadoDeEncomienda
                    {
                        TrackingId = 1001,
                        EstadoActual = EstadoEnvio.Transito,
                        FechaHoraUltimoCambio = DateTime.Today.AddHours(-3),
                        LocalidadActual = "Rosario (Sta. Fe)",
                        Origen = "Retiro",
                        Destino = "Cordoba Capital",
                        TipoDeBulto = "M",
                        Historial = new List<Movimiento>
                        {
                            new Movimiento{
                                Estado = EstadoEnvio.AdmitidaCD,
                                FechaHora = DateTime.Today.AddDays(-2).AddHours(9),
                                UbicacionAnterior = "Sucursal Caballito (CABA)",
                                TransportistaAsignado = "Transp. Norte SRL",
                                IdHojaRuta = "HR-202",

                            },
                            new Movimiento{
                                Estado = EstadoEnvio.CentroDistribucionDestino,
                                FechaHora = DateTime.Today.AddDays(-1).AddHours(15),
                                UbicacionAnterior = "CD Zona Norte (CABA)",
                                TransportistaAsignado = "Transp. Norte SRL",
                                IdHojaRuta = "HR-245",

                            },
                            new Movimiento{
                                Estado = EstadoEnvio.RuteadaEntregaAgencia,
                                FechaHora = DateTime.Today.AddHours(-3),
                                UbicacionAnterior = "Peaje Gral. Lagos",
                                TransportistaAsignado = "Transp. Norte SRL",
                                IdHojaRuta = "HR-310",
                               

                            }
                        }
                    }
                },
                {
                    2002, new EstadoDeEncomienda
                    {
                        TrackingId = 2002,
                        EstadoActual = EstadoEnvio.EntregadaDomicilio,
                        FechaHoraUltimoCambio = DateTime.Today.AddHours(-1),
                        LocalidadActual = "Córdoba Capital",
                        Origen = "Retiro",
                        Destino = "Cordoba Capital",
                        TipoDeBulto = "XL",
                        Historial = new List<Movimiento>
                        {
                            new Movimiento{
                                Estado = EstadoEnvio.RuteadaEntregaDomicilio,
                                FechaHora = DateTime.Today.AddHours(-4),
                                UbicacionAnterior = "Villa Carlos Paz",
                                TransportistaAsignado = "Ruta Centro",
                                IdHojaRuta = "HR-811",
                               

                            },
                            new Movimiento{
                                Estado = EstadoEnvio.EntregadaDomicilio,
                                FechaHora = DateTime.Today.AddHours(-1),
                                UbicacionAnterior = "Córdoba Capital",
                                TransportistaAsignado = "Ruta Centro",
                                IdHojaRuta = "HR-811",


                            }
                        }
                    }
                }
                };

            public bool TryGet(int trackingId, out EstadoDeEncomienda model)
            {
                return data.TryGetValue(trackingId, out model);
            }
        }
    }




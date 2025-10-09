using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.ConsultarEstadoEncomienda
{
    internal class EstadoDeEncomiendaModel
    {
            private readonly Dictionary<int, EstadoDeEncomienda> _data =
                new Dictionary<int, EstadoDeEncomienda>
                {
                {
                    1001, new EstadoDeEncomienda
                    {
                        TrackingId = 1001,
                        EstadoActual = EstadoEnvio.EnCaminoADestino,
                        FechaHoraUltimoCambio = DateTime.Today.AddHours(-3),
                        LocalidadActual = "Rosario (Sta. Fe)",
                        Historial = new List<Movimiento>
                        {
                            new Movimiento{
                                Estado = EstadoEnvio.Admitido,
                                FechaHora = DateTime.Today.AddDays(-2).AddHours(9),
                                UbicacionAnterior = "Sucursal Caballito (CABA)",
                                TransportistaAsignado = "Transp. Norte SRL",
                                IdHojaRuta = "HR-202",
                                Origen = "CABA",
                                Destino = "Rosario",
                                TipoDeBulto = "M",

                            },
                            new Movimiento{
                                Estado = EstadoEnvio.EnCentroDistribucion,
                                FechaHora = DateTime.Today.AddDays(-1).AddHours(15),
                                UbicacionAnterior = "CD Zona Norte (CABA)",
                                TransportistaAsignado = "Transp. Norte SRL",
                                IdHojaRuta = "HR-245",
                                Origen = "CABA",
                                Destino = "Rosario",
                                TipoDeBulto = "M",

                            },
                            new Movimiento{
                                Estado = EstadoEnvio.EnCaminoADestino,
                                FechaHora = DateTime.Today.AddHours(-3),
                                UbicacionAnterior = "Peaje Gral. Lagos",
                                TransportistaAsignado = "Transp. Norte SRL",
                                IdHojaRuta = "HR-310",
                                Origen = "CABA",
                                Destino = "Rosario",
                                TipoDeBulto = "M",

                            }
                        }
                    }
                },
                {
                    2002, new EstadoDeEncomienda
                    {
                        TrackingId = 2002,
                        EstadoActual = EstadoEnvio.Entregado,
                        FechaHoraUltimoCambio = DateTime.Today.AddHours(-1),
                        LocalidadActual = "Córdoba Capital",
                        Historial = new List<Movimiento>
                        {
                            new Movimiento{
                                Estado = EstadoEnvio.EnCaminoADestino,
                                FechaHora = DateTime.Today.AddHours(-4),
                                UbicacionAnterior = "Villa Carlos Paz",
                                TransportistaAsignado = "Ruta Centro",
                                IdHojaRuta = "HR-811",
                                Origen = "Córdoba",
                                Destino = "Córdoba",
                                TipoDeBulto = "XS",

                            },
                            new Movimiento{
                                Estado = EstadoEnvio.Entregado,
                                FechaHora = DateTime.Today.AddHours(-1),
                                UbicacionAnterior = "Córdoba Capital",
                                TransportistaAsignado = "Ruta Centro",
                                IdHojaRuta = "HR-811",
                                Origen = "Córdoba",
                                Destino = "Córdoba",
                                TipoDeBulto = "XS",

                            }
                        }
                    }
                }
                };

            public bool TryGet(int trackingId, out EstadoDeEncomienda model)
            {
                return _data.TryGetValue(trackingId, out model);
            }
        }
    }




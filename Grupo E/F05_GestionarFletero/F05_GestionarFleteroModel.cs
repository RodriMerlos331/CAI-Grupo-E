using Grupo_E.Almacenes;
using Grupo_E.F05_GestionarFletero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Grupo_E.GestionarFletero
{
    public class F05_GestionarFleteroModel
    {
        private List<HDR> HDRRendicion;
        private List<HDR> HDRGeneracion;


        //NO SÉ SI ESTO TIENE SENTIDO
        public int dniActual = 0;

        public F05_GestionarFleteroModel()
        {
            HDRRendicion = new List<HDR>();
            HDRGeneracion = new List<HDR>();
        }

        public List<HDR> ObtenerHDRRendicionPorTransportista(int dni)
        {
            dniActual = dni;

            // Devuelve las mismas instancias que están en el almacén (referencias)
            HDRRendicion = HDRDistribucionUMAlmacen.HDRDistribucionUM
                 .Where(h => h.DniFleteroAsignado == dni && h.Rendida == false)
                 .Select(h => new HDR
                 {
                     Cumplida = false,
                     DniTransportista = dniActual,
                     Guias = h.Encomiendas
                              .Select(e => EncomiendaAlmacen.Encomienda.Single(en => en.Tracking == e))
                              .Select(e => new Guia
                              {
                                  CodigoGuia = e.Tracking,
                                  Estado = EstadoEquivalenteA(e.Estado),
                                  NumeroHDR = h.NumeroHDRUM
                              }).ToList(),
                     NumeroHDR = h.NumeroHDRUM,
                     Rendida = false,
                     Tipo = TipoEquivalenteA(h.Tipo)
                 })
                 .ToList();

            return HDRRendicion;
        }
        public List<HDR> ObtenerHDRRendicionTransportistaActual()
        {
            return HDRRendicion
                .Where(h => h.DniTransportista == dniActual && h.Rendida == false)
                .ToList();
        }
        public List<HDR> ObtenerHDRPorNumero(int numeroHDR)
        {
            return HDRRendicion
                .Where(h => h.NumeroHDR == numeroHDR)
                .ToList();
        }
        public List<Guia> ObtenerGuiasDeHDRNoCumplidas(int dni, HDR.TipoHDR tipo)
        {
            return HDRRendicion
                .Where(h => h.DniTransportista == dni && h.Tipo == tipo && !h.Cumplida && h.Rendida == false)
                .SelectMany(h => h.Guias)
                .ToList();

        }
        public List<HDR> ObtenerHDRGeneracionPorTransportista(int dni)
        {
           

            var fletero = FleteroAlmacen.Fletero
                .FirstOrDefault(f => f.DniFletero == dni);


            if (fletero == null)
            {
                MessageBox.Show("No se encontró un fletero con el DNI ingresado.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var cdsFletero = fletero.CodCDAsociados;

            var encomiendasRetiro = EncomiendaAlmacen.Encomienda
                .Where(e =>
                    (e.Estado == EstadoEncomiendaEnum.ImpuestaPendienteRetiroDomicilio ||
                     e.Estado == EstadoEncomiendaEnum.ImpuestaPendienteRetiroAgencia)
            && cdsFletero.Contains(e.CodCentroDistribucionOrigen))
                .Select(e => e.Tracking)
                .ToList();

            var encomiendasEntrega = EncomiendaAlmacen.Encomienda
                .Where(e =>
                    (e.Estado == EstadoEncomiendaEnum.PendienteEntregaDomicilio ||
                     e.Estado == EstadoEncomiendaEnum.PendienteEntregaAgencia)
            && cdsFletero.Contains(e.CodCentroDistribucionDestino))
                .Select(e => e.Tracking)
                .ToList();

            foreach (var encomienda in EncomiendaAlmacen.Encomienda
                .Where(e => encomiendasRetiro.Contains(e.Tracking)))
            {
                var estadoPrevio = encomienda.Estado;

                if (estadoPrevio == EstadoEncomiendaEnum.ImpuestaPendienteRetiroDomicilio)
                    encomienda.Estado = EstadoEncomiendaEnum.RuteadaRetiroDomicilio;
                else if (estadoPrevio == EstadoEncomiendaEnum.ImpuestaPendienteRetiroAgencia)
                    encomienda.Estado = EstadoEncomiendaEnum.RuteadaRetiroAgencia;

                encomienda.HistorialCambios.Add(new Historial
                {
                    Tracking = encomienda.Tracking,
                    FechaPrevia = encomienda.FechaImposicion,
                    UbicacionPrevia = null,
                    FleteroAsignado = 0,
                    NumeroHDRUM = 0, 
                    NumeroHDRMD = 0,
                    EstadoPrevio = estadoPrevio
                });
            }

            if (!encomiendasRetiro.Any())
            {
                MessageBox.Show("No se encontraron encomiendas pendientes de retiro para este fletero.",
                    "Sin retiros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (!encomiendasEntrega.Any())
            {
                MessageBox.Show("No se encontraron encomiendas pendientes de entrega para este fletero.",
                    "Sin entregas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var hdrGeneradas = new List<HDRDistribucionUMEntidad>();

            int proximoNumeroHDR = HDRDistribucionUMAlmacen.HDRDistribucionUM.Any()
                ? HDRDistribucionUMAlmacen.HDRDistribucionUM.Max(h => h.NumeroHDRUM) + 1
                : 1000;

            //Faltaría Group by retiro = domicilio o agencia??

            if (encomiendasRetiro.Any())
            {
                var hdrRetiro = new HDRDistribucionUMEntidad
                {
                    NumeroHDRUM = proximoNumeroHDR++,
                    Tipo = TipoHDREnum.Retiro,  // 0
                    DniFleteroAsignado = dni,
                    Cumplida = false,
                    Rendida = false,
                    Encomiendas = encomiendasRetiro
                };

                hdrGeneradas.Add(hdrRetiro);
            }

            if (encomiendasEntrega.Any())
            {
                var hdrEntrega = new HDRDistribucionUMEntidad
                {
                    NumeroHDRUM = proximoNumeroHDR++,
                    Tipo = TipoHDREnum.Entrega,  // 1
                    DniFleteroAsignado = dni,
                    Cumplida = false,
                    Rendida = false,
                    Encomiendas = encomiendasEntrega
                };

                hdrGeneradas.Add(hdrEntrega);
            }

            HDRGeneracion = hdrGeneradas.Select(h => new HDR
            {
                Cumplida = false,
                DniTransportista = dniActual,
                Guias = h.Encomiendas
                              .Select(e => EncomiendaAlmacen.Encomienda.Single(en => en.Tracking == e))
                              .Select(e => new Guia
                              {
                                  CodigoGuia = e.Tracking,
                                  Estado = EstadoEquivalenteA(e.Estado),
                                  NumeroHDR = h.NumeroHDRUM
                              }).ToList(),
                NumeroHDR = h.NumeroHDRUM,
                Rendida = false,
                Tipo = TipoEquivalenteA(h.Tipo)
            })
            .ToList();

            return HDRGeneracion;
        }


        public bool Aceptar()
        {
            foreach (var hdr in HDRRendicion)
            {
                var entidad = HDRDistribucionUMAlmacen.HDRDistribucionUM
                    .First(h => h.NumeroHDRUM == hdr.NumeroHDR);

                entidad.Rendida = hdr.Rendida;
                entidad.Cumplida = hdr.Cumplida;
            }

            foreach (var hdr in HDRGeneracion)
            {

                var nuevaEntidad = new HDRDistribucionUMEntidad
                {
                    NumeroHDRUM = hdr.NumeroHDR,
                    Tipo = MapTipoHDR(hdr.Tipo),
                    DniFleteroAsignado = hdr.DniTransportista,
                    Cumplida = false,
                    Rendida = false,
                    Encomiendas = hdr.Guias.Select(g => g.CodigoGuia).ToList()
                };

                HDRDistribucionUMAlmacen.HDRDistribucionUM.Add(nuevaEntidad);
            }

            //Actualizar estados de encomiendas para HDR de retiro rendidas

            var cdActual = CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoCD;

            foreach (var hdr in HDRRendicion.Where(h => h.Tipo == HDR.TipoHDR.Retiro && h.Cumplida))
            {
                foreach (var guia in hdr.Guias)
                {
                    var encomienda = EncomiendaAlmacen.Encomienda
                        .FirstOrDefault(e => e.Tracking == guia.CodigoGuia);

                    var estadoPrevio = encomienda.Estado;

                    encomienda.Estado = EstadoEncomiendaEnum.Admitida;
                    encomienda.CodCDActual = cdActual;
                    encomienda.FechaAdmision = DateTime.Now;

                    var tarifario = TarifarioAlmacen.Tarifario.FirstOrDefault();
                    if (tarifario != null)
                    {
                        bool incluirRetiro = !string.IsNullOrEmpty(encomienda.DatosRetiroADomicilio);
                        bool incluirEntrega = !string.IsNullOrEmpty(encomienda.DireccionDestinatario);
                        bool incluirAgencia = !string.IsNullOrEmpty(encomienda.AgenciaDestino);

                        encomienda.GenerarFactura(tarifario, incluirRetiro, incluirEntrega, incluirAgencia);
                    }

                    encomienda.RecorridoPlanificado = new List<ParadaPlanificada>();

                    encomienda.HistorialCambios.Add(new Historial
                    {
                        Tracking = encomienda.Tracking,
                        FechaPrevia = DateTime.Now, //Chequear qué poner en fecha previa:
                        UbicacionPrevia = null,
                        FleteroAsignado = hdr.DniTransportista,
                        NumeroHDRUM = hdr.NumeroHDR,
                        NumeroHDRMD = 0,
                        EstadoPrevio = estadoPrevio
                    });
                }
            }

            //Actualizar estados de encomiendas para HDR de entrega cumplidas

            foreach (var hdr in HDRRendicion.Where(h => h.Tipo == HDR.TipoHDR.Entrega && h.Cumplida))
            {
                foreach (var guia in hdr.Guias)
                {
                    var encomienda = EncomiendaAlmacen.Encomienda
                        .FirstOrDefault(e => e.Tracking == guia.CodigoGuia);

                    var estadoPrevio = encomienda.Estado;
                    var UbicacionPrevia = encomienda.CodCDActual;

                    encomienda.Estado = EstadoEncomiendaEnum.Entregada;
                    encomienda.FechaEntrega = DateTime.Now;


                    encomienda.HistorialCambios.Add(new Historial
                    {
                        Tracking = encomienda.Tracking,
                        FechaPrevia = DateTime.Now, //Chequear qué poner en fecha previa:
                        UbicacionPrevia = null,
                        FleteroAsignado = hdr.DniTransportista,
                        NumeroHDRUM = hdr.NumeroHDR,
                        NumeroHDRMD = 0,
                        EstadoPrevio = estadoPrevio
                    });
                }
            }

            //Actualizar estados de encomiendas para HDR de Retiro Generadas
            foreach (var hdr in HDRGeneracion.Where(h => h.Tipo == HDR.TipoHDR.Retiro))
            {
                foreach (var guia in hdr.Guias)
                {
                    var encomienda = EncomiendaAlmacen.Encomienda
                        .FirstOrDefault(e => e.Tracking == guia.CodigoGuia);


                    var estadoPrevio = encomienda.Estado;

                    if (estadoPrevio == EstadoEncomiendaEnum.RuteadaRetiroDomicilio ||
                        estadoPrevio == EstadoEncomiendaEnum.RuteadaRetiroAgencia)
                    {
                        encomienda.Estado = EstadoEncomiendaEnum.EnTransitoUMOrigen;
                        encomienda.FechaAdmision = DateTime.Now;

                        encomienda.HistorialCambios.Add(new Historial
                        {
                            Tracking = encomienda.Tracking,
                            FechaPrevia = DateTime.Now,
                            UbicacionPrevia = encomienda.CodCentroDistribucionOrigen,
                            FleteroAsignado = hdr.DniTransportista,
                            NumeroHDRUM = hdr.NumeroHDR,
                            NumeroHDRMD = 0,
                            EstadoPrevio = estadoPrevio
                        });
                    }
                }
            }

            //Actualizar estados encomiendas para HDR de entrega generadas

            foreach (var hdr in HDRGeneracion.Where(h => h.Tipo == HDR.TipoHDR.Entrega))
            {
                foreach (var guia in hdr.Guias)
                {
                    var encomienda = EncomiendaAlmacen.Encomienda
                        .FirstOrDefault(e => e.Tracking == guia.CodigoGuia);


                    var estadoPrevio = encomienda.Estado;

                    encomienda.Estado = EstadoEncomiendaEnum.EnTransitoUMDestino;
                    encomienda.CodCDActual = null;

                        encomienda.HistorialCambios.Add(new Historial
                        {
                            Tracking = encomienda.Tracking,
                            FechaPrevia = DateTime.Now, //REVISAR
                            UbicacionPrevia = encomienda.CodCentroDistribucionOrigen,
                            FleteroAsignado = 0,
                            NumeroHDRUM =0,
                            NumeroHDRMD = 0,
                            EstadoPrevio = estadoPrevio
                        });
                    }
                }
            

            return true;
        }


        private HDR.TipoHDR TipoEquivalenteA(TipoHDREnum tipo)
        {
            // Mapear TipoHDREnum -> HDR.TipoHDR
            return tipo == TipoHDREnum.Entrega ? HDR.TipoHDR.Entrega : HDR.TipoHDR.Retiro;
        }
        private Guia.EstadoGuia EstadoEquivalenteA(EstadoEncomiendaEnum estado)
        {
            // Mapear EstadoEncomiendaEnum -> Guia.EstadoGuia
            switch (estado)
            {
                case EstadoEncomiendaEnum.Entregada:
                    return Guia.EstadoGuia.Entregada;

                case EstadoEncomiendaEnum.PendienteEntregaDomicilio:
                case EstadoEncomiendaEnum.PendienteEntregaAgencia:
                case EstadoEncomiendaEnum.NoEntregada:
                    return Guia.EstadoGuia.NoEntregada;

                // Estados que implican que la encomienda ya fue retirada por el fletero / en tránsito
                case EstadoEncomiendaEnum.Admitida:
                case EstadoEncomiendaEnum.EnTransitoUMOrigen:
                case EstadoEncomiendaEnum.EnTransitoMD:
                case EstadoEncomiendaEnum.EnTransitoUMDestino:
                    return Guia.EstadoGuia.Retirada;

                // Estados iniciales de retiro o cancelación -> no retirada aún
                case EstadoEncomiendaEnum.ImpuestaPendienteRetiroDomicilio:
                case EstadoEncomiendaEnum.ImpuestaPendienteRetiroAgencia:
                case EstadoEncomiendaEnum.RuteadaRetiroDomicilio:
                case EstadoEncomiendaEnum.RuteadaRetiroAgencia:
                case EstadoEncomiendaEnum.PendienteRetiroCD:
                case EstadoEncomiendaEnum.PendienteRetiroAgencia:
                case EstadoEncomiendaEnum.Cancelada:
                    return Guia.EstadoGuia.NoRetirada;

                // Por defecto, considerar no entregada
                default:
                    return Guia.EstadoGuia.NoEntregada;
            }
        }

        private TipoHDREnum MapTipoHDR(HDR.TipoHDR tipo)
        {
            return tipo == HDR.TipoHDR.Entrega ? TipoHDREnum.Entrega : TipoHDREnum.Retiro;
        }


    }
}
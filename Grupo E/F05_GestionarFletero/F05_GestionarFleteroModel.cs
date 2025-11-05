using Grupo_E.Almacenes;
using Grupo_E.F05_GestionarFletero;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace Grupo_E.GestionarFletero
{
    public class F05_GestionarFleteroModel
    {


        // private List<HDR> HDRRendicion;
        private List<HDR> HDRGeneracion;


        public void CargarHDRDePrueba()
        {
            /* HDRRendicion = new List<HDR>
             {
                 new HDR
                 {
                     NumeroHDR = 1,
                     Tipo = HDR.TipoHDR.Entrega,
                     Cumplida = false,
                     Rendida = false,
                     DniTransportista = 12345678,
                     Guias = new List<Guia>
                     {
                         new Guia { CodigoGuia = "E001", NumeroHDR = 1, Estado = Guia.EstadoGuia.NoEntregada },
                         new Guia { CodigoGuia = "E002", NumeroHDR = 1, Estado = Guia.EstadoGuia.NoEntregada }
                     }
                 },
                 new HDR
                 {
                     NumeroHDR = 2,
                     Tipo = HDR.TipoHDR.Retiro,
                     Cumplida = false,
                     Rendida = false,
                     DniTransportista = 12345678,
                     Guias = new List<Guia>
                     {
                         new Guia { CodigoGuia = "R001", NumeroHDR = 2, Estado = Guia.EstadoGuia.NoRetirada },
                         new Guia { CodigoGuia = "R002", NumeroHDR = 2, Estado = Guia.EstadoGuia.NoRetirada }
                     }
                 },
                 new HDR
                 {
                     NumeroHDR = 11,
                     Tipo = HDR.TipoHDR.Entrega,
                     Cumplida = false,
                     Rendida = false,
                     DniTransportista = 23456789,
                     Guias = new List<Guia>
                     {
                         new Guia { CodigoGuia = "C151", NumeroHDR = 11, Estado = Guia.EstadoGuia.NoEntregada },
                         new Guia { CodigoGuia = "F108", NumeroHDR = 11, Estado = Guia.EstadoGuia.NoEntregada }
                     }
                 },
                 new HDR
                 {
                     NumeroHDR = 12,
                     Tipo = HDR.TipoHDR.Retiro,
                     Cumplida = false,
                     Rendida = false,
                     DniTransportista = 23456789,
                     Guias = new List<Guia>
                     {
                         new Guia { CodigoGuia = "K106", NumeroHDR = 12, Estado = Guia.EstadoGuia.NoRetirada },
                         new Guia { CodigoGuia = "K121", NumeroHDR = 12, Estado = Guia.EstadoGuia.NoRetirada }
                     }
                 }
             };
            */
            // --- HDR de generación (nuevas asignadas al fletero) ---
            HDRGeneracion = new List<HDR>
            {
                new HDR
                {
                    NumeroHDR = 3,
                    Tipo = HDR.TipoHDR.Entrega,
                    Cumplida = false,
                    Rendida = false,
                    DniTransportista = 12345678,
                    Guias = new List<Guia>
                    {
                        new Guia { CodigoGuia = "A100", NumeroHDR = 3, Estado = Guia.EstadoGuia.NoEntregada },
                        new Guia { CodigoGuia = "A101", NumeroHDR = 3, Estado = Guia.EstadoGuia.NoEntregada }
                    }
                },
                new HDR
                {
                    NumeroHDR = 4,
                    Tipo = HDR.TipoHDR.Retiro,
                    Cumplida = false,
                    Rendida = false,
                    DniTransportista = 12345678,
                    Guias = new List<Guia>
                    {
                        new Guia { CodigoGuia = "B100", NumeroHDR = 4, Estado = Guia.EstadoGuia.NoRetirada },
                        new Guia { CodigoGuia = "B101", NumeroHDR = 4, Estado = Guia.EstadoGuia.NoRetirada }
                    }
                },
                new HDR
                {
                    NumeroHDR = 13,
                    Tipo = HDR.TipoHDR.Entrega,
                    Cumplida = false,
                    Rendida = false,
                    DniTransportista = 23456789,
                    Guias = new List<Guia>
                    {
                        new Guia { CodigoGuia = "A240", NumeroHDR = 13, Estado = Guia.EstadoGuia.NoEntregada },
                        new Guia { CodigoGuia = "A601", NumeroHDR = 13, Estado = Guia.EstadoGuia.NoEntregada }
                    }
                },
                new HDR
                {
                    NumeroHDR = 14,
                    Tipo = HDR.TipoHDR.Retiro,
                    Cumplida = false,
                    Rendida = false,
                    DniTransportista = 23456789,
                    Guias = new List<Guia>
                    {
                        new Guia { CodigoGuia = "S200", NumeroHDR = 14, Estado = Guia.EstadoGuia.NoRetirada },
                        new Guia { CodigoGuia = "B501", NumeroHDR = 14, Estado = Guia.EstadoGuia.NoRetirada }
                    }
                }
            };
        }


        public int dniActual = 0;

        
         
        
        public List<HDRDistribucionUMEntidad> ObtenerHDRRendicionPorTransportista(int dni)
        {
            dniActual = dni;
            // Devuelve las mismas instancias que están en el almacén (referencias)
            return HDRDistribucionUMAlmacen.HDRDistribucionUM
                .Where(h => h.DniFleteroAsignado == dni && h.Rendida == false)
                .ToList();
        }
        public List<HDRDistribucionUMEntidad> ObtenerHDRRendicionTransportistaActual()
        {
            return HDRDistribucionUMAlmacen.HDRDistribucionUM
                .Where(h => h.DniFleteroAsignado == dniActual && h.Rendida == false)
                .ToList();
        }

        /*
         public List<Guia> ObtenerGuiasDeHDRNoCumplidas(int dni, HDR.TipoHDR tipo)
        {
            return HDRRendicion
                .Where(h => h.DniTransportista == dni && h.Tipo == tipo && !h.Cumplida && h.Rendida == false)
                .SelectMany(h => h.Guias)
                .ToList();

        }
        */

        /*
        public List<string> ObtenerGuiasDeHDRNoCumplidas(TipoHDREnum tipo)
        {
            return HDRDistribucionUMAlmacen.HDRDistribucionUM
                .Where(h => h.DniFleteroAsignado == dniActual &&
                            h.Tipo == tipo &&
                            !h.Rendida &&
                            !h.Cumplida)
                .SelectMany(h => h.Encomiendas)
                .ToList();
        }
        */
        public List<(int NumeroHDR, string Guia)> ObtenerGuiasDeHDRNoCumplidas(TipoHDREnum tipo)
        {
            return HDRDistribucionUMAlmacen.HDRDistribucionUM
                .Where(h => h.DniFleteroAsignado == dniActual &&
                            h.Tipo == tipo &&
                            !h.Rendida &&
                            !h.Cumplida)
                .SelectMany(h => h.Encomiendas.Select(g => (h.NumeroHDRUM, g)))
                .ToList();
        }


        /*public List<HDR> ObtenerHDRPorNumero(int numeroHDR)
        {
            return HDRRendicion
                .Where(h => h.NumeroHDR == numeroHDR)
                .ToList();
        }*/

        public HDRDistribucionUMEntidad ObtenerHDRPorNumero(int numeroHDR)
        {
            // Devuelve la referencia única al objeto del almacén
            return HDRDistribucionUMAlmacen.HDRDistribucionUM
                .FirstOrDefault(h => h.NumeroHDRUM == numeroHDR);
        }

        /*
        public List<HDR> ObtenerHDRGeneracionPorTransportista(int dni)
        {

            return HDRGeneracion
                .Where(h => h.DniTransportista == dni)
                .ToList();
        }
        */



        public List<HDRDistribucionUMEntidad> ObtenerHDRGeneracionPorTransportista(int dni)
        {
            // 1. Buscar fletero
            var fletero = FleteroAlmacen.Fletero
                .FirstOrDefault(f => f.DniFletero == dni);

            if (fletero == null)
            {
                MessageBox.Show("No se encontró un fletero con el DNI ingresado.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<HDRDistribucionUMEntidad>();
            }

            // 2. CDs asociados
            var cdsFletero = fletero.CodCDAsociados;

            // 3. Encomiendas a RETIRAR
            var encomiendasRetiro = EncomiendaAlmacen.Encomienda
                .Where(e =>
                    (e.Estado == EstadoEncomiendaEnum.ImpuestaPendienteRetiroDomicilio ||
                     e.Estado == EstadoEncomiendaEnum.ImpuestaPendienteRetiroAgencia)
                    && cdsFletero.Contains(e.CodCentroDistribucionOrigen))
                .Select(e => e.Tracking)
                .ToList();

            // 4. Encomiendas a ENTREGAR
            var encomiendasEntrega = EncomiendaAlmacen.Encomienda
                .Where(e =>
                    (e.Estado == EstadoEncomiendaEnum.PendienteEntregaDomicilio ||
                     e.Estado == EstadoEncomiendaEnum.PendienteEntregaAgencia)
                    && cdsFletero.Contains(e.CodCentroDistribucionDestino))
                .Select(e => e.Tracking)
                .ToList();

            // 5. Validaciones con mensajes
            if (!encomiendasRetiro.Any() && !encomiendasEntrega.Any())
            {
                MessageBox.Show("No se encontraron encomiendas pendientes para generar HDR (ni de retiro ni de entrega).",
                    "Sin encomiendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return new List<HDRDistribucionUMEntidad>();
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

            // 6. Crear HDR nuevas
            var hdrGeneradas = new List<HDRDistribucionUMEntidad>();

            int proximoNumeroHDR = HDRDistribucionUMAlmacen.HDRDistribucionUM.Any()
                ? HDRDistribucionUMAlmacen.HDRDistribucionUM.Max(h => h.NumeroHDRUM) + 1
                : 1000;

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

            // 7. Guardar en memoria
            HDRDistribucionUMAlmacen.HDRDistribucionUM.AddRange(hdrGeneradas);

            // 8. Retornar al form
            return hdrGeneradas;
        }
    }
    }

/*
        public void ActualizarEstadoHDR(int numeroHDR, bool cumplida)
        {
            var hdr = HDRRendicion.FirstOrDefault(h => h.NumeroHDR == numeroHDR);
            if (hdr != null)
            {
                hdr.Cumplida = cumplida;
                hdr.ActualizarEstado(cumplida);
            }
        }
        */
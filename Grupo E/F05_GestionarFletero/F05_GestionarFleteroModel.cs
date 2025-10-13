using Grupo_E.F05_GestionarFletero;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Grupo_E.GestionarFletero
{
    public class F05_GestionarFleteroModel
    {
        private List<HDR> HDRRendicion;
        private List<HDR> HDRGeneracion;

        public F05_GestionarFleteroModel()
        {
            HDRRendicion = new List<HDR>();
            HDRGeneracion = new List<HDR>();


        }
        public void CargarHDRDePrueba()
        {
            HDRRendicion = new List<HDR>
    {
        new HDR
        {
            NumeroHDR = 1,
            Tipo = HDR.TipoHDR.Entrega,
            Cumplida = false,
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
            DniTransportista = 12345678,
            Guias = new List<Guia>
            {
                new Guia { CodigoGuia = "R001", NumeroHDR = 2, Estado = Guia.EstadoGuia.NoRetirada },
                new Guia { CodigoGuia = "R002", NumeroHDR = 2, Estado = Guia.EstadoGuia.NoRetirada }
            }
        }
    };

            // --- HDR de generación (nuevas asignadas al fletero) ---
            HDRGeneracion = new List<HDR>
    {
        new HDR
        {
            NumeroHDR = 3,
            Tipo = HDR.TipoHDR.Entrega,
            Cumplida = false,
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
            DniTransportista = 12345678,
            Guias = new List<Guia>
            {
                new Guia { CodigoGuia = "B100", NumeroHDR = 4, Estado = Guia.EstadoGuia.NoRetirada },
                new Guia { CodigoGuia = "B101", NumeroHDR = 4, Estado = Guia.EstadoGuia.NoRetirada }
            }
        }
    };
        }

        public List<HDR> ObtenerHDRPorTransportista(int dni)
        {
            return HDRRendicion
                .Where(h => h.DniTransportista == dni)
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
                .Where(h => h.DniTransportista == dni && h.Tipo == tipo && !h.Cumplida)
                .SelectMany(h => h.Guias)
                .ToList();

        }

        public List<HDR> ObtenerHDRGeneracionPorTransportista(int dni)
        {
            return HDRGeneracion
                .Where(h => h.DniTransportista == dni)
                .ToList();
        }

    }

}
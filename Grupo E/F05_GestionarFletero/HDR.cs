using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.F05_GestionarFletero
{
    public class HDR
    {
        public enum TipoHDR
        {
            Retiro,
            Entrega
        }

        public int NumeroHDR { get; set; }
        public TipoHDR Tipo { get; set; }
        public bool Cumplida { get; set; }
        public int DniTransportista { get; set; }

        public List<Guia> Guias { get; set; }

        public HDR()
        {
            Guias = new List<Guia>();
        }

        public void ActualizarEstado(bool cumplida)
        {
            Cumplida = cumplida;

            foreach (Guia guia in Guias)
            {
                if (Tipo == TipoHDR.Entrega)
                {
                    guia.Estado = cumplida
                        ? Guia.EstadoGuia.Entregada
                        : Guia.EstadoGuia.NoEntregada;
                }
                else
                {
                    guia.Estado = cumplida
                        ? Guia.EstadoGuia.Retirada
                        : Guia.EstadoGuia.NoRetirada;
                }
            }
        }
    }
}

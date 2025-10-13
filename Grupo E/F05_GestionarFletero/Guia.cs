using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.F05_GestionarFletero
{
    public class Guia
    {
        public enum EstadoGuia
        {
            Entregada,
            NoEntregada,
            Retirada,
            NoRetirada
        }

        public string CodigoGuia { get; set; }
        public int NumeroHDR { get; set; }
        public EstadoGuia Estado { get; set; }
    }
}

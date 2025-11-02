using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    internal class HDR_Distribucion_UMEntidad
    {
        public int NumeroHDRUM { get; set; }
        public List<TipoHDR> TipoHDR { get; set; } = new List<TipoHDR>();
        public bool Cumplida { get; set; }
        public bool Rendida { get; set; }
        public List<int> Encomiendas { get; set; } = new List<int>();
    }
}

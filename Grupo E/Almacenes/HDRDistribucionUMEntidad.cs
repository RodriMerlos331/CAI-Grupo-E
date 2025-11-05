using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    public class HDRDistribucionUMEntidad
    {
        public int NumeroHDRUM { get; set; }
        public TipoHDREnum Tipo { get; set; }
        public int DniFleteroAsignado { get; set; }
        public bool Cumplida { get; set; }
        public bool Rendida { get; set; }
        public List<string> Encomiendas { get; set; }
    }
}

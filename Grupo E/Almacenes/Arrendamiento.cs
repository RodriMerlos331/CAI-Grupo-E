using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    internal class Arrendamiento
    {
        public TipoArrendamientoEnum Tipo { get; set; }
        public decimal Costo { get; set; }
        public DateTime Mes { get; set; }
    }
}

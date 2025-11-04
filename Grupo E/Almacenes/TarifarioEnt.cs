using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    internal class TarifarioEnt
    {
        public decimal ExtraEntregaDomicilio { get; set; }
        public decimal ExtraRetiro { get; set; }
        public decimal ExtraAgencia { get; set; } 
        public List<PreciosPorOrigenDestino> PreciosPorOrigenDestinos { get; set; } = new List<PreciosPorOrigenDestino>();
    }
}

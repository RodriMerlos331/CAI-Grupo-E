using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    internal class EncomiendaFactura
    {
        public decimal PrecioCombinacionTamanoOrigenDestino { get; set; }
        public decimal ExtraRetiro { get; set; }
        public decimal ExtraAgencia { get; set; }
        public decimal ExtraEntrega { get; set; }
        public decimal PrecioTotalEncomienda { get; set; }
    }
}

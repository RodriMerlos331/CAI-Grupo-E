using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    internal class PreciosPorOrigenDestino
    {
        public TipoBultoEnum Tipo { get; set; }

        public string CodigoCDOrigen { get; set; }

        public string CodigoCDDestino { get; set; }

        public decimal Precio { get; set; }
    }
}

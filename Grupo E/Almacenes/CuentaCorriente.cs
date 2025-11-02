using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupo_E.ConsultarEstadoEncomienda;

namespace Grupo_E.Almacenes
{
    internal class CuentaCorriente
    {
        public string CUITCliente { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber  { get; set; }

        public List<int> Facturas { get; set; } = new List<int>();
    }
}

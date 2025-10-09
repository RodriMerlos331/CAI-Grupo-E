using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.EstadoCuentasCorrientes
{
    // Clase que representa un movimiento de cuenta corriente (DEBE ESTAR FUERA DEL MODELO)
    public class MovimientoCC
    {
        public DateTime FechaEmision { get; set; }
        public string NroFactura { get; set; }
        public string Estado { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
        public string CUIT { get; set; } = "30712345674"; // Valor por defecto del CUIT base
    }
}
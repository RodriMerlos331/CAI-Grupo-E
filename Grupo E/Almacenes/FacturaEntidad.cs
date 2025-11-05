using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    internal class FacturaEntidad
    {
      public string NroFactura { get; set; }
       public string CuitTutasa { get; set; }
        public string CuitCliente { get; set; }
        public DateTime FechaEmision { get; set; }

        public List<string> EncomiendasIncluidas { get; set; }
        public decimal Subtotal { get; set; }

        public decimal Iva { get; set; }

        public decimal Total { get; set; }
         
        public string CodigoDeAutorizacionElectronica { get; set; }
        public DateTime? FechadePago { get; set; }
    }
}

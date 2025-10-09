using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.F10_GeneracionDeFacturas
{
    internal class EncomiendaFactura
    {
        public int CUIT { get; set; }
        public string NroTracking { get; set; }
        public string FechaAdmision { get; set; }
        public string Importe { get; set; }
        public string ExtraRetiro { get; set; }
        public string ExtraEntrega { get; set; }
        public string ExtraAgencia { get; set; }
    }

    internal class F10_GeneracionDeFacturasModelo
    {
        private List<EncomiendaFactura> encomiendas = new List<EncomiendaFactura>
        {
            new EncomiendaFactura
            {
                CUIT = 20123456,
                NroTracking = "10004050",
                FechaAdmision = "12-10-2024",
                Importe = "$100.000",
                ExtraRetiro = "$5.000",
                ExtraEntrega = "$4.000",
                ExtraAgencia = "$0"
            },
            new EncomiendaFactura
            {
                CUIT = 20987654,
                NroTracking = "10004051",
                FechaAdmision = "13-10-2024",
                Importe = "$120.000",
                ExtraRetiro = "$6.000",
                ExtraEntrega = "$5.000",
                ExtraAgencia = "$0"
            }
        };

        internal List<EncomiendaFactura> ListarEncomiendas(int cuit)
        {
            return encomiendas.Where(e => e.CUIT == cuit).ToList();
        }
    }
}

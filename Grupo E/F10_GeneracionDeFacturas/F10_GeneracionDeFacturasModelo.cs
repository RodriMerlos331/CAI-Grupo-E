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
        public DateTime FechaAdmision { get; set; }
        public int Importe { get; set; }
        public int ExtraRetiro { get; set; }
        public int ExtraEntrega { get; set; }
        public int ExtraAgencia { get; set; }
    }

    internal class F10_GeneracionDeFacturasModelo
    {
        private int UltimoCUITConsultado;
        internal bool ValidarCUIT(int cuit)
        {
            if (cuit < 20_000_000 || cuit > 30_000_000)
            {
                MessageBox.Show("El CUIT debe ser válido (entre 20.000.000 y 30.000.000)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            UltimoCUITConsultado = cuit; 
            return true;
        }


        private List<EncomiendaFactura> encomiendasPendientesDeFactura = new List<EncomiendaFactura>
        {
            new EncomiendaFactura
            {
                CUIT = 20123456,
                NroTracking = "10004050",
                FechaAdmision = new DateTime(2024, 10, 12),
                Importe = 100000,
                ExtraRetiro = 5000,
                ExtraEntrega = 4000,
                ExtraAgencia = 0
            },

            new EncomiendaFactura
            {
                CUIT = 20987654,
                NroTracking = "10004051",
                FechaAdmision = new DateTime(2024, 10, 13),
                Importe = 120000,
                ExtraRetiro = 6000,
                ExtraEntrega = 5000,
                ExtraAgencia = 0
            }
        };

        internal List<EncomiendaFactura> ListarEncomiendas(int cuit)
        {
            return encomiendasPendientesDeFactura.Where(e => e.CUIT == cuit).ToList();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Grupo_E.F10_GeneracionDeFacturas
{
    internal class EncomiendaFactura
    {
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

        private Dictionary<int, List<EncomiendaFactura>> encomiendasPorCUIT = new Dictionary<int, List<EncomiendaFactura>>
        {
            {
                20123456, new List<EncomiendaFactura>
                {
                    new EncomiendaFactura
                    {
                        NroTracking = "10004050",
                        FechaAdmision = new DateTime(2024, 10, 12),
                        Importe = 100000,
                        ExtraRetiro = 5000,
                        ExtraEntrega = 4000,
                        ExtraAgencia = 0
                    },
                    new EncomiendaFactura
                    {
                        NroTracking = "10004051",
                        FechaAdmision = new DateTime(2024, 10, 13),
                        Importe = 110000,
                        ExtraRetiro = 6000,
                        ExtraEntrega = 5000,
                        ExtraAgencia = 0
                    },
                    new EncomiendaFactura
                    {
                        NroTracking = "10004052",
                        FechaAdmision = new DateTime(2024, 10, 14),
                        Importe = 120000,
                        ExtraRetiro = 7000,
                        ExtraEntrega = 6000,
                        ExtraAgencia = 0
                    }
                }
            },
            {
                20987654, new List<EncomiendaFactura>
                {
                    new EncomiendaFactura
                    {
                        NroTracking = "20005060",
                        FechaAdmision = new DateTime(2024, 10, 15),
                        Importe = 130000,
                        ExtraRetiro = 8000,
                        ExtraEntrega = 7000,
                        ExtraAgencia = 0
                    },
                    new EncomiendaFactura
                    {
                        NroTracking = "20005061",
                        FechaAdmision = new DateTime(2024, 10, 16),
                        Importe = 140000,
                        ExtraRetiro = 9000,
                        ExtraEntrega = 8000,
                        ExtraAgencia = 0
                    }
                }
            }
        };

        internal List<EncomiendaFactura> ListarEncomiendas(int cuit)
        {
            if (encomiendasPorCUIT.ContainsKey(cuit))
                return encomiendasPorCUIT[cuit];
            else
                return new List<EncomiendaFactura>();
        }

        internal int CalcularTotalImportes(IEnumerable<(int Importe, int ExtraRetiro, int ExtraEntrega)> importes)
        {
            int total = 0;
            foreach (var item in importes)
            {
                total += item.Importe + item.ExtraRetiro + item.ExtraEntrega;
            }
            return total;
        }
    }
}

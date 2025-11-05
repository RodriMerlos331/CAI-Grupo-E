using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Grupo_E.Almacenes;

namespace Grupo_E.F10_GeneracionDeFacturas
{
    internal class F10_GeneracionDeFacturasModelo
    {
        private string UltimoCUITConsultado;
        private Dictionary<string, List<EncomiendaFactura>> encomiendasPorCUIT = new Dictionary<string, List<EncomiendaFactura>>();

        internal bool ValidarCUIT(string cuit)
        {
            // Validar formato 00-00000000-00
            if (!Regex.IsMatch(cuit, @"^\d{2}-\d{8}-\d{2}$"))
            {
                MessageBox.Show("El CUIT debe tener el formato 00-00000000-00", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            UltimoCUITConsultado = cuit;
            return true;
        }

        internal List<EncomiendaFactura> ListarEncomiendas(string cuit)
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

        internal List<EncomiendaEntidad> BuscarEncomiendasNoFacturadasPorCUIT(string cuit, List<EncomiendaEntidad> todasLasEncomiendas)
        {
            // Solo devuelve encomiendas NO facturadas
            return todasLasEncomiendas
                .Where(e => e.CUITCliente == cuit && !e.facturada)
                .ToList();
        }

        internal List<EncomiendaFactura> PrepararFacturasParaForm(string cuit, List<EncomiendaEntidad> todasLasEncomiendas)
        {
            // Solo se consideran encomiendas NO facturadas
            var encomiendas = BuscarEncomiendasNoFacturadasPorCUIT(cuit, todasLasEncomiendas);
            var EncomiendasAFacturar = new List<EncomiendaFactura>();

            foreach (var encomienda in encomiendas)
            {
                if (encomienda.DatosFacturacion != null)
                {
                    EncomiendasAFacturar.Add(encomienda.DatosFacturacion);
                }
                // Si necesitas manejar el caso donde DatosFacturacion es null, puedes agregar lógica aquí.
            }

            return EncomiendasAFacturar;
        }
    }
}

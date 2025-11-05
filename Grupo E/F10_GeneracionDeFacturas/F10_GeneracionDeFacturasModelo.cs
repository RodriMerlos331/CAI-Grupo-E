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
           if (!Regex.IsMatch(cuit, @"^\d{2}-\d{8}-\d{2}$"))
            {
                MessageBox.Show("El CUIT debe tener el formato 00-00000000-00", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            UltimoCUITConsultado = cuit;
            return true;
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
            if (todasLasEncomiendas == null || !todasLasEncomiendas.Any())
            {
                MessageBox.Show("No hay encomiendas disponibles para buscar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return new List<EncomiendaEntidad>();
            }

            // Normaliza el CUIT para comparar solo los números
            string cuitNormalizado = new string(cuit.Where(char.IsDigit).ToArray());

            var resultado = todasLasEncomiendas
                .Where(e =>
                    !e.facturada &&
                    !string.IsNullOrEmpty(e.CUITCliente) &&
                    new string(e.CUITCliente.Where(char.IsDigit).ToArray()) == cuitNormalizado
                )
                .ToList();

            if (!resultado.Any())
            {
                MessageBox.Show("No hay encomiendas no facturadas para este CUIT.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return resultado;
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

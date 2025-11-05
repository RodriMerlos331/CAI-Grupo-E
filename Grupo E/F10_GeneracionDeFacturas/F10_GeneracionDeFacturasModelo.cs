using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Grupo_E.Almacenes;
using Grupo_E.F10_GeneracionDeFacturas;
namespace Grupo_E.F10_GeneracionDeFacturas
{
    public class EncomiendaFacturaDTO
    {
        public string Tracking { get; set; }
        public string FechaAdmision { get; set; }
        public string Importe { get; set; }
        public string ExtraRetiro { get; set; }
        public string ExtraEntrega { get; set; }
        public string ExtraAgencia { get; set; }
        public string PrecioTotal { get; set; }
    }

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



        internal decimal CalcularTotalImportes(IEnumerable<(decimal Importe, decimal ExtraRetiro, decimal ExtraEntrega, decimal ExtraAgencia)> importes)
        {
            decimal total = 0;
            foreach (var item in importes)
            {
                total += item.Importe + item.ExtraRetiro + item.ExtraEntrega + item.ExtraAgencia;
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
                    !e.Facturada &&
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

        internal List<EncomiendaFacturaDTO> PrepararFacturasParaForm(string cuit, List<EncomiendaEntidad> todasLasEncomiendas)
        {
            var encomiendas = BuscarEncomiendasNoFacturadasPorCUIT(cuit, todasLasEncomiendas);
            var resultado = new List<EncomiendaFacturaDTO>();

            foreach (var encomienda in encomiendas)
            {
                if (encomienda.EncomiendaFactura != null)
                {
                    resultado.Add(new EncomiendaFacturaDTO
                    {
                        Tracking = encomienda.Tracking ?? "",
                        FechaAdmision = encomienda.FechaAdmision.HasValue && encomienda.FechaAdmision.Value.Year > 1
                            ? encomienda.FechaAdmision.Value.ToString("dd/MM/yyyy")
                            : "",
                        Importe = encomienda.EncomiendaFactura.PrecioCombinacionTamanoOrigenDestino.ToString("C"),
                        ExtraRetiro = encomienda.EncomiendaFactura.ExtraRetiro.ToString("C"),
                        ExtraEntrega = encomienda.EncomiendaFactura.ExtraEntrega.ToString("C"),
                        ExtraAgencia = encomienda.EncomiendaFactura.ExtraAgencia.ToString("C"),
                        PrecioTotal = encomienda.EncomiendaFactura.PrecioTotalEncomienda.ToString("C")
                    });
                }
            }

            return resultado;
        }
    }

}
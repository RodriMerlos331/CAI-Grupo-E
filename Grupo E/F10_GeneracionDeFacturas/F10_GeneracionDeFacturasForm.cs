using Grupo_E.Almacenes;
using Grupo_E.F10_GeneracionDeFacturas;
using Grupo_E.RetirarEnAgencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.GeneracionDeFacturas
{
    public partial class F10_GeneracionDeFacturasForm : Form
    {
        private F10_GeneracionDeFacturasModelo modelo = new F10_GeneracionDeFacturasModelo();

        public F10_GeneracionDeFacturasForm()
        {
            InitializeComponent();
        }

        private void GeneracionDeFacturas_Load(object sender, EventArgs e)
        {
            // Ajusta el ancho de las columnas al contenido y encabezado
            foreach (ColumnHeader column in listViewFactura.Columns)
            {
                column.Width = -2; // -2 ajusta al contenido, -1 ajusta al encabezado
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cuit = txtCUIT.Text.Trim();

            if (!modelo.ValidarCUIT(cuit))
                return;

            // Siempre toma la lista actualizada del almacén
            var todasLasEncomiendas = EncomiendaAlmacen.Encomienda ?? new List<EncomiendaEntidad>();

            var facturas = modelo.PrepararFacturasParaForm(cuit, todasLasEncomiendas);

            listViewFactura.Items.Clear();

            foreach (var dto in facturas)
            {
                var item = new ListViewItem(dto.Tracking);
                item.SubItems.Add(dto.FechaAdmision);
                item.SubItems.Add(dto.Importe);
                item.SubItems.Add(dto.ExtraRetiro);
                item.SubItems.Add(dto.ExtraEntrega);
                item.SubItems.Add(dto.ExtraAgencia);
                listViewFactura.Items.Add(item);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listViewFactura.Items.Clear();
            txtCUIT.Clear();
            lblSumaImporte.Text = "Total: $0";
        }

        private void listViewFactura_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var importes = new List<(decimal Importe, decimal ExtraRetiro, decimal ExtraEntrega, decimal ExtraAgencia)>();

            for (int i = 0; i < listViewFactura.Items.Count; i++)
            {
                bool EstaCheckeado = (i == e.Index) ? (e.NewValue == CheckState.Checked) : listViewFactura.Items[i].Checked;

                if (EstaCheckeado)
                {
                    var item = listViewFactura.Items[i];
                    decimal importe = ParseImporteDecimal(item.SubItems[2].Text);       // Importe
                    decimal extraRetiro = ParseImporteDecimal(item.SubItems[3].Text);   // ExtraRetiro
                    decimal extraEntrega = ParseImporteDecimal(item.SubItems[4].Text);  // ExtraEntrega
                    decimal extraAgencia = ParseImporteDecimal(item.SubItems[5].Text);  // ExtraAgencia
                    importes.Add((importe, extraRetiro, extraEntrega, extraAgencia));
                }
            }

            decimal total = modelo.CalcularTotalImportes(importes);
            lblSumaImporte.Text = $"Total: ${total:N2}";
        }

        private decimal ParseImporteDecimal(string texto)
        {
            // Elimina el símbolo de moneda y los espacios
            string limpio = texto.Replace("$", "").Trim();

            // Elimina los puntos (separador de miles)
            limpio = limpio.Replace(",", "");

            // Ahora la coma queda como separador decimal
            decimal.TryParse(limpio, out decimal valor);
            return valor;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            // Obtiene las encomiendas seleccionadas (checked)
            var seleccionadas = listViewFactura.Items
                .Cast<ListViewItem>()
                .Where(item => item.Checked)
                .ToList();

            if (!seleccionadas.Any())
            {
                MessageBox.Show("Debe seleccionar al menos una encomienda para generar la factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cuitCliente = txtCUIT.Text.Trim();
            List<string> encomiendasIncluidas = seleccionadas.Select(item => item.Text).ToList();

            decimal subtotal = 0;
            foreach (var item in seleccionadas)
            {
                subtotal += ParseImporteDecimal(item.SubItems[2].Text)
                          + ParseImporteDecimal(item.SubItems[3].Text)
                          + ParseImporteDecimal(item.SubItems[4].Text)
                          + ParseImporteDecimal(item.SubItems[5].Text);
            }

            DateTime? fechaPago = null; // O tu lógica si corresponde

            // Llama al modelo, que se encarga de buscar los datos generales y crear la factura
            modelo.GenerarFactura(
                cuitCliente,
                encomiendasIncluidas,
                subtotal,
                fechaPago
            );

            MessageBox.Show("La factura se generó correctamente.", "Factura generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listViewFactura.Items.Clear();
            txtCUIT.Clear();
            lblSumaImporte.Text = "Total: $0";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "¿Seguro que quieres salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}


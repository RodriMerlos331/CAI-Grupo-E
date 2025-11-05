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
        private List<EncomiendaEntidad> todasLasEncomiendas; // Debe estar cargada previamente

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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCUIT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cuit = txtCUIT.Text.Trim();

            if (!modelo.ValidarCUIT(cuit))
                return;

            var facturas = modelo.PrepararFacturasParaForm(cuit, todasLasEncomiendas);

            listViewFactura.Items.Clear();

            foreach (var factura in facturas)
            {
                var item = new ListViewItem(factura.PrecioCombinacionTamanoOrigenDestino.ToString("C"));
                item.SubItems.Add(factura.ExtraRetiro.ToString("C"));
                item.SubItems.Add(factura.ExtraAgencia.ToString("C"));
                item.SubItems.Add(factura.ExtraEntrega.ToString("C"));
                item.SubItems.Add(factura.PrecioTotalEncomienda.ToString("C"));
                listViewFactura.Items.Add(item);
            }
        }



        private void grpboxImporteTotal_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            listViewFactura.Items.Clear();
            txtCUIT.Clear();
            lblSumaImporte.Text = "Total: $0";

        }

        private void listViewFactura_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var importes = new List<(int Importe, int ExtraRetiro, int ExtraEntrega)>();

            // Recorre todos los ítems del ListView
            for (int i = 0; i < listViewFactura.Items.Count; i++)
            {
                // Si es el ítem que está cambiando, usa el valor futuro (e.NewValue)
                bool EstaCheckeado = (i == e.Index) ? (e.NewValue == CheckState.Checked) : listViewFactura.Items[i].Checked;

                if (EstaCheckeado)
                {
                    var item = listViewFactura.Items[i];
                    int importe = ParseImporte(item.SubItems[2].Text);
                    int extraRetiro = ParseImporte(item.SubItems[3].Text);
                    int extraEntrega = ParseImporte(item.SubItems[4].Text);
                    importes.Add((importe, extraRetiro, extraEntrega));
                }
            }

            int total = modelo.CalcularTotalImportes(importes);
            lblSumaImporte.Text = $"Total: ${total:N0}";
        }

        private int ParseImporte(string texto)
        {
            // Elimina cualquier símbolo de moneda y separadores de miles
            string limpio = texto.Replace("$", "").Replace(".", "").Replace(",", "").Trim();
            int.TryParse(limpio, out int valor);
            return valor;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos un ítem seleccionado (checked)
            bool haySeleccionado = listViewFactura.Items.Cast<ListViewItem>().Any(item => item.Checked);

            if (!haySeleccionado)
            {
                MessageBox.Show("Debe seleccionar al menos una encomienda para generar la factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

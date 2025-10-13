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

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCUIT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCUIT.Text))
            {
                MessageBox.Show("El campo numero de tracking no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listViewFactura.Items.Clear();
                txtCUIT.Clear();
                return;
            }

            if (!int.TryParse(txtCUIT.Text, out int cuit))
            {
                MessageBox.Show("El campo numero de tracking debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listViewFactura.Items.Clear();
                txtCUIT.Clear();
                return;

            }

            if (!modelo.ValidarCUIT(cuit))
            {
                listViewFactura.Items.Clear();
                txtCUIT.Clear();
                return;
           
            }

            var resultados = modelo.ListarEncomiendas(cuit);

            listViewFactura.Items.Clear();

            if (resultados.Any())
            {
                foreach (var encomienda in resultados)
                {
                    var item = new ListViewItem(encomienda.NroTracking);
                    item.SubItems.Add(encomienda.FechaAdmision.ToString("dd-MM-yyyy"));
                    item.SubItems.Add(encomienda.Importe.ToString("C0"));
                    item.SubItems.Add(encomienda.ExtraRetiro.ToString("C0"));
                    item.SubItems.Add(encomienda.ExtraEntrega.ToString("C0"));
                    item.SubItems.Add(encomienda.ExtraAgencia.ToString("C0"));
                    listViewFactura.Items.Add(item);
                }
               
            }
            else
            {
                MessageBox.Show("No se encontró ninguna encomienda con ese CUIT.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void grpboxImporteTotal_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listViewFactura.Items.Clear();
            txtCUIT.Clear();
        }

        private void listViewFactura_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var importes = new List<(int Importe, int ExtraRetiro, int ExtraEntrega)>();

            // Recorre todos los ítems del ListView
            for (int i = 0; i < listViewFactura.Items.Count; i++)
            {
                // Si es el ítem que está cambiando, usa el valor futuro (e.NewValue)
                bool isChecked = (i == e.Index) ? (e.NewValue == CheckState.Checked) : listViewFactura.Items[i].Checked;

                if (isChecked)
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
    }
}

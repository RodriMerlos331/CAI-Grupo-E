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
                return;
            }

            if (!int.TryParse(txtCUIT.Text, out int cuit))
            {
                MessageBox.Show("El campo numero de tracking debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultados = modelo.ListarEncomiendas(cuit);

            listViewFactura.Items.Clear();

            if (resultados.Any())
            {
                foreach (var encomienda in resultados)
                {
                    var item = new ListViewItem(encomienda.NroTracking);
                    item.SubItems.Add(encomienda.FechaAdmision);
                    item.SubItems.Add(encomienda.Importe);
                    item.SubItems.Add(encomienda.ExtraRetiro);
                    item.SubItems.Add(encomienda.ExtraEntrega);
                    item.SubItems.Add(encomienda.ExtraAgencia);
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
    }
}

using Grupo_E.Almacenes;
using Grupo_E.F07_RetirarEnCD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.RetirarEnCD
{
    public partial class RetirarEnCDForm : Form
    {
        private F07_RetirarEnCDModelo modelo;

        public RetirarEnCDForm()
        {
            InitializeComponent();
            modelo = new F07_RetirarEnCDModelo();
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtNumeroDeTracking.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroDeTracking.Text))
            {
                MessageBox.Show("El campo número de tracking no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (modelo.ExisteEncomiendaEnCDActual(txtNumeroDeTracking.Text))
            {
                MessageBox.Show("Encomienda encontrada en este Centro de Distribución.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró una encomienda con ese número de tracking en este Centro de Distribución.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEntregarEncomienda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroDeTracking.Text))
            {
                MessageBox.Show("El campo número de tracking no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo Apellido no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtDNI.Text, out int dni))
            {
                MessageBox.Show("El campo DNI debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (modelo.ChequearEncomiendaCD(
                    txtNumeroDeTracking.Text,
                    txtNombre.Text,
                    txtApellido.Text,
                    dni))
            {
                MessageBox.Show("Encomienda  entregada en el CD.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumeroDeTracking.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtDNI.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "¿Realmente desea salir y volver al menú principal?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtNumeroDeTracking_TextChanged(object sender, EventArgs e)
        {

        }

        private void RetirarEnCDForm_Load(object sender, EventArgs e)
        {

        }
    }
}
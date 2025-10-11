using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.RetirarEnAgencia
{
    public partial class RetirarEnAgencia : Form
    {
        private RetirarEnAgenciaModelo modelo = new RetirarEnAgenciaModelo();
        public RetirarEnAgencia()
        {
            InitializeComponent();
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
                MessageBox.Show("El campo numero de tracking no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtNumeroDeTracking.Text, out int numeroDeTracking))
            {
                MessageBox.Show("El campo numero de tracking debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (modelo.ExisteEncomiendaPorTracking(numeroDeTracking))
            {
                MessageBox.Show("La encomienda está en la agencia.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La encomienda NO está en la agencia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEntregarEncomienda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroDeTracking.Text))
            {
                MessageBox.Show("El campo numero de tracking no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtNumeroDeTracking.Text, out int numeroDeTracking))
            {
                MessageBox.Show("El campo numero de tracking debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            EncomiendaRA EncomiendaX = new EncomiendaRA //RA x Retirar en Agencia
            {
                NumeroDeTracking = numeroDeTracking,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                DNI = dni
            };

            if (modelo.chequearEncomienda(EncomiendaX))
            {
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
    }
}

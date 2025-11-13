using Grupo_E.Almacenes;
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

namespace Grupo_E.RetirarEnAgencia
{
    public partial class RetirarEnAgencia : Form
    {
        private RetirarEnAgenciaModelo modelo;

        public RetirarEnAgencia()
        {
            InitializeComponent();
            modelo = new RetirarEnAgenciaModelo();
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

            if (modelo.ExisteEncomiendaEnAgenciaActual(txtNumeroDeTracking.Text))
            {
                MessageBox.Show("Encomienda encontrada en esta agencia.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró una encomienda con ese número de tracking en esta agencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEntregarEncomienda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroDeTracking.Text))
            {
                MessageBox.Show("El campo numero de tracking no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (modelo.chequearEncomienda(
                    txtNumeroDeTracking.Text,
                    txtNombre.Text,
                    txtApellido.Text,
                    dni))
            {
                MessageBox.Show("Encomienda entregada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


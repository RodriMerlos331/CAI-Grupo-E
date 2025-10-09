using Grupo_E.GestionarFletero;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.ImposicionEnCallCenter
{
    public partial class F01_ImposicionEnCallCenterForm : Form
    {

        private readonly F01_ImposicionEnCallCenterModel modelo = new F01_ImposicionEnCallCenterModel();
        private int CUITClienteActual = 0;
        public F01_ImposicionEnCallCenterForm()
        {
            InitializeComponent();
        }

        //validar cuit cliente
        private void txtCUITCliente_Leave(object sender, EventArgs e)
        {
            ValidarCUIT();
        }

        private void txtCUIT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarCUIT();
                e.SuppressKeyPress = true;
            }
        }

        private void ValidarCUIT()
        {
            if (!long.TryParse(txtCUITClienteCC.Text, out long cuitCliente))
            {
                MessageBox.Show("El CUIT debe ser numérico.");
                return;
            }

            var cliente = modelo.ExisteClientePorCUIT(cuitCliente);
            if (cliente != null)
            {
            }
        }
    
        private void lblCalleDireccionPCC_Click(object sender, EventArgs e)
        {

        }

        private void txtCalleDireccionPCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreDestinatarioCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNombreDestinatarioCC_Click(object sender, EventArgs e)
        {

        }

        private void lbCUITCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

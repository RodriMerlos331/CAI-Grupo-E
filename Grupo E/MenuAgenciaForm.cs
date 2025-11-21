using Grupo_E.Almacenes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E
{
    public partial class MenuAgenciaForm : Form
    {
        public MenuAgenciaForm()
        {
            InitializeComponent();
        }

        private void MenuAgenciaForm_Load(object sender, EventArgs e)
        {
            AgenciaActualCombo.DisplayMember = "NombreAgencia";
            AgenciaActualCombo.Items.AddRange(AgenciaAlmacen.Agencia.ToArray());
        }

        private void AgenciaActualCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AgenciaAlmacen.AgenciaActual = (AgenciaEntidad)AgenciaActualCombo.SelectedItem;

        }

        private void btnConsultarEstado_Click(object sender, EventArgs e)
        {
            using (var f = new ConsultarEstadoEncomienda.EstadoDeEncomiendaForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnImposicionEnAgencia_Click(object sender, EventArgs e)
        {
            if (AgenciaAlmacen.AgenciaActual == null)
            {
                MessageBox.Show(
                    "Debe seleccionar una agencia antes de ingresar a Imposición en Agencia.",
                    "Agencia no seleccionada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            using (var f = new ImposicionEnAgencia.F02_ImposicionEnAgencia())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnRendicionHDRAgencia_Click(object sender, EventArgs e)
        {
            if (AgenciaAlmacen.AgenciaActual == null)
            {
                MessageBox.Show(
                    "Debe seleccionar una agencia antes de ingresar a Entregar y Recepcionar en Agencia.",
                    "Agencia no seleccionada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            using (var f = new EntregarYRecepcionarEncomiendaAgencia.EntregarYRecepcionarEncomiendaAgenciaForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnRetirarEnAgencia_Click(object sender, EventArgs e)
        {
            if (AgenciaAlmacen.AgenciaActual == null)
            {
                MessageBox.Show(
                    "Debe seleccionar una agencia antes de ingresar a Retiro en Agencia.",
                    "Agencia no seleccionada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            using (var f = new RetirarEnAgencia.RetirarEnAgencia())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void AgenciaActualCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AgenciaAlmacen.AgenciaActual = (AgenciaEntidad)AgenciaActualCombo.SelectedItem;
        }
    }
}

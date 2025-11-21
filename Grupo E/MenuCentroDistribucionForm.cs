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
    public partial class MenuCentroDistribucionForm : Form
    {
        public MenuCentroDistribucionForm()
        {
            InitializeComponent();
        }

       

        private void btnGestionarFletero_Click(object sender, EventArgs e)
        {
            if (CentroDeDistribucionAlmacen.CentroDistribucionActual == null)
            {
                MessageBox.Show(
                    "Debe seleccionar un Centro de Distribución antes de ingresar a Gestionar Fletero",
                    "Centro de Distribución no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            using (var f = new GestionarFletero.F05_GestionarFleteroForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void CentroDeDistribucionActualCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CentroDeDistribucionAlmacen.CentroDistribucionActual = (CentroDeDistribucionEntidad)CentroDeDistribucionActualCombo.SelectedItem;

        }

        private void btnGestionarOmnibus_Click(object sender, EventArgs e)
        {
            if (CentroDeDistribucionAlmacen.CentroDistribucionActual == null)
            {
                MessageBox.Show(
                    "Debe seleccionar un Centro de Distribución antes de ingresar a Gestionar Omnibus.",
                    "Centro de Distribución no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            using (var f = new GestionarOmnibus.F04_GestionarOmnibusForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnImposicionEnCD_Click(object sender, EventArgs e)
        {
            if (CentroDeDistribucionAlmacen.CentroDistribucionActual == null)
            {
                MessageBox.Show(
                    "Debe seleccionar un Centro de Distribución antes de ingresar a Imposición en CD.",
                    "Centro de Distribución no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            using (var f = new ImposicionEnCD.F03_ImposicionCDForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnRetirarEnCD_Click(object sender, EventArgs e)
        {
            if (CentroDeDistribucionAlmacen.CentroDistribucionActual == null)
            {
                MessageBox.Show(
                    "Debe seleccionar un Centro de Distribución antes de ingresar a Retiro en CD.",
                    "Centro de Distribución no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            using (var f = new RetirarEnCD.RetirarEnCDForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnConsultarEstado_Click(object sender, EventArgs e)
        {
            using (var f = new ConsultarEstadoEncomienda.EstadoDeEncomiendaForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void MenuCentroDistribucionForm_Load_1(object sender, EventArgs e)
        {
            CentroDeDistribucionActualCombo.DisplayMember = "NombreTerminal";
            CentroDeDistribucionActualCombo.Items.AddRange(CentroDeDistribucionAlmacen.CentroDeDistribucion.ToArray());
        }
    }
}

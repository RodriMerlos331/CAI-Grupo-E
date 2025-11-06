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
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();

            // Enlazar eventos Click de los botones del menú
            this.btnConsultarEstado.Click += btnConsultarEstado_Click;
            this.btnCostosVsVentas.Click += btnCostosVsVentas_Click;
            this.btnImposicionEnAgencia.Click += btnImposicionEnAgencia_Click;
            this.btnImposicionEnCD.Click += btnImposicionEnCD_Click;
            this.btnRendicionHDRAgencia.Click += btnRendicionHDRAgencia_Click;
            this.btnRetirarEnAgencia.Click += btnRetirarEnAgencia_Click;
            this.btnRetirarEnCD.Click += btnRetirarEnCD_Click;
            this.btnEstadoCuentasCorrientes.Click += btnEstadoCuentasCorrientes_Click;
            this.btnGeneracionDeFacturas.Click += btnGeneracionDeFacturas_Click;
            this.btnGestionarFletero.Click += btnGestionarFletero_Click;
            this.btnGestionarOmnibus.Click += btnGestionarOmnibus_Click;
            this.btnImposicionEnCallCenter.Click += btnImposicionEnCallCenter_Click;

        }
        private void btnConsultarEstado_Click(object sender, EventArgs e)
        {
            using (var f = new ConsultarEstadoEncomienda.EstadoDeEncomiendaForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnCostosVsVentas_Click(object sender, EventArgs e)
        {
            using (var f = new FormResultadoCostoVsVentas.FormResultadoCostoVsVentas())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnImposicionEnAgencia_Click(object sender, EventArgs e)
        {
            using (var f = new ImposicionEnAgencia.F02_ImposicionEnAgencia())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnImposicionEnCD_Click(object sender, EventArgs e)
        {
            using (var f = new ImposicionEnCD.F03_ImposicionCDForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnRendicionHDRAgencia_Click(object sender, EventArgs e)
        {
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
        private void btnEstadoCuentasCorrientes_Click(object sender, EventArgs e)
        {
            using (var f = new EstadoCuentasCorrientes.FormEstadoCuentasCorrientes())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnGeneracionDeFacturas_Click(object sender, EventArgs e)
        {
            using (var f = new GeneracionDeFacturas.F10_GeneracionDeFacturasForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnGestionarFletero_Click(object sender, EventArgs e)
        {
            using (var f = new GestionarFletero.F05_GestionarFleteroForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnGestionarOmnibus_Click(object sender, EventArgs e)
        {
            using (var f = new GestionarOmnibus.F04_GestionarOmnibusForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnImposicionEnCallCenter_Click(object sender, EventArgs e)
        {
            using (var f = new ImposicionEnCallCenter.F01_ImposicionEnCallCenterForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);


            }
        }

        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {
            CentroDeDistribucionActualCombo.DisplayMember = "NombreTerminal";
            CentroDeDistribucionActualCombo.Items.AddRange(CentroDeDistribucionAlmacen.CentroDeDistribucion.ToArray());

            AgenciaActualCombo.DisplayMember = "NombreAgencia";
            AgenciaActualCombo.Items.AddRange(AgenciaAlmacen.Agencia.ToArray());
        }

        private void CentroDeDistribucionActualCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CentroDeDistribucionAlmacen.CentroDistribucionActual = (CentroDeDistribucionEntidad)CentroDeDistribucionActualCombo.SelectedItem;
          
        }

 

        private void AgenciaActualCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AgenciaAlmacen.AgenciaActual = (AgenciaEntidad)AgenciaActualCombo.SelectedItem;

        }
    }

}

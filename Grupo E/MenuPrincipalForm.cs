
using Grupo_E.GestionarFletero;
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
            using (var f = new ImposicionEnAgencia.ImposicionEnAgencia())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnImposicionEnCD_Click(object sender, EventArgs e)
        {
            using (var f = new ImposicionEnCD.ImposicionCD())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnRendicionHDRAgencia_Click(object sender, EventArgs e)
        {
            using (var f = new RendicionHDRAgencia.RendicionHDRAgenciaForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnRetirarEnAgencia_Click(object sender, EventArgs e)
        {
            using (var f = new RetirarEnAgencia.RetirarEnAgencia())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnRetirarEnCD_Click(object sender, EventArgs e)
        {
            using (var f = new RetirarEnCD.RetirarEnCD())
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
            using (var f = new GeneracionDeFacturas.GeneracionDeFacturas())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnGestionarFletero_Click(object sender, EventArgs e)
        {
            using (var f = new GestionarFleteroForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnGestionarOmnibus_Click(object sender, EventArgs e)
        {
            using (var f = new GestionarOmnibus.GestionarOmnibusForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnImposicionEnCallCenter_Click(object sender, EventArgs e)
        {
            using (var f = new ImposicionEnCallCenter.ImposicionEnCallCenter())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);


            }
        }


    }

}

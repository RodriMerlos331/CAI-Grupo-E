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
    public partial class MenuAdminFinancieraForm : Form
    {
        public MenuAdminFinancieraForm()
        {
            InitializeComponent();
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
    }
}

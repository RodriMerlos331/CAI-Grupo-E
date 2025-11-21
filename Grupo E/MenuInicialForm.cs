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
    public partial class MenuInicialForm : Form
    {
        public MenuInicialForm()
        {
            InitializeComponent();
        }

        private void btnMenuAgencia_Click(object sender, EventArgs e)
        {
            using (var f = new MenuAgenciaForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnMenuCentroDistribución_Click(object sender, EventArgs e)
        {
            using (var f = new MenuCentroDistribucionForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }

        }

        private void btnMenuAdministracion_Click(object sender, EventArgs e)
        {
            using (var f = new MenuAdminFinancieraForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnMenuCallCenter_Click(object sender, EventArgs e)
        {
            using (var f = new MenuCallCenterForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }
    }
}

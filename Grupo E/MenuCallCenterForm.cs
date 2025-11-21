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
    public partial class MenuCallCenterForm : Form
    {
        public MenuCallCenterForm()
        {
            InitializeComponent();
        }

        private void btnImposicionEnCallCenter_Click(object sender, EventArgs e)
        {
            using (var f = new ImposicionEnCallCenter.F01_ImposicionEnCallCenterForm())
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
    }
}

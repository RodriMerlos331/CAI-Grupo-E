using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.GestionarFletero
{
    public partial class GestionarFleteroForm : Form
    {
        private readonly GestionarFleteroModel modelo = new GestionarFleteroModel();
        public GestionarFleteroForm()
        {
            InitializeComponent();
        }

        private void GestionarFleteroForm_Load(object sender, EventArgs e)
        {

        }
    }
}

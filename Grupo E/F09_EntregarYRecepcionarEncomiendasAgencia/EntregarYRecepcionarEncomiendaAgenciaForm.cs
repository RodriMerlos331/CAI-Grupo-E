using Grupo_E.F05_GestionarFletero;
using Grupo_E.F09_EntregarYRecepcionarEncomiendasAgencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.EntregarYRecepcionarEncomiendaAgencia
{
    public partial class EntregarYRecepcionarEncomiendaAgenciaForm : Form
    {

        private readonly EntregaYRecepcionEncomiendaAgenciaModel modelo = new EntregaYRecepcionEncomiendaAgenciaModel();    
        
        public EntregarYRecepcionarEncomiendaAgenciaForm()
        {
            InitializeComponent();
        }

        private void EntregarYRecepcionarEncomiendaAgenciaForm_Load(object sender, EventArgs e)
        {

        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            GuiasAEntregarListView.Items.Clear();
            GuiasARecibirListView.Items.Clear();

            if (string.IsNullOrWhiteSpace(DNITxt.Text))
            {
                MessageBox.Show("Ingresá un DNI.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DNITxt.Focus();
                return;
            }

            int dni;


            if (!int.TryParse(DNITxt.Text.Trim(), out dni))
            {
                MessageBox.Show("Ingresá un DNI válido.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DNITxt.Focus();
                return;
            }

            // se imprime en ambas listas corregir
            foreach (var encomienda in modelo.EncomiendasAEntregar(dni))
            {
                GuiasAEntregarListView.Items.Add(
                    new ListViewItem(encomienda.TrackingId.ToString()));
            }

            foreach (var encomienda in modelo.EncomiendasARecibir(dni))
            {
                GuiasARecibirListView.Items.Add(
                    new ListViewItem(encomienda.TrackingId.ToString()));
            }

           
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            DNITxt.Clear();
            GuiasAEntregarListView.Items.Clear();
            GuiasARecibirListView.Items.Clear();
            DNITxt.Focus();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            modelo.AceptarCambiosEncomiendas();
            DNITxt.Clear();
            GuiasAEntregarListView.Items.Clear();
            GuiasARecibirListView.Items.Clear();
            DNITxt.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

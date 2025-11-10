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

            /* foreach (KeyValuePair<string, GuiaDeEncomiendas> numGuia in modelo.data)
            {
                GuiaDeEncomiendas guia = numGuia.Value;

                if (guia.FleteroAsignado == dni)
                {

                    //EntransitoUM: encomiendas que le doy al fletero y agenciaorigen = agencia actual
                    if (guia.EstadoEnvio == EstadoDeEnvio.EntransitoUM)
                    {
                        GuiasAEntregarListView.Items.Add(
                            new ListViewItem(guia.TrackingId.ToString()));
                    }
                    //EnTransitoUMDestino: encomienda && agenciadestino = agencia actual
                    else if (guia.EstadoEnvio == EstadoDeEnvio.PendienteEntregaAgencia)
                    {
                        GuiasARecibirListView.Items.Add(
                            new ListViewItem(guia.TrackingId.ToString()));
                    }
                } 
             } */
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

            /*
             foreach (ListViewItem item in GuiasAEntregarListView.Items)
             {
                string trackingId = ""; 
                modelo.data[trackingId].EstadoEnvio = EstadoDeEnvio.RetiradaAgenciaFletero;
                //Pasa a "RetiradaAgenciaFletero"
             }

            foreach (ListViewItem item in GuiasARecibirListView.Items)
            {

                 string trackingId = "";
                 modelo.data[trackingId].EstadoEnvio = EstadoDeEnvio.PendienteRetiroAgencia;

                //este está ok_!!!

            }

            */

        }
    }
}

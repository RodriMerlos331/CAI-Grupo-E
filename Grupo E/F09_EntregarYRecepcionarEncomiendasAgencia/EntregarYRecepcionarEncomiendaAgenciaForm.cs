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

            var result = modelo.ObtenerListasParaForm(dni);
            var aEntregar = result.Item1;
            var aRecibir = result.Item2;

            GuiasAEntregarListView.Items.Clear();
            GuiasARecibirListView.Items.Clear();

            foreach (var enc in aEntregar)
                if (!string.IsNullOrWhiteSpace(enc.Tracking))
                    GuiasAEntregarListView.Items.Add(new ListViewItem(enc.Tracking.Trim()));

            foreach (var enc in aRecibir)
                if (!string.IsNullOrWhiteSpace(enc.Tracking))
                    GuiasARecibirListView.Items.Add(new ListViewItem(enc.Tracking.Trim()));

            /*foreach (KeyValuePair<int, GuiaDeEncomiendas> numGuia in modelo.data)
            {
                GuiaDeEncomiendas guia = numGuia.Value;

                if (guia.FleteroAsignado.DNI == dni)
                {
                    if (guia.EstadoEnvio == EstadoDeEnvio.RuteadaRetiroAgencia)
                    {
                        GuiasAEntregarListView.Items.Add(
                            new ListViewItem(guia.TrackingId.ToString()));
                    }
                    else if (guia.EstadoEnvio == EstadoDeEnvio.PendienteEntregaAgencia)
                    {
                        GuiasARecibirListView.Items.Add(
                            new ListViewItem(guia.TrackingId.ToString()));
                    }
                }
            }*/
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
            var aEntregar = GuiasAEntregarListView.Items
                 .Cast<ListViewItem>()
                 .Select(i => (i.Text ?? "").Trim())
                 .Where(t => t.Length > 0)
                 .ToList();

            var aRecibir = GuiasARecibirListView.Items
                .Cast<ListViewItem>()
                .Select(i => (i.Text ?? "").Trim())
                .Where(t => t.Length > 0)
                .ToList();

            var result = modelo.ConfirmarCambiosDesdeListas(aEntregar, aRecibir);
            int aEnTransitoUMOrigen = result.Item1;
            int aPendienteRetiroAgencia = result.Item2;

            GuiasAEntregarListView.Items.Clear();
            GuiasARecibirListView.Items.Clear();
            DNITxt.Clear();
            DNITxt.Focus();

            MessageBox.Show(
            $"Actualizadas {aEnTransitoUMOrigen} a EnTransitoUMOrigen y {aPendienteRetiroAgencia} a PendienteRetiroAgencia.",
            "Operación completada",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);





            /*   foreach (ListViewItem item in GuiasAEntregarListView.Items)
               {
                   int trackingId = int.Parse(item.Text);
                   //modelo.data[trackingId].EstadoEnvio = EstadoDeEnvio.ImpuestaPendienteRetiroAgencia;
               }

               foreach (ListViewItem item in GuiasARecibirListView.Items)
               {

                   int trackingId = int.Parse(item.Text);
                   //modelo.data[trackingId].EstadoEnvio = EstadoDeEnvio.PendienteRetiroAgencia;

               }
            */
        }
    }
}

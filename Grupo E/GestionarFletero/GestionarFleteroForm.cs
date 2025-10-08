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
            modelo.CargarFleteros();
            modelo.CargarHDR();
            modelo.GenerarNuevasHDRyGuias();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            HDRAsignadasListView.Items.Clear();
            if (string.IsNullOrWhiteSpace(DNIText.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacío");
                return;
            }
            if (!int.TryParse(DNIText.Text, out int dniFleteroBuscar))
            {
                MessageBox.Show("El campo DNI debe ser un número válido");
                return;
            }

            var hdrAsignadas = modelo.ObtenerHDRAsignadas(dniFleteroBuscar);

            foreach (var hdr in hdrAsignadas)
            {
                var item = new ListViewItem(hdr.IdHDR.ToString());
                item.SubItems.Add(hdr.Tipo);
                item.Tag = hdr;
                HDRAsignadasListView.Items.Add(item);
            }

            foreach (var hdr in modelo.NuevasHDRRetiro)
            {
                var item = new ListViewItem(hdr.IdHDR.ToString());
                item.SubItems.Add(hdr.Tipo);
                HDRRetirarListViews.Items.Add(item);
            }

            foreach (var hdr in modelo.NuevasHDREntrega)
            {
                var item = new ListViewItem(hdr.IdHDR.ToString());
                item.SubItems.Add(hdr.Tipo);
                HDREntregarListView.Items.Add(item);
            }

            foreach (var guia in modelo.NuevasGuiasRetiro)
            {
                var item = new ListViewItem(guia.NroHDRAsignada.ToString());
                item.SubItems.Add(guia.Tracking.ToString());
                GuiasRetirarListView.Items.Add(item);
            }

            // Guías Entrega
            foreach (var guia in modelo.NuevasGuiasEntrega)
            {
                var item = new ListViewItem(guia.NroHDRAsignada.ToString());
                item.SubItems.Add(guia.Tracking.ToString());
                GuiasEntregarListView.Items.Add(item);
            }
            foreach (var hdr in modelo.NuevasHDRRetiro)
            {
                var item = new ListViewItem(hdr.IdHDR.ToString());
                item.SubItems.Add(hdr.Tipo);
                HDRRetirarListViews.Items.Add(item);
            }

            foreach (var hdr in modelo.NuevasHDREntrega)
            {
                var item = new ListViewItem(hdr.IdHDR.ToString());
                item.SubItems.Add(hdr.Tipo);
                HDREntregarListView.Items.Add(item);
            }

            foreach (var guia in modelo.NuevasGuiasRetiro)
            {
                var item = new ListViewItem(guia.NroHDRAsignada.ToString());
                item.SubItems.Add(guia.Tracking.ToString());
                GuiasRetirarListView.Items.Add(item);
            }

            // Guías Entrega
            foreach (var guia in modelo.NuevasGuiasEntrega)
            {
                var item = new ListViewItem(guia.NroHDRAsignada.ToString());
                item.SubItems.Add(guia.Tracking.ToString());
                GuiasEntregarListView.Items.Add(item);
            }
        }



        //BOTON ACTUALIZAR HDR
        private void ActualizarHDRBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in HDRAsignadasListView.Items)
            {
                var hdr = item.Tag as HDR;
                if (hdr == null)
                    continue;

                hdr.Cumplida = item.Checked;
            }

            modelo.ProcesarHDRsActualizadas();

            MessageBox.Show("HDR actualizadas correctamente.");

            foreach (var guia in modelo.guiasAAdmitir)
            {
                var item = new ListViewItem(guia.NroHDRAsignada.ToString());
                item.SubItems.Add(guia.Tracking.ToString());
                GuiasRetiradasListView.Items.Add(item);
            }

            foreach (var guia in modelo.guiasADevolver)
            {
                var item = new ListViewItem(guia.NroHDRAsignada.ToString());
                item.SubItems.Add(guia.Tracking.ToString());
                GuiasNoEntregadasListView.Items.Add(item);
            }          
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            HDRAsignadasListView.Items.Clear();
            GuiasEntregarListView.Items.Clear();
            GuiasRetirarListView.Items.Clear();
            GuiasNoEntregadasListView.Items.Clear();
            GuiasRetiradasListView.Items.Clear();
            HDREntregarListView.Items.Clear();
            HDRRetirarListViews.Items.Clear();

        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            modelo.GuardarCambios();
            //TODO: limpiá la pantalla.
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            //Está ud? seguro?
            this.Close();
        }        
    }


}


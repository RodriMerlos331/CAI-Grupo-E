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
        private int dniFleteroActual = 0;

        public GestionarFleteroForm()
        {
            InitializeComponent();
        }

        private void GestionarFleteroForm_Load(object sender, EventArgs e)
        {

        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(DNIText.Text, out int dniFletero))
            {
                MessageBox.Show("El DNI debe ser númerico");
                return;

            }

            dniFleteroActual = dniFletero;
            HDRAsignadasListView.Items.Clear();

            var hdrAsignadas = modelo.ObtenerHDRAsignadas(dniFletero);

            foreach (var hdr in hdrAsignadas)
            {
                var item = new ListViewItem(hdr.IdHDR.ToString());
                item.SubItems.Add(hdr.Tipo);
                item.Checked = hdr.Cumplida; 
                HDRAsignadasListView.Items.Add(item);
            }
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            HDRAsignadasListView.Items.Clear();

        }

        private void HDRAsignadasListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item != null)
            {
                int idHDR = int.Parse(e.Item.Text);
                bool cumplida = e.Item.Checked;

                // Actualizo estado en el modelo
                modelo.ActualizarCumplimientoHDR(idHDR, cumplida);

                // Refresco las listas de guías
                ActualizarListasDeGuias();
            }
        }


        private void ActualizarListasDeGuias()
        {
            GuiasNoEntregadasListView.Items.Clear();
            GuiasRetiradasListView.Items.Clear();
            var hdrsDelFletero = modelo.ObtenerHDRPorFletero(dniFleteroActual);

            foreach (var hdr in hdrsDelFletero)
            {
                // 🔹 Si es de entrega y no se cumplió → va a "No Entregadas"
                if (hdr.Tipo == "Entrega" && !hdr.Cumplida)
                {
                    foreach (var guia in hdr.Guias)
                    {
                        var item = new ListViewItem(hdr.IdHDR.ToString());
                        item.SubItems.Add(guia.Tracking.ToString());
                        GuiasNoEntregadasListView.Items.Add(item);
                    }
                }

                // 🔹 Si es de retiro y se cumplió → va a "Retiradas a admitir"
                else if (hdr.Tipo == "Retiro" && hdr.Cumplida)
                {
                    foreach (var guia in hdr.Guias)
                    {
                        var item = new ListViewItem(hdr.IdHDR.ToString());
                        item.SubItems.Add(guia.Tracking.ToString());
                        GuiasRetiradasListView.Items.Add(item);
                    }
                }
            }
        }

    }
}

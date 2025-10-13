using Grupo_E.F05_GestionarFletero;
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
    public partial class F05_GestionarFleteroForm : Form
    {
        private readonly F05_GestionarFleteroModel modelo = new F05_GestionarFleteroModel();

        public F05_GestionarFleteroForm()
        {
            InitializeComponent();
        }

        private void F05_GestionarFleteroForm_Load(object sender, EventArgs e)
        {
            modelo.CargarHDRDePrueba();

        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(DNIText.Text, out int dni))
            {
                MessageBox.Show("El DNI debe ser numerico");
                return;
            }

            HDRAsignadasListView.Items.Clear();

            var hdrs = modelo.ObtenerHDRPorTransportista(dni);

            if (hdrs.Count == 0)
            {
                MessageBox.Show("No se encontraron HDR para el DNI ingresado");
                return;
            }

            foreach (var hdr in hdrs)
            {
                var item = new ListViewItem(hdr.NumeroHDR.ToString());
                item.SubItems.Add(hdr.Tipo.ToString());
                HDRAsignadasListView.Items.Add(item);

            }

            var guiasNoEntregadas = modelo.ObtenerGuiasDeHDRNoCumplidas(dni, HDR.TipoHDR.Entrega);
            var guiasNoRetiradas = modelo.ObtenerGuiasDeHDRNoCumplidas(dni, HDR.TipoHDR.Retiro);

            GuiasNoEntregadasListView.Items.Clear();

            foreach (var guia in guiasNoEntregadas)
            {
                var item = new ListViewItem(guia.NumeroHDR.ToString());
                item.SubItems.Add(guia.CodigoGuia.ToString());
                GuiasNoEntregadasListView.Items.Add(item);
            }
            
            NuevasHDREntregarListView.Items.Clear();
            NuevasHDRRetirarListViews.Items.Clear();
            NuevasGuiasEntregarListView.Items.Clear();
            NuevasGuiasRetirarListView.Items.Clear();
            
            var hdrGeneracion = modelo.ObtenerHDRGeneracionPorTransportista(dni);

            var hdrsEntrega = hdrGeneracion.Where(h => h.Tipo == HDR.TipoHDR.Entrega).ToList();
            var hdrsRetiro = hdrGeneracion.Where(h => h.Tipo == HDR.TipoHDR.Retiro).ToList();

            
            foreach (var hdr in hdrsEntrega)
            {
                var item = new ListViewItem(hdr.NumeroHDR.ToString());
                NuevasHDREntregarListView.Items.Add(item);

                foreach (var guia in hdr.Guias)
                {
                    var guiaItem = new ListViewItem(hdr.NumeroHDR.ToString());
                    guiaItem.SubItems.Add(guia.CodigoGuia);
                    NuevasGuiasEntregarListView.Items.Add(guiaItem);
                }
            }
            
            foreach (var hdr in hdrsRetiro)
            {
                var item = new ListViewItem(hdr.NumeroHDR.ToString());
                NuevasHDRRetirarListViews.Items.Add(item);

                foreach (var guia in hdr.Guias)
                {
                    var guiaItem = new ListViewItem(hdr.NumeroHDR.ToString());
                    guiaItem.SubItems.Add(guia.CodigoGuia);
                    NuevasGuiasRetirarListView.Items.Add(guiaItem);
                }
            }

        }

        private void HDRAsignadasListView_ItemChecked_1(object sender, ItemCheckedEventArgs e)
        {
            int nroHDR = int.Parse(e.Item.SubItems[0].Text);

            var hdr = modelo.ObtenerHDRPorNumero(nroHDR)
                   .FirstOrDefault(h => h.NumeroHDR == nroHDR);

            hdr.Cumplida = e.Item.Checked;
            hdr.ActualizarEstado(hdr.Cumplida);

            ActualizarListasPorHDR(hdr);
        }

        private void ActualizarListasPorHDR(HDR hdr)
        {
            if (hdr.Tipo == HDR.TipoHDR.Entrega)
            {
                if (hdr.Cumplida) // Si se marcó como cumplida → quitar guías
                {
                    foreach (var guia in hdr.Guias)
                    {
                        foreach (ListViewItem item in GuiasNoEntregadasListView.Items)
                        {
                            if (item.SubItems[0].Text == hdr.NumeroHDR.ToString() &&
                                item.SubItems[1].Text == guia.CodigoGuia)
                            {
                                GuiasNoEntregadasListView.Items.Remove(item);
                                break;
                            }
                        }
                    }
                }
                else // Si se desmarcó → volver a agregar guías
                {
                    foreach (var guia in hdr.Guias)
                    {
                        var item = new ListViewItem(hdr.NumeroHDR.ToString());
                        item.SubItems.Add(guia.CodigoGuia);
                        GuiasNoEntregadasListView.Items.Add(item);
                    }
                }
            }

            if (hdr.Tipo == HDR.TipoHDR.Retiro)
            {
                if (hdr.Cumplida) // Si se marcó como cumplida → agregar guías
                {
                    foreach (var guia in hdr.Guias)
                    {
                        var item = new ListViewItem(hdr.NumeroHDR.ToString());
                        item.SubItems.Add(guia.CodigoGuia);
                        GuiasRetiradasListView.Items.Add(item);
                    }
                }
                else // Si se desmarcó → quitar guías
                {
                    foreach (var guia in hdr.Guias)
                    {
                        foreach (ListViewItem item in GuiasRetiradasListView.Items)
                        {
                            if (item.SubItems[0].Text == hdr.NumeroHDR.ToString() &&
                                item.SubItems[1].Text == guia.CodigoGuia)
                            {
                                GuiasRetiradasListView.Items.Remove(item);
                                break;
                            }
                        }
                    }
                }
            }
        }

       
    }
}


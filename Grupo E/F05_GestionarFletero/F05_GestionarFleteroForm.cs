using Grupo_E.Almacenes;
using Grupo_E.F05_GestionarFletero;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            //modelo.CargarHDRDePrueba();

        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(DNIText.Text, out int dni))
            {
                MessageBox.Show("El DNI debe ser numerico");
                return;
            }


            var hdrs = modelo.ObtenerHDRRendicionPorTransportista(dni);

            if (hdrs.Count == 0)
            {
                MessageBox.Show("No se encontraron HDR a rendir para el DNI ingresado");
                return;
            }

            HDRAsignadasListView.Items.Clear();

            foreach (var hdr in hdrs)
            {
                var item = new ListViewItem(hdr.NumeroHDRUM.ToString());
                item.SubItems.Add(Enum.GetName(typeof(TipoHDREnum), hdr.Tipo));
                item.Tag = hdr; // guardo la referencia real del almacen
                HDRAsignadasListView.Items.Add(item);
            }

            var guiasNoEntregadas = modelo.ObtenerGuiasDeHDRNoCumplidas(TipoHDREnum.Entrega);
            var guiasNoRetiradas = modelo.ObtenerGuiasDeHDRNoCumplidas(TipoHDREnum.Retiro);

            GuiasNoEntregadasListView.Items.Clear();

            foreach (var itemData in guiasNoEntregadas)
            {
                var item = new ListViewItem(itemData.NumeroHDR.ToString());
                item.SubItems.Add(itemData.Guia);
                GuiasNoEntregadasListView.Items.Add(item);
            }

            NuevasHDREntregarListView.Items.Clear();
            NuevasHDRRetirarListViews.Items.Clear();
            NuevasGuiasEntregarListView.Items.Clear();
            NuevasGuiasRetirarListView.Items.Clear();
            

           

        }

        /*
        private void HDRAsignadasListView_ItemChecked_1(object sender, ItemCheckedEventArgs e)
        {
            int nroHDR = int.Parse(e.Item.SubItems[0].Text);

            var hdr = modelo.ObtenerHDRPorNumero(nroHDR)
                   .FirstOrDefault(h => h.NumeroHDR == nroHDR);

            hdr.Cumplida = e.Item.Checked;

            //Está ok poner el metodo acá o debería ir en el modelo?
            hdr.ActualizarEstado(hdr.Cumplida);

            ActualizarListasPorHDR(hdr);
        }
        */

            private void HDRAsignadasListView_ItemChecked_1(object sender, ItemCheckedEventArgs e)
{

            var hdr = e.Item.Tag as HDRDistribucionUMEntidad;

            hdr.Cumplida = e.Item.Checked;


            hdr.ActualizarEstado(e.Item.Checked);

            ActualizarListasPorHDR(hdr);
            /*
             * int nroHDR = int.Parse(e.Item.SubItems[0].Text);

            var hdr = modelo.ObtenerHDRPorNumero(nroHDR)
                   .FirstOrDefault(h => h.NumeroHDR == nroHDR);

            hdr.Cumplida = e.Item.Checked;

            //Está ok poner el metodo acá o debería ir en el modelo?
            hdr.ActualizarEstado(hdr.Cumplida);

            ActualizarListasPorHDR(hdr);
             */
        }


        private void ActualizarListasPorHDR(HDRDistribucionUMEntidad hdr)
        {
            if (hdr.Tipo == TipoHDREnum.Entrega)
            {
                if (hdr.Cumplida)
                {
                    foreach (var guia in hdr.Encomiendas)
                    {
                        foreach (ListViewItem item in GuiasNoEntregadasListView.Items)
                        {
                            if (item.SubItems[0].Text == hdr.NumeroHDRUM.ToString() &&
                                item.SubItems[1].Text == guia)
                            {
                                GuiasNoEntregadasListView.Items.Remove(item);
                                break;
                            }
                        }
                    }
                }
                else
                {
                    foreach (var guia in hdr.Encomiendas)
                    {
                        var item = new ListViewItem(hdr.NumeroHDRUM.ToString());
                        item.SubItems.Add(guia);
                        GuiasNoEntregadasListView.Items.Add(item);
                    }
                }
            }

            if (hdr.Tipo == TipoHDREnum.Retiro)
            {
                if (hdr.Cumplida)
                {
                    foreach (var guia in hdr.Encomiendas)
                    {
                        var item = new ListViewItem(hdr.NumeroHDRUM.ToString());
                        item.SubItems.Add(guia);
                        GuiasRetiradasListView.Items.Add(item);
                    }
                }
                else
                {
                    foreach (var guia in hdr.Encomiendas)
                    {
                        foreach (ListViewItem item in GuiasRetiradasListView.Items)
                        {
                            if (item.SubItems[0].Text == hdr.NumeroHDRUM.ToString() &&
                                item.SubItems[1].Text == guia)
                            {
                                GuiasRetiradasListView.Items.Remove(item);
                                break;
                            }
                        }
                    }
                }
            }
        }

        /*
        private void ActualizarListasPorHDR(HDR hdr)
        {
            if (hdr.Tipo == HDR.TipoHDR.Entrega)
            {
                if (hdr.Cumplida) 
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
                else 
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
                if (hdr.Cumplida) 
                {
                    foreach (var guia in hdr.Guias)
                    {
                        var item = new ListViewItem(hdr.NumeroHDR.ToString());
                        item.SubItems.Add(guia.CodigoGuia);
                        GuiasRetiradasListView.Items.Add(item);
                    }
                }
                else
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
        */

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            DNIText.Text = "";
            HDRAsignadasListView.Items.Clear();
            GuiasNoEntregadasListView.Items.Clear();    
            GuiasRetiradasListView.Items.Clear();
            NuevasHDREntregarListView.Items.Clear();
            NuevasHDRRetirarListViews.Items.Clear();
            NuevasGuiasEntregarListView.Items.Clear();
            NuevasGuiasRetirarListView.Items.Clear();

        }

        private void GenerarHdrBtn_Click(object sender, EventArgs e)
        {
            //GENERACION - Esto en el prototipo era independiente a lo anterior, así que ahora voy a hacerlo aparte con otro botón! 
            if (!int.TryParse(DNIText.Text, out int dni))
            {
                MessageBox.Show("El DNI debe ser numerico");
                return;
            }

            NuevasHDREntregarListView.Items.Clear();
            NuevasHDRRetirarListViews.Items.Clear();
            NuevasGuiasEntregarListView.Items.Clear();
            NuevasGuiasRetirarListView.Items.Clear();

            var hdrGeneracion = modelo.ObtenerHDRGeneracionPorTransportista(dni);

            if (hdrGeneracion == null || hdrGeneracion.Count == 0)
            {
                MessageBox.Show("No hay HDR para generar para el DNI ingresado");
                return;
            }

            var hdrsEntrega = hdrGeneracion.Where(h => h.Tipo == TipoHDREnum.Entrega).ToList();
            var hdrsRetiro = hdrGeneracion.Where(h => h.Tipo == TipoHDREnum.Retiro).ToList();


            foreach (var hdr in hdrsEntrega)
            {
                var item = new ListViewItem(hdr.NumeroHDRUM.ToString());
                NuevasHDREntregarListView.Items.Add(item);

                if (hdr.Encomiendas != null)
                {
                    foreach (var guia in hdr.Encomiendas)
                    {
                        var guiaItem = new ListViewItem(hdr.NumeroHDRUM.ToString());
                        guiaItem.SubItems.Add(guia);
                        NuevasGuiasEntregarListView.Items.Add(guiaItem);
                    }
                }
            }

            foreach (var hdr in hdrsRetiro)
            {
                var item = new ListViewItem(hdr.NumeroHDRUM.ToString());
                NuevasHDRRetirarListViews.Items.Add(item);

                if (hdr.Encomiendas != null)
                {
                    foreach (var guia in hdr.Encomiendas)
                    {
                        var guiaItem = new ListViewItem(hdr.NumeroHDRUM.ToString());
                        guiaItem.SubItems.Add(guia);
                        NuevasGuiasRetirarListView.Items.Add(guiaItem);
                    }
                }
            }

        }
        private void AceptarBtn_Click(object sender, EventArgs e)
        {

            //Actualizo encomiendas rendidas y HDR generadoas
            var HDRARendir = modelo.ObtenerHDRRendicionTransportistaActual();

            if (HDRARendir.Count == 0)
            {
                MessageBox.Show("No hay HDR para rendir.");
                return;
            }

            string resumen = "Se marcarán como rendidas las siguientes HDR, con sus estados (Cumplida o no Cumplida):\n";

            foreach (var hdr in HDRARendir)
            {
                string estado = hdr.Cumplida ? "Cumplida" : "No Cumplida";
                resumen += $"HDR Nro: {hdr.NumeroHDRUM}, Estado: {estado}\n";
            }

            MessageBox.Show(resumen, "Resumen de Rendición", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (var hdr in HDRARendir)
            {
                hdr.Rendida = true;
            }



            MessageBox.Show("Cambios guardados correctamente (se reflejarán al cerrar la aplicación).");

            DNIText.Text = "";
            HDRAsignadasListView.Items.Clear();
            GuiasNoEntregadasListView.Items.Clear();
            GuiasRetiradasListView.Items.Clear();
            NuevasHDREntregarListView.Items.Clear();
            NuevasHDRRetirarListViews.Items.Clear();
            NuevasGuiasEntregarListView.Items.Clear();
            NuevasGuiasRetirarListView.Items.Clear();
        }


        //REVISAR SI EL GUARDADO ESTÁ OK ASÍ:

        /*
        private void AceptarBtn_Click(object sender, EventArgs e)
        {

            //Se podría hacer así?
            //var HDRARendir = modelo.ObtenerHDRRendicionPorTransportista(int.Parse(DNIText.Text));

            var HDRARendir = modelo.ObtenerHDRRendicionTransportistaActual();

            if( HDRARendir.Count == 0)
            {
                MessageBox.Show("No hay HDR para rendir.");
                return;
            }

            string resumen = "Se marcarán como rendidas las siguientes HDR, con sus estados (Cumplida o no Cumplida):\n";
            
            foreach (var hdr in HDRARendir)
            {
                string estado = hdr.Cumplida ? "Cumplida" : "No Cumplida";
                resumen += $"HDR Nro: {hdr.NumeroHDR}, Estado: {estado}\n";
            }

            MessageBox.Show(resumen, "Resumen de Rendición", MessageBoxButtons.OK, MessageBoxIcon.Information);


            foreach (var hdr in HDRARendir)
            {
                
                    hdr.Rendida = true;
                
            }

            MessageBox.Show("Cambios guardados correctamente.");

            DNIText.Text = "";
            HDRAsignadasListView.Items.Clear();
            GuiasNoEntregadasListView.Items.Clear();
            GuiasRetiradasListView.Items.Clear();
            NuevasHDREntregarListView.Items.Clear();
            NuevasHDRRetirarListViews.Items.Clear();
            NuevasGuiasEntregarListView.Items.Clear();
            NuevasGuiasRetirarListView.Items.Clear();

        }
        */
       
           


        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se han guardado los cambios.");
            this.Close();
        }
    }
}


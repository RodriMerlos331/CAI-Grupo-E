   using Grupo_E.F04_GestionarOmnibus;
using Grupo_E.GestionarFletero;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Grupo_E.GestionarOmnibus
{
    public partial class F04_GestionarOmnibusForm : Form
    {
        private readonly F04_GestionarOmnibusModel modelo = new F04_GestionarOmnibusModel();


        private void btnBuscar_Click(object sender, EventArgs e)
        {


            string patente = txtPatente.Text;
            //txtPatente.Enabled = false;

            // 1. Validar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(patente))
            {
                MessageBox.Show("Por favor ingrese un número de patente");
                return;
            }

            //2. Validar que el omnibus exista:

            /*
            if( modelo.BuscarOmnibus(patente) == null)
            {
                MessageBox.Show("El ómnibus con la patente ingresada no existe.");
                return;
            }
            */
            if (!modelo.ValidarOmnibus(patente))
            {
                txtPatente.Clear();
                return;
            }

            //3. Validar hay encomiendas a bajar y a subir:

            lstBajar.Items.Clear();
            lstSubir.Items.Clear(); 

            var encomiendasARecepcionar = modelo.EncomiendasABajar(patente);
            var encomiendasAEntregar = modelo.EncomiendasASubir(patente);

            if (encomiendasARecepcionar.Any())
            {
                //lstBajar.Items.Clear();
                foreach (var guia in encomiendasARecepcionar)
                {
                    ListViewItem listItem = new ListViewItem(guia.IdHdr);
                    listItem.SubItems.Add(guia.Tracking);
                    listItem.SubItems.Add(guia.TipoDeBulto);
                    lstBajar.Items.Add(listItem);
                }
            }
            


            if (encomiendasAEntregar.Any())
            {
                //lstSubir.Items.Clear();
                foreach (var guiaEntrega in encomiendasAEntregar)
                {
                    ListViewItem listItem = new ListViewItem(guiaEntrega.IdHdr);
                    listItem.SubItems.Add(guiaEntrega.Tracking);
                    listItem.SubItems.Add(guiaEntrega.TipoDeBulto);
                    lstSubir.Items.Add(listItem);
                }
            }
            

            if (!encomiendasAEntregar.Any() && !encomiendasARecepcionar.Any())
            {
                MessageBox.Show("No hay encomiendas para subir, ni para bajar para la pantente: " + patente);
            }

            ActualizarContadores();
        }

    

        private void ActualizarContadores() 
        {
            int recepcionCount = 0;
            int despachoCount = 0;

            if (lstBajar != null) recepcionCount = lstBajar.Items.Count;
            if (lstSubir != null) despachoCount = lstSubir.Items.Count;

            lblCantidadRecepcion.Text = $"Encomiendas: {recepcionCount}";
            lblCantidadDespacho.Text = $"Encomiendas: {despachoCount}";
        }

        private void btnLimpiar_Click(object sender, EventArgs e) //Limpiar el textbox de patente
        {
            LimpiarPantalla();

        }

        public void LimpiarPantalla()
        {
            txtPatente.Clear();

            lstBajar.Items.Clear();
            lstSubir.Items.Clear();

            lblCantidadRecepcion.Text = "Encomiendas: 0";
            lblCantidadDespacho.Text = "Encomiendas: 0";
        }

        private void btnCancelar_Click(object sender, EventArgs e) 
        {
            var msg = "¿Está seguro de que desea salir? Los cambios no se guardarán.";
            var title = "Confirmar salida";
            var result = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                this.Close(); 
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if(lstBajar.Items.Count == 0 && lstSubir.Items.Count == 0)
            {
                MessageBox.Show("No hay cambios para guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool todoOk = modelo.AceptarGestionOmnibus();

            if (!todoOk)
            {
                return; 
            }

            
            MessageBox.Show("Rendición registrada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarPantalla();
        }


        public F04_GestionarOmnibusForm()
        {
            InitializeComponent();

        }


        
    }
}

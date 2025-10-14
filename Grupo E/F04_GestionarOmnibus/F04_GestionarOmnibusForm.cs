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
            txtPatente.Enabled = false;
            // Validar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(patente))
            {
                MessageBox.Show("Por favor ingrese un número de patente");
                return;
            }

            // Buscar encomiendas a recepcionar
            var encomiendasARecepcionar = modelo.EncomiendasARecepcionar(patente);
            if (encomiendasARecepcionar != null)
            {
                lstRecepcion.Items.Clear();
                foreach (var guia in encomiendasARecepcionar)
                {
                    ListViewItem listItem = new ListViewItem(guia.IdHdr);
                    listItem.SubItems.Add(guia.Tracking);
                    listItem.SubItems.Add(guia.TipoDeBulto);
                    lstRecepcion.Items.Add(listItem);
                }
            }

            // Buscar encomiendas a entregar
            var encomiendasAEntregar = modelo.ObtenerGuiasEntrega(patente);
            if (encomiendasAEntregar != null)
            {
                lstDespacho.Items.Clear();
                foreach (var guiaEntrega in encomiendasAEntregar)
                {
                    ListViewItem listItem = new ListViewItem(guiaEntrega.IdHdr);
                    listItem.SubItems.Add(guiaEntrega.Tracking);
                    listItem.SubItems.Add(guiaEntrega.TipoDeBulto);
                    lstDespacho.Items.Add(listItem);
                }
            }

            ActualizarContadores();
        }

    

        private void ActualizarContadores() //contadores de la cantidad de encomiendas
        {
            int recepcionCount = 0;
            int despachoCount = 0;

            if (lstRecepcion != null) recepcionCount = lstRecepcion.Items.Count;
            if (lstDespacho != null) despachoCount = lstDespacho.Items.Count;

            // Actualizo labels (ajustá los nombres si son distintos)
            lblCantidadRecepcion.Text = $"Encomiendas: {recepcionCount}";
            lblCantidadDespacho.Text = $"Encomiendas: {despachoCount}";
        }

        private void btnLimpiar_Click(object sender, EventArgs e) //Limpiar el textbox de patente
        {
            txtPatente.Enabled = true;  

            // 1) Limpiar el textbox de patente
            if (txtPatente != null)
            {
                txtPatente.Clear();
                txtPatente.Focus();
            }

            // 2) Limpiar los list view
            try
            {
                if (lstRecepcion != null)
                    lstRecepcion.Items.Clear();

                if (lstDespacho != null)
                    lstDespacho.Items.Clear();
            }
            catch { /* ignoro si no existen */ }

            
            try
            {
                if (lstRecepcion != null)
                    lstRecepcion.Items.Clear();

                if (lstDespacho != null)
                    lstDespacho.Items.Clear();
            }
            catch { /* ignoro si no existen */ }

            // 4) Resetear labels informativos (ajustá nombres si los tenés distintos)

        }

        private void btnCancelar_Click(object sender, EventArgs e) 
        {
            var msg = "¿Está seguro de que desea salir? Los cambios no se guardarán.";
            var title = "Confirmar salida";
            var result = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                this.Close(); // cierra el form
            }
            // si el usuario responde No, no hace nada y vuelve a la pantalla
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //consultar con andres como hacer para que esa patente no vuelva a aparecer.

           
            // Mensaje de confirmación
            MessageBox.Show("Rendición registrada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar textbox y ListViews
            if (txtPatente != null)
            {
                txtPatente.Clear();
                txtPatente.Focus();
            }
            try
            {
                if (lstRecepcion != null) lstRecepcion.Items.Clear();
                if (lstDespacho != null) lstDespacho.Items.Clear();
            }
            catch {}

            // 5) Resetear labels si corresponde
        }


        public F04_GestionarOmnibusForm()
        {
            InitializeComponent();

        }


    }
}

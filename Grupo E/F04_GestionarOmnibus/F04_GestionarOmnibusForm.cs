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
                    lstRecepcion.Clear();

                if (lstDespacho != null)
                    lstDespacho.Clear();
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
            string patente = txtPatente.Text;

            // 1) Mover encomiendas de recepcion a la lista de recepcionadas
            var encomiendasRecepcion = modelo.EncomiendasARecepcionar(patente);
            if (encomiendasRecepcion != null && lstRecepcion != null)
            {
                var aMover = new List<EncomiendasARecepcionar>();
                foreach (ListViewItem item in lstRecepcion.Items)
                {
                    var encomienda = encomiendasRecepcion
                        .FirstOrDefault(x => x.IdHdr == item.Text && x.Tracking == item.SubItems[1].Text);
                    if (encomienda != null)
                    {
                        modelo.EncomiendasRecepcionadasEnCDOrigen.Add(encomienda);
                        aMover.Add(encomienda);
                    }
                }
                // Elimina las encomiendas movidas para que no vuelvan a aparecer
                foreach (var enc in aMover)
                    encomiendasRecepcion.Remove(enc);
            }

            // 2) Mover encomiendas de despacho a la lista de en tránsito
            var encomiendasDespacho = modelo.ObtenerGuiasEntrega(patente);
            if (encomiendasDespacho != null && lstDespacho != null)
            {
                var aMover = new List<EncomiendasAEntregar>();
                foreach (ListViewItem item in lstDespacho.Items)
                {
                    var encomienda = encomiendasDespacho
                        .FirstOrDefault(x => x.IdHdr == item.Text && x.Tracking == item.SubItems[1].Text);
                    if (encomienda != null)
                    {
                        modelo.EncomiendasEnTransito.Add(encomienda);
                        aMover.Add(encomienda);
                    }
                }
                // Elimina las encomiendas movidas para que no vuelvan a aparecer
                foreach (var enc in aMover)
                    encomiendasDespacho.Remove(enc);
            }

            // 3) Mensaje de confirmación
            MessageBox.Show("Rendición registrada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 4) Limpiar textbox y ListViews
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

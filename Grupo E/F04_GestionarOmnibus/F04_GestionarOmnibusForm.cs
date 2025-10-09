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

        public F04_GestionarOmnibusForm()
        {
            InitializeComponent();
            ConfigurarGrids();            
        }

        private void ConfigurarGrids()
        {
            // Recepción

            lstRecepcion.Columns.Clear();
            lstRecepcion.Columns.Add("IdHDR", "ID HDR");
            lstRecepcion.Columns.Add("NumeroGuia", "Número de Tracking");
            lstRecepcion.Columns.Add("TipoBulto", "Tipo de Bulto");

            // Despacho

            lstDespacho.Columns.Clear();
            lstDespacho.Columns.Add("IdHDR", "ID HDR");
            lstDespacho.Columns.Add("NumeroGuia", "Número de Tracking");
            lstDespacho.Columns.Add("TipoBulto", "Tipo de Bulto");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string patente = txtPatente.Text?.Trim();
            if (string.IsNullOrEmpty(patente))
            {
                MessageBox.Show("Ingresá la patente.", "Patente requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Verificar si la patente existe en los datos
            bool existe = modelo.Datos.Any(d => string.Equals(d.Patente, patente, StringComparison.OrdinalIgnoreCase));

            if (!existe)
            {
                MessageBox.Show("Esa patente no existe dentro del sistema.", "Patente no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // aca creo la logica de lo que tiene que mostrarme en el list view
            var recepcion = modelo.Datos.Where(d => string.Equals(d.Patente, patente, StringComparison.OrdinalIgnoreCase)
                                           && d.Ubicacion == "Recepcion").ToList();

            var despacho = modelo.Datos.Where(d => string.Equals(d.Patente, patente, StringComparison.OrdinalIgnoreCase)
                                          && d.Ubicacion == "Despacho").ToList();

            // y aca llamamos a esos metodos para que funcionen cuando la patente que se ingresa existe:
            CargarGridSimple(lstRecepcion, recepcion);
            CargarGridSimple(lstDespacho, despacho);
            ActualizarContadores(); // 



        }

        private void CargarGridSimple(ListView listView, List<ItemHDR> lista)
        {
            // Asegurarnos de que el ListView está en modo detalles y tiene columnas
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;

            if (listView.Columns.Count == 0)
            {
                listView.Columns.Add("ID HDR", 80);
                listView.Columns.Add("Número de Tracking", 140);
                listView.Columns.Add("Tipo de Bulto", 100);
            }

            listView.Items.Clear();

            foreach (var i in lista)
            {
                var row = new ListViewItem(i.IdHDR.ToString());
                row.SubItems.Add(i.NumeroGuia);
                row.SubItems.Add(i.TipoBulto);
                listView.Items.Add(row);
            }
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

        private void btnAceptar_Click(object sender, EventArgs e) //btn de aceptar
        {
            // 1) Mensaje de confirmación
            MessageBox.Show("Rendición registrada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 2) Limpiar textbox de patente y poner foco
            if (txtPatente != null)
            {
                txtPatente.Clear();
                txtPatente.Focus();
            }

            //  Limpiar ListView 

            try
            {
                if (lstRecepcion != null) lstRecepcion.Items.Clear();
                if (lstDespacho != null) lstDespacho.Items.Clear();
            }
            catch {}

            //  Resetear labels

        }
    }
}

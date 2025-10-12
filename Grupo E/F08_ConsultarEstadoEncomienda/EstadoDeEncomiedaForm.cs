using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.ConsultarEstadoEncomienda
{
    public partial class EstadoDeEncomiendaForm : Form
    {
        private readonly EstadoDeEncomiendaModel modelo = new EstadoDeEncomiendaModel();

        public EstadoDeEncomiendaForm()
        {
            InitializeComponent();
            ConfigurarListaHistorial();
        }

        private void ConfigurarListaHistorial()
        {
            // Ajustá si tu control no es ListView
            HistoriaEncomiendaList.View = View.Details;
            HistoriaEncomiendaList.FullRowSelect = true;
            HistoriaEncomiendaList.GridLines = true;
            HistoriaEncomiendaList.Columns.Clear();

            HistoriaEncomiendaList.Columns.Add("Estado", 160);
            HistoriaEncomiendaList.Columns.Add("Fecha / Hora mov. previo", 180);
            HistoriaEncomiendaList.Columns.Add("Ubicación anterior", 180);
            HistoriaEncomiendaList.Columns.Add("Transportista asignado", 180);
            HistoriaEncomiendaList.Columns.Add("ID Hoja de ruta", 120);
            HistoriaEncomiendaList.Columns.Add("Origen", 100);
            HistoriaEncomiendaList.Columns.Add("Destino", 100);
            HistoriaEncomiendaList.Columns.Add("Tipo de bulto", 120);
        }

        private void btnEstadoBusqueda_Click(object sender, EventArgs e)
        {
            // 6. Validación: campo no vacío
            string texto = txtIdTracking.Text.Trim();
            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Debes ingresar un ID valido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdTracking.Focus();
                return;
            }

            // 2. Validación: numérico
            int trackingId;
            if (!int.TryParse(texto, out trackingId))
            {
                MessageBox.Show("El valor ingresado no es válido, sólo se permiten valores numéricos",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdTracking.Focus();
                txtIdTracking.SelectAll();
                return;
            }

            //pedirle los datos al modelo
            
            //agarrar todo lo que viene del historial y pasarlo a la grilla
           
        }

        private void LimpiarPantalla()
        {
            lblEstadoActual.Text = "—";
            lblFechaUltimo.Text = "—";
            lblUbicacionActual.Text = "—";
            HistoriaEncomiendaList.Items.Clear();
        }

        private void CargarHistorial(EstadoDeEncomienda model)
        {
            HistoriaEncomiendaList.Items.Clear();

            // Mostramos del más antiguo al más reciente (o invertí si preferís)
            foreach (var m in model.Historial)
            {
                var item = new ListViewItem(MapEstado(m.Estado));
                item.SubItems.Add(m.FechaHora.ToString("dd/MM/yyyy HH:mm"));
                item.SubItems.Add(m.UbicacionAnterior ?? "");
                item.SubItems.Add(m.TransportistaAsignado ?? "");
                item.SubItems.Add(m.IdHojaRuta ?? "");
                item.SubItems.Add(m.Origen ?? "");
                item.SubItems.Add(m.Destino ?? "");
                item.SubItems.Add(m.TipoDeBulto ?? "");
                HistoriaEncomiendaList.Items.Add(item);
            }
        }

        private string MapEstado(EstadoEnvio estado)
        {
            // Mapea exactamente a los textos del enunciado
            switch (estado)
            {
                case EstadoEnvio.EsperandoRetiro: return "Esperando a ser retirado";
                case EstadoEnvio.Admitido: return "Admitido";
                case EstadoEnvio.EnCaminoACD: return "En camino a centro de distribución";
                case EstadoEnvio.EnCentroDistribucion: return "En centro de distribución";
                case EstadoEnvio.EnCaminoAAgenciaDestino: return "En camino a agencia destino";
                case EstadoEnvio.EnCaminoADestino: return "En camino a destino";
                case EstadoEnvio.Entregado: return "Entregado";
                case EstadoEnvio.Cancelado: return "Cancelado";
                default: return estado.ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        }
    }



}

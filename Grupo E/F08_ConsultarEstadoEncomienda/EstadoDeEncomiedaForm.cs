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
        }

        private void btnEstadoBusqueda_Click(object sender, EventArgs e)
        {
            string texto = txtIdTracking.Text.Trim();

            // Validación: campo no vacío
            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Debes ingresar un ID valido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdTracking.Focus();
                return;
            }


            var trackingId = txtIdTracking.Text;

            Historial.Items.Clear();


            if (modelo.data.ContainsKey(trackingId))
            {
                EstadoDeEncomienda encomienda = modelo.data[trackingId];

                lblEstadoActual.Text = EstadoATexto(encomienda.EstadoActual);
                lblFechaUltimo.Text = encomienda.FechaHoraUltimoCambio.ToString();
                lblUbicacionActual.Text = encomienda.LocalidadActual;
                lblOrigen.Text = encomienda.Origen;
                lblDestino.Text = encomienda.Destino;
                lblBulto.Text = encomienda.TipoDeBulto;

                foreach(Movimiento mov in encomienda.Historial)
                {
                    ListViewItem fila = new ListViewItem(EstadoATexto(mov.Estado));

                    fila.SubItems.Add(mov.FechaHora.ToString("dd/MM/yyyy HH:mm"));
                    fila.SubItems.Add(mov.UbicacionAnterior);
                    fila.SubItems.Add(mov.TransportistaAsignado.ToString());
                    fila.SubItems.Add(mov.IdHojaRuta);

                    Historial.Items.Add(fila);

                }
    
            }
            else
            {
                MessageBox.Show("No se encontró una encomienda con ese número de guía.", "Aviso");
            }

        }


        private string EstadoATexto(EstadoEnvio estado)
        {
            switch (estado)
            {
                case EstadoEnvio.ImpuestaPendienteRetiroDomicilio: return "Impuesta y pendiente de retiro en domicilio";
                case EstadoEnvio.ImpuestaPendienteRetiroAgencia: return "Impuesta y pendiente de retiro en agencia";
                case EstadoEnvio.RuteadaRetiroDomicilio: return "Ruteada para retiro a domicilio";
                case EstadoEnvio.RuteadaRetiroAgencia: return "Ruteada para retiro a agencia";
                case EstadoEnvio.EnTransitoUMOrigen: return "En transito a a CD de origen";
                case EstadoEnvio.Admitida: return "Admitida en el centro de distribucion";
                case EstadoEnvio.EnTransitoMD: return "En Transito";
                case EstadoEnvio.PendienteRetiroCD: return "Pendiente de retiro en CD de destino";
                case EstadoEnvio.PendienteEntregaDomicilio: return "Pendiente a entregar a domicilio";
                case EstadoEnvio.PendienteEntregaAgencia: return "Ruteada para entrega a agencia";
                case EstadoEnvio.PendienteRetiroAgencia: return "Pendiente de retiro en agencia por el destinatario";
                case EstadoEnvio.EnTransitoUMDestino: return "En camino a domicilio de destino";
                case EstadoEnvio.Entregada: return "Entregada";
                case EstadoEnvio.Cancelada: return "Cancelado";
                case EstadoEnvio.RetiradaAgenciaFletero: return "Retirada de agencia por fletero";
                default: return estado.ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grbEstado_Enter(object sender, EventArgs e)
        {

        }
    }



}

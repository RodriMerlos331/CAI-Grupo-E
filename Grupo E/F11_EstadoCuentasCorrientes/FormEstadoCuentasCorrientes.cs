using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.EstadoCuentasCorrientes
{
    public partial class FormEstadoCuentasCorrientes : Form
    {
        private readonly EstadoCuentasCorrientesModel _modelo = new EstadoCuentasCorrientesModel();

        public FormEstadoCuentasCorrientes()
        {
            InitializeComponent();
        }

        private void FormEstadoCuentasCorrientes_Load(object sender, EventArgs e)
        {
            ConfigurarFormulario();

            var hoy = DateTime.Today;
            dtpFechaHasta.Value = hoy;
            dtpFechaDesde.Value = hoy;

            dtpFechaDesde.MaxDate = hoy;
            dtpFechaHasta.MaxDate = hoy;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            EjecutarBusqueda();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigurarFormulario()
        {
            lvMovimientos.View = View.Details;
            lvMovimientos.GridLines = true;
            lvMovimientos.FullRowSelect = true;

            lvMovimientos.Columns[0].Width = 115;
            lvMovimientos.Columns[1].Width = 115;
            lvMovimientos.Columns[2].Width = 115;
            lvMovimientos.Columns[3].Width = 115;
            lvMovimientos.Columns[4].Width = 115;
            lvMovimientos.Columns[5].Width = 115;

            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Todas");
            cmbEstado.Items.Add("Pendiente");
            cmbEstado.Items.Add("Pagada");
            cmbEstado.SelectedIndex = 0;
        }

        private void EjecutarBusqueda()
        {
            lvMovimientos.Items.Clear();
            txtSaldoDeudor.Text = string.Empty;
            txtSaldoAcreedor.Text = string.Empty;

            if (string.IsNullOrWhiteSpace(txtCuitCliente.Text))
            {
                MessageBox.Show("El CUIT del cliente es requerido para la búsqueda.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCuitCliente.Focus();
                return;
            }

            if (!ValidarFechas())
            {
                return;
            }

            if (!ValidarFormatoCuit(txtCuitCliente.Text))
            {
                MessageBox.Show("El formato del CUIT es incorrecto.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCuitCliente.Focus();
                return;
            }

            string cuit = txtCuitCliente.Text.Trim();
            DateTime fechaDesde = dtpFechaDesde.Value.Date;
            DateTime fechaHasta = dtpFechaHasta.Value.Date;
            string estadoFiltro = cmbEstado.SelectedItem?.ToString() ?? "Todas";

            try
            {
                decimal saldoDeudorModelo;
                decimal saldoAcreedorModelo;

                var movimientos = _modelo.ObtenerMovimientos(
                    cuit, fechaDesde, fechaHasta, estadoFiltro,
                    out saldoDeudorModelo, out saldoAcreedorModelo);

                if (movimientos.Count == 0)
                {
                    MessageBox.Show(
                        $"No se encontraron movimientos para el cliente con CUIT: {cuit}.",
                        "Información de Búsqueda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                PresentarResultados(movimientos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PresentarResultados(List<MovimientoCC> movimientos)
        {
            decimal saldoActual = 0M;
            decimal totalDebe = 0M;
            decimal totalHaber = 0M;

            foreach (var m in movimientos)
            {
                saldoActual = saldoActual + m.Debe - m.Haber;

                totalDebe += m.Debe;
                totalHaber += m.Haber;

                ListViewItem item = new ListViewItem(m.FechaEmision.ToShortDateString());
                item.SubItems.Add(m.NroFactura);
                item.SubItems.Add(m.Estado);
                item.SubItems.Add(m.Debe.ToString("N2"));
                item.SubItems.Add(m.Haber.ToString("N2"));
                item.SubItems.Add(saldoActual.ToString("N2"));

                lvMovimientos.Items.Add(item);
            }

            ActualizarSaldosTotales(totalDebe, totalHaber);
        }

        private void ActualizarSaldosTotales(decimal totalDeudor, decimal totalAcreedor)
        {
            txtSaldoDeudor.Text = totalDeudor.ToString("C2");
            txtSaldoAcreedor.Text = totalAcreedor.ToString("C2");
        }

        private void LimpiarFiltros()
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
            txtCuitCliente.Text = string.Empty;
            cmbEstado.SelectedIndex = 0;

            lvMovimientos.Items.Clear();
            txtSaldoDeudor.Text = string.Empty;
            txtSaldoAcreedor.Text = string.Empty;
        }

        private bool ValidarFechas()
        {
            if (dtpFechaDesde.Value.Date > dtpFechaHasta.Value.Date)
            {
                MessageBox.Show("La 'Fecha desde' no puede ser posterior a la 'Fecha hasta'.", "Error de Rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaDesde.Focus();
                return false;
            }
            return true;
        }

        private bool ValidarFormatoCuit(string cuit)
        {
            if (cuit.Length != 13 || !cuit.Contains("-"))
            {
                return false;
            }
            return true;
        }

        private void lvMovimientos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

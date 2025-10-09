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
        // 1. REFERENCIA AL MODELO: El formulario tiene una referencia a la clase que maneja la lógica (Modelo)
        private readonly EstadoCuentasCorrientesModel _modelo = new EstadoCuentasCorrientesModel();

        public FormEstadoCuentasCorrientes()
        {
            InitializeComponent();
        }

        // ----------------------------------------------------------------------
        // EVENTOS DE LA PANTALLA
        // ----------------------------------------------------------------------

        private void FormEstadoCuentasCorrientes_Load(object sender, EventArgs e)
        {
            // Inicialización de controles al cargar la pantalla
            ConfigurarFormulario();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Ejecuta el flujo principal de búsqueda
            EjecutarBusqueda();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            // Lógica de limpieza de campos
            LimpiarFiltros();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra el formulario
            this.Close();
        }

        // ----------------------------------------------------------------------
        // FUNCIONES AUXILIARES Y DE LÓGICA DE FORMULARIO
        // ----------------------------------------------------------------------

        private void ConfigurarFormulario()
        {
            // Configuración del ListView (Asumimos: lvMovimientos)
            lvMovimientos.View = View.Details;
            lvMovimientos.GridLines = true;
            lvMovimientos.FullRowSelect = true;

            // Ajustar anchos de columnas (aunque ya están en el Designer, es buena práctica)
            lvMovimientos.Columns[0].Width = 100; // Fecha de emisión
            lvMovimientos.Columns[1].Width = 120; // N° de Factura
            lvMovimientos.Columns[2].Width = 80;  // Estado
            lvMovimientos.Columns[3].Width = 90;  // Debe
            lvMovimientos.Columns[4].Width = 90;  // Haber
            lvMovimientos.Columns[5].Width = 100; // Saldo

            // Cargar los valores del ComboBox (Asumimos: cmbEstado)
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Todas");
            cmbEstado.Items.Add("Pendiente");
            cmbEstado.Items.Add("Pagada");
            cmbEstado.Items.Add("Vencida");
            cmbEstado.SelectedIndex = 0;
        }

        private void EjecutarBusqueda()
        {
            lvMovimientos.Items.Clear();
            txtSaldoDeudor.Text = string.Empty;
            txtSaldoAcreedor.Text = string.Empty;

            // -----------------------------------------------------------------
            // VALIDACIÓN 1: CUIT REQUERIDO (Nivel 1/2)
            // -----------------------------------------------------------------
            if (string.IsNullOrWhiteSpace(txtCuitCliente.Text))
            {
                MessageBox.Show("El CUIT del cliente es requerido para la búsqueda.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCuitCliente.Focus();
                return;
            }

            // 1. Validación de Rango de Fechas (2do Nivel: Lógica de la fecha)
            if (!ValidarFechas())
            {
                return;
            }

            // 2. Validación de Tipo CUIT (1er Nivel: Formato y Tipo de dato)
            if (!ValidarFormatoCuit(txtCuitCliente.Text))
            {
                MessageBox.Show("El formato del CUIT es incorrecto (debe ser numérico de 11 dígitos).", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCuitCliente.Focus();
                return;
            }

            // RECOLECCIÓN DE PARÁMETROS
            string cuit = txtCuitCliente.Text.Trim();
            DateTime fechaDesde = dtpFechaDesde.Value.Date;
            DateTime fechaHasta = dtpFechaHasta.Value.Date;
            string estadoFiltro = cmbEstado.SelectedItem?.ToString() ?? "Todas";

            // LLAMADA AL MODELO (Delega la validación de negocio y la búsqueda)
            decimal saldoAcumuladoFinal;
            var movimientos = _modelo.ObtenerMovimientos(cuit, fechaDesde, fechaHasta, estadoFiltro, out saldoAcumuladoFinal);

            // -----------------------------------------------------------------
            // VALIDACIÓN 2: NO HAY DATOS ENCONTRADOS (Nivel 4 / Negocio)
            // -----------------------------------------------------------------
            if (movimientos.Count == 0 && !string.IsNullOrEmpty(cuit))
            {
                MessageBox.Show($"No se encontraron movimientos para el cliente con CUIT: {cuit} en el rango de fechas y estado especificados.", "Información de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // No hay nada que mostrar, salimos.
            }

            // PRESENTACIÓN DE RESULTADOS
            PresentarResultados(movimientos, saldoAcumuladoFinal);
        }

        private void PresentarResultados(List<MovimientoCC> movimientos, decimal saldoFinalModelo)
        {
            decimal saldoActual = 0M;

            foreach (var m in movimientos)
            {
                // La grilla calcula el saldo acumulado para su propia presentación visual
                saldoActual = saldoActual + m.Debe - m.Haber;

                ListViewItem item = new ListViewItem(m.FechaEmision.ToShortDateString());
                item.SubItems.Add(m.NroFactura);
                item.SubItems.Add(m.Estado);
                item.SubItems.Add(m.Debe.ToString("N2"));
                item.SubItems.Add(m.Haber.ToString("N2"));
                item.SubItems.Add(saldoActual.ToString("N2")); // Saldo de la fila

                lvMovimientos.Items.Add(item);
            }

            // Mostrar los saldos finales, usando el resultado del Modelo
            ActualizarSaldosTotales(saldoFinalModelo);
        }

        private void ActualizarSaldosTotales(decimal saldoFinal)
        {
            decimal totalDeudor = 0M;
            decimal totalAcreedor = 0M;

            if (saldoFinal > 0)
            {
                totalDeudor = saldoFinal;
            }
            else if (saldoFinal < 0)
            {
                totalAcreedor = Math.Abs(saldoFinal);
            }

            txtSaldoDeudor.Text = totalDeudor.ToString("C2");
            txtSaldoAcreedor.Text = totalAcreedor.ToString("C2");
        }

        private void LimpiarFiltros()
        {
            // Restablecer campos de filtro
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
            txtCuitCliente.Text = string.Empty;
            cmbEstado.SelectedIndex = 0;

            // Limpiar la grilla y los saldos
            lvMovimientos.Items.Clear();
            txtSaldoDeudor.Text = string.Empty;
            txtSaldoAcreedor.Text = string.Empty;
        }

        // -------------------------------------------------------------
        // VALIDACIONES DE FORMULARIO (1er y 2do Nivel)
        // -------------------------------------------------------------

        private bool ValidarFechas()
        {
            // Validación de Rango (2do Nivel)
            if (dtpFechaDesde.Value.Date > dtpFechaHasta.Value.Date)
            {
                MessageBox.Show("La 'Fecha desde' no puede ser posterior a la 'Fecha hasta'.", "Error de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaDesde.Focus();
                return false;
            }
            return true;
        }

        private bool ValidarFormatoCuit(string cuit)
        {
            // Validación de Tipo (1er Nivel)
            string cuitLimpio = cuit.Replace("-", "").Replace(" ", "");
            return (cuitLimpio.Length == 11 && long.TryParse(cuitLimpio, out _));
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grupo_E.F12_CostoVsVentas;

namespace FormResultadoCostoVsVentas
{
    public partial class FormResultadoCostoVsVentas : Form
    {
        private readonly CostosVsVentasModel _modelo = new CostosVsVentasModel();

        public FormResultadoCostoVsVentas()
        {
            InitializeComponent();
        }

        private void FormResultadoCostoVsVentas_Load(object sender, EventArgs e)
        {
            // Limito las fechas al día de hoy y dejo todo inicializado en "hoy"
            dtpFechaInicial.MaxDate = DateTime.Today;
            dtpFechaFinal.MaxDate = DateTime.Today;

            dtpFechaInicial.Value = DateTime.Today;
            dtpFechaFinal.Value = DateTime.Today;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string cuit = txtCuit.Text.Trim();

            // --- Validaciones de front ---
            if (string.IsNullOrWhiteSpace(cuit))
            {
                MessageBox.Show(
                    "Debe ingresar un CUIT.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCuit.Focus();
                return;
            }

            if (!ValidarFormatoCuit(cuit))
            {
                MessageBox.Show(
                    "Debe ingresar un CUIT válido con formato XX-XXXXXXXX-X.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCuit.Focus();
                return;
            }

            DateTime fechaDesde = dtpFechaInicial.Value.Date;
            DateTime fechaHasta = dtpFechaFinal.Value.Date;

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show(
                    "La fecha inicial no puede ser posterior a la fecha final.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dtpFechaInicial.Focus();
                return;
            }

            // --- Llamada al modelo ---
            try
            {
                var query = new Datos
                {
                    Cuit = cuit,
                    FechaInicial = fechaDesde,
                    FechaFinal = fechaHasta
                };

                ResultadoCostosVentas resultado = _modelo.Consultar(query);

                // Muestro en la pantalla
                ActualizarCamposResultado(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error en la consulta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                // Si hubo error, limpio el resultado
                ActualizarCamposResultado(new ResultadoCostosVentas());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCuit.Clear();
            dtpFechaInicial.Value = DateTime.Today;
            dtpFechaFinal.Value = DateTime.Today;

            ActualizarCamposResultado(new ResultadoCostosVentas());
            txtCuit.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Validación simple de CUIT (formato XX-XXXXXXXX-X, 13 caracteres y 2 guiones)
        private bool ValidarFormatoCuit(string cuit)
        {
            if (string.IsNullOrWhiteSpace(cuit))
                return false;

            if (cuit.Length != 13)
                return false;

            int guiones = 0;
            foreach (char c in cuit)
            {
                if (c == '-')
                    guiones++;
            }

            return guiones == 2;
        }

        // Pinta los resultados en los TextBox de la sección "Resultado"
        private void ActualizarCamposResultado(ResultadoCostosVentas resultado)
        {
            txtNombreEmpresa.Text = resultado.NombreEmpresa;

            txtTotalCostos.Text = resultado.TotalCostos != 0m
                ? resultado.TotalCostos.ToString("C2")
                : string.Empty;

            txtTotalVentas.Text = resultado.TotalVentas != 0m
                ? resultado.TotalVentas.ToString("C2")
                : string.Empty;
        }

        // Handler generado por el diseñador; lo dejamos vacío
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
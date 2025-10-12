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
        private readonly CostosVsVentasModel modelo = new CostosVsVentasModel();

        public FormResultadoCostoVsVentas()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ActualizarCamposResultado(new ResultadoCostosVentas());

            // Errores de Formato/Rango (Nivel 1 y 2) -> ADVERTENCIA

            if (string.IsNullOrWhiteSpace(txtCuit.Text))
            {
                MessageBox.Show("Debe ingresar un CUIT válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarFormatoCuit(txtCuit.Text))
            {
                MessageBox.Show("Debe ingresar un CUIT válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpFechaInicial.Value.Date > dtpFechaFinal.Value.Date)
            {
                MessageBox.Show("Debe ingresar un rango de fechas válidas. La fecha inicial no puede ser posterior a la final.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var query = new Datos
            {
                Cuit = txtCuit.Text,
                FechaInicial = dtpFechaInicial.Value.Date,
                FechaFinal = dtpFechaFinal.Value.Date
            };

            try
            {
                var resultado = modelo.Consultar(query);
                ActualizarCamposResultado(resultado);
            }
            catch (Exception ex)
            {
                // Errores de Datos/Negocio (Nivel 4) -> ERROR CRÍTICO
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarFormatoCuit(string cuit)
        {
            if (cuit.Length != 13 || !cuit.Contains("-"))
            {
                return false;
            }
            return true;
        }

        private void ActualizarCamposResultado(ResultadoCostosVentas resultado)
        {
            txtNombreEmpresa.Text = resultado.NombreEmpresa;
            txtTotalCostos.Text = (resultado.TotalCostos != 0) ? resultado.TotalCostos.ToString("C2") : string.Empty;
            txtTotalVentas.Text = (resultado.TotalVentas != 0) ? resultado.TotalVentas.ToString("C2") : string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCuit.Clear();
            dtpFechaInicial.Value = DateTime.Today;
            dtpFechaFinal.Value = DateTime.Today;
            ActualizarCamposResultado(new ResultadoCostosVentas());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormResultadoCostoVsVentas_Load(object sender, EventArgs e)
        {
            dtpFechaInicial.MaxDate = DateTime.Today;
            dtpFechaFinal.MaxDate = DateTime.Today;

            if (dtpFechaFinal.Value.Date > DateTime.Today)
            {
                dtpFechaFinal.Value = DateTime.Today;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
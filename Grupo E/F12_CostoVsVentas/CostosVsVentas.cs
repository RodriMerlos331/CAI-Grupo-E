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
        public FormResultadoCostoVsVentas()
        {
            InitializeComponent();
        }

        private readonly CostosVsVentasModel modelo = new CostosVsVentasModel();

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ActualizarCamposResultado(new ResultadoCostosVentas());

            if (string.IsNullOrWhiteSpace(txtCuit.Text))
            {
                MessageBox.Show("Debe ingresar un CUIT válido.");
                return;
            }

            if (!ValidarFormatoCuit(txtCuit.Text))
            {
                MessageBox.Show("Debe ingresar un CUIT válido.");
                return;
            }

            if (dtpFechaInicial.Value.Date > dtpFechaFinal.Value.Date)
            {
                MessageBox.Show("Debe ingresar un rango de fechas válidas. La fecha inicial no puede ser posterior a la final.");
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
                MessageBox.Show(ex.Message, "Error");
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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }

    internal class Datos
    {
        public string Cuit { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
    }

    internal class ResultadoCostosVentas
    {
        public string NombreEmpresa { get; set; }
        public decimal TotalCostos { get; set; }
        public decimal TotalVentas { get; set; }

        public ResultadoCostosVentas()
        {
            NombreEmpresa = string.Empty;
            TotalCostos = 0m;
            TotalVentas = 0m;
        }
    }

    internal class CostosVsVentasModel
    {
        internal ResultadoCostosVentas Consultar(Datos query)
        {
            (bool existe, string nombre) = BuscarEmpresa(query.Cuit);
            if (!existe)
            {
                throw new Exception("No se encontró ninguna empresa con el CUIT ingresado.");
            }

            (decimal costos, decimal ventas) = ObtenerTotales(query.Cuit, query.FechaInicial, query.FechaFinal);

            if (costos == 0m && ventas == 0m)
            {
                throw new Exception("No se registran registros para la empresa en el año seleccionado.");
            }

            return new ResultadoCostosVentas
            {
                NombreEmpresa = nombre,
                TotalCostos = costos,
                TotalVentas = ventas
            };
        }

        private (bool Existe, string Nombre) BuscarEmpresa(string cuit)
        {
            if (cuit == "20-12345678-0")
            {
                return (true, "Empresa Ejemplo S.A.");
            }
            return (false, string.Empty);
        }

        private (decimal Costos, decimal Ventas) ObtenerTotales(string cuit, DateTime fIni, DateTime fFin)
        {
            if (cuit == "20-12345678-0" && fIni.Year == 2024)
            {
                return (50000.00m, 95000.00m);
            }
            return (0m, 0m);
        }
    }
}
using Grupo_E.F07_RetirarEnCD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.RetirarEnCD
{
    public partial class F07_RetirarEnCDForm : Form
    {
        private readonly RetirarEnCDModel modelo = new RetirarEnCDModel();
        // Variable para almacenar el objeto completo (Tracking + Nombre/Apellido/DNI) esperado después de la búsqueda
        private DatosCliente clienteEsperado = null;

        public F07_RetirarEnCDForm()
        {
            InitializeComponent();
            HabilitarControlesDestinatario(false);
        }

        private void HabilitarControlesDestinatario(bool habilitar)
        {
            NombreText.Enabled = habilitar;
            ApellidoText.Enabled = habilitar;
            DNIText.Enabled = habilitar;
            btnEntregar.Enabled = habilitar;

            if (!habilitar)
            {
                NombreText.Clear();
                ApellidoText.Clear();
                DNIText.Clear();
                clienteEsperado = null; 
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            NumeroTrackingText.Clear();
            HabilitarControlesDestinatario(false);
            NumeroTrackingText.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            HabilitarControlesDestinatario(false);
            if (string.IsNullOrWhiteSpace(NumeroTrackingText.Text))
            {
                MessageBox.Show("Debe ingresar un número de tracking para realizar la búsqueda.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NumeroTrackingText.Focus();
                return;
            }

            int numeroDeTracking;
            if (!int.TryParse(NumeroTrackingText.Text, out numeroDeTracking) || numeroDeTracking <= 0)
            {
                MessageBox.Show("El número de tracking debe ser un número entero válido y positivo.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NumeroTrackingText.Clear();
                NumeroTrackingText.Focus();
                return;
            }

            // Buscar y recuperar los datos
            clienteEsperado = modelo.BuscarEncomiendaPorTracking(numeroDeTracking);

            if (clienteEsperado != null) 
            {
                MessageBox.Show("La encomienda está en la agencia. Por favor, complete los datos del destinatario para la entrega.", "Búsqueda Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HabilitarControlesDestinatario(true);
                NombreText.Focus();
            }
            else
            {
                MessageBox.Show("La encomienda con el número de tracking ingresado NO está disponible para retiro en este Centro de Distribución.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            // 1. Debe haber un cliente esperado
            if (clienteEsperado == null)
            {
                MessageBox.Show("Debe ingresar un número de tracking para realizar la búsqueda.", "Error de Flujo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NumeroTrackingText.Focus();
                return;
            }

            // 2. Validación de campos vacíos para Nombre y Apellido
            if (string.IsNullOrWhiteSpace(NombreText.Text) || string.IsNullOrWhiteSpace(ApellidoText.Text))
            {
                MessageBox.Show("Debe completar todos los datos del destinatario para entregar la encomienda.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (string.IsNullOrWhiteSpace(NombreText.Text)) NombreText.Focus();
                else ApellidoText.Focus();
                return;
            }

            // 3. Validación de DNI: Numérico, positivo y con 8 dígitos
            int dniIngresado;
            if (!int.TryParse(DNIText.Text, out dniIngresado) || dniIngresado <= 0 || DNIText.Text.Length != 8)
            {
                MessageBox.Show("DNI inválido. Debe ser un número entero positivo de exactamente 8 dígitos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DNIText.Focus();
                return;
            }

            // 4.Coincidencia de datos
            if (NombreText.Text.Trim().ToUpper() != clienteEsperado.Nombre.ToUpper() ||
                ApellidoText.Text.Trim().ToUpper() != clienteEsperado.Apellido.ToUpper() ||
                dniIngresado != clienteEsperado.DNI)
            {
                MessageBox.Show("Los datos ingresados NO coinciden con los datos registrados para el destinatario de esta encomienda.", "Error de Coincidencia de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. Confirmación de Entrega (solo si todas las validaciones pasaron)
            var confirmacion = MessageBox.Show(
                $"¿Confirma la entrega de la encomienda {clienteEsperado.NumeroTracking} al destinatario {clienteEsperado.Nombre} {clienteEsperado.Apellido}?",
                "Confirmar Entrega",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                DatosCliente destinatario = new DatosCliente
                {
                    NumeroTracking = clienteEsperado.NumeroTracking,
                    Nombre = NombreText.Text.Trim(),
                    Apellido = ApellidoText.Text.Trim(),
                    DNI = dniIngresado
                };

                modelo.EntregarEncomienda(destinatario);

                MessageBox.Show("Entrega de encomienda registrada y finalizada con éxito.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpiar_Click(sender, e);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "¿Desea cancelar la operación? Los datos ingresados no se guardarán.",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
                this.Close();
        }
    }


}

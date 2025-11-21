using Grupo_E.F02_ImposicionEnAgencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.ImposicionEnAgencia
{
    public partial class F02_ImposicionEnAgencia : Form
    {
        public F02_ImposicionEnAgencia()
        {
            InitializeComponent();
            this.Load += F02_ImposicionEnAgencia_Load;

        }
        
        public F02_ImposicionEnAgenciaModel modelo = new F02_ImposicionEnAgenciaModel();
        

        private void F02_ImposicionEnAgencia_Load(object sender, EventArgs e)
        {
            // Deshabilitar grupos de detalle al iniciar
            CentroDistribucionGrb.Enabled = false;
            DireccionParticularGrb.Enabled = false;
            AgenciaGrb.Enabled = false;
            DatosDestinatarioGrb.Enabled=false;
            TamañoBultoGrb.Enabled = false;

            foreach (string localidad in modelo.Localidad)
                LocalidadCbo.Items.Add(localidad);

            foreach (string tamaño in modelo.TamanoBulto)
                TamanoBultoCbo.Items.Add(tamaño);

            foreach (string cliente in modelo.ClientesLista)
            {
                ListadoClientesCC.Items.Add(cliente);
            }

            // Corrección: enganchar eventos a los RadioButtons (no a los GroupBox)
            DireccionParticularRb.CheckedChanged += DomicilioRb_CheckedChanged;
            AgenciaRb.CheckedChanged += AgenciaRb_CheckedChanged;
            CentroDistribucionRb.CheckedChanged += CentroDistribucionRb_CheckedChanged;

            LocalidadCbo.SelectedIndexChanged += LocalidadCbo_SelectedIndexChanged;

            ListadoClientesCC.DropDownStyle = ComboBoxStyle.DropDown;
            ListadoClientesCC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ListadoClientesCC.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void LocalidadCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AgenciaCbo.Items.Clear();
            TerminalesCbo.Items.Clear();

            AgenciaCbo.SelectedIndex = -1;
            TerminalesCbo.SelectedIndex = -1;
            DatosEntregaDomiclioText.Text = "";
            TerminalesCbo.Text = "";
            AgenciaCbo.Text = "";

            string localidadSeleccionada = LocalidadCbo.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(localidadSeleccionada))
                return;

            var informacionLocalidades = modelo.Localidades[localidadSeleccionada];

            foreach (var agencia in informacionLocalidades.Agencias)
                AgenciaCbo.Items.Add(agencia);

            foreach (var terminal in informacionLocalidades.Terminales)
                TerminalesCbo.Items.Add(terminal);
        }

        private void DomicilioRb_CheckedChanged(object sender, EventArgs e)
        {
            // Limpiar selecciones de opciones que no aplican
            TerminalesCbo.SelectedIndex = -1;
            TerminalesCbo.Text = "";
            AgenciaCbo.SelectedIndex = -1;

            //  Corrección: verificar el RadioButton, no el GroupBox
            if (DireccionParticularRb.Checked)
            {
                DireccionParticularGrb.Enabled = true;
                AgenciaGrb.Enabled = false;
                CentroDistribucionGrb.Enabled = false;
                DatosDestinatarioGrb.Enabled = true;
                TamañoBultoGrb.Enabled = true;
            }
        }

        private void AgenciaRb_CheckedChanged(object sender, EventArgs e)
        {
            TerminalesCbo.SelectedIndex = -1;
            TerminalesCbo.Text = "";
            DatosEntregaDomiclioText.Text = "";

            // Corrección: verificar el RadioButton, no el GroupBox
            if (AgenciaRb.Checked)
            {
                DireccionParticularGrb.Enabled = false;
                AgenciaGrb.Enabled = true;
                CentroDistribucionGrb.Enabled = false;
                DatosDestinatarioGrb.Enabled = true;
                TamañoBultoGrb.Enabled = true;
            }
        }

        private void CentroDistribucionRb_CheckedChanged(object sender, EventArgs e)
        {
            AgenciaCbo.SelectedIndex = -1;
            AgenciaCbo.Text = "";

            if (CentroDistribucionRb.Checked)
            {
                DireccionParticularGrb.Enabled = false;
                AgenciaGrb.Enabled = false;
                CentroDistribucionGrb.Enabled = true;
                DatosDestinatarioGrb.Enabled = true;
                TamañoBultoGrb.Enabled = true;
            }
        }

        // Aceptar
        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (ListadoClientesCC.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un cliente");
                return;
            }

            //  Corrección: validar por RadioButtons (no por GroupBox)
            if (!CentroDistribucionRb.Checked && !DireccionParticularRb.Checked && !AgenciaRb.Checked)
            {
                MessageBox.Show("Debe seleccionar un tipo de entrega.");
                return;
            }

            if (LocalidadCbo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una localidad.");
                return;
            }

            if (TamanoBultoCbo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tamaño de bulto.");
                return;
            }

            if (string.IsNullOrEmpty(NombreDestinatarioTxt.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del destinatario.");
                return;
            }

            if (string.IsNullOrEmpty(ApellidoDestinatarioTxt.Text))
            {
                MessageBox.Show("Debe ingresar el Apellido del destinatario.");
                return;
            }


            if (string.IsNullOrEmpty(DniDestinatarioTxt.Text))
            {
                MessageBox.Show("Debe ingresar el DNI del destinatario.");
                return;
            }

            if (!int.TryParse(DniDestinatarioTxt.Text, out int dni) || dni <= 0)
            {
                MessageBox.Show("El DNI del destinatario debe ser un número válido mayor a cero.");
                return;
            }

            var clienteSeleccionado = ListadoClientesCC.SelectedItem?.ToString();
            var cuit = clienteSeleccionado?.Split(',')[0].Trim();

            if (CentroDistribucionRb.Checked)
            {
                if (TerminalesCbo.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una terminal de destino.");
                    return;
                }

                modelo.ImposicionConDestinoACD(
                    cuit.ToString(),
                    TerminalesCbo.SelectedItem?.ToString(),
                    TamanoBultoCbo.SelectedItem?.ToString(),
                    NombreDestinatarioTxt.Text,
                    ApellidoDestinatarioTxt.Text,
                    dni
                );
            }
            else if (DireccionParticularRb.Checked)
            {
                if (string.IsNullOrEmpty(DatosEntregaDomiclioText.Text))
                {
                    MessageBox.Show("Debe ingresar una dirección de entrega.");
                    return;
                }

                modelo.ImposicionDomicilioParticular(
                     cuit.ToString(),
                    DatosEntregaDomiclioText.Text,
                    TamanoBultoCbo.SelectedItem?.ToString(),
                    NombreDestinatarioTxt.Text,
                    ApellidoDestinatarioTxt.Text,
                    dni,
                    LocalidadCbo.SelectedItem?.ToString()
                );
            }
            else if (AgenciaRb.Checked)
            {
                if (AgenciaCbo.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una agencia de destino.");
                    return;
                }

                modelo.ImposicionEnAgencia(
                     cuit.ToString(),
                    AgenciaCbo.SelectedItem?.ToString(),
                    TamanoBultoCbo.SelectedItem?.ToString(),
                    NombreDestinatarioTxt.Text,
                    ApellidoDestinatarioTxt.Text,
                    dni
                );
            }

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            ListadoClientesCC.SelectedIndex = -1;

            LocalidadCbo.SelectedIndex = -1;

            //  Corrección: desmarcar RadioButtons
            CentroDistribucionRb.Checked = false;
            DireccionParticularRb.Checked = false;
            AgenciaRb.Checked = false;

            TerminalesCbo.SelectedIndex = -1;
            CentroDistribucionGrb.Enabled = false;

            AgenciaCbo.SelectedIndex = -1;
            AgenciaGrb.Enabled = false;

            DatosEntregaDomiclioText.Clear();
            DireccionParticularGrb.Enabled = false;

            TamanoBultoCbo.SelectedIndex = -1;

            NombreDestinatarioTxt.Clear();
            ApellidoDestinatarioTxt.Clear();
            DniDestinatarioTxt.Clear();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DialogResult resultado = MessageBox.Show(
                "¿Seguro que querés cancelar la operación?",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Se canceló la operación de imposición");
                this.Close();
            }
        }
    }
}

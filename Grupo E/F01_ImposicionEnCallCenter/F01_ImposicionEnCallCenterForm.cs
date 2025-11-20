using Grupo_E.F01_ImposicionEnCallCenter;
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

namespace Grupo_E.ImposicionEnCallCenter
{
    public partial class F01_ImposicionEnCallCenterForm : Form
    {

        public F01_ImposicionEnCallCenterModel modelo = new F01_ImposicionEnCallCenterModel();
        
        public F01_ImposicionEnCallCenterForm()
        {
            InitializeComponent();
        }


        /*
         * Estamos asumiendo que en esta pantalla se va a hacer una imposición por bulto ....
         * Deberíamos sumar un campo para cantidad de bultos? Pero no siempre van a ser todos del mismo tamaño...
         * Además se generararía más de una guía por imposición.
         */

        private void F01_ImposicionEnCallCenter_Load(object sender, EventArgs e)
        {
            //Los groupBox se van a ir habilitando según correspodna:
            CentroDistribucionCCgrb.Enabled = false;
            ParticularCCgrb.Enabled = false;
            AgenciaCCgrb.Enabled = false;

            foreach (string localidad in modelo.Localidad)
            {
                LocalidadCCcmb.Items.Add(localidad);
            }

            foreach (String localidad in modelo.Localidad)
            {
                LocalidadCCcmbOrigen.Items.Add(localidad);
            }


            foreach (string tamaño in modelo.TamanoBulto)
            {
                TamanoBultoCCcmb.Items.Add(tamaño);
            }

            foreach (string cliente in modelo.ClientesLista)
            {
                ListadoClientesCC.Items.Add(cliente);
            }

            ListadoClientesCC.DropDownStyle = ComboBoxStyle.DropDown;
            ListadoClientesCC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ListadoClientesCC.AutoCompleteSource = AutoCompleteSource.ListItems;

            //Esto lo hizo copilot y no termino de entender: Preguntar
            ParticularCCrb.CheckedChanged += ParticularCCrb_CheckedChanged;
            AgenciaCCrb.CheckedChanged += AgenciaCCrb_CheckedChanged;
            CDCCrb.CheckedChanged += CDCCrb_CheckedChanged;
            LocalidadCCcmb.SelectedIndexChanged += LocalidadCCcmb_SelectedIndexChanged;
        }
        //Esto lo hizo copilot y no termino de entender: Preguntar

        private void LocalidadCCcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            AgenciasCCcmb.Items.Clear();
            TerminalesCCcmb.Items.Clear();


            AgenciasCCcmb.SelectedIndex = -1;
            TerminalesCCcmb.SelectedIndex = -1;
            DatosDomicilioCCtxt.Text = "";
            AgenciasCCcmb.SelectedIndex = -1;
            TerminalesCCcmb.SelectedIndex = -1;
            TerminalesCCcmb.Text = "";
            AgenciasCCcmb.Text = "";


            string localidadSeleccionada = LocalidadCCcmb.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(localidadSeleccionada))
                return;


            // Acceso directo al diccionario del modelo
            var informacionLocalidad = modelo.Localidades[localidadSeleccionada];

            foreach (var agencia in informacionLocalidad.Agencias)
                AgenciasCCcmb.Items.Add(agencia);

            foreach (var terminal in informacionLocalidad.Terminales)
                TerminalesCCcmb.Items.Add(terminal);
        }


        private void ParticularCCrb_CheckedChanged(object sender, EventArgs e)
        {
            TerminalesCCcmb.SelectedIndex = -1;
            TerminalesCCcmb.Text = "";

            if (ParticularCCrb.Checked)
            {
                ParticularCCgrb.Enabled = true;
                AgenciaCCgrb.Enabled = false;
                CentroDistribucionCCgrb.Enabled = false;
            }
        }

        private void AgenciaCCrb_CheckedChanged(object sender, EventArgs e)
        {
            TerminalesCCcmb.SelectedIndex = -1;
            TerminalesCCcmb.Text = "";
            DatosDomicilioCCtxt.Text = "";
            if (AgenciaCCrb.Checked)
            {
                ParticularCCgrb.Enabled = false;
                AgenciaCCgrb.Enabled = true;
                CentroDistribucionCCgrb.Enabled = false;
            }
        }

        private void CDCCrb_CheckedChanged(object sender, EventArgs e)
        {
            AgenciasCCcmb.SelectedIndex = -1;
            AgenciasCCcmb.Text = "";
            if (CDCCrb.Checked)
            {
                ParticularCCgrb.Enabled = false;
                AgenciaCCgrb.Enabled = false;
                CentroDistribucionCCgrb.Enabled = true;
            }
        }

        private void AceptarImpoAgenciabtn_Click(object sender, EventArgs e)
        {


            if (ListadoClientesCC.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un cliente");
                return;
            }

            /*
            if (string.IsNullOrEmpty(CUITClienteCCtxt.Text))
            {
                MessageBox.Show("El CUIT no puede estar vacío");
                return;
            }*/

            //Chequeo si existe cliente:

            /*
            if (!modelo.clientes.ContainsKey(CUITClienteCCtxt.Text))
            {
                MessageBox.Show("El CUIT ingresado no corresponde a un cliente registrado");
                return;
            }
            */



            if (ListadoClientesCC.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista.");
                return;
            }


            if (!CDCCrb.Checked && !ParticularCCrb.Checked && !AgenciaCCrb.Checked)
            {
                MessageBox.Show("Debe seleccionar un tipo de entrega.");
                return;
            }

            if (LocalidadCCcmb.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una localidad.");
                return;
            }

            if (TamanoBultoCCcmb.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tamaño de bulto.");
                return;
            }

            if (string.IsNullOrEmpty(DatosDestinatarioCCtxt.Text))
            {
                MessageBox.Show("Debe ingresar un los datos del destinatario.");
                return;
            }

            if (string.IsNullOrEmpty(DatosRetiroCCtxt.Text))
            {
                MessageBox.Show("Debe ingresar un los datos de retiro");
                return;
            }

            var clienteSeleccionado = ListadoClientesCC.SelectedItem?.ToString();
            var cuit = clienteSeleccionado?.Split(',')[0].Trim();

            if (CDCCrb.Checked)
            {
                if (TerminalesCCcmb.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una terminal de destino.");
                    return;
                }

                

                modelo.ImposicionConDestinoACD(
                    //CUITClienteCCtxt.Text,
                    cuit.ToString(),
                    TerminalesCCcmb.SelectedItem?.ToString(),
                    TamanoBultoCCcmb.SelectedItem?.ToString(),
                    DatosDestinatarioCCtxt.Text,
                    DatosRetiroCCtxt.Text,
                    LocalidadCCcmbOrigen.SelectedItem.ToString()
                );

            }


            else if (ParticularCCrb.Checked)
            {
                if (string.IsNullOrEmpty(DatosDomicilioCCtxt.Text))
                {
                    //Debería chequear campo por campo??
                    MessageBox.Show("Debe ingresar una dirección de entrega.");
                    return;
                }

                modelo.ImposicionDomicilioParticular(
                    cuit.ToString(),
                    DatosDomicilioCCtxt.Text,
                    TamanoBultoCCcmb.SelectedItem?.ToString(),
                    DatosDestinatarioCCtxt.Text,
                    DatosRetiroCCtxt.Text,
                    LocalidadCCcmb.SelectedItem.ToString(),
                    LocalidadCCcmbOrigen.SelectedItem.ToString()
                );
            }


            else if (AgenciaCCrb.Checked)
            {
                if (AgenciasCCcmb.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una agencia de destino.");
                    return;
                }

                modelo.ImposicionEnAgencia(
                    cuit.ToString(),
                    AgenciasCCcmb.SelectedItem?.ToString(),
                    TamanoBultoCCcmb.SelectedItem?.ToString(),
                    DatosDestinatarioCCtxt.Text,
                    DatosRetiroCCtxt.Text,
                    LocalidadCCcmbOrigen.SelectedItem.ToString()
                );

            }

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            ListadoClientesCC.SelectedIndex = -1;

            LocalidadCCcmb.SelectedIndex = -1;

            CDCCrb.Checked = false;
            ParticularCCrb.Checked = false;
            AgenciaCCrb.Checked = false;

            TerminalesCCcmb.SelectedIndex = -1;
            CentroDistribucionCCgrb.Enabled = false;

            AgenciasCCcmb.SelectedIndex = -1;
            AgenciaCCgrb.Enabled = false;

            DatosDomicilioCCtxt.Clear();
            ParticularCCgrb.Enabled = false;

            TamanoBultoCCcmb.SelectedIndex = -1;

            DatosDestinatarioCCtxt.Clear();

            DatosRetiroCCtxt.Clear();
        }

        private void CancelarImpoCCbtn_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DialogResult resultado = MessageBox.Show(
            "¿Seguro que querés cancelar la operación?",
            "Confirmar cancelación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Se canceló la operación de imposición");
                this.Close();
            }
        }

    }
}

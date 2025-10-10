using Grupo_E.F03_ImposicionEnCD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.ImposicionEnCD
{
    public partial class F03_ImposicionCDForm : Form
    {
        public F03_ImposicionEnCDModel modelo = new F03_ImposicionEnCDModel();
        public F03_ImposicionCDForm()
        {
            InitializeComponent();   
        }


        /*
         * Estamos asumiendo que en esta pantalla se va a hacer una imposición por bulto ....
         * Deberíamos sumar un campo para cantidad de bultos? Pero no siempre van a ser todos del mismo tamaño...
         */

         private void F03_ImposicionCDForm_Load(object sender, EventArgs e)
        {
           //Los groupBox se van a ir habilitando según correspodna:
            CentroDistribucionGrb.Enabled = false;
            DireccionParticularGrb.Enabled = false;
            AgenciaGrb.Enabled = false;

            foreach (string localidad in modelo.Localidad)
            {
                LocalidadCbo.Items.Add(localidad);
            }

            foreach (string tamaño in modelo.TamanoBulto)
            {
                TamanoBultoCbo.Items.Add(tamaño);
            }
            

            //Esto lo hizo copilot y no termino de entender: Preguntar
            DomicilioRb.CheckedChanged += DomicilioRb_CheckedChanged;
            AgenciaRb.CheckedChanged += AgenciaRb_CheckedChanged;
            CentroDistribucionRb.CheckedChanged += CentroDistribucionRb_CheckedChanged;
            LocalidadCbo.SelectedIndexChanged += LocalidadCbo_SelectedIndexChanged;
        }


        //Esto lo hizo copilot y no termino de entender: Preguntar

        private void LocalidadCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AgenciaCbo.Items.Clear();
            TerminalesCbo.Items.Clear();

            string localidadSeleccionada = LocalidadCbo.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(localidadSeleccionada))
                return;

            // Acceso directo al diccionario del modelo
            var informacionLocalidades = modelo.Localidades[localidadSeleccionada];

            foreach (var agencia in informacionLocalidades.Agencias)
                AgenciaCbo.Items.Add(agencia);

            foreach (var terminal in informacionLocalidades.Terminales)
                TerminalesCbo.Items.Add(terminal);
        }



        
        private void DomicilioRb_CheckedChanged(object sender, EventArgs e)
        {
            if (DomicilioRb.Checked)
            {
                DireccionParticularGrb.Enabled = true;
                AgenciaGrb.Enabled = false;
                CentroDistribucionGrb.Enabled = false;
            }
        }

        private void AgenciaRb_CheckedChanged(object sender, EventArgs e)
        {
            if (AgenciaRb.Checked)
            {
                DireccionParticularGrb.Enabled = false;
                AgenciaGrb.Enabled = true;
                CentroDistribucionGrb.Enabled = false;
            }
        }

        private void CentroDistribucionRb_CheckedChanged(object sender, EventArgs e)
        {
            if (CentroDistribucionRb.Checked)
            {
                DireccionParticularGrb.Enabled = false;
                AgenciaGrb.Enabled = false;
                CentroDistribucionGrb.Enabled = true;
            }
        }

        //Acá le tengo que pasar todos los datos al modelo para que me cree la imposición que corresponda:
        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            //Validaciones previas a pasarle al modelo:
            //No tendría sentido que primero busque el cliente y que si no lo encuentra ahí directamente no me deje avanzar? 

            if (string.IsNullOrEmpty(CuitText.Text))
            {
                MessageBox.Show("El CUIT no puede estar vacío");
                return;
            }

            //Chequeo si existe cliente:

            if (!modelo.clientes.ContainsKey(CuitText.Text))
            {
                MessageBox.Show("El CUIT ingresado no corresponde a un cliente registrado");
                return;
            }



            if (!CentroDistribucionRb.Checked && !DomicilioRb.Checked && !AgenciaRb.Checked)
            {
                MessageBox.Show("Debe seleccionar un tipo de entrega.");
                return;
            }


            if (LocalidadCbo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una localidad.");
                return;
            }

            //Falta chequear agencia y Cd dependiendo el tipo de entrega seleccionado

            /*
            if (string.IsNullOrEmpty(DatosEntregaDomiclioText.Text))
            {
                //Debería chequear campo por campo??
                MessageBox.Show("Debe ingresar una dirección de entrega.");
                return;
            }
            */

            if (string.IsNullOrEmpty(DatosDestinatarioText.Text))
            {
                MessageBox.Show("Debe ingresar un los datos del destinatario.");
                return;
            }


            //Si está todo ok:

            if(CentroDistribucionRb.Checked)
            {
                modelo.ImposicionConDestinoACD(
                    CuitText.Text,
                    TerminalesCbo.SelectedItem?.ToString(),
                    TamanoBultoCbo.SelectedItem?.ToString(),
                    DatosDestinatarioText.Text
                );

                LimpiarCampos();
            }

            /*
            else if (DomicilioRb.Checked)
            {
                modelo.ImposicionDomicilioParticular(
                    CuitText.Text,
                    DatosEntregaDomiclioText.Text,
                    TamanoBultoCbo.SelectedItem?.ToString(),
                    DatosDestinatarioText.Text
                );
            }
            else if (AgenciaRb.Checked)
            {
                modelo.ImposicionEnAgencia(
                    CuitText.Text,
                    AgenciaCbo.SelectedItem?.ToString(),
                    TamanoBultoCbo.SelectedItem?.ToString(),
                    DatosDestinatarioText.Text
                );
            }
            */

        }

        private void LimpiarCampos()
        {
            CuitText.Clear();

            LocalidadCbo.SelectedIndex = -1;

            CentroDistribucionRb.Checked = false;
            DomicilioRb.Checked = false;
            AgenciaRb.Checked = false;

            TerminalesCbo.Items.Clear();
            CentroDistribucionGrb.Enabled = false;

            AgenciaCbo.Items.Clear();
            AgenciaGrb.Enabled = false;

            DatosEntregaDomiclioText.Clear();
            DireccionParticularGrb.Enabled = false;

            TamanoBultoCbo.SelectedIndex = -1;


            DatosDestinatarioText.Clear();
        }




    }
}

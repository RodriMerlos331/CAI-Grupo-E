using Grupo_E.Almacenes;
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
         * Además se generararía más de una guía por imposición.
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
            AgenciaCbo.SelectedIndex = -1;
            TerminalesCbo.SelectedIndex = -1;
            DatosEntregaDomiclioText.Text = "";


            string localidadSeleccionada = LocalidadCbo.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(localidadSeleccionada))
                return;

            //Me guarda localidad seleccionada como localidad de destino
            LocalidadAlmacen.LocalidadDestino = (LocalidadEntidad)LocalidadCbo.SelectedItem;



            var informacionLocalidades = modelo.Localidades[localidadSeleccionada];

            TerminalesCbo.Items.Clear();
            AgenciaCbo.Items.Clear();

            foreach (var agencia in informacionLocalidades.Agencias)
                AgenciaCbo.Items.Add(agencia);

            foreach (var terminal in informacionLocalidades.Terminales)
                TerminalesCbo.Items.Add(terminal);
        }


        private void DomicilioRb_CheckedChanged(object sender, EventArgs e)
        {
            TerminalesCbo.SelectedIndex = -1;
            TerminalesCbo.Text = "";
            AgenciaCbo.SelectedIndex = -1;
            if (DomicilioRb.Checked)
            {
                DireccionParticularGrb.Enabled = true;
                AgenciaGrb.Enabled = false;
                CentroDistribucionGrb.Enabled = false;
            }
        }

        private void AgenciaRb_CheckedChanged(object sender, EventArgs e)
        {
            TerminalesCbo.SelectedIndex = -1;
            TerminalesCbo.Text = "";
            DatosEntregaDomiclioText.Text = "";
            if (AgenciaRb.Checked)
            {
                DireccionParticularGrb.Enabled = false;
                AgenciaGrb.Enabled = true;
                CentroDistribucionGrb.Enabled = false;
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


            if(TamanoBultoCbo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tamaño de bulto.");
                return;
            }

            if (string.IsNullOrEmpty(DatosDestinatarioText.Text))
            {
                MessageBox.Show("Debe ingresar un los datos del destinatario.");
                return;
            }



            if(CentroDistribucionRb.Checked)
            {
                if(TerminalesCbo.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una terminal de destino.");
                    return;
                }

                modelo.ImposicionConDestinoACD(
                    CuitText.Text,
                    TerminalesCbo.SelectedItem?.ToString(),
                    TamanoBultoCbo.SelectedItem?.ToString(),
                    DatosDestinatarioText.Text
                );

            }

         
            else if (DomicilioRb.Checked)
            {
                if (string.IsNullOrEmpty(DatosEntregaDomiclioText.Text))
                {
                    //Debería chequear campo por campo??
                    MessageBox.Show("Debe ingresar una dirección de entrega.");
                    return;
                }

                modelo.ImposicionDomicilioParticular(
                    CuitText.Text,
                    DatosEntregaDomiclioText.Text,
                    TamanoBultoCbo.SelectedItem?.ToString(),
                    DatosDestinatarioText.Text
                );


            }

            
            else if (AgenciaRb.Checked)
            {
                if(AgenciaCbo.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una agencia de destino.");
                    return;
                }

                modelo.ImposicionConDestinoACD(
                    CuitText.Text,
                    AgenciaCbo.SelectedItem?.ToString(),
                    TamanoBultoCbo.SelectedItem?.ToString(),
                    DatosDestinatarioText.Text
                );

            }

            LimpiarCampos();

            //Ahora tendría que guardarlo. 
        }

        private void LimpiarCampos()
        {
            CuitText.Clear();

            LocalidadCbo.SelectedIndex = -1;

            CentroDistribucionRb.Checked = false;
            DomicilioRb.Checked = false;
            AgenciaRb.Checked = false;

            TerminalesCbo.SelectedIndex = -1;
            CentroDistribucionGrb.Enabled = false;

            AgenciaCbo.SelectedIndex = -1;
            AgenciaGrb.Enabled = false;

            DatosEntregaDomiclioText.Clear();
            DireccionParticularGrb.Enabled = false;

            TamanoBultoCbo.SelectedIndex = -1;


            DatosDestinatarioText.Clear();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            //debería cancelar la última encomienda impuesta??
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

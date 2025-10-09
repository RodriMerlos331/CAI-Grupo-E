namespace Grupo_E.ImposicionEnCallCenter
{
    partial class F01_ImposicionEnCallCenterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbDatosRetiroCC = new System.Windows.Forms.GroupBox();
            this.lblNombreRetiroCC = new System.Windows.Forms.Label();
            this.txtNombreRetiroCC = new System.Windows.Forms.TextBox();
            this.btnCancelarImpoAgencia = new System.Windows.Forms.Button();
            this.btnAceptarImpoAgencia = new System.Windows.Forms.Button();
            this.lbCUITImpo = new System.Windows.Forms.Label();
            this.txtCUITClienteCC = new System.Windows.Forms.TextBox();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.rbAgecnia = new System.Windows.Forms.RadioButton();
            this.rbCC = new System.Windows.Forms.RadioButton();
            this.rbParticular = new System.Windows.Forms.RadioButton();
            this.grbDatosDestino = new System.Windows.Forms.GroupBox();
            this.lbLocalidad = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.grbCC = new System.Windows.Forms.GroupBox();
            this.lbAgencia = new System.Windows.Forms.Label();
            this.cbAgencias = new System.Windows.Forms.ComboBox();
            this.grbAgencia = new System.Windows.Forms.GroupBox();
            this.grbBultoCC = new System.Windows.Forms.GroupBox();
            this.cbTamañoVulto = new System.Windows.Forms.ComboBox();
            this.lbTamañoBulto = new System.Windows.Forms.Label();
            this.grbParticular = new System.Windows.Forms.GroupBox();
            this.txtCiudadDestino = new System.Windows.Forms.TextBox();
            this.lbCiudadDestino = new System.Windows.Forms.Label();
            this.grbDatosDestinatario = new System.Windows.Forms.GroupBox();
            this.txtApellidoDestinatario = new System.Windows.Forms.TextBox();
            this.lbNombreDestinatario = new System.Windows.Forms.Label();
            this.grbDatosRetiroCC.SuspendLayout();
            this.grbCliente.SuspendLayout();
            this.grbDatosDestino.SuspendLayout();
            this.grbCC.SuspendLayout();
            this.grbAgencia.SuspendLayout();
            this.grbBultoCC.SuspendLayout();
            this.grbParticular.SuspendLayout();
            this.grbDatosDestinatario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosRetiroCC
            // 
            this.grbDatosRetiroCC.Controls.Add(this.lblNombreRetiroCC);
            this.grbDatosRetiroCC.Controls.Add(this.txtNombreRetiroCC);
            this.grbDatosRetiroCC.Location = new System.Drawing.Point(466, 389);
            this.grbDatosRetiroCC.Name = "grbDatosRetiroCC";
            this.grbDatosRetiroCC.Size = new System.Drawing.Size(463, 117);
            this.grbDatosRetiroCC.TabIndex = 23;
            this.grbDatosRetiroCC.TabStop = false;
            this.grbDatosRetiroCC.Text = "Datos de Retiro";
            // 
            // lblNombreRetiroCC
            // 
            this.lblNombreRetiroCC.AutoSize = true;
            this.lblNombreRetiroCC.Location = new System.Drawing.Point(12, 30);
            this.lblNombreRetiroCC.Name = "lblNombreRetiroCC";
            this.lblNombreRetiroCC.Size = new System.Drawing.Size(393, 13);
            this.lblNombreRetiroCC.TabIndex = 19;
            this.lblNombreRetiroCC.Text = "Nombre / Apellido / Ciudad / Codigo Postal / Calle / Altura / Piso / Departamento" +
    "";
            // 
            // txtNombreRetiroCC
            // 
            this.txtNombreRetiroCC.Location = new System.Drawing.Point(15, 46);
            this.txtNombreRetiroCC.Name = "txtNombreRetiroCC";
            this.txtNombreRetiroCC.Size = new System.Drawing.Size(441, 20);
            this.txtNombreRetiroCC.TabIndex = 18;
            // 
            // btnCancelarImpoAgencia
            // 
            this.btnCancelarImpoAgencia.Location = new System.Drawing.Point(799, 547);
            this.btnCancelarImpoAgencia.Name = "btnCancelarImpoAgencia";
            this.btnCancelarImpoAgencia.Size = new System.Drawing.Size(109, 23);
            this.btnCancelarImpoAgencia.TabIndex = 39;
            this.btnCancelarImpoAgencia.Text = "Cancelar";
            this.btnCancelarImpoAgencia.UseVisualStyleBackColor = true;
            // 
            // btnAceptarImpoAgencia
            // 
            this.btnAceptarImpoAgencia.Location = new System.Drawing.Point(665, 547);
            this.btnAceptarImpoAgencia.Name = "btnAceptarImpoAgencia";
            this.btnAceptarImpoAgencia.Size = new System.Drawing.Size(109, 23);
            this.btnAceptarImpoAgencia.TabIndex = 38;
            this.btnAceptarImpoAgencia.Text = "Aceptar";
            this.btnAceptarImpoAgencia.UseVisualStyleBackColor = true;
            // 
            // lbCUITImpo
            // 
            this.lbCUITImpo.AutoSize = true;
            this.lbCUITImpo.Location = new System.Drawing.Point(7, 32);
            this.lbCUITImpo.Name = "lbCUITImpo";
            this.lbCUITImpo.Size = new System.Drawing.Size(32, 13);
            this.lbCUITImpo.TabIndex = 0;
            this.lbCUITImpo.Text = "CUIT";
            // 
            // txtCUITClienteCC
            // 
            this.txtCUITClienteCC.Location = new System.Drawing.Point(45, 25);
            this.txtCUITClienteCC.Name = "txtCUITClienteCC";
            this.txtCUITClienteCC.Size = new System.Drawing.Size(849, 20);
            this.txtCUITClienteCC.TabIndex = 1;
            this.txtCUITClienteCC.TextChanged += new System.EventHandler(this.lbCUITCliente_TextChanged);
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.txtCUITClienteCC);
            this.grbCliente.Controls.Add(this.lbCUITImpo);
            this.grbCliente.Location = new System.Drawing.Point(8, 12);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(906, 75);
            this.grbCliente.TabIndex = 34;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Cliente";
            // 
            // rbAgecnia
            // 
            this.rbAgecnia.AutoSize = true;
            this.rbAgecnia.Location = new System.Drawing.Point(15, 108);
            this.rbAgecnia.Name = "rbAgecnia";
            this.rbAgecnia.Size = new System.Drawing.Size(64, 17);
            this.rbAgecnia.TabIndex = 1;
            this.rbAgecnia.TabStop = true;
            this.rbAgecnia.Text = "Agencia";
            this.rbAgecnia.UseVisualStyleBackColor = true;
            // 
            // rbCC
            // 
            this.rbCC.AutoSize = true;
            this.rbCC.Location = new System.Drawing.Point(14, 30);
            this.rbCC.Name = "rbCC";
            this.rbCC.Size = new System.Drawing.Size(127, 17);
            this.rbCC.TabIndex = 0;
            this.rbCC.TabStop = true;
            this.rbCC.Text = "Centro de distribucion";
            this.rbCC.UseVisualStyleBackColor = true;
            // 
            // rbParticular
            // 
            this.rbParticular.AutoSize = true;
            this.rbParticular.Location = new System.Drawing.Point(14, 68);
            this.rbParticular.Name = "rbParticular";
            this.rbParticular.Size = new System.Drawing.Size(116, 17);
            this.rbParticular.TabIndex = 2;
            this.rbParticular.TabStop = true;
            this.rbParticular.Text = "Direccion particular";
            this.rbParticular.UseVisualStyleBackColor = true;
            // 
            // grbDatosDestino
            // 
            this.grbDatosDestino.Controls.Add(this.rbParticular);
            this.grbDatosDestino.Controls.Add(this.rbCC);
            this.grbDatosDestino.Controls.Add(this.rbAgecnia);
            this.grbDatosDestino.Location = new System.Drawing.Point(466, 93);
            this.grbDatosDestino.Name = "grbDatosDestino";
            this.grbDatosDestino.Size = new System.Drawing.Size(448, 176);
            this.grbDatosDestino.TabIndex = 32;
            this.grbDatosDestino.TabStop = false;
            this.grbDatosDestino.Text = "Datos de destino";
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Location = new System.Drawing.Point(11, 30);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lbLocalidad.TabIndex = 8;
            this.lbLocalidad.Text = "Localidad";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Buenos Aires (GBA)",
            "CABA",
            "Córdoba ",
            "Tucumán ",
            "Corrientes",
            "Neuquén",
            "Viedma",
            ""});
            this.comboBox2.Location = new System.Drawing.Point(13, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(414, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // grbCC
            // 
            this.grbCC.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.grbCC.Controls.Add(this.comboBox2);
            this.grbCC.Controls.Add(this.lbLocalidad);
            this.grbCC.Location = new System.Drawing.Point(8, 93);
            this.grbCC.Name = "grbCC";
            this.grbCC.Size = new System.Drawing.Size(447, 85);
            this.grbCC.TabIndex = 31;
            this.grbCC.TabStop = false;
            this.grbCC.Text = "Destino";
            // 
            // lbAgencia
            // 
            this.lbAgencia.AutoSize = true;
            this.lbAgencia.Location = new System.Drawing.Point(11, 30);
            this.lbAgencia.Name = "lbAgencia";
            this.lbAgencia.Size = new System.Drawing.Size(46, 13);
            this.lbAgencia.TabIndex = 10;
            this.lbAgencia.Text = "Agencia";
            // 
            // cbAgencias
            // 
            this.cbAgencias.FormattingEnabled = true;
            this.cbAgencias.Location = new System.Drawing.Point(11, 46);
            this.cbAgencias.Name = "cbAgencias";
            this.cbAgencias.Size = new System.Drawing.Size(414, 21);
            this.cbAgencias.TabIndex = 11;
            // 
            // grbAgencia
            // 
            this.grbAgencia.Controls.Add(this.cbAgencias);
            this.grbAgencia.Controls.Add(this.lbAgencia);
            this.grbAgencia.Location = new System.Drawing.Point(8, 184);
            this.grbAgencia.Name = "grbAgencia";
            this.grbAgencia.Size = new System.Drawing.Size(449, 85);
            this.grbAgencia.TabIndex = 35;
            this.grbAgencia.TabStop = false;
            this.grbAgencia.Text = "Datos de Agencia";
            // 
            // grbBultoCC
            // 
            this.grbBultoCC.Controls.Add(this.cbTamañoVulto);
            this.grbBultoCC.Controls.Add(this.lbTamañoBulto);
            this.grbBultoCC.Location = new System.Drawing.Point(8, 389);
            this.grbBultoCC.Name = "grbBultoCC";
            this.grbBultoCC.Size = new System.Drawing.Size(449, 117);
            this.grbBultoCC.TabIndex = 46;
            this.grbBultoCC.TabStop = false;
            this.grbBultoCC.Text = "Datos del bulto";
            // 
            // cbTamañoVulto
            // 
            this.cbTamañoVulto.FormattingEnabled = true;
            this.cbTamañoVulto.Location = new System.Drawing.Point(6, 46);
            this.cbTamañoVulto.Name = "cbTamañoVulto";
            this.cbTamañoVulto.Size = new System.Drawing.Size(419, 21);
            this.cbTamañoVulto.TabIndex = 10;
            // 
            // lbTamañoBulto
            // 
            this.lbTamañoBulto.AutoSize = true;
            this.lbTamañoBulto.Location = new System.Drawing.Point(3, 30);
            this.lbTamañoBulto.Name = "lbTamañoBulto";
            this.lbTamañoBulto.Size = new System.Drawing.Size(89, 13);
            this.lbTamañoBulto.TabIndex = 8;
            this.lbTamañoBulto.Text = "Tamaño del bulto";
            // 
            // grbParticular
            // 
            this.grbParticular.Controls.Add(this.txtCiudadDestino);
            this.grbParticular.Controls.Add(this.lbCiudadDestino);
            this.grbParticular.Location = new System.Drawing.Point(466, 275);
            this.grbParticular.Name = "grbParticular";
            this.grbParticular.Size = new System.Drawing.Size(442, 108);
            this.grbParticular.TabIndex = 45;
            this.grbParticular.TabStop = false;
            this.grbParticular.Text = "Direccion particular";
            // 
            // txtCiudadDestino
            // 
            this.txtCiudadDestino.Location = new System.Drawing.Point(5, 51);
            this.txtCiudadDestino.Name = "txtCiudadDestino";
            this.txtCiudadDestino.Size = new System.Drawing.Size(420, 20);
            this.txtCiudadDestino.TabIndex = 9;
            // 
            // lbCiudadDestino
            // 
            this.lbCiudadDestino.AutoSize = true;
            this.lbCiudadDestino.Location = new System.Drawing.Point(11, 30);
            this.lbCiudadDestino.Name = "lbCiudadDestino";
            this.lbCiudadDestino.Size = new System.Drawing.Size(297, 13);
            this.lbCiudadDestino.TabIndex = 8;
            this.lbCiudadDestino.Text = "Ciudad / Codigo Postal / Calle / Altura / Piso / Departamento";
            // 
            // grbDatosDestinatario
            // 
            this.grbDatosDestinatario.Controls.Add(this.txtApellidoDestinatario);
            this.grbDatosDestinatario.Controls.Add(this.lbNombreDestinatario);
            this.grbDatosDestinatario.Location = new System.Drawing.Point(8, 275);
            this.grbDatosDestinatario.Name = "grbDatosDestinatario";
            this.grbDatosDestinatario.Size = new System.Drawing.Size(449, 108);
            this.grbDatosDestinatario.TabIndex = 44;
            this.grbDatosDestinatario.TabStop = false;
            this.grbDatosDestinatario.Text = "Datos de destinatario";
            // 
            // txtApellidoDestinatario
            // 
            this.txtApellidoDestinatario.Location = new System.Drawing.Point(4, 51);
            this.txtApellidoDestinatario.Name = "txtApellidoDestinatario";
            this.txtApellidoDestinatario.Size = new System.Drawing.Size(424, 20);
            this.txtApellidoDestinatario.TabIndex = 3;
            // 
            // lbNombreDestinatario
            // 
            this.lbNombreDestinatario.AutoSize = true;
            this.lbNombreDestinatario.Location = new System.Drawing.Point(7, 35);
            this.lbNombreDestinatario.Name = "lbNombreDestinatario";
            this.lbNombreDestinatario.Size = new System.Drawing.Size(122, 13);
            this.lbNombreDestinatario.TabIndex = 0;
            this.lbNombreDestinatario.Text = "Nombre / Apellido / DNI";
            // 
            // ImposicionEnCallCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 580);
            this.Controls.Add(this.grbBultoCC);
            this.Controls.Add(this.grbParticular);
            this.Controls.Add(this.grbDatosDestinatario);
            this.Controls.Add(this.btnCancelarImpoAgencia);
            this.Controls.Add(this.btnAceptarImpoAgencia);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.grbAgencia);
            this.Controls.Add(this.grbCC);
            this.Controls.Add(this.grbDatosDestino);
            this.Controls.Add(this.grbDatosRetiroCC);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ImposicionEnCallCenter";
            this.Text = "Imposicion En Call Center";
            this.grbDatosRetiroCC.ResumeLayout(false);
            this.grbDatosRetiroCC.PerformLayout();
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            this.grbDatosDestino.ResumeLayout(false);
            this.grbDatosDestino.PerformLayout();
            this.grbCC.ResumeLayout(false);
            this.grbCC.PerformLayout();
            this.grbAgencia.ResumeLayout(false);
            this.grbAgencia.PerformLayout();
            this.grbBultoCC.ResumeLayout(false);
            this.grbBultoCC.PerformLayout();
            this.grbParticular.ResumeLayout(false);
            this.grbParticular.PerformLayout();
            this.grbDatosDestinatario.ResumeLayout(false);
            this.grbDatosDestinatario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbDatosRetiroCC;
        private System.Windows.Forms.Label lblNombreRetiroCC;
        private System.Windows.Forms.TextBox txtNombreRetiroCC;
        private System.Windows.Forms.Button btnCancelarImpoAgencia;
        private System.Windows.Forms.Button btnAceptarImpoAgencia;
        private System.Windows.Forms.Label lbCUITImpo;
        private System.Windows.Forms.TextBox txtCUITClienteCC;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.RadioButton rbAgecnia;
        private System.Windows.Forms.RadioButton rbCC;
        private System.Windows.Forms.RadioButton rbParticular;
        private System.Windows.Forms.GroupBox grbDatosDestino;
        private System.Windows.Forms.Label lbLocalidad;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox grbCC;
        private System.Windows.Forms.Label lbAgencia;
        private System.Windows.Forms.ComboBox cbAgencias;
        private System.Windows.Forms.GroupBox grbAgencia;
        private System.Windows.Forms.GroupBox grbBultoCC;
        private System.Windows.Forms.ComboBox cbTamañoVulto;
        private System.Windows.Forms.Label lbTamañoBulto;
        private System.Windows.Forms.GroupBox grbParticular;
        private System.Windows.Forms.TextBox txtCiudadDestino;
        private System.Windows.Forms.Label lbCiudadDestino;
        private System.Windows.Forms.GroupBox grbDatosDestinatario;
        private System.Windows.Forms.TextBox txtApellidoDestinatario;
        private System.Windows.Forms.Label lbNombreDestinatario;
    }
}
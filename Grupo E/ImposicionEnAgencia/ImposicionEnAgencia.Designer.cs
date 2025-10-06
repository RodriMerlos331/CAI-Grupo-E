namespace Grupo_E.ImposicionEnAgencia
{
    partial class ImposicionEnAgencia
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
            this.btnCancelarImpoAgencia = new System.Windows.Forms.Button();
            this.btnAceptarImpoAgencia = new System.Windows.Forms.Button();
            this.grbParticular = new System.Windows.Forms.GroupBox();
            this.txtDeptoDestino = new System.Windows.Forms.TextBox();
            this.lbDepto = new System.Windows.Forms.Label();
            this.txtAlturaDestino = new System.Windows.Forms.TextBox();
            this.lbAltura = new System.Windows.Forms.Label();
            this.txtCalleDestino = new System.Windows.Forms.TextBox();
            this.lbCP = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.lbCalle = new System.Windows.Forms.Label();
            this.txtCiudadDestino = new System.Windows.Forms.TextBox();
            this.lbCiudadDestino = new System.Windows.Forms.Label();
            this.grbAgencia = new System.Windows.Forms.GroupBox();
            this.cbAgencias = new System.Windows.Forms.ComboBox();
            this.lbAgencia = new System.Windows.Forms.Label();
            this.grbCC = new System.Windows.Forms.GroupBox();
            this.lbLocalidad = new System.Windows.Forms.Label();
            this.grbDatosDestino = new System.Windows.Forms.GroupBox();
            this.rbParticular = new System.Windows.Forms.RadioButton();
            this.rbCC = new System.Windows.Forms.RadioButton();
            this.rbAgecnia = new System.Windows.Forms.RadioButton();
            this.grbDatosDestinatario = new System.Windows.Forms.GroupBox();
            this.txtCuitDestinatario = new System.Windows.Forms.TextBox();
            this.lbCuitDestinatario = new System.Windows.Forms.Label();
            this.txtApellidoDestinatario = new System.Windows.Forms.TextBox();
            this.lbApellidoDestinatario = new System.Windows.Forms.Label();
            this.txtNombreDestinatario = new System.Windows.Forms.TextBox();
            this.lbNombreDestinatario = new System.Windows.Forms.Label();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.lbCUITCliente = new System.Windows.Forms.TextBox();
            this.lbCUITImpo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grbBultoCC = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTamañoVulto = new System.Windows.Forms.ComboBox();
            this.lbTamañoBulto = new System.Windows.Forms.Label();
            this.grbParticular.SuspendLayout();
            this.grbAgencia.SuspendLayout();
            this.grbCC.SuspendLayout();
            this.grbDatosDestino.SuspendLayout();
            this.grbDatosDestinatario.SuspendLayout();
            this.grbCliente.SuspendLayout();
            this.grbBultoCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelarImpoAgencia
            // 
            this.btnCancelarImpoAgencia.Location = new System.Drawing.Point(807, 719);
            this.btnCancelarImpoAgencia.Name = "btnCancelarImpoAgencia";
            this.btnCancelarImpoAgencia.Size = new System.Drawing.Size(109, 23);
            this.btnCancelarImpoAgencia.TabIndex = 25;
            this.btnCancelarImpoAgencia.Text = "Cancelar";
            this.btnCancelarImpoAgencia.UseVisualStyleBackColor = true;
            // 
            // btnAceptarImpoAgencia
            // 
            this.btnAceptarImpoAgencia.Location = new System.Drawing.Point(692, 719);
            this.btnAceptarImpoAgencia.Name = "btnAceptarImpoAgencia";
            this.btnAceptarImpoAgencia.Size = new System.Drawing.Size(109, 23);
            this.btnAceptarImpoAgencia.TabIndex = 24;
            this.btnAceptarImpoAgencia.Text = "Aceptar";
            this.btnAceptarImpoAgencia.UseVisualStyleBackColor = true;
            this.btnAceptarImpoAgencia.Click += new System.EventHandler(this.btnAceptarImpoAgencia_Click);
            // 
            // grbParticular
            // 
            this.grbParticular.Controls.Add(this.txtDeptoDestino);
            this.grbParticular.Controls.Add(this.lbDepto);
            this.grbParticular.Controls.Add(this.txtAlturaDestino);
            this.grbParticular.Controls.Add(this.lbAltura);
            this.grbParticular.Controls.Add(this.txtCalleDestino);
            this.grbParticular.Controls.Add(this.lbCP);
            this.grbParticular.Controls.Add(this.txtCP);
            this.grbParticular.Controls.Add(this.lbCalle);
            this.grbParticular.Controls.Add(this.txtCiudadDestino);
            this.grbParticular.Controls.Add(this.lbCiudadDestino);
            this.grbParticular.Location = new System.Drawing.Point(10, 447);
            this.grbParticular.Name = "grbParticular";
            this.grbParticular.Size = new System.Drawing.Size(906, 125);
            this.grbParticular.TabIndex = 22;
            this.grbParticular.TabStop = false;
            this.grbParticular.Text = "Direccion particular";
            // 
            // txtDeptoDestino
            // 
            this.txtDeptoDestino.Location = new System.Drawing.Point(7, 94);
            this.txtDeptoDestino.Name = "txtDeptoDestino";
            this.txtDeptoDestino.Size = new System.Drawing.Size(205, 20);
            this.txtDeptoDestino.TabIndex = 17;
            // 
            // lbDepto
            // 
            this.lbDepto.AutoSize = true;
            this.lbDepto.Location = new System.Drawing.Point(10, 78);
            this.lbDepto.Name = "lbDepto";
            this.lbDepto.Size = new System.Drawing.Size(105, 13);
            this.lbDepto.TabIndex = 16;
            this.lbDepto.Text = "Piso / Departamento";
            this.lbDepto.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtAlturaDestino
            // 
            this.txtAlturaDestino.Location = new System.Drawing.Point(640, 46);
            this.txtAlturaDestino.Name = "txtAlturaDestino";
            this.txtAlturaDestino.Size = new System.Drawing.Size(186, 20);
            this.txtAlturaDestino.TabIndex = 15;
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(646, 30);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(34, 13);
            this.lbAltura.TabIndex = 14;
            this.lbAltura.Text = "Altura";
            // 
            // txtCalleDestino
            // 
            this.txtCalleDestino.Location = new System.Drawing.Point(429, 46);
            this.txtCalleDestino.Name = "txtCalleDestino";
            this.txtCalleDestino.Size = new System.Drawing.Size(205, 20);
            this.txtCalleDestino.TabIndex = 13;
            // 
            // lbCP
            // 
            this.lbCP.AutoSize = true;
            this.lbCP.Location = new System.Drawing.Point(222, 32);
            this.lbCP.Name = "lbCP";
            this.lbCP.Size = new System.Drawing.Size(72, 13);
            this.lbCP.TabIndex = 12;
            this.lbCP.Text = "Codigo Postal";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(225, 46);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(189, 20);
            this.txtCP.TabIndex = 11;
            // 
            // lbCalle
            // 
            this.lbCalle.AutoSize = true;
            this.lbCalle.Location = new System.Drawing.Point(430, 32);
            this.lbCalle.Name = "lbCalle";
            this.lbCalle.Size = new System.Drawing.Size(30, 13);
            this.lbCalle.TabIndex = 10;
            this.lbCalle.Text = "Calle";
            // 
            // txtCiudadDestino
            // 
            this.txtCiudadDestino.Location = new System.Drawing.Point(10, 46);
            this.txtCiudadDestino.Name = "txtCiudadDestino";
            this.txtCiudadDestino.Size = new System.Drawing.Size(206, 20);
            this.txtCiudadDestino.TabIndex = 9;
            // 
            // lbCiudadDestino
            // 
            this.lbCiudadDestino.AutoSize = true;
            this.lbCiudadDestino.Location = new System.Drawing.Point(11, 30);
            this.lbCiudadDestino.Name = "lbCiudadDestino";
            this.lbCiudadDestino.Size = new System.Drawing.Size(40, 13);
            this.lbCiudadDestino.TabIndex = 8;
            this.lbCiudadDestino.Text = "Ciudad";
            // 
            // grbAgencia
            // 
            this.grbAgencia.Controls.Add(this.cbAgencias);
            this.grbAgencia.Controls.Add(this.lbAgencia);
            this.grbAgencia.Location = new System.Drawing.Point(10, 184);
            this.grbAgencia.Name = "grbAgencia";
            this.grbAgencia.Size = new System.Drawing.Size(460, 85);
            this.grbAgencia.TabIndex = 21;
            this.grbAgencia.TabStop = false;
            this.grbAgencia.Text = "Datos de Agencia";
            // 
            // cbAgencias
            // 
            this.cbAgencias.FormattingEnabled = true;
            this.cbAgencias.Location = new System.Drawing.Point(11, 46);
            this.cbAgencias.Name = "cbAgencias";
            this.cbAgencias.Size = new System.Drawing.Size(414, 21);
            this.cbAgencias.TabIndex = 11;
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
            // grbCC
            // 
            this.grbCC.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.grbCC.Controls.Add(this.comboBox1);
            this.grbCC.Controls.Add(this.lbLocalidad);
            this.grbCC.Location = new System.Drawing.Point(10, 93);
            this.grbCC.Name = "grbCC";
            this.grbCC.Size = new System.Drawing.Size(460, 85);
            this.grbCC.TabIndex = 17;
            this.grbCC.TabStop = false;
            this.grbCC.Text = "Destino";
            this.grbCC.Enter += new System.EventHandler(this.grbCC_Enter);
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
            // grbDatosDestino
            // 
            this.grbDatosDestino.Controls.Add(this.rbParticular);
            this.grbDatosDestino.Controls.Add(this.rbCC);
            this.grbDatosDestino.Controls.Add(this.rbAgecnia);
            this.grbDatosDestino.Location = new System.Drawing.Point(485, 93);
            this.grbDatosDestino.Name = "grbDatosDestino";
            this.grbDatosDestino.Size = new System.Drawing.Size(431, 85);
            this.grbDatosDestino.TabIndex = 18;
            this.grbDatosDestino.TabStop = false;
            this.grbDatosDestino.Text = "Datos de destino";
            // 
            // rbParticular
            // 
            this.rbParticular.AutoSize = true;
            this.rbParticular.Location = new System.Drawing.Point(15, 62);
            this.rbParticular.Name = "rbParticular";
            this.rbParticular.Size = new System.Drawing.Size(116, 17);
            this.rbParticular.TabIndex = 2;
            this.rbParticular.TabStop = true;
            this.rbParticular.Text = "Direccion particular";
            this.rbParticular.UseVisualStyleBackColor = true;
            // 
            // rbCC
            // 
            this.rbCC.AutoSize = true;
            this.rbCC.Location = new System.Drawing.Point(15, 25);
            this.rbCC.Name = "rbCC";
            this.rbCC.Size = new System.Drawing.Size(127, 17);
            this.rbCC.TabIndex = 0;
            this.rbCC.TabStop = true;
            this.rbCC.Text = "Centro de distribucion";
            this.rbCC.UseVisualStyleBackColor = true;
            // 
            // rbAgecnia
            // 
            this.rbAgecnia.AutoSize = true;
            this.rbAgecnia.Location = new System.Drawing.Point(265, 25);
            this.rbAgecnia.Name = "rbAgecnia";
            this.rbAgecnia.Size = new System.Drawing.Size(64, 17);
            this.rbAgecnia.TabIndex = 1;
            this.rbAgecnia.TabStop = true;
            this.rbAgecnia.Text = "Agencia";
            this.rbAgecnia.UseVisualStyleBackColor = true;
            // 
            // grbDatosDestinatario
            // 
            this.grbDatosDestinatario.Controls.Add(this.txtCuitDestinatario);
            this.grbDatosDestinatario.Controls.Add(this.lbCuitDestinatario);
            this.grbDatosDestinatario.Controls.Add(this.txtApellidoDestinatario);
            this.grbDatosDestinatario.Controls.Add(this.lbApellidoDestinatario);
            this.grbDatosDestinatario.Controls.Add(this.txtNombreDestinatario);
            this.grbDatosDestinatario.Controls.Add(this.lbNombreDestinatario);
            this.grbDatosDestinatario.Location = new System.Drawing.Point(10, 275);
            this.grbDatosDestinatario.Name = "grbDatosDestinatario";
            this.grbDatosDestinatario.Size = new System.Drawing.Size(906, 166);
            this.grbDatosDestinatario.TabIndex = 19;
            this.grbDatosDestinatario.TabStop = false;
            this.grbDatosDestinatario.Text = "Datos de destinatario";
            // 
            // txtCuitDestinatario
            // 
            this.txtCuitDestinatario.Location = new System.Drawing.Point(6, 120);
            this.txtCuitDestinatario.Name = "txtCuitDestinatario";
            this.txtCuitDestinatario.Size = new System.Drawing.Size(441, 20);
            this.txtCuitDestinatario.TabIndex = 5;
            // 
            // lbCuitDestinatario
            // 
            this.lbCuitDestinatario.AutoSize = true;
            this.lbCuitDestinatario.Location = new System.Drawing.Point(7, 104);
            this.lbCuitDestinatario.Name = "lbCuitDestinatario";
            this.lbCuitDestinatario.Size = new System.Drawing.Size(32, 13);
            this.lbCuitDestinatario.TabIndex = 4;
            this.lbCuitDestinatario.Text = "CUIT";
            // 
            // txtApellidoDestinatario
            // 
            this.txtApellidoDestinatario.Location = new System.Drawing.Point(453, 51);
            this.txtApellidoDestinatario.Name = "txtApellidoDestinatario";
            this.txtApellidoDestinatario.Size = new System.Drawing.Size(441, 20);
            this.txtApellidoDestinatario.TabIndex = 3;
            // 
            // lbApellidoDestinatario
            // 
            this.lbApellidoDestinatario.AutoSize = true;
            this.lbApellidoDestinatario.Location = new System.Drawing.Point(454, 35);
            this.lbApellidoDestinatario.Name = "lbApellidoDestinatario";
            this.lbApellidoDestinatario.Size = new System.Drawing.Size(44, 13);
            this.lbApellidoDestinatario.TabIndex = 2;
            this.lbApellidoDestinatario.Text = "Apellido";
            // 
            // txtNombreDestinatario
            // 
            this.txtNombreDestinatario.Location = new System.Drawing.Point(6, 51);
            this.txtNombreDestinatario.Name = "txtNombreDestinatario";
            this.txtNombreDestinatario.Size = new System.Drawing.Size(441, 20);
            this.txtNombreDestinatario.TabIndex = 1;
            // 
            // lbNombreDestinatario
            // 
            this.lbNombreDestinatario.AutoSize = true;
            this.lbNombreDestinatario.Location = new System.Drawing.Point(7, 35);
            this.lbNombreDestinatario.Name = "lbNombreDestinatario";
            this.lbNombreDestinatario.Size = new System.Drawing.Size(44, 13);
            this.lbNombreDestinatario.TabIndex = 0;
            this.lbNombreDestinatario.Text = "Nombre";
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.lbCUITCliente);
            this.grbCliente.Controls.Add(this.lbCUITImpo);
            this.grbCliente.Location = new System.Drawing.Point(10, 12);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(906, 75);
            this.grbCliente.TabIndex = 20;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Cliente";
            // 
            // lbCUITCliente
            // 
            this.lbCUITCliente.Location = new System.Drawing.Point(45, 25);
            this.lbCUITCliente.Name = "lbCUITCliente";
            this.lbCUITCliente.Size = new System.Drawing.Size(849, 20);
            this.lbCUITCliente.TabIndex = 1;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(414, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // grbBultoCC
            // 
            this.grbBultoCC.Controls.Add(this.button1);
            this.grbBultoCC.Controls.Add(this.textBox2);
            this.grbBultoCC.Controls.Add(this.textBox1);
            this.grbBultoCC.Controls.Add(this.label3);
            this.grbBultoCC.Controls.Add(this.label2);
            this.grbBultoCC.Controls.Add(this.cbTamañoVulto);
            this.grbBultoCC.Controls.Add(this.lbTamañoBulto);
            this.grbBultoCC.Location = new System.Drawing.Point(10, 578);
            this.grbBultoCC.Name = "grbBultoCC";
            this.grbBultoCC.Size = new System.Drawing.Size(906, 117);
            this.grbBultoCC.TabIndex = 30;
            this.grbBultoCC.TabStop = false;
            this.grbBultoCC.Text = "Datos del bulto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Siguiente bulto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(239, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Bulto Nro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cantidad de bultos:";
            // 
            // cbTamañoVulto
            // 
            this.cbTamañoVulto.FormattingEnabled = true;
            this.cbTamañoVulto.Location = new System.Drawing.Point(455, 47);
            this.cbTamañoVulto.Name = "cbTamañoVulto";
            this.cbTamañoVulto.Size = new System.Drawing.Size(183, 21);
            this.cbTamañoVulto.TabIndex = 10;
            // 
            // lbTamañoBulto
            // 
            this.lbTamañoBulto.AutoSize = true;
            this.lbTamañoBulto.Location = new System.Drawing.Point(454, 32);
            this.lbTamañoBulto.Name = "lbTamañoBulto";
            this.lbTamañoBulto.Size = new System.Drawing.Size(89, 13);
            this.lbTamañoBulto.TabIndex = 8;
            this.lbTamañoBulto.Text = "Tamaño del bulto";
            // 
            // ImposicionEnAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 755);
            this.Controls.Add(this.grbBultoCC);
            this.Controls.Add(this.btnCancelarImpoAgencia);
            this.Controls.Add(this.btnAceptarImpoAgencia);
            this.Controls.Add(this.grbParticular);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.grbAgencia);
            this.Controls.Add(this.grbCC);
            this.Controls.Add(this.grbDatosDestino);
            this.Controls.Add(this.grbDatosDestinatario);
            this.Name = "ImposicionEnAgencia";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ImposicionEnAgencia_Load);
            this.grbParticular.ResumeLayout(false);
            this.grbParticular.PerformLayout();
            this.grbAgencia.ResumeLayout(false);
            this.grbAgencia.PerformLayout();
            this.grbCC.ResumeLayout(false);
            this.grbCC.PerformLayout();
            this.grbDatosDestino.ResumeLayout(false);
            this.grbDatosDestino.PerformLayout();
            this.grbDatosDestinatario.ResumeLayout(false);
            this.grbDatosDestinatario.PerformLayout();
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            this.grbBultoCC.ResumeLayout(false);
            this.grbBultoCC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarImpoAgencia;
        private System.Windows.Forms.Button btnAceptarImpoAgencia;
        private System.Windows.Forms.GroupBox grbParticular;
        private System.Windows.Forms.TextBox txtDeptoDestino;
        private System.Windows.Forms.Label lbDepto;
        private System.Windows.Forms.TextBox txtAlturaDestino;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.TextBox txtCalleDestino;
        private System.Windows.Forms.Label lbCP;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label lbCalle;
        private System.Windows.Forms.TextBox txtCiudadDestino;
        private System.Windows.Forms.Label lbCiudadDestino;
        private System.Windows.Forms.GroupBox grbAgencia;
        private System.Windows.Forms.ComboBox cbAgencias;
        private System.Windows.Forms.Label lbAgencia;
        private System.Windows.Forms.GroupBox grbCC;
        private System.Windows.Forms.Label lbLocalidad;
        private System.Windows.Forms.GroupBox grbDatosDestino;
        private System.Windows.Forms.RadioButton rbParticular;
        private System.Windows.Forms.RadioButton rbCC;
        private System.Windows.Forms.RadioButton rbAgecnia;
        private System.Windows.Forms.GroupBox grbDatosDestinatario;
        private System.Windows.Forms.TextBox txtCuitDestinatario;
        private System.Windows.Forms.Label lbCuitDestinatario;
        private System.Windows.Forms.TextBox txtApellidoDestinatario;
        private System.Windows.Forms.Label lbApellidoDestinatario;
        private System.Windows.Forms.TextBox txtNombreDestinatario;
        private System.Windows.Forms.Label lbNombreDestinatario;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.TextBox lbCUITCliente;
        private System.Windows.Forms.Label lbCUITImpo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox grbBultoCC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTamañoVulto;
        private System.Windows.Forms.Label lbTamañoBulto;
    }
}
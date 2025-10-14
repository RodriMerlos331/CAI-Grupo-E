namespace Grupo_E.ImposicionEnCD
{
    partial class F03_ImposicionCDForm
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
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.DireccionParticularGrb = new System.Windows.Forms.GroupBox();
            this.DatosEntregaDomiclioText = new System.Windows.Forms.TextBox();
            this.lbCiudadDestino = new System.Windows.Forms.Label();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.CuitText = new System.Windows.Forms.TextBox();
            this.lbCUITImpo = new System.Windows.Forms.Label();
            this.AgenciaGrb = new System.Windows.Forms.GroupBox();
            this.AgenciaCbo = new System.Windows.Forms.ComboBox();
            this.lbAgencia = new System.Windows.Forms.Label();
            this.grbCC = new System.Windows.Forms.GroupBox();
            this.LocalidadCbo = new System.Windows.Forms.ComboBox();
            this.lbLocalidad = new System.Windows.Forms.Label();
            this.TipoEntregaGrb = new System.Windows.Forms.GroupBox();
            this.DomicilioRb = new System.Windows.Forms.RadioButton();
            this.CentroDistribucionRb = new System.Windows.Forms.RadioButton();
            this.AgenciaRb = new System.Windows.Forms.RadioButton();
            this.grbDatosDestinatario = new System.Windows.Forms.GroupBox();
            this.DatosDestinatarioText = new System.Windows.Forms.TextBox();
            this.lbNombreDestinatario = new System.Windows.Forms.Label();
            this.grbBultoCC = new System.Windows.Forms.GroupBox();
            this.TamanoBultoCbo = new System.Windows.Forms.ComboBox();
            this.lbTamañoBulto = new System.Windows.Forms.Label();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.CentroDistribucionGrb = new System.Windows.Forms.GroupBox();
            this.TerminalesCbo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DireccionParticularGrb.SuspendLayout();
            this.grbCliente.SuspendLayout();
            this.AgenciaGrb.SuspendLayout();
            this.grbCC.SuspendLayout();
            this.TipoEntregaGrb.SuspendLayout();
            this.grbDatosDestinatario.SuspendLayout();
            this.grbBultoCC.SuspendLayout();
            this.CentroDistribucionGrb.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(1214, 791);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(164, 35);
            this.CancelarBtn.TabIndex = 34;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // DireccionParticularGrb
            // 
            this.DireccionParticularGrb.Controls.Add(this.DatosEntregaDomiclioText);
            this.DireccionParticularGrb.Controls.Add(this.lbCiudadDestino);
            this.DireccionParticularGrb.Location = new System.Drawing.Point(18, 512);
            this.DireccionParticularGrb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DireccionParticularGrb.Name = "DireccionParticularGrb";
            this.DireccionParticularGrb.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DireccionParticularGrb.Size = new System.Drawing.Size(1359, 131);
            this.DireccionParticularGrb.TabIndex = 31;
            this.DireccionParticularGrb.TabStop = false;
            this.DireccionParticularGrb.Text = "Direccion particular";
            // 
            // DatosEntregaDomiclioText
            // 
            this.DatosEntregaDomiclioText.Location = new System.Drawing.Point(8, 78);
            this.DatosEntregaDomiclioText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatosEntregaDomiclioText.Name = "DatosEntregaDomiclioText";
            this.DatosEntregaDomiclioText.Size = new System.Drawing.Size(448, 26);
            this.DatosEntregaDomiclioText.TabIndex = 9;
            // 
            // lbCiudadDestino
            // 
            this.lbCiudadDestino.AutoSize = true;
            this.lbCiudadDestino.Location = new System.Drawing.Point(16, 46);
            this.lbCiudadDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCiudadDestino.Name = "lbCiudadDestino";
            this.lbCiudadDestino.Size = new System.Drawing.Size(427, 20);
            this.lbCiudadDestino.TabIndex = 8;
            this.lbCiudadDestino.Text = "Ciudad / Codigo Postal / Calle / Altura / Piso / Departamento";
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.CuitText);
            this.grbCliente.Controls.Add(this.lbCUITImpo);
            this.grbCliente.Location = new System.Drawing.Point(18, 31);
            this.grbCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbCliente.Size = new System.Drawing.Size(1359, 115);
            this.grbCliente.TabIndex = 29;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Cliente";
            // 
            // CuitText
            // 
            this.CuitText.Location = new System.Drawing.Point(68, 38);
            this.CuitText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CuitText.Name = "CuitText";
            this.CuitText.Size = new System.Drawing.Size(1270, 26);
            this.CuitText.TabIndex = 1;
            // 
            // lbCUITImpo
            // 
            this.lbCUITImpo.AutoSize = true;
            this.lbCUITImpo.Location = new System.Drawing.Point(10, 49);
            this.lbCUITImpo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCUITImpo.Name = "lbCUITImpo";
            this.lbCUITImpo.Size = new System.Drawing.Size(46, 20);
            this.lbCUITImpo.TabIndex = 0;
            this.lbCUITImpo.Text = "CUIT";
            // 
            // AgenciaGrb
            // 
            this.AgenciaGrb.Controls.Add(this.AgenciaCbo);
            this.AgenciaGrb.Controls.Add(this.lbAgencia);
            this.AgenciaGrb.Location = new System.Drawing.Point(756, 372);
            this.AgenciaGrb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgenciaGrb.Name = "AgenciaGrb";
            this.AgenciaGrb.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgenciaGrb.Size = new System.Drawing.Size(621, 131);
            this.AgenciaGrb.TabIndex = 30;
            this.AgenciaGrb.TabStop = false;
            this.AgenciaGrb.Text = "Agencia";
            // 
            // AgenciaCbo
            // 
            this.AgenciaCbo.FormattingEnabled = true;
            this.AgenciaCbo.Location = new System.Drawing.Point(16, 71);
            this.AgenciaCbo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgenciaCbo.Name = "AgenciaCbo";
            this.AgenciaCbo.Size = new System.Drawing.Size(350, 28);
            this.AgenciaCbo.TabIndex = 11;
            // 
            // lbAgencia
            // 
            this.lbAgencia.AutoSize = true;
            this.lbAgencia.Location = new System.Drawing.Point(12, 38);
            this.lbAgencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAgencia.Name = "lbAgencia";
            this.lbAgencia.Size = new System.Drawing.Size(246, 20);
            this.lbAgencia.TabIndex = 10;
            this.lbAgencia.Text = "Agencias disponibles en localidad";
            // 
            // grbCC
            // 
            this.grbCC.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.grbCC.Controls.Add(this.LocalidadCbo);
            this.grbCC.Controls.Add(this.lbLocalidad);
            this.grbCC.Location = new System.Drawing.Point(16, 155);
            this.grbCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbCC.Name = "grbCC";
            this.grbCC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbCC.Size = new System.Drawing.Size(1360, 97);
            this.grbCC.TabIndex = 26;
            this.grbCC.TabStop = false;
            this.grbCC.Text = "Destino";
            // 
            // LocalidadCbo
            // 
            this.LocalidadCbo.FormattingEnabled = true;
            this.LocalidadCbo.Location = new System.Drawing.Point(110, 46);
            this.LocalidadCbo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LocalidadCbo.Name = "LocalidadCbo";
            this.LocalidadCbo.Size = new System.Drawing.Size(1202, 28);
            this.LocalidadCbo.TabIndex = 12;
            this.LocalidadCbo.SelectedIndexChanged += new System.EventHandler(this.LocalidadCbo_SelectedIndexChanged);
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Location = new System.Drawing.Point(16, 46);
            this.lbLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(77, 20);
            this.lbLocalidad.TabIndex = 8;
            this.lbLocalidad.Text = "Localidad";
            // 
            // TipoEntregaGrb
            // 
            this.TipoEntregaGrb.Controls.Add(this.DomicilioRb);
            this.TipoEntregaGrb.Controls.Add(this.CentroDistribucionRb);
            this.TipoEntregaGrb.Controls.Add(this.AgenciaRb);
            this.TipoEntregaGrb.Location = new System.Drawing.Point(14, 263);
            this.TipoEntregaGrb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TipoEntregaGrb.Name = "TipoEntregaGrb";
            this.TipoEntregaGrb.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TipoEntregaGrb.Size = new System.Drawing.Size(1364, 98);
            this.TipoEntregaGrb.TabIndex = 27;
            this.TipoEntregaGrb.TabStop = false;
            this.TipoEntregaGrb.Text = "Tipo de entrega:";
            // 
            // DomicilioRb
            // 
            this.DomicilioRb.AutoSize = true;
            this.DomicilioRb.Location = new System.Drawing.Point(591, 38);
            this.DomicilioRb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DomicilioRb.Name = "DomicilioRb";
            this.DomicilioRb.Size = new System.Drawing.Size(169, 24);
            this.DomicilioRb.TabIndex = 2;
            this.DomicilioRb.TabStop = true;
            this.DomicilioRb.Text = "Direccion particular";
            this.DomicilioRb.UseVisualStyleBackColor = true;
            // 
            // CentroDistribucionRb
            // 
            this.CentroDistribucionRb.AutoSize = true;
            this.CentroDistribucionRb.Location = new System.Drawing.Point(46, 38);
            this.CentroDistribucionRb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CentroDistribucionRb.Name = "CentroDistribucionRb";
            this.CentroDistribucionRb.Size = new System.Drawing.Size(188, 24);
            this.CentroDistribucionRb.TabIndex = 0;
            this.CentroDistribucionRb.TabStop = true;
            this.CentroDistribucionRb.Text = "Centro de distribucion";
            this.CentroDistribucionRb.UseVisualStyleBackColor = true;
            this.CentroDistribucionRb.CheckedChanged += new System.EventHandler(this.CentroDistribucionRb_CheckedChanged);
            // 
            // AgenciaRb
            // 
            this.AgenciaRb.AutoSize = true;
            this.AgenciaRb.Location = new System.Drawing.Point(1184, 38);
            this.AgenciaRb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgenciaRb.Name = "AgenciaRb";
            this.AgenciaRb.Size = new System.Drawing.Size(92, 24);
            this.AgenciaRb.TabIndex = 1;
            this.AgenciaRb.TabStop = true;
            this.AgenciaRb.Text = "Agencia";
            this.AgenciaRb.UseVisualStyleBackColor = true;
            // 
            // grbDatosDestinatario
            // 
            this.grbDatosDestinatario.Controls.Add(this.DatosDestinatarioText);
            this.grbDatosDestinatario.Controls.Add(this.lbNombreDestinatario);
            this.grbDatosDestinatario.Location = new System.Drawing.Point(756, 652);
            this.grbDatosDestinatario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDatosDestinatario.Name = "grbDatosDestinatario";
            this.grbDatosDestinatario.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDatosDestinatario.Size = new System.Drawing.Size(621, 129);
            this.grbDatosDestinatario.TabIndex = 28;
            this.grbDatosDestinatario.TabStop = false;
            this.grbDatosDestinatario.Text = "Datos de destinatario";
            // 
            // DatosDestinatarioText
            // 
            this.DatosDestinatarioText.Location = new System.Drawing.Point(16, 77);
            this.DatosDestinatarioText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatosDestinatarioText.Name = "DatosDestinatarioText";
            this.DatosDestinatarioText.Size = new System.Drawing.Size(416, 26);
            this.DatosDestinatarioText.TabIndex = 3;
            // 
            // lbNombreDestinatario
            // 
            this.lbNombreDestinatario.AutoSize = true;
            this.lbNombreDestinatario.Location = new System.Drawing.Point(12, 40);
            this.lbNombreDestinatario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreDestinatario.Name = "lbNombreDestinatario";
            this.lbNombreDestinatario.Size = new System.Drawing.Size(173, 20);
            this.lbNombreDestinatario.TabIndex = 0;
            this.lbNombreDestinatario.Text = "Nombre / Apellido / DNI";
            // 
            // grbBultoCC
            // 
            this.grbBultoCC.Controls.Add(this.TamanoBultoCbo);
            this.grbBultoCC.Controls.Add(this.lbTamañoBulto);
            this.grbBultoCC.Location = new System.Drawing.Point(18, 652);
            this.grbBultoCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbBultoCC.Name = "grbBultoCC";
            this.grbBultoCC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbBultoCC.Size = new System.Drawing.Size(674, 129);
            this.grbBultoCC.TabIndex = 35;
            this.grbBultoCC.TabStop = false;
            this.grbBultoCC.Text = "Datos del bulto";
            // 
            // TamanoBultoCbo
            // 
            this.TamanoBultoCbo.FormattingEnabled = true;
            this.TamanoBultoCbo.Location = new System.Drawing.Point(20, 77);
            this.TamanoBultoCbo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TamanoBultoCbo.Name = "TamanoBultoCbo";
            this.TamanoBultoCbo.Size = new System.Drawing.Size(272, 28);
            this.TamanoBultoCbo.TabIndex = 10;
            // 
            // lbTamañoBulto
            // 
            this.lbTamañoBulto.AutoSize = true;
            this.lbTamañoBulto.Location = new System.Drawing.Point(15, 40);
            this.lbTamañoBulto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTamañoBulto.Name = "lbTamañoBulto";
            this.lbTamañoBulto.Size = new System.Drawing.Size(131, 20);
            this.lbTamañoBulto.TabIndex = 8;
            this.lbTamañoBulto.Text = "Tamaño del bulto";
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(1012, 791);
            this.AceptarBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(164, 35);
            this.AceptarBtn.TabIndex = 33;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // CentroDistribucionGrb
            // 
            this.CentroDistribucionGrb.Controls.Add(this.TerminalesCbo);
            this.CentroDistribucionGrb.Controls.Add(this.label1);
            this.CentroDistribucionGrb.Location = new System.Drawing.Point(14, 372);
            this.CentroDistribucionGrb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CentroDistribucionGrb.Name = "CentroDistribucionGrb";
            this.CentroDistribucionGrb.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CentroDistribucionGrb.Size = new System.Drawing.Size(726, 131);
            this.CentroDistribucionGrb.TabIndex = 31;
            this.CentroDistribucionGrb.TabStop = false;
            this.CentroDistribucionGrb.Text = "Centro de distribución";
            // 
            // TerminalesCbo
            // 
            this.TerminalesCbo.FormattingEnabled = true;
            this.TerminalesCbo.Location = new System.Drawing.Point(16, 71);
            this.TerminalesCbo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TerminalesCbo.Name = "TerminalesCbo";
            this.TerminalesCbo.Size = new System.Drawing.Size(350, 28);
            this.TerminalesCbo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Terminales (Centros de distribución) en localidad";
            // 
            // F03_ImposicionCDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 848);
            this.Controls.Add(this.CentroDistribucionGrb);
            this.Controls.Add(this.grbBultoCC);
            this.Controls.Add(this.TipoEntregaGrb);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.DireccionParticularGrb);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.AgenciaGrb);
            this.Controls.Add(this.grbCC);
            this.Controls.Add(this.grbDatosDestinatario);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "F03_ImposicionCDForm";
            this.Text = "Atención al cliente";
            this.Load += new System.EventHandler(this.F03_ImposicionCDForm_Load);
            this.DireccionParticularGrb.ResumeLayout(false);
            this.DireccionParticularGrb.PerformLayout();
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            this.AgenciaGrb.ResumeLayout(false);
            this.AgenciaGrb.PerformLayout();
            this.grbCC.ResumeLayout(false);
            this.grbCC.PerformLayout();
            this.TipoEntregaGrb.ResumeLayout(false);
            this.TipoEntregaGrb.PerformLayout();
            this.grbDatosDestinatario.ResumeLayout(false);
            this.grbDatosDestinatario.PerformLayout();
            this.grbBultoCC.ResumeLayout(false);
            this.grbBultoCC.PerformLayout();
            this.CentroDistribucionGrb.ResumeLayout(false);
            this.CentroDistribucionGrb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.GroupBox DireccionParticularGrb;
        private System.Windows.Forms.TextBox DatosEntregaDomiclioText;
        private System.Windows.Forms.Label lbCiudadDestino;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.TextBox CuitText;
        private System.Windows.Forms.Label lbCUITImpo;
        private System.Windows.Forms.GroupBox AgenciaGrb;
        private System.Windows.Forms.ComboBox AgenciaCbo;
        private System.Windows.Forms.Label lbAgencia;
        private System.Windows.Forms.GroupBox grbCC;
        private System.Windows.Forms.ComboBox LocalidadCbo;
        private System.Windows.Forms.Label lbLocalidad;
        private System.Windows.Forms.GroupBox TipoEntregaGrb;
        private System.Windows.Forms.RadioButton DomicilioRb;
        private System.Windows.Forms.RadioButton CentroDistribucionRb;
        private System.Windows.Forms.RadioButton AgenciaRb;
        private System.Windows.Forms.GroupBox grbDatosDestinatario;
        private System.Windows.Forms.TextBox DatosDestinatarioText;
        private System.Windows.Forms.Label lbNombreDestinatario;
        private System.Windows.Forms.GroupBox grbBultoCC;
        private System.Windows.Forms.ComboBox TamanoBultoCbo;
        private System.Windows.Forms.Label lbTamañoBulto;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.GroupBox CentroDistribucionGrb;
        private System.Windows.Forms.ComboBox TerminalesCbo;
        private System.Windows.Forms.Label label1;
    }
}
namespace FormResultadoCostoVsVentas
{
    partial class FormResultadoCostoVsVentas
    {

        private System.ComponentModel.IContainer components = null;


        /// <param name="disposing"
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.GroupBox();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.txtTotalCostos = new System.Windows.Forms.TextBox();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.dgvResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.lblCUIT.Location = new System.Drawing.Point(10, 22);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(38, 17);
            this.lblCUIT.TabIndex = 1;
            this.lblCUIT.Text = "CUIT:";
            this.lblCUIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCuit
            // 
            this.txtCuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuit.Location = new System.Drawing.Point(54, 20);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(143, 25);
            this.txtCuit.TabIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnConsultar.Location = new System.Drawing.Point(12, 77);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(397, 30);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Buscar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaFinal);
            this.groupBox1.Controls.Add(this.dtpFechaInicial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCUIT);
            this.groupBox1.Controls.Add(this.txtCuit);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 59);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.dtpFechaFinal.Location = new System.Drawing.Point(595, 20);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(184, 25);
            this.dtpFechaFinal.TabIndex = 6;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(307, 20);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(184, 25);
            this.dtpFechaInicial.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.label2.Location = new System.Drawing.Point(516, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Feha hasta:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.label1.Location = new System.Drawing.Point(223, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Feha desde:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvResultados
            // 
            this.dgvResultados.Controls.Add(this.txtTotalVentas);
            this.dgvResultados.Controls.Add(this.txtTotalCostos);
            this.dgvResultados.Controls.Add(this.txtNombreEmpresa);
            this.dgvResultados.Controls.Add(this.label5);
            this.dgvResultados.Controls.Add(this.label4);
            this.dgvResultados.Controls.Add(this.label3);
            this.dgvResultados.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.dgvResultados.Location = new System.Drawing.Point(138, 113);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(547, 81);
            this.dgvResultados.TabIndex = 12;
            this.dgvResultados.TabStop = false;
            this.dgvResultados.Text = "Resultado";
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalVentas.Location = new System.Drawing.Point(427, 28);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.Size = new System.Drawing.Size(102, 25);
            this.txtTotalVentas.TabIndex = 9;
            // 
            // txtTotalCostos
            // 
            this.txtTotalCostos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalCostos.Location = new System.Drawing.Point(252, 28);
            this.txtTotalCostos.Name = "txtTotalCostos";
            this.txtTotalCostos.Size = new System.Drawing.Size(102, 25);
            this.txtTotalCostos.TabIndex = 8;
            this.txtTotalCostos.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreEmpresa.Location = new System.Drawing.Point(80, 28);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(102, 25);
            this.txtNombreEmpresa.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ventas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Costos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Empresa:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnSalir.Location = new System.Drawing.Point(724, 207);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 25);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnLimpiar.Location = new System.Drawing.Point(415, 77);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(391, 30);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar Filtros";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FormResultadoCostoVsVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 243);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConsultar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormResultadoCostoVsVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Costos vs Ventas";
            this.Load += new System.EventHandler(this.FormResultadoCostoVsVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.dgvResultados.ResumeLayout(false);
            this.dgvResultados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox dgvResultados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalVentas;
        private System.Windows.Forms.TextBox txtTotalCostos;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
    }
}


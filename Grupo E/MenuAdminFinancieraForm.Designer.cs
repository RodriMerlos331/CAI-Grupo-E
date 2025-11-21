namespace Grupo_E
{
    partial class MenuAdminFinancieraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdminFinancieraForm));
            this.btnConsultarEstado = new System.Windows.Forms.Button();
            this.btnCostosVsVentas = new System.Windows.Forms.Button();
            this.btnEstadoCuentasCorrientes = new System.Windows.Forms.Button();
            this.btnGeneracionDeFacturas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultarEstado
            // 
            this.btnConsultarEstado.BackColor = System.Drawing.Color.LightGray;
            this.btnConsultarEstado.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEstado.Location = new System.Drawing.Point(45, 134);
            this.btnConsultarEstado.Name = "btnConsultarEstado";
            this.btnConsultarEstado.Size = new System.Drawing.Size(189, 36);
            this.btnConsultarEstado.TabIndex = 2;
            this.btnConsultarEstado.Text = "Consultar estado de encomienda";
            this.btnConsultarEstado.UseVisualStyleBackColor = false;
            this.btnConsultarEstado.Click += new System.EventHandler(this.btnConsultarEstado_Click);
            // 
            // btnCostosVsVentas
            // 
            this.btnCostosVsVentas.BackColor = System.Drawing.Color.LightGray;
            this.btnCostosVsVentas.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCostosVsVentas.Location = new System.Drawing.Point(286, 134);
            this.btnCostosVsVentas.Name = "btnCostosVsVentas";
            this.btnCostosVsVentas.Size = new System.Drawing.Size(189, 36);
            this.btnCostosVsVentas.TabIndex = 3;
            this.btnCostosVsVentas.Text = "Costos y Ventas";
            this.btnCostosVsVentas.UseVisualStyleBackColor = false;
            this.btnCostosVsVentas.Click += new System.EventHandler(this.btnCostosVsVentas_Click);
            // 
            // btnEstadoCuentasCorrientes
            // 
            this.btnEstadoCuentasCorrientes.BackColor = System.Drawing.Color.LightGray;
            this.btnEstadoCuentasCorrientes.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoCuentasCorrientes.Location = new System.Drawing.Point(45, 210);
            this.btnEstadoCuentasCorrientes.Name = "btnEstadoCuentasCorrientes";
            this.btnEstadoCuentasCorrientes.Size = new System.Drawing.Size(189, 36);
            this.btnEstadoCuentasCorrientes.TabIndex = 4;
            this.btnEstadoCuentasCorrientes.Text = "Estado de Cuentas Corrientes";
            this.btnEstadoCuentasCorrientes.UseVisualStyleBackColor = false;
            this.btnEstadoCuentasCorrientes.Click += new System.EventHandler(this.btnEstadoCuentasCorrientes_Click);
            // 
            // btnGeneracionDeFacturas
            // 
            this.btnGeneracionDeFacturas.BackColor = System.Drawing.Color.LightGray;
            this.btnGeneracionDeFacturas.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneracionDeFacturas.Location = new System.Drawing.Point(286, 210);
            this.btnGeneracionDeFacturas.Name = "btnGeneracionDeFacturas";
            this.btnGeneracionDeFacturas.Size = new System.Drawing.Size(189, 36);
            this.btnGeneracionDeFacturas.TabIndex = 5;
            this.btnGeneracionDeFacturas.Text = "Generacion de facturas";
            this.btnGeneracionDeFacturas.UseVisualStyleBackColor = false;
            this.btnGeneracionDeFacturas.Click += new System.EventHandler(this.btnGeneracionDeFacturas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(64, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 93);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Menú principal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Liberation Sans", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Administración financiera";
            // 
            // MenuAdminFinancieraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 298);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGeneracionDeFacturas);
            this.Controls.Add(this.btnEstadoCuentasCorrientes);
            this.Controls.Add(this.btnCostosVsVentas);
            this.Controls.Add(this.btnConsultarEstado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAdminFinancieraForm";
            this.Text = "Menú Administración financiera";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarEstado;
        private System.Windows.Forms.Button btnCostosVsVentas;
        private System.Windows.Forms.Button btnEstadoCuentasCorrientes;
        private System.Windows.Forms.Button btnGeneracionDeFacturas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
using System;

namespace Grupo_E
{
    partial class MenuPrincipalForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarEstado = new System.Windows.Forms.Button();
            this.btnCostosVsVentas = new System.Windows.Forms.Button();
            this.btnEstadoCuentasCorrientes = new System.Windows.Forms.Button();
            this.btnGeneracionDeFacturas = new System.Windows.Forms.Button();
            this.btnGestionarFletero = new System.Windows.Forms.Button();
            this.btnGestionarOmnibus = new System.Windows.Forms.Button();
            this.btnImposicionEnAgencia = new System.Windows.Forms.Button();
            this.btnImposicionEnCallCenter = new System.Windows.Forms.Button();
            this.btnImposicionEnCD = new System.Windows.Forms.Button();
            this.btnRendicionHDRAgencia = new System.Windows.Forms.Button();
            this.btnRetirarEnAgencia = new System.Windows.Forms.Button();
            this.btnRetirarEnCD = new System.Windows.Forms.Button();
            this.CentroDeDistribucionActualCombo = new System.Windows.Forms.ComboBox();
            this.AgenciaActualCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu principal";
            // 
            // btnConsultarEstado
            // 
            this.btnConsultarEstado.Location = new System.Drawing.Point(115, 156);
            this.btnConsultarEstado.Name = "btnConsultarEstado";
            this.btnConsultarEstado.Size = new System.Drawing.Size(189, 36);
            this.btnConsultarEstado.TabIndex = 1;
            this.btnConsultarEstado.Text = "Consultar estado de encomienda";
            this.btnConsultarEstado.UseVisualStyleBackColor = true;
            // 
            // btnCostosVsVentas
            // 
            this.btnCostosVsVentas.Location = new System.Drawing.Point(115, 198);
            this.btnCostosVsVentas.Name = "btnCostosVsVentas";
            this.btnCostosVsVentas.Size = new System.Drawing.Size(189, 36);
            this.btnCostosVsVentas.TabIndex = 2;
            this.btnCostosVsVentas.Text = "Costos y Ventas";
            this.btnCostosVsVentas.UseVisualStyleBackColor = true;
            // 
            // btnEstadoCuentasCorrientes
            // 
            this.btnEstadoCuentasCorrientes.Location = new System.Drawing.Point(115, 240);
            this.btnEstadoCuentasCorrientes.Name = "btnEstadoCuentasCorrientes";
            this.btnEstadoCuentasCorrientes.Size = new System.Drawing.Size(189, 36);
            this.btnEstadoCuentasCorrientes.TabIndex = 3;
            this.btnEstadoCuentasCorrientes.Text = "Estado de Cuentas Corrientes";
            this.btnEstadoCuentasCorrientes.UseVisualStyleBackColor = true;
            // 
            // btnGeneracionDeFacturas
            // 
            this.btnGeneracionDeFacturas.Location = new System.Drawing.Point(115, 282);
            this.btnGeneracionDeFacturas.Name = "btnGeneracionDeFacturas";
            this.btnGeneracionDeFacturas.Size = new System.Drawing.Size(189, 36);
            this.btnGeneracionDeFacturas.TabIndex = 4;
            this.btnGeneracionDeFacturas.Text = "Generacion de facturas";
            this.btnGeneracionDeFacturas.UseVisualStyleBackColor = true;
            // 
            // btnGestionarFletero
            // 
            this.btnGestionarFletero.Location = new System.Drawing.Point(115, 324);
            this.btnGestionarFletero.Name = "btnGestionarFletero";
            this.btnGestionarFletero.Size = new System.Drawing.Size(189, 36);
            this.btnGestionarFletero.TabIndex = 5;
            this.btnGestionarFletero.Text = "Gestion de fleteros";
            this.btnGestionarFletero.UseVisualStyleBackColor = true;
            // 
            // btnGestionarOmnibus
            // 
            this.btnGestionarOmnibus.Location = new System.Drawing.Point(115, 362);
            this.btnGestionarOmnibus.Name = "btnGestionarOmnibus";
            this.btnGestionarOmnibus.Size = new System.Drawing.Size(189, 36);
            this.btnGestionarOmnibus.TabIndex = 6;
            this.btnGestionarOmnibus.Text = "Gestion de Omnibus";
            this.btnGestionarOmnibus.UseVisualStyleBackColor = true;
            // 
            // btnImposicionEnAgencia
            // 
            this.btnImposicionEnAgencia.Location = new System.Drawing.Point(115, 404);
            this.btnImposicionEnAgencia.Name = "btnImposicionEnAgencia";
            this.btnImposicionEnAgencia.Size = new System.Drawing.Size(189, 36);
            this.btnImposicionEnAgencia.TabIndex = 7;
            this.btnImposicionEnAgencia.Text = "Imposicion en Agencia";
            this.btnImposicionEnAgencia.UseVisualStyleBackColor = true;
            // 
            // btnImposicionEnCallCenter
            // 
            this.btnImposicionEnCallCenter.Location = new System.Drawing.Point(115, 446);
            this.btnImposicionEnCallCenter.Name = "btnImposicionEnCallCenter";
            this.btnImposicionEnCallCenter.Size = new System.Drawing.Size(189, 36);
            this.btnImposicionEnCallCenter.TabIndex = 8;
            this.btnImposicionEnCallCenter.Text = "Imposicion en Call Center";
            this.btnImposicionEnCallCenter.UseVisualStyleBackColor = true;
            // 
            // btnImposicionEnCD
            // 
            this.btnImposicionEnCD.Location = new System.Drawing.Point(115, 488);
            this.btnImposicionEnCD.Name = "btnImposicionEnCD";
            this.btnImposicionEnCD.Size = new System.Drawing.Size(189, 36);
            this.btnImposicionEnCD.TabIndex = 9;
            this.btnImposicionEnCD.Text = "Imposicion en Centro de Distribucion";
            this.btnImposicionEnCD.UseVisualStyleBackColor = true;
            // 
            // btnRendicionHDRAgencia
            // 
            this.btnRendicionHDRAgencia.Location = new System.Drawing.Point(115, 530);
            this.btnRendicionHDRAgencia.Name = "btnRendicionHDRAgencia";
            this.btnRendicionHDRAgencia.Size = new System.Drawing.Size(189, 36);
            this.btnRendicionHDRAgencia.TabIndex = 10;
            this.btnRendicionHDRAgencia.Text = "Entrega y recepcion en Agencia";
            this.btnRendicionHDRAgencia.UseVisualStyleBackColor = true;
            // 
            // btnRetirarEnAgencia
            // 
            this.btnRetirarEnAgencia.Location = new System.Drawing.Point(115, 572);
            this.btnRetirarEnAgencia.Name = "btnRetirarEnAgencia";
            this.btnRetirarEnAgencia.Size = new System.Drawing.Size(189, 36);
            this.btnRetirarEnAgencia.TabIndex = 11;
            this.btnRetirarEnAgencia.Text = "Retiro en Agencia";
            this.btnRetirarEnAgencia.UseVisualStyleBackColor = true;
            // 
            // btnRetirarEnCD
            // 
            this.btnRetirarEnCD.Location = new System.Drawing.Point(115, 614);
            this.btnRetirarEnCD.Name = "btnRetirarEnCD";
            this.btnRetirarEnCD.Size = new System.Drawing.Size(189, 36);
            this.btnRetirarEnCD.TabIndex = 12;
            this.btnRetirarEnCD.Text = "Retiro en Centro de Distribucion";
            this.btnRetirarEnCD.UseVisualStyleBackColor = true;
            // 
            // CentroDeDistribucionActualCombo
            // 
            this.CentroDeDistribucionActualCombo.FormattingEnabled = true;
            this.CentroDeDistribucionActualCombo.Location = new System.Drawing.Point(156, 12);
            this.CentroDeDistribucionActualCombo.Name = "CentroDeDistribucionActualCombo";
            this.CentroDeDistribucionActualCombo.Size = new System.Drawing.Size(247, 21);
            this.CentroDeDistribucionActualCombo.TabIndex = 13;
            this.CentroDeDistribucionActualCombo.SelectedIndexChanged += new System.EventHandler(this.CentroDeDistribucionActualCombo_SelectedIndexChanged);
            // 
            // AgenciaActualCombo
            // 
            this.AgenciaActualCombo.FormattingEnabled = true;
            this.AgenciaActualCombo.Location = new System.Drawing.Point(156, 50);
            this.AgenciaActualCombo.Name = "AgenciaActualCombo";
            this.AgenciaActualCombo.Size = new System.Drawing.Size(247, 21);
            this.AgenciaActualCombo.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Centro de distribucion actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Agencia actual";
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 684);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AgenciaActualCombo);
            this.Controls.Add(this.CentroDeDistribucionActualCombo);
            this.Controls.Add(this.btnRetirarEnCD);
            this.Controls.Add(this.btnRetirarEnAgencia);
            this.Controls.Add(this.btnRendicionHDRAgencia);
            this.Controls.Add(this.btnImposicionEnCD);
            this.Controls.Add(this.btnImposicionEnCallCenter);
            this.Controls.Add(this.btnImposicionEnAgencia);
            this.Controls.Add(this.btnGestionarOmnibus);
            this.Controls.Add(this.btnGestionarFletero);
            this.Controls.Add(this.btnGeneracionDeFacturas);
            this.Controls.Add(this.btnEstadoCuentasCorrientes);
            this.Controls.Add(this.btnCostosVsVentas);
            this.Controls.Add(this.btnConsultarEstado);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuPrincipalForm";
            this.Text = "MenuPrincipalForm";
            this.Load += new System.EventHandler(this.MenuPrincipalForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarEstado;
        private System.Windows.Forms.Button btnCostosVsVentas;
        private System.Windows.Forms.Button btnEstadoCuentasCorrientes;
        private System.Windows.Forms.Button btnGeneracionDeFacturas;
        private System.Windows.Forms.Button btnGestionarFletero;
        private System.Windows.Forms.Button btnGestionarOmnibus;
        private System.Windows.Forms.Button btnImposicionEnAgencia;
        private System.Windows.Forms.Button btnImposicionEnCallCenter;
        private System.Windows.Forms.Button btnImposicionEnCD;
        private System.Windows.Forms.Button btnRendicionHDRAgencia;
        private System.Windows.Forms.Button btnRetirarEnAgencia;
        private System.Windows.Forms.Button btnRetirarEnCD;
        private System.Windows.Forms.ComboBox CentroDeDistribucionActualCombo;
        private System.Windows.Forms.ComboBox AgenciaActualCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
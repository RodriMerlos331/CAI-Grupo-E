namespace Grupo_E
{
    partial class MenuAgenciaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAgenciaForm));
            this.btnImposicionEnAgencia = new System.Windows.Forms.Button();
            this.btnRendicionHDRAgencia = new System.Windows.Forms.Button();
            this.btnRetirarEnAgencia = new System.Windows.Forms.Button();
            this.btnConsultarEstado = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AgenciaActualCombo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImposicionEnAgencia
            // 
            this.btnImposicionEnAgencia.BackColor = System.Drawing.Color.LightGray;
            this.btnImposicionEnAgencia.Font = new System.Drawing.Font("Liberation Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImposicionEnAgencia.Location = new System.Drawing.Point(285, 165);
            this.btnImposicionEnAgencia.Name = "btnImposicionEnAgencia";
            this.btnImposicionEnAgencia.Size = new System.Drawing.Size(189, 36);
            this.btnImposicionEnAgencia.TabIndex = 8;
            this.btnImposicionEnAgencia.Text = "Imposicion en Agencia";
            this.btnImposicionEnAgencia.UseVisualStyleBackColor = false;
            this.btnImposicionEnAgencia.Click += new System.EventHandler(this.btnImposicionEnAgencia_Click);
            // 
            // btnRendicionHDRAgencia
            // 
            this.btnRendicionHDRAgencia.BackColor = System.Drawing.Color.LightGray;
            this.btnRendicionHDRAgencia.Font = new System.Drawing.Font("Liberation Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRendicionHDRAgencia.Location = new System.Drawing.Point(76, 221);
            this.btnRendicionHDRAgencia.Name = "btnRendicionHDRAgencia";
            this.btnRendicionHDRAgencia.Size = new System.Drawing.Size(189, 36);
            this.btnRendicionHDRAgencia.TabIndex = 11;
            this.btnRendicionHDRAgencia.Text = "Entrega y recepcion en Agencia";
            this.btnRendicionHDRAgencia.UseVisualStyleBackColor = false;
            this.btnRendicionHDRAgencia.Click += new System.EventHandler(this.btnRendicionHDRAgencia_Click);
            // 
            // btnRetirarEnAgencia
            // 
            this.btnRetirarEnAgencia.BackColor = System.Drawing.Color.LightGray;
            this.btnRetirarEnAgencia.Font = new System.Drawing.Font("Liberation Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirarEnAgencia.Location = new System.Drawing.Point(285, 221);
            this.btnRetirarEnAgencia.Name = "btnRetirarEnAgencia";
            this.btnRetirarEnAgencia.Size = new System.Drawing.Size(189, 36);
            this.btnRetirarEnAgencia.TabIndex = 12;
            this.btnRetirarEnAgencia.Text = "Retiro en Agencia";
            this.btnRetirarEnAgencia.UseVisualStyleBackColor = false;
            this.btnRetirarEnAgencia.Click += new System.EventHandler(this.btnRetirarEnAgencia_Click);
            // 
            // btnConsultarEstado
            // 
            this.btnConsultarEstado.BackColor = System.Drawing.Color.LightGray;
            this.btnConsultarEstado.Font = new System.Drawing.Font("Liberation Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEstado.Location = new System.Drawing.Point(76, 165);
            this.btnConsultarEstado.Name = "btnConsultarEstado";
            this.btnConsultarEstado.Size = new System.Drawing.Size(189, 36);
            this.btnConsultarEstado.TabIndex = 13;
            this.btnConsultarEstado.Text = "Consultar estado de encomienda";
            this.btnConsultarEstado.UseVisualStyleBackColor = false;
            this.btnConsultarEstado.Click += new System.EventHandler(this.btnConsultarEstado_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Liberation Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "Agencia actual";
            // 
            // AgenciaActualCombo
            // 
            this.AgenciaActualCombo.FormattingEnabled = true;
            this.AgenciaActualCombo.Location = new System.Drawing.Point(198, 120);
            this.AgenciaActualCombo.Name = "AgenciaActualCombo";
            this.AgenciaActualCombo.Size = new System.Drawing.Size(247, 21);
            this.AgenciaActualCombo.TabIndex = 18;
            this.AgenciaActualCombo.SelectedIndexChanged += new System.EventHandler(this.AgenciaActualCombo_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(76, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 93);
            this.groupBox2.TabIndex = 20;
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
            this.label1.Location = new System.Drawing.Point(131, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Agencia";
            // 
            // MenuAgenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 288);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AgenciaActualCombo);
            this.Controls.Add(this.btnConsultarEstado);
            this.Controls.Add(this.btnRetirarEnAgencia);
            this.Controls.Add(this.btnRendicionHDRAgencia);
            this.Controls.Add(this.btnImposicionEnAgencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAgenciaForm";
            this.Text = "Menú Agencia";
            this.Load += new System.EventHandler(this.MenuAgenciaForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImposicionEnAgencia;
        private System.Windows.Forms.Button btnRendicionHDRAgencia;
        private System.Windows.Forms.Button btnRetirarEnAgencia;
        private System.Windows.Forms.Button btnConsultarEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AgenciaActualCombo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
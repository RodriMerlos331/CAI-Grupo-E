namespace Grupo_E
{
    partial class MenuInicialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicialForm));
            this.btnMenuAgencia = new System.Windows.Forms.Button();
            this.btnMenuCentroDistribución = new System.Windows.Forms.Button();
            this.btnMenuAdministracion = new System.Windows.Forms.Button();
            this.btnMenuCallCenter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenuAgencia
            // 
            this.btnMenuAgencia.BackColor = System.Drawing.Color.LightGray;
            this.btnMenuAgencia.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAgencia.Location = new System.Drawing.Point(286, 32);
            this.btnMenuAgencia.Name = "btnMenuAgencia";
            this.btnMenuAgencia.Size = new System.Drawing.Size(189, 36);
            this.btnMenuAgencia.TabIndex = 2;
            this.btnMenuAgencia.Text = "Agencia";
            this.btnMenuAgencia.UseVisualStyleBackColor = false;
            this.btnMenuAgencia.Click += new System.EventHandler(this.btnMenuAgencia_Click);
            // 
            // btnMenuCentroDistribución
            // 
            this.btnMenuCentroDistribución.BackColor = System.Drawing.Color.LightGray;
            this.btnMenuCentroDistribución.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCentroDistribución.Location = new System.Drawing.Point(28, 98);
            this.btnMenuCentroDistribución.Name = "btnMenuCentroDistribución";
            this.btnMenuCentroDistribución.Size = new System.Drawing.Size(189, 36);
            this.btnMenuCentroDistribución.TabIndex = 3;
            this.btnMenuCentroDistribución.Text = "Centro de distribución";
            this.btnMenuCentroDistribución.UseVisualStyleBackColor = false;
            this.btnMenuCentroDistribución.Click += new System.EventHandler(this.btnMenuCentroDistribución_Click);
            // 
            // btnMenuAdministracion
            // 
            this.btnMenuAdministracion.BackColor = System.Drawing.Color.LightGray;
            this.btnMenuAdministracion.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAdministracion.Location = new System.Drawing.Point(286, 98);
            this.btnMenuAdministracion.Name = "btnMenuAdministracion";
            this.btnMenuAdministracion.Size = new System.Drawing.Size(189, 36);
            this.btnMenuAdministracion.TabIndex = 4;
            this.btnMenuAdministracion.Text = "Administración financiera";
            this.btnMenuAdministracion.UseVisualStyleBackColor = false;
            this.btnMenuAdministracion.Click += new System.EventHandler(this.btnMenuAdministracion_Click);
            // 
            // btnMenuCallCenter
            // 
            this.btnMenuCallCenter.BackColor = System.Drawing.Color.LightGray;
            this.btnMenuCallCenter.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCallCenter.Location = new System.Drawing.Point(28, 32);
            this.btnMenuCallCenter.Name = "btnMenuCallCenter";
            this.btnMenuCallCenter.Size = new System.Drawing.Size(189, 36);
            this.btnMenuCallCenter.TabIndex = 5;
            this.btnMenuCallCenter.Text = "Call center";
            this.btnMenuCallCenter.UseVisualStyleBackColor = false;
            this.btnMenuCallCenter.Click += new System.EventHandler(this.btnMenuCallCenter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Liberation Sans", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "TUTASA S.A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Menú principal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMenuCallCenter);
            this.groupBox1.Controls.Add(this.btnMenuAdministracion);
            this.groupBox1.Controls.Add(this.btnMenuCentroDistribución);
            this.groupBox1.Controls.Add(this.btnMenuAgencia);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 155);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una opción para continuar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(152, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 98);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // MenuInicialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 323);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuInicialForm";
            this.Text = "Menú principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuAgencia;
        private System.Windows.Forms.Button btnMenuCentroDistribución;
        private System.Windows.Forms.Button btnMenuAdministracion;
        private System.Windows.Forms.Button btnMenuCallCenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
namespace Grupo_E.RetirarEnCD
{
    partial class F07_RetirarEnCDForm
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
            this.btnEntregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DNIText = new System.Windows.Forms.TextBox();
            this.ApellidoText = new System.Windows.Forms.TextBox();
            this.NombreText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.NumeroTrackingText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEntregar
            // 
            this.btnEntregar.Location = new System.Drawing.Point(12, 336);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(186, 23);
            this.btnEntregar.TabIndex = 7;
            this.btnEntregar.Text = "Entregar encomienda";
            this.btnEntregar.UseVisualStyleBackColor = true;
            this.btnEntregar.Click += new System.EventHandler(this.btnEntregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(210, 336);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(198, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DNIText);
            this.groupBox2.Controls.Add(this.ApellidoText);
            this.groupBox2.Controls.Add(this.NombreText);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 187);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de retiro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // DNIText
            // 
            this.DNIText.Location = new System.Drawing.Point(9, 145);
            this.DNIText.Name = "DNIText";
            this.DNIText.Size = new System.Drawing.Size(365, 20);
            this.DNIText.TabIndex = 2;
            // 
            // ApellidoText
            // 
            this.ApellidoText.Location = new System.Drawing.Point(9, 97);
            this.ApellidoText.Name = "ApellidoText";
            this.ApellidoText.Size = new System.Drawing.Size(365, 20);
            this.ApellidoText.TabIndex = 1;
            // 
            // NombreText
            // 
            this.NombreText.Location = new System.Drawing.Point(9, 52);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(365, 20);
            this.NombreText.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.NumeroTrackingText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda del pedido en CD";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(158, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(277, 47);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(113, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar filtro";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // NumeroTrackingText
            // 
            this.NumeroTrackingText.Location = new System.Drawing.Point(6, 47);
            this.NumeroTrackingText.Name = "NumeroTrackingText";
            this.NumeroTrackingText.Size = new System.Drawing.Size(140, 20);
            this.NumeroTrackingText.TabIndex = 1;
            this.NumeroTrackingText.TextChanged += new System.EventHandler(this.NumeroTrackingText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de tracking";
            // 
            // F07_RetirarEnCDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 382);
            this.Controls.Add(this.btnEntregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "F07_RetirarEnCDForm";
            this.Text = "Retiro en CD";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DNIText;
        private System.Windows.Forms.TextBox ApellidoText;
        private System.Windows.Forms.TextBox NombreText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox NumeroTrackingText;
        private System.Windows.Forms.Label label1;
    }
}
namespace Grupo_E.RendicionHDRAgencia
{
    partial class RendicionHDRAgenciaForm
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
            this.btnCancelarRendiAgencia = new System.Windows.Forms.Button();
            this.btnAceptarRendiAgencia = new System.Windows.Forms.Button();
            this.grbResumen = new System.Windows.Forms.GroupBox();
            this.lbResumen = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbRendicionHDR = new System.Windows.Forms.GroupBox();
            this.rbNoCumplida = new System.Windows.Forms.RadioButton();
            this.rbCumplida = new System.Windows.Forms.RadioButton();
            this.lbIDHDR = new System.Windows.Forms.Label();
            this.txtIDHDR = new System.Windows.Forms.TextBox();
            this.btnActualizarHDR = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbResumen.SuspendLayout();
            this.grbRendicionHDR.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelarRendiAgencia
            // 
            this.btnCancelarRendiAgencia.Location = new System.Drawing.Point(309, 376);
            this.btnCancelarRendiAgencia.Name = "btnCancelarRendiAgencia";
            this.btnCancelarRendiAgencia.Size = new System.Drawing.Size(72, 20);
            this.btnCancelarRendiAgencia.TabIndex = 15;
            this.btnCancelarRendiAgencia.Text = "Cancelar";
            this.btnCancelarRendiAgencia.UseVisualStyleBackColor = true;
            // 
            // btnAceptarRendiAgencia
            // 
            this.btnAceptarRendiAgencia.Location = new System.Drawing.Point(220, 376);
            this.btnAceptarRendiAgencia.Name = "btnAceptarRendiAgencia";
            this.btnAceptarRendiAgencia.Size = new System.Drawing.Size(72, 20);
            this.btnAceptarRendiAgencia.TabIndex = 14;
            this.btnAceptarRendiAgencia.Text = "Aceptar";
            this.btnAceptarRendiAgencia.UseVisualStyleBackColor = true;
            // 
            // grbResumen
            // 
            this.grbResumen.Controls.Add(this.lbResumen);
            this.grbResumen.Controls.Add(this.listView1);
            this.grbResumen.Location = new System.Drawing.Point(12, 216);
            this.grbResumen.Name = "grbResumen";
            this.grbResumen.Size = new System.Drawing.Size(369, 143);
            this.grbResumen.TabIndex = 13;
            this.grbResumen.TabStop = false;
            this.grbResumen.Text = "Resumen";
            // 
            // lbResumen
            // 
            this.lbResumen.AutoSize = true;
            this.lbResumen.Location = new System.Drawing.Point(10, 16);
            this.lbResumen.Name = "lbResumen";
            this.lbResumen.Size = new System.Drawing.Size(184, 13);
            this.lbResumen.TabIndex = 4;
            this.lbResumen.Text = "Resumen de hojas de ruta cumplidas:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(339, 88);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID HDR";
            // 
            // grbRendicionHDR
            // 
            this.grbRendicionHDR.Controls.Add(this.rbNoCumplida);
            this.grbRendicionHDR.Controls.Add(this.rbCumplida);
            this.grbRendicionHDR.Controls.Add(this.lbIDHDR);
            this.grbRendicionHDR.Controls.Add(this.txtIDHDR);
            this.grbRendicionHDR.Controls.Add(this.btnActualizarHDR);
            this.grbRendicionHDR.Location = new System.Drawing.Point(12, 56);
            this.grbRendicionHDR.Name = "grbRendicionHDR";
            this.grbRendicionHDR.Size = new System.Drawing.Size(369, 154);
            this.grbRendicionHDR.TabIndex = 12;
            this.grbRendicionHDR.TabStop = false;
            this.grbRendicionHDR.Text = "Rendicion de hoja de ruta";
            // 
            // rbNoCumplida
            // 
            this.rbNoCumplida.AutoSize = true;
            this.rbNoCumplida.Location = new System.Drawing.Point(245, 79);
            this.rbNoCumplida.Name = "rbNoCumplida";
            this.rbNoCumplida.Size = new System.Drawing.Size(77, 17);
            this.rbNoCumplida.TabIndex = 13;
            this.rbNoCumplida.TabStop = true;
            this.rbNoCumplida.Text = "No retirada";
            this.rbNoCumplida.UseVisualStyleBackColor = true;
            // 
            // rbCumplida
            // 
            this.rbCumplida.AutoSize = true;
            this.rbCumplida.Location = new System.Drawing.Point(28, 79);
            this.rbCumplida.Name = "rbCumplida";
            this.rbCumplida.Size = new System.Drawing.Size(65, 17);
            this.rbCumplida.TabIndex = 12;
            this.rbCumplida.TabStop = true;
            this.rbCumplida.Text = "Retirada";
            this.rbCumplida.UseVisualStyleBackColor = true;
            // 
            // lbIDHDR
            // 
            this.lbIDHDR.AutoSize = true;
            this.lbIDHDR.Location = new System.Drawing.Point(12, 27);
            this.lbIDHDR.Name = "lbIDHDR";
            this.lbIDHDR.Size = new System.Drawing.Size(79, 13);
            this.lbIDHDR.TabIndex = 11;
            this.lbIDHDR.Text = "ID Hoja de ruta";
            // 
            // txtIDHDR
            // 
            this.txtIDHDR.Location = new System.Drawing.Point(12, 43);
            this.txtIDHDR.Name = "txtIDHDR";
            this.txtIDHDR.Size = new System.Drawing.Size(142, 20);
            this.txtIDHDR.TabIndex = 10;
            // 
            // btnActualizarHDR
            // 
            this.btnActualizarHDR.Location = new System.Drawing.Point(15, 117);
            this.btnActualizarHDR.Name = "btnActualizarHDR";
            this.btnActualizarHDR.Size = new System.Drawing.Size(333, 20);
            this.btnActualizarHDR.TabIndex = 8;
            this.btnActualizarHDR.Text = "Actualizar hoja de ruta";
            this.btnActualizarHDR.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 42);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rendicion hoja de ruta de retiro";
            // 
            // RendicionHDRAgenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 407);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelarRendiAgencia);
            this.Controls.Add(this.btnAceptarRendiAgencia);
            this.Controls.Add(this.grbResumen);
            this.Controls.Add(this.grbRendicionHDR);
            this.Name = "RendicionHDRAgenciaForm";
            this.Text = "RendicionHDRAgenciaForm";
            this.grbResumen.ResumeLayout(false);
            this.grbResumen.PerformLayout();
            this.grbRendicionHDR.ResumeLayout(false);
            this.grbRendicionHDR.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarRendiAgencia;
        private System.Windows.Forms.Button btnAceptarRendiAgencia;
        private System.Windows.Forms.GroupBox grbResumen;
        private System.Windows.Forms.Label lbResumen;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox grbRendicionHDR;
        private System.Windows.Forms.RadioButton rbNoCumplida;
        private System.Windows.Forms.RadioButton rbCumplida;
        private System.Windows.Forms.Label lbIDHDR;
        private System.Windows.Forms.TextBox txtIDHDR;
        private System.Windows.Forms.Button btnActualizarHDR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}
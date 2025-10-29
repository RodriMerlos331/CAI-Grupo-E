namespace Grupo_E.GestionarOmnibus
{

    partial class F04_GestionarOmnibusForm
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstBajar = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCantidadRecepcion = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstSubir = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCantidadDespacho = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtPatente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(563, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búscar Omnibus";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(405, 46);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(149, 28);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar filtro";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(253, 46);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(145, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(13, 48);
            this.txtPatente.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(233, 22);
            this.txtPatente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstBajar);
            this.groupBox2.Controls.Add(this.lblCantidadRecepcion);
            this.groupBox2.Location = new System.Drawing.Point(20, 150);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(563, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bajar";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lstBajar
            // 
            this.lstBajar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader22,
            this.columnHeader25});
            this.lstBajar.HideSelection = false;
            this.lstBajar.Location = new System.Drawing.Point(8, 76);
            this.lstBajar.Margin = new System.Windows.Forms.Padding(4);
            this.lstBajar.Name = "lstBajar";
            this.lstBajar.Size = new System.Drawing.Size(547, 123);
            this.lstBajar.TabIndex = 14;
            this.lstBajar.UseCompatibleStateImageBehavior = false;
            this.lstBajar.View = System.Windows.Forms.View.Details;
            this.lstBajar.SelectedIndexChanged += new System.EventHandler(this.lstBajar_SelectedIndexChanged);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "ID HDR";
            this.columnHeader13.Width = 102;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Numero de Tracking";
            this.columnHeader22.Width = 282;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Tipo de Bulto";
            this.columnHeader25.Width = 155;
            // 
            // lblCantidadRecepcion
            // 
            this.lblCantidadRecepcion.AutoSize = true;
            this.lblCantidadRecepcion.Location = new System.Drawing.Point(9, 31);
            this.lblCantidadRecepcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadRecepcion.Name = "lblCantidadRecepcion";
            this.lblCantidadRecepcion.Size = new System.Drawing.Size(112, 16);
            this.lblCantidadRecepcion.TabIndex = 0;
            this.lblCantidadRecepcion.Text = "Encomiendas: XX";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstSubir);
            this.groupBox3.Controls.Add(this.lblCantidadDespacho);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 386);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(563, 202);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Subir";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lstSubir
            // 
            this.lstSubir.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstSubir.HideSelection = false;
            this.lstSubir.Location = new System.Drawing.Point(13, 68);
            this.lstSubir.Margin = new System.Windows.Forms.Padding(4);
            this.lstSubir.Name = "lstSubir";
            this.lstSubir.Size = new System.Drawing.Size(543, 123);
            this.lstSubir.TabIndex = 17;
            this.lstSubir.UseCompatibleStateImageBehavior = false;
            this.lstSubir.View = System.Windows.Forms.View.Details;
            this.lstSubir.SelectedIndexChanged += new System.EventHandler(this.lstSubir_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID HDR";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Numero de Tracking";
            this.columnHeader2.Width = 285;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipo de Bulto";
            this.columnHeader3.Width = 155;
            // 
            // lblCantidadDespacho
            // 
            this.lblCantidadDespacho.AutoSize = true;
            this.lblCantidadDespacho.Location = new System.Drawing.Point(8, 31);
            this.lblCantidadDespacho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadDespacho.Name = "lblCantidadDespacho";
            this.lblCantidadDespacho.Size = new System.Drawing.Size(112, 16);
            this.lblCantidadDespacho.TabIndex = 1;
            this.lblCantidadDespacho.Text = "Encomiendas: XX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 869);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 15;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(20, 597);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(279, 36);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(307, 597);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(276, 36);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // F04_GestionarOmnibusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 642);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F04_GestionarOmnibusForm";
            this.Text = "Gestionar Transporte Omnibus";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.TextBox txtPatente;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnLimpiar;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label lblCantidadRecepcion;
    private System.Windows.Forms.Label lblCantidadDespacho;
        private System.Windows.Forms.ListView lstBajar;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstSubir;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
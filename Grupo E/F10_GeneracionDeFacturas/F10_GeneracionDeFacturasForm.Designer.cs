namespace Grupo_E.GeneracionDeFacturas
{
    partial class F10_GeneracionDeFacturasForm
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
            this.listViewFactura = new System.Windows.Forms.ListView();
            this.colNroTracking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colImporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExtraRetiro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExtraEntrega = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAgencia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpboxImporteTotal = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewFactura
            // 
            this.listViewFactura.CheckBoxes = true;
            this.listViewFactura.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNroTracking,
            this.colFecha,
            this.colImporte,
            this.colExtraRetiro,
            this.colExtraEntrega,
            this.colAgencia});
            this.listViewFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewFactura.FullRowSelect = true;
            this.listViewFactura.GridLines = true;
            this.listViewFactura.HideSelection = false;
            this.listViewFactura.Location = new System.Drawing.Point(30, 166);
            this.listViewFactura.Name = "listViewFactura";
            this.listViewFactura.Size = new System.Drawing.Size(1210, 329);
            this.listViewFactura.TabIndex = 5;
            this.listViewFactura.UseCompatibleStateImageBehavior = false;
            this.listViewFactura.View = System.Windows.Forms.View.Details;
            // 
            // colNroTracking
            // 
            this.colNroTracking.Text = "Nro de Tracking";
            this.colNroTracking.Width = 149;
            // 
            // colFecha
            // 
            this.colFecha.Text = "Fecha de Admision";
            this.colFecha.Width = 169;
            // 
            // colImporte
            // 
            this.colImporte.Text = "Importe";
            this.colImporte.Width = 100;
            // 
            // colExtraRetiro
            // 
            this.colExtraRetiro.Text = "Extra retiro a domicilio";
            this.colExtraRetiro.Width = 291;
            // 
            // colExtraEntrega
            // 
            this.colExtraEntrega.Text = "Extra entrega a domicilio";
            this.colExtraEntrega.Width = 283;
            // 
            // colAgencia
            // 
            this.colAgencia.Text = "Extra entrega en agencia";
            this.colAgencia.Width = 380;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(729, 642);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(254, 43);
            this.btnFacturar.TabIndex = 6;
            this.btnFacturar.Text = "Generar factura";
            this.btnFacturar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(988, 642);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(254, 43);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCUIT);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1212, 109);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar cliente";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(80, 59);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(703, 26);
            this.txtCUIT.TabIndex = 4;
            this.txtCUIT.TextChanged += new System.EventHandler(this.txtCUIT_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(1012, 55);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(190, 35);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar filtro";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(810, 55);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(194, 35);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUIT";
            // 
            // grpboxImporteTotal
            // 
            this.grpboxImporteTotal.Location = new System.Drawing.Point(30, 642);
            this.grpboxImporteTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpboxImporteTotal.Name = "grpboxImporteTotal";
            this.grpboxImporteTotal.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpboxImporteTotal.Size = new System.Drawing.Size(660, 43);
            this.grpboxImporteTotal.TabIndex = 12;
            this.grpboxImporteTotal.TabStop = false;
            this.grpboxImporteTotal.Text = "IMPORTE TOTAL";
            this.grpboxImporteTotal.Enter += new System.EventHandler(this.grpboxImporteTotal_Enter);
            // 
            // F10_GeneracionDeFacturasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 702);
            this.Controls.Add(this.grpboxImporteTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.listViewFactura);
            this.Name = "F10_GeneracionDeFacturasForm";
            this.Text = "Generación de facturas";
            this.Load += new System.EventHandler(this.GeneracionDeFacturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewFactura;
        private System.Windows.Forms.ColumnHeader colNroTracking;
        private System.Windows.Forms.ColumnHeader colFecha;
        private System.Windows.Forms.ColumnHeader colImporte;
        private System.Windows.Forms.ColumnHeader colExtraRetiro;
        private System.Windows.Forms.ColumnHeader colAgencia;
        private System.Windows.Forms.ColumnHeader colExtraEntrega;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.GroupBox grpboxImporteTotal;
    }
}
namespace Grupo_E.GeneracionDeFacturas
{
    partial class GeneracionDeFacturas
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "10004050",
            "12-10-2024",
            "$100.000",
            "$5.000",
            "$4.000",
            "$0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewFactura = new System.Windows.Forms.ListView();
            this.colAgencia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNroTracking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colImporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExtraRetiro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExtraEntrega = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CUIT";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(102, 37);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(717, 26);
            this.txtCUIT.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(825, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(215, 26);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar cliente";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCUIT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 73);
            this.panel1.TabIndex = 4;
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
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.listViewFactura.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listViewFactura.Location = new System.Drawing.Point(18, 141);
            this.listViewFactura.Name = "listViewFactura";
            this.listViewFactura.Size = new System.Drawing.Size(1043, 328);
            this.listViewFactura.TabIndex = 5;
            this.listViewFactura.UseCompatibleStateImageBehavior = false;
            this.listViewFactura.View = System.Windows.Forms.View.Details;
            // 
            // colAgencia
            // 
            this.colAgencia.Text = "Extra entrega en agencia";
            this.colAgencia.Width = 213;
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
            this.colExtraRetiro.Width = 202;
            // 
            // colExtraEntrega
            // 
            this.colExtraEntrega.Text = "Extra entrega a domicilio";
            this.colExtraEntrega.Width = 211;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(530, 488);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(254, 80);
            this.btnFacturar.TabIndex = 6;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(804, 488);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(254, 80);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // GeneracionDeFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 589);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.listViewFactura);
            this.Controls.Add(this.panel1);
            this.Name = "GeneracionDeFacturas";
            this.Text = "Generacion De Facturas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewFactura;
        private System.Windows.Forms.ColumnHeader colNroTracking;
        private System.Windows.Forms.ColumnHeader colFecha;
        private System.Windows.Forms.ColumnHeader colImporte;
        private System.Windows.Forms.ColumnHeader colExtraRetiro;
        private System.Windows.Forms.ColumnHeader colAgencia;
        private System.Windows.Forms.ColumnHeader colExtraEntrega;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
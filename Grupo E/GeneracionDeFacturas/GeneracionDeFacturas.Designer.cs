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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "10004050",
            "12-10-2024",
            "$100.000",
            "$5.000",
            "$4.000",
            "$0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            this.listViewFactura.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
            this.listViewFactura.Location = new System.Drawing.Point(20, 108);
            this.listViewFactura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewFactura.Name = "listViewFactura";
            this.listViewFactura.Size = new System.Drawing.Size(808, 215);
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
            this.colExtraRetiro.Width = 202;
            // 
            // colExtraEntrega
            // 
            this.colExtraEntrega.Text = "Extra entrega a domicilio";
            this.colExtraEntrega.Width = 211;
            // 
            // colAgencia
            // 
            this.colAgencia.Text = "Extra entrega en agencia";
            this.colAgencia.Width = 213;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(486, 417);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(169, 28);
            this.btnFacturar.TabIndex = 6;
            this.btnFacturar.Text = "Generar factura";
            this.btnFacturar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(659, 417);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(169, 28);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 71);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUIT";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(470, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(675, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpiar filtro";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(14, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 28);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IMPORTE TOTAL";
            // 
            // GeneracionDeFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.listViewFactura);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GeneracionDeFacturas";
            this.Text = "Generación de facturas";
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
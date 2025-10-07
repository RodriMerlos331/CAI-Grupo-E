namespace FormResultadoCostoVsVentas
{
    partial class FormResultadoCostoVsVentas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCUIT = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lvwCostoVsVentas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMesAnio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVentas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCostos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCostosVentas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.lblCUIT.Location = new System.Drawing.Point(6, 21);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(38, 17);
            this.lblCUIT.TabIndex = 1;
            this.lblCUIT.Text = "CUIT:";
            this.lblCUIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(50, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 25);
            this.textBox1.TabIndex = 2;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.lblFechaInicio.Location = new System.Drawing.Point(232, 21);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(84, 17);
            this.lblFechaInicio.TabIndex = 3;
            this.lblFechaInicio.Text = "Fecha desde:";
            this.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.lblFechaFin.Location = new System.Drawing.Point(554, 21);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(79, 17);
            this.lblFechaFin.TabIndex = 4;
            this.lblFechaFin.Text = "Fecha hasta:";
            this.lblFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.dateTimePicker1.Location = new System.Drawing.Point(322, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 25);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.dateTimePicker2.Location = new System.Drawing.Point(639, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(208, 25);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnBuscar.Location = new System.Drawing.Point(17, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(853, 35);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lvwCostoVsVentas
            // 
            this.lvwCostoVsVentas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colMesAnio,
            this.colVentas,
            this.colCostos,
            this.colCostosVentas});
            this.lvwCostoVsVentas.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.lvwCostoVsVentas.FullRowSelect = true;
            this.lvwCostoVsVentas.GridLines = true;
            this.lvwCostoVsVentas.HideSelection = false;
            this.lvwCostoVsVentas.Location = new System.Drawing.Point(13, 29);
            this.lvwCostoVsVentas.MultiSelect = false;
            this.lvwCostoVsVentas.Name = "lvwCostoVsVentas";
            this.lvwCostoVsVentas.Size = new System.Drawing.Size(738, 315);
            this.lvwCostoVsVentas.TabIndex = 8;
            this.lvwCostoVsVentas.UseCompatibleStateImageBehavior = false;
            this.lvwCostoVsVentas.View = System.Windows.Forms.View.Details;
            this.lvwCostoVsVentas.SelectedIndexChanged += new System.EventHandler(this.lvwCostoVsVentas_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 1;
            // 
            // colMesAnio
            // 
            this.colMesAnio.Text = "Mes/Año";
            this.colMesAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMesAnio.Width = 153;
            // 
            // colVentas
            // 
            this.colVentas.Text = "Ventas";
            this.colVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colVentas.Width = 191;
            // 
            // colCostos
            // 
            this.colCostos.Text = "Costos";
            this.colCostos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCostos.Width = 191;
            // 
            // colCostosVentas
            // 
            this.colCostosVentas.Text = "Ventas - Costos";
            this.colCostosVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCostosVentas.Width = 200;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.lblTotal.Location = new System.Drawing.Point(489, 480);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(134, 17);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total Ventas - Costos:";
            this.lblTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(629, 474);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(182, 30);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCUIT);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblFechaInicio);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblFechaFin);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 59);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwCostoVsVentas);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.groupBox2.Location = new System.Drawing.Point(67, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 350);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.button1.Location = new System.Drawing.Point(782, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormResultadoCostoVsVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 557);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnBuscar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormResultadoCostoVsVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Costos vs Ventas";
            this.Load += new System.EventHandler(this.FormResultadoCostoVsVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListView lvwCostoVsVentas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader colMesAnio;
        private System.Windows.Forms.ColumnHeader colVentas;
        private System.Windows.Forms.ColumnHeader colCostos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader colCostosVentas;
        private System.Windows.Forms.Button button1;
    }
}


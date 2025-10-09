namespace Grupo_E.EstadoCuentasCorrientes
{
    partial class FormEstadoCuentasCorrientes
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
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpboxBusqueda = new System.Windows.Forms.GroupBox();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.txtCuitCliente = new System.Windows.Forms.TextBox();
            this.lblCuitCliente = new System.Windows.Forms.Label();
            this.grpboxResultado = new System.Windows.Forms.GroupBox();
            this.txtSaldoAcreedor = new System.Windows.Forms.TextBox();
            this.txtSaldoDeudor = new System.Windows.Forms.TextBox();
            this.lblAcreedor = new System.Windows.Forms.Label();
            this.lblDeudor = new System.Windows.Forms.Label();
            this.lvMovimientos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpboxBusqueda.SuspendLayout();
            this.grpboxResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(12, 38);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(178, 23);
            this.dtpFechaDesde.TabIndex = 5;
            this.dtpFechaDesde.Value = new System.DateTime(2025, 10, 5, 15, 13, 56, 0);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblFechaDesde.Location = new System.Drawing.Point(9, 21);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(72, 15);
            this.lblFechaDesde.TabIndex = 4;
            this.lblFechaDesde.Text = "Fecha desde";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(609, 36);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(217, 23);
            this.cmbEstado.TabIndex = 3;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblEstado.Location = new System.Drawing.Point(606, 20);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(98, 15);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado de factura";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btnBuscar.Location = new System.Drawing.Point(12, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(404, 34);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(422, 74);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(405, 34);
            this.btnLimpiarFiltros.TabIndex = 4;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btnSalir.Location = new System.Drawing.Point(665, 598);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(161, 34);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpboxBusqueda
            // 
            this.grpboxBusqueda.Controls.Add(this.lblFechaHasta);
            this.grpboxBusqueda.Controls.Add(this.dtpFechaHasta);
            this.grpboxBusqueda.Controls.Add(this.dtpFechaDesde);
            this.grpboxBusqueda.Controls.Add(this.lblFechaDesde);
            this.grpboxBusqueda.Controls.Add(this.txtCuitCliente);
            this.grpboxBusqueda.Controls.Add(this.btnLimpiarFiltros);
            this.grpboxBusqueda.Controls.Add(this.lblCuitCliente);
            this.grpboxBusqueda.Controls.Add(this.btnBuscar);
            this.grpboxBusqueda.Controls.Add(this.cmbEstado);
            this.grpboxBusqueda.Controls.Add(this.lblEstado);
            this.grpboxBusqueda.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.grpboxBusqueda.Location = new System.Drawing.Point(12, 16);
            this.grpboxBusqueda.Name = "grpboxBusqueda";
            this.grpboxBusqueda.Size = new System.Drawing.Size(833, 114);
            this.grpboxBusqueda.TabIndex = 10;
            this.grpboxBusqueda.TabStop = false;
            this.grpboxBusqueda.Text = "Búsqueda cliente";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblFechaHasta.Location = new System.Drawing.Point(193, 19);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(69, 15);
            this.lblFechaHasta.TabIndex = 8;
            this.lblFechaHasta.Text = "Fecha hasta";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(196, 38);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(178, 23);
            this.dtpFechaHasta.TabIndex = 7;
            this.dtpFechaHasta.Value = new System.DateTime(2025, 10, 5, 15, 13, 56, 0);
            // 
            // txtCuitCliente
            // 
            this.txtCuitCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuitCliente.Location = new System.Drawing.Point(380, 36);
            this.txtCuitCliente.Name = "txtCuitCliente";
            this.txtCuitCliente.Size = new System.Drawing.Size(223, 23);
            this.txtCuitCliente.TabIndex = 6;
            // 
            // lblCuitCliente
            // 
            this.lblCuitCliente.AutoSize = true;
            this.lblCuitCliente.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblCuitCliente.Location = new System.Drawing.Point(377, 21);
            this.lblCuitCliente.Name = "lblCuitCliente";
            this.lblCuitCliente.Size = new System.Drawing.Size(90, 15);
            this.lblCuitCliente.TabIndex = 0;
            this.lblCuitCliente.Text = "CUIT del cliente";
            // 
            // grpboxResultado
            // 
            this.grpboxResultado.Controls.Add(this.txtSaldoAcreedor);
            this.grpboxResultado.Controls.Add(this.txtSaldoDeudor);
            this.grpboxResultado.Controls.Add(this.lblAcreedor);
            this.grpboxResultado.Controls.Add(this.lblDeudor);
            this.grpboxResultado.Controls.Add(this.lvMovimientos);
            this.grpboxResultado.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.grpboxResultado.Location = new System.Drawing.Point(73, 156);
            this.grpboxResultado.Name = "grpboxResultado";
            this.grpboxResultado.Size = new System.Drawing.Size(714, 436);
            this.grpboxResultado.TabIndex = 11;
            this.grpboxResultado.TabStop = false;
            this.grpboxResultado.Text = "Resultado";
            // 
            // txtSaldoAcreedor
            // 
            this.txtSaldoAcreedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldoAcreedor.Location = new System.Drawing.Point(110, 405);
            this.txtSaldoAcreedor.Name = "txtSaldoAcreedor";
            this.txtSaldoAcreedor.Size = new System.Drawing.Size(140, 23);
            this.txtSaldoAcreedor.TabIndex = 10;
            // 
            // txtSaldoDeudor
            // 
            this.txtSaldoDeudor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldoDeudor.Location = new System.Drawing.Point(110, 376);
            this.txtSaldoDeudor.Name = "txtSaldoDeudor";
            this.txtSaldoDeudor.Size = new System.Drawing.Size(140, 23);
            this.txtSaldoDeudor.TabIndex = 9;
            // 
            // lblAcreedor
            // 
            this.lblAcreedor.AutoSize = true;
            this.lblAcreedor.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.lblAcreedor.Location = new System.Drawing.Point(11, 408);
            this.lblAcreedor.Name = "lblAcreedor";
            this.lblAcreedor.Size = new System.Drawing.Size(105, 17);
            this.lblAcreedor.TabIndex = 2;
            this.lblAcreedor.Text = "Saldo acreedor: ";
            // 
            // lblDeudor
            // 
            this.lblDeudor.AutoSize = true;
            this.lblDeudor.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.lblDeudor.Location = new System.Drawing.Point(11, 378);
            this.lblDeudor.Name = "lblDeudor";
            this.lblDeudor.Size = new System.Drawing.Size(95, 17);
            this.lblDeudor.TabIndex = 1;
            this.lblDeudor.Text = "Saldo deudor: ";
            // 
            // lvMovimientos
            // 
            this.lvMovimientos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8});
            this.lvMovimientos.GridLines = true;
            this.lvMovimientos.HideSelection = false;
            this.lvMovimientos.Location = new System.Drawing.Point(15, 26);
            this.lvMovimientos.Name = "lvMovimientos";
            this.lvMovimientos.Size = new System.Drawing.Size(689, 336);
            this.lvMovimientos.TabIndex = 0;
            this.lvMovimientos.UseCompatibleStateImageBehavior = false;
            this.lvMovimientos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha de emisión";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "N° de Factura";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Estado";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 115;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Debe";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Haber";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 115;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Saldo";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 115;
            // 
            // FormEstadoCuentasCorrientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 645);
            this.Controls.Add(this.grpboxResultado);
            this.Controls.Add(this.grpboxBusqueda);
            this.Controls.Add(this.btnSalir);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEstadoCuentasCorrientes";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estado de Cuentas Corrientes";
            this.Load += new System.EventHandler(this.FormEstadoCuentasCorrientes_Load);
            this.grpboxBusqueda.ResumeLayout(false);
            this.grpboxBusqueda.PerformLayout();
            this.grpboxResultado.ResumeLayout(false);
            this.grpboxResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpboxBusqueda;
        private System.Windows.Forms.Label lblCuitCliente;
        private System.Windows.Forms.TextBox txtCuitCliente;
        private System.Windows.Forms.GroupBox grpboxResultado;
        private System.Windows.Forms.ListView lvMovimientos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label lblDeudor;
        private System.Windows.Forms.Label lblAcreedor;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.TextBox txtSaldoAcreedor;
        private System.Windows.Forms.TextBox txtSaldoDeudor;
    }
}


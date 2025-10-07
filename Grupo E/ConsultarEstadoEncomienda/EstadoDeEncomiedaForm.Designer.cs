using System;

namespace Grupo_E.ConsultarEstadoEncomienda
{
    partial class EstadoDeEncomiendaForm
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
            this.grbBusquedaEncomienda = new System.Windows.Forms.GroupBox();
            this.lbTracking = new System.Windows.Forms.Label();
            this.btnEstadoBusqueda = new System.Windows.Forms.Button();
            this.txtIdTracking = new System.Windows.Forms.TextBox();
            this.grbEstado = new System.Windows.Forms.GroupBox();
            this.lblUbicacionActual = new System.Windows.Forms.Label();
            this.EstadoLocalidadlbl = new System.Windows.Forms.Label();
            this.lblFechaUltimo = new System.Windows.Forms.Label();
            this.EstadoFechalbl = new System.Windows.Forms.Label();
            this.lblEstadoActual = new System.Windows.Forms.Label();
            this.Estadolbl = new System.Windows.Forms.Label();
            this.grbHistorial = new System.Windows.Forms.GroupBox();
            this.HistoriaEncomiendaList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbBusquedaEncomienda.SuspendLayout();
            this.grbEstado.SuspendLayout();
            this.grbHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBusquedaEncomienda
            // 
            this.grbBusquedaEncomienda.Controls.Add(this.lbTracking);
            this.grbBusquedaEncomienda.Controls.Add(this.btnEstadoBusqueda);
            this.grbBusquedaEncomienda.Controls.Add(this.txtIdTracking);
            this.grbBusquedaEncomienda.Location = new System.Drawing.Point(15, 24);
            this.grbBusquedaEncomienda.Name = "grbBusquedaEncomienda";
            this.grbBusquedaEncomienda.Size = new System.Drawing.Size(991, 91);
            this.grbBusquedaEncomienda.TabIndex = 0;
            this.grbBusquedaEncomienda.TabStop = false;
            this.grbBusquedaEncomienda.Text = "Búsqueda de encomienda";
            // 
            // lbTracking
            // 
            this.lbTracking.AutoSize = true;
            this.lbTracking.Location = new System.Drawing.Point(6, 22);
            this.lbTracking.Name = "lbTracking";
            this.lbTracking.Size = new System.Drawing.Size(82, 13);
            this.lbTracking.TabIndex = 2;
            this.lbTracking.Text = "Numero de guia";
            // 
            // btnEstadoBusqueda
            // 
            this.btnEstadoBusqueda.Location = new System.Drawing.Point(869, 38);
            this.btnEstadoBusqueda.Name = "btnEstadoBusqueda";
            this.btnEstadoBusqueda.Size = new System.Drawing.Size(116, 23);
            this.btnEstadoBusqueda.TabIndex = 1;
            this.btnEstadoBusqueda.Text = "Buscar";
            this.btnEstadoBusqueda.UseVisualStyleBackColor = true;
            this.btnEstadoBusqueda.Click += new System.EventHandler(this.btnEstadoBusqueda_Click);
            // 
            // txtIdTracking
            // 
            this.txtIdTracking.Location = new System.Drawing.Point(6, 40);
            this.txtIdTracking.Name = "txtIdTracking";
            this.txtIdTracking.Size = new System.Drawing.Size(857, 20);
            this.txtIdTracking.TabIndex = 0;
            // 
            // grbEstado
            // 
            this.grbEstado.Controls.Add(this.lblUbicacionActual);
            this.grbEstado.Controls.Add(this.EstadoLocalidadlbl);
            this.grbEstado.Controls.Add(this.lblFechaUltimo);
            this.grbEstado.Controls.Add(this.EstadoFechalbl);
            this.grbEstado.Controls.Add(this.lblEstadoActual);
            this.grbEstado.Controls.Add(this.Estadolbl);
            this.grbEstado.Location = new System.Drawing.Point(15, 121);
            this.grbEstado.Name = "grbEstado";
            this.grbEstado.Size = new System.Drawing.Size(991, 93);
            this.grbEstado.TabIndex = 1;
            this.grbEstado.TabStop = false;
            this.grbEstado.Text = "Estado";
            // 
            // lblUbicacionActual
            // 
            this.lblUbicacionActual.AutoSize = true;
            this.lblUbicacionActual.Location = new System.Drawing.Point(862, 51);
            this.lblUbicacionActual.Name = "lblUbicacionActual";
            this.lblUbicacionActual.Size = new System.Drawing.Size(70, 13);
            this.lblUbicacionActual.TabIndex = 5;
            this.lblUbicacionActual.Text = "XXXXXXXXX";
            this.lblUbicacionActual.Click += new System.EventHandler(this.label6_Click);
            // 
            // EstadoLocalidadlbl
            // 
            this.EstadoLocalidadlbl.AutoSize = true;
            this.EstadoLocalidadlbl.Location = new System.Drawing.Point(766, 51);
            this.EstadoLocalidadlbl.Name = "EstadoLocalidadlbl";
            this.EstadoLocalidadlbl.Size = new System.Drawing.Size(90, 13);
            this.EstadoLocalidadlbl.TabIndex = 4;
            this.EstadoLocalidadlbl.Text = "Ubicacion actual:";
            // 
            // lblFechaUltimo
            // 
            this.lblFechaUltimo.AutoSize = true;
            this.lblFechaUltimo.Location = new System.Drawing.Point(533, 52);
            this.lblFechaUltimo.Name = "lblFechaUltimo";
            this.lblFechaUltimo.Size = new System.Drawing.Size(113, 13);
            this.lblFechaUltimo.TabIndex = 3;
            this.lblFechaUltimo.Text = "XX/XX/XXXX   XX:XX";
            // 
            // EstadoFechalbl
            // 
            this.EstadoFechalbl.AutoSize = true;
            this.EstadoFechalbl.Location = new System.Drawing.Point(347, 51);
            this.EstadoFechalbl.Name = "EstadoFechalbl";
            this.EstadoFechalbl.Size = new System.Drawing.Size(180, 13);
            this.EstadoFechalbl.TabIndex = 2;
            this.EstadoFechalbl.Text = "Fecha / Hora del ultimo movimiento: ";
            this.EstadoFechalbl.Click += new System.EventHandler(this.EstadoFechalbl_Click);
            // 
            // lblEstadoActual
            // 
            this.lblEstadoActual.AutoSize = true;
            this.lblEstadoActual.Location = new System.Drawing.Point(116, 52);
            this.lblEstadoActual.Name = "lblEstadoActual";
            this.lblEstadoActual.Size = new System.Drawing.Size(63, 13);
            this.lblEstadoActual.TabIndex = 1;
            this.lblEstadoActual.Text = "XXXXXXXX";
            // 
            // Estadolbl
            // 
            this.Estadolbl.AutoSize = true;
            this.Estadolbl.Location = new System.Drawing.Point(32, 51);
            this.Estadolbl.Name = "Estadolbl";
            this.Estadolbl.Size = new System.Drawing.Size(78, 13);
            this.Estadolbl.TabIndex = 0;
            this.Estadolbl.Text = "Estado actual: ";
            // 
            // grbHistorial
            // 
            this.grbHistorial.Controls.Add(this.HistoriaEncomiendaList);
            this.grbHistorial.Location = new System.Drawing.Point(15, 220);
            this.grbHistorial.Name = "grbHistorial";
            this.grbHistorial.Size = new System.Drawing.Size(991, 231);
            this.grbHistorial.TabIndex = 2;
            this.grbHistorial.TabStop = false;
            this.grbHistorial.Text = "Historial";
            // 
            // HistoriaEncomiendaList
            // 
            this.HistoriaEncomiendaList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.HistoriaEncomiendaList.HideSelection = false;
            this.HistoriaEncomiendaList.Location = new System.Drawing.Point(6, 19);
            this.HistoriaEncomiendaList.Name = "HistoriaEncomiendaList";
            this.HistoriaEncomiendaList.Size = new System.Drawing.Size(979, 206);
            this.HistoriaEncomiendaList.TabIndex = 0;
            this.HistoriaEncomiendaList.UseCompatibleStateImageBehavior = false;
            this.HistoriaEncomiendaList.View = System.Windows.Forms.View.Details;
            this.HistoriaEncomiendaList.SelectedIndexChanged += new System.EventHandler(this.HistoriaEncomiendaList_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Estado";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha / Hora de movimientos previos";
            this.columnHeader3.Width = 199;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ubicacion";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Transportista asignado";
            this.columnHeader5.Width = 167;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Hoja de ruta";
            this.columnHeader6.Width = 114;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Origen";
            this.columnHeader7.Width = 119;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Destino";
            this.columnHeader8.Width = 118;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tipo de bulto";
            this.columnHeader9.Width = 247;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Observaciones";
            this.columnHeader10.Width = 240;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(890, 457);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // EstadoDeEncomiendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 491);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbHistorial);
            this.Controls.Add(this.grbEstado);
            this.Controls.Add(this.grbBusquedaEncomienda);
            this.Name = "EstadoDeEncomiendaForm";
            this.Text = "Estado de Encomienda";
            this.grbBusquedaEncomienda.ResumeLayout(false);
            this.grbBusquedaEncomienda.PerformLayout();
            this.grbEstado.ResumeLayout(false);
            this.grbEstado.PerformLayout();
            this.grbHistorial.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void HistoriaEncomiendaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EstadoFechalbl_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox grbBusquedaEncomienda;
        private System.Windows.Forms.GroupBox grbEstado;
        private System.Windows.Forms.Button btnEstadoBusqueda;
        private System.Windows.Forms.TextBox txtIdTracking;
        private System.Windows.Forms.Label lblUbicacionActual;
        private System.Windows.Forms.Label EstadoLocalidadlbl;
        private System.Windows.Forms.Label lblFechaUltimo;
        private System.Windows.Forms.Label EstadoFechalbl;
        private System.Windows.Forms.Label lblEstadoActual;
        private System.Windows.Forms.Label Estadolbl;
        private System.Windows.Forms.GroupBox grbHistorial;
        private System.Windows.Forms.ListView HistoriaEncomiendaList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label lbTracking;
        private System.Windows.Forms.Button btnSalir;
    }
}
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
            this.lblBulto = new System.Windows.Forms.Label();
            this.Bultolbl = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.Destinolbl = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.Origenlbl = new System.Windows.Forms.Label();
            this.lblUbicacionActual = new System.Windows.Forms.Label();
            this.Localidadlbl = new System.Windows.Forms.Label();
            this.lblFechaUltimo = new System.Windows.Forms.Label();
            this.EstadoFechalbl = new System.Windows.Forms.Label();
            this.lblEstadoActual = new System.Windows.Forms.Label();
            this.Estadolbl = new System.Windows.Forms.Label();
            this.grbHistorial = new System.Windows.Forms.GroupBox();
            this.Historial = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.grbBusquedaEncomienda.Size = new System.Drawing.Size(681, 91);
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
            this.btnEstadoBusqueda.Location = new System.Drawing.Point(554, 37);
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
            this.txtIdTracking.Size = new System.Drawing.Size(532, 20);
            this.txtIdTracking.TabIndex = 0;
            // 
            // grbEstado
            // 
            this.grbEstado.Controls.Add(this.lblBulto);
            this.grbEstado.Controls.Add(this.Bultolbl);
            this.grbEstado.Controls.Add(this.lblDestino);
            this.grbEstado.Controls.Add(this.Destinolbl);
            this.grbEstado.Controls.Add(this.lblOrigen);
            this.grbEstado.Controls.Add(this.Origenlbl);
            this.grbEstado.Controls.Add(this.lblUbicacionActual);
            this.grbEstado.Controls.Add(this.Localidadlbl);
            this.grbEstado.Controls.Add(this.lblFechaUltimo);
            this.grbEstado.Controls.Add(this.EstadoFechalbl);
            this.grbEstado.Controls.Add(this.lblEstadoActual);
            this.grbEstado.Controls.Add(this.Estadolbl);
            this.grbEstado.Location = new System.Drawing.Point(15, 121);
            this.grbEstado.Name = "grbEstado";
            this.grbEstado.Size = new System.Drawing.Size(681, 203);
            this.grbEstado.TabIndex = 1;
            this.grbEstado.TabStop = false;
            this.grbEstado.Text = "Informacion del pedido";
            this.grbEstado.Enter += new System.EventHandler(this.grbEstado_Enter);
            // 
            // lblBulto
            // 
            this.lblBulto.AutoSize = true;
            this.lblBulto.Location = new System.Drawing.Point(110, 170);
            this.lblBulto.Name = "lblBulto";
            this.lblBulto.Size = new System.Drawing.Size(63, 13);
            this.lblBulto.TabIndex = 11;
            this.lblBulto.Text = "XXXXXXXX";
            // 
            // Bultolbl
            // 
            this.Bultolbl.AutoSize = true;
            this.Bultolbl.Location = new System.Drawing.Point(26, 170);
            this.Bultolbl.Name = "Bultolbl";
            this.Bultolbl.Size = new System.Drawing.Size(72, 13);
            this.Bultolbl.TabIndex = 10;
            this.Bultolbl.Text = "Tipo de bulto:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(78, 146);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(63, 13);
            this.lblDestino.TabIndex = 9;
            this.lblDestino.Text = "XXXXXXXX";
            // 
            // Destinolbl
            // 
            this.Destinolbl.AutoSize = true;
            this.Destinolbl.Location = new System.Drawing.Point(26, 146);
            this.Destinolbl.Name = "Destinolbl";
            this.Destinolbl.Size = new System.Drawing.Size(46, 13);
            this.Destinolbl.TabIndex = 8;
            this.Destinolbl.Text = "Destino:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(73, 117);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(63, 13);
            this.lblOrigen.TabIndex = 7;
            this.lblOrigen.Text = "XXXXXXXX";
            // 
            // Origenlbl
            // 
            this.Origenlbl.AutoSize = true;
            this.Origenlbl.Location = new System.Drawing.Point(26, 117);
            this.Origenlbl.Name = "Origenlbl";
            this.Origenlbl.Size = new System.Drawing.Size(41, 13);
            this.Origenlbl.TabIndex = 6;
            this.Origenlbl.Text = "Origen:";
            // 
            // lblUbicacionActual
            // 
            this.lblUbicacionActual.AutoSize = true;
            this.lblUbicacionActual.Location = new System.Drawing.Point(122, 88);
            this.lblUbicacionActual.Name = "lblUbicacionActual";
            this.lblUbicacionActual.Size = new System.Drawing.Size(70, 13);
            this.lblUbicacionActual.TabIndex = 5;
            this.lblUbicacionActual.Text = "XXXXXXXXX";
            this.lblUbicacionActual.Click += new System.EventHandler(this.label6_Click);
            // 
            // Localidadlbl
            // 
            this.Localidadlbl.AutoSize = true;
            this.Localidadlbl.Location = new System.Drawing.Point(26, 88);
            this.Localidadlbl.Name = "Localidadlbl";
            this.Localidadlbl.Size = new System.Drawing.Size(90, 13);
            this.Localidadlbl.TabIndex = 4;
            this.Localidadlbl.Text = "Ubicacion actual:";
            // 
            // lblFechaUltimo
            // 
            this.lblFechaUltimo.AutoSize = true;
            this.lblFechaUltimo.Location = new System.Drawing.Point(212, 58);
            this.lblFechaUltimo.Name = "lblFechaUltimo";
            this.lblFechaUltimo.Size = new System.Drawing.Size(113, 13);
            this.lblFechaUltimo.TabIndex = 3;
            this.lblFechaUltimo.Text = "XX/XX/XXXX   XX:XX";
            // 
            // EstadoFechalbl
            // 
            this.EstadoFechalbl.AutoSize = true;
            this.EstadoFechalbl.Location = new System.Drawing.Point(26, 58);
            this.EstadoFechalbl.Name = "EstadoFechalbl";
            this.EstadoFechalbl.Size = new System.Drawing.Size(180, 13);
            this.EstadoFechalbl.TabIndex = 2;
            this.EstadoFechalbl.Text = "Fecha / Hora del ultimo movimiento: ";
            this.EstadoFechalbl.Click += new System.EventHandler(this.EstadoFechalbl_Click);
            // 
            // lblEstadoActual
            // 
            this.lblEstadoActual.AutoSize = true;
            this.lblEstadoActual.Location = new System.Drawing.Point(110, 27);
            this.lblEstadoActual.Name = "lblEstadoActual";
            this.lblEstadoActual.Size = new System.Drawing.Size(63, 13);
            this.lblEstadoActual.TabIndex = 1;
            this.lblEstadoActual.Text = "XXXXXXXX";
            // 
            // Estadolbl
            // 
            this.Estadolbl.AutoSize = true;
            this.Estadolbl.Location = new System.Drawing.Point(26, 27);
            this.Estadolbl.Name = "Estadolbl";
            this.Estadolbl.Size = new System.Drawing.Size(78, 13);
            this.Estadolbl.TabIndex = 0;
            this.Estadolbl.Text = "Estado actual: ";
            // 
            // grbHistorial
            // 
            this.grbHistorial.Controls.Add(this.Historial);
            this.grbHistorial.Location = new System.Drawing.Point(15, 340);
            this.grbHistorial.Name = "grbHistorial";
            this.grbHistorial.Size = new System.Drawing.Size(681, 231);
            this.grbHistorial.TabIndex = 2;
            this.grbHistorial.TabStop = false;
            this.grbHistorial.Text = "Historial";
            // 
            // Historial
            // 
            this.Historial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.Historial.HideSelection = false;
            this.Historial.Location = new System.Drawing.Point(6, 19);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(664, 206);
            this.Historial.TabIndex = 0;
            this.Historial.UseCompatibleStateImageBehavior = false;
            this.Historial.View = System.Windows.Forms.View.Details;
            this.Historial.SelectedIndexChanged += new System.EventHandler(this.HistoriaEncomiendaList_SelectedIndexChanged);
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
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(580, 592);
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
            this.ClientSize = new System.Drawing.Size(714, 627);
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
        private System.Windows.Forms.Label Localidadlbl;
        private System.Windows.Forms.Label lblFechaUltimo;
        private System.Windows.Forms.Label EstadoFechalbl;
        private System.Windows.Forms.Label lblEstadoActual;
        private System.Windows.Forms.Label Estadolbl;
        private System.Windows.Forms.GroupBox grbHistorial;
        private System.Windows.Forms.ListView Historial;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lbTracking;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblBulto;
        private System.Windows.Forms.Label Bultolbl;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label Destinolbl;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label Origenlbl;
    }
}
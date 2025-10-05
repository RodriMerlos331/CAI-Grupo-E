namespace Grupo_E.ConsultarEstadoEncomienda
{
    partial class EstadoDeEncomiedaForm
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
            this.BuscarEstadobtn = new System.Windows.Forms.Button();
            this.IdTrackertxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EstadoLocalidadlbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EstadoFechalbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Estadolbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HistoriaEncomiendaList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BuscarEstadobtn);
            this.groupBox1.Controls.Add(this.IdTrackertxt);
            this.groupBox1.Location = new System.Drawing.Point(15, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda de encomienda";
            // 
            // BuscarEstadobtn
            // 
            this.BuscarEstadobtn.Location = new System.Drawing.Point(876, 38);
            this.BuscarEstadobtn.Name = "BuscarEstadobtn";
            this.BuscarEstadobtn.Size = new System.Drawing.Size(116, 23);
            this.BuscarEstadobtn.TabIndex = 1;
            this.BuscarEstadobtn.Text = "Buscar";
            this.BuscarEstadobtn.UseVisualStyleBackColor = true;
            // 
            // IdTrackertxt
            // 
            this.IdTrackertxt.Location = new System.Drawing.Point(6, 40);
            this.IdTrackertxt.Name = "IdTrackertxt";
            this.IdTrackertxt.Size = new System.Drawing.Size(864, 20);
            this.IdTrackertxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.EstadoLocalidadlbl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.EstadoFechalbl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Estadolbl);
            this.groupBox2.Location = new System.Drawing.Point(17, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1002, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "XXXXXXXXX";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // EstadoLocalidadlbl
            // 
            this.EstadoLocalidadlbl.AutoSize = true;
            this.EstadoLocalidadlbl.Location = new System.Drawing.Point(473, 51);
            this.EstadoLocalidadlbl.Name = "EstadoLocalidadlbl";
            this.EstadoLocalidadlbl.Size = new System.Drawing.Size(64, 15);
            this.EstadoLocalidadlbl.TabIndex = 4;
            this.EstadoLocalidadlbl.Text = "Localidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "XX/XX/XXXX   XX:XX";
            // 
            // EstadoFechalbl
            // 
            this.EstadoFechalbl.AutoSize = true;
            this.EstadoFechalbl.Location = new System.Drawing.Point(223, 51);
            this.EstadoFechalbl.Name = "EstadoFechalbl";
            this.EstadoFechalbl.Size = new System.Drawing.Size(83, 15);
            this.EstadoFechalbl.TabIndex = 2;
            this.EstadoFechalbl.Text = "Fecha / Hora: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "XXXXXXXX";
            // 
            // Estadolbl
            // 
            this.Estadolbl.AutoSize = true;
            this.Estadolbl.Location = new System.Drawing.Point(17, 51);
            this.Estadolbl.Name = "Estadolbl";
            this.Estadolbl.Size = new System.Drawing.Size(87, 15);
            this.Estadolbl.TabIndex = 0;
            this.Estadolbl.Text = "Estado actual: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HistoriaEncomiendaList);
            this.groupBox3.Location = new System.Drawing.Point(17, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1002, 303);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Historial";
            // 
            // HistoriaEncomiendaList
            // 
            this.HistoriaEncomiendaList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
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
            this.HistoriaEncomiendaList.Location = new System.Drawing.Point(4, 19);
            this.HistoriaEncomiendaList.Name = "HistoriaEncomiendaList";
            this.HistoriaEncomiendaList.Size = new System.Drawing.Size(986, 278);
            this.HistoriaEncomiendaList.TabIndex = 0;
            this.HistoriaEncomiendaList.UseCompatibleStateImageBehavior = false;
            this.HistoriaEncomiendaList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Tracker";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Estado";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha / Hora";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ubicacion";
            this.columnHeader4.Width = 79;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Transportista asignado";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Hoja de ruta";
            this.columnHeader6.Width = 97;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Origen";
            this.columnHeader7.Width = 101;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Destino";
            this.columnHeader8.Width = 94;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tipo de bulto";
            this.columnHeader9.Width = 92;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Observaciones";
            this.columnHeader10.Width = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Tracking";
            // 
            // EstadoDeEncomiedaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 581);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EstadoDeEncomiedaForm";
            this.Text = "Estado de Encomienda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BuscarEstadobtn;
        private System.Windows.Forms.TextBox IdTrackertxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label EstadoLocalidadlbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label EstadoFechalbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Estadolbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView HistoriaEncomiendaList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label1;
    }
}
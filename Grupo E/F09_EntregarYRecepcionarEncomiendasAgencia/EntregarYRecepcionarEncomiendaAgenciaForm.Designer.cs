namespace Grupo_E.EntregarYRecepcionarEncomiendaAgencia
{
    partial class EntregarYRecepcionarEncomiendaAgenciaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntregarYRecepcionarEncomiendaAgenciaForm));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GuiasARecibirListView = new System.Windows.Forms.ListView();
            this.TrackingRetiroCol2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GuiasAEntregarListView = new System.Windows.Forms.ListView();
            this.TrackingAEntregarCol2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LimpiarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DNITxt = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GuiasARecibirListView);
            this.groupBox3.Controls.Add(this.GuiasAEntregarListView);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 249);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encomiendas";
            // 
            // GuiasARecibirListView
            // 
            this.GuiasARecibirListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TrackingRetiroCol2});
            this.GuiasARecibirListView.HideSelection = false;
            this.GuiasARecibirListView.Location = new System.Drawing.Point(265, 42);
            this.GuiasARecibirListView.Name = "GuiasARecibirListView";
            this.GuiasARecibirListView.Size = new System.Drawing.Size(166, 181);
            this.GuiasARecibirListView.TabIndex = 8;
            this.GuiasARecibirListView.UseCompatibleStateImageBehavior = false;
            this.GuiasARecibirListView.View = System.Windows.Forms.View.Details;
            // 
            // TrackingRetiroCol2
            // 
            this.TrackingRetiroCol2.Text = "Tracking";
            this.TrackingRetiroCol2.Width = 162;
            // 
            // GuiasAEntregarListView
            // 
            this.GuiasAEntregarListView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GuiasAEntregarListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TrackingAEntregarCol2});
            this.GuiasAEntregarListView.HideSelection = false;
            this.GuiasAEntregarListView.Location = new System.Drawing.Point(9, 42);
            this.GuiasAEntregarListView.Name = "GuiasAEntregarListView";
            this.GuiasAEntregarListView.Size = new System.Drawing.Size(169, 181);
            this.GuiasAEntregarListView.TabIndex = 7;
            this.GuiasAEntregarListView.UseCompatibleStateImageBehavior = false;
            this.GuiasAEntregarListView.View = System.Windows.Forms.View.Details;
            // 
            // TrackingAEntregarCol2
            // 
            this.TrackingAEntregarCol2.Text = "Tracking";
            this.TrackingAEntregarCol2.Width = 165;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Guías a recibir del fletero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Guías a entregar al fletero";
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AceptarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarBtn.Location = new System.Drawing.Point(275, 370);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(86, 39);
            this.AceptarBtn.TabIndex = 13;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = false;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LimpiarBtn);
            this.groupBox2.Controls.Add(this.BuscarBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DNITxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 88);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda por fletero";
            // 
            // LimpiarBtn
            // 
            this.LimpiarBtn.BackColor = System.Drawing.Color.LightGray;
            this.LimpiarBtn.Location = new System.Drawing.Point(358, 28);
            this.LimpiarBtn.Name = "LimpiarBtn";
            this.LimpiarBtn.Size = new System.Drawing.Size(87, 37);
            this.LimpiarBtn.TabIndex = 13;
            this.LimpiarBtn.Text = "Limpiar";
            this.LimpiarBtn.UseVisualStyleBackColor = false;
            this.LimpiarBtn.Click += new System.EventHandler(this.LimpiarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.BackColor = System.Drawing.Color.LightGray;
            this.BuscarBtn.Location = new System.Drawing.Point(263, 28);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(89, 37);
            this.BuscarBtn.TabIndex = 12;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = false;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "DNI:";
            // 
            // DNITxt
            // 
            this.DNITxt.Location = new System.Drawing.Point(17, 44);
            this.DNITxt.Name = "DNITxt";
            this.DNITxt.Size = new System.Drawing.Size(230, 21);
            this.DNITxt.TabIndex = 10;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(367, 370);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(84, 39);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // EntregarYRecepcionarEncomiendaAgenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 421);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntregarYRecepcionarEncomiendaAgenciaForm";
            this.Text = "Entregar y Recepcionar en Agencia";
            this.Load += new System.EventHandler(this.EntregarYRecepcionarEncomiendaAgenciaForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.ListView GuiasARecibirListView;
        private System.Windows.Forms.ColumnHeader TrackingRetiroCol2;
        private System.Windows.Forms.ListView GuiasAEntregarListView;
        private System.Windows.Forms.ColumnHeader TrackingAEntregarCol2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LimpiarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DNITxt;
        private System.Windows.Forms.Button BtnCancelar;
    }
}
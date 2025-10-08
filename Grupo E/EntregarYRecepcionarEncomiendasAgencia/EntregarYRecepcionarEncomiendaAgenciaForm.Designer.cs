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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GuiasRetiradasListView = new System.Windows.Forms.ListView();
            this.TrackingRetiroCol2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GuiasNoEntregadasListView = new System.Windows.Forms.ListView();
            this.TrackingAEntregarCol2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LimpiarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DNIText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GuiasRetiradasListView);
            this.groupBox3.Controls.Add(this.GuiasNoEntregadasListView);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(682, 249);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encomiendas";
            // 
            // GuiasRetiradasListView
            // 
            this.GuiasRetiradasListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TrackingRetiroCol2});
            this.GuiasRetiradasListView.HideSelection = false;
            this.GuiasRetiradasListView.Location = new System.Drawing.Point(441, 45);
            this.GuiasRetiradasListView.Name = "GuiasRetiradasListView";
            this.GuiasRetiradasListView.Size = new System.Drawing.Size(166, 181);
            this.GuiasRetiradasListView.TabIndex = 8;
            this.GuiasRetiradasListView.UseCompatibleStateImageBehavior = false;
            this.GuiasRetiradasListView.View = System.Windows.Forms.View.Details;
            // 
            // TrackingRetiroCol2
            // 
            this.TrackingRetiroCol2.Text = "Tracking";
            // 
            // GuiasNoEntregadasListView
            // 
            this.GuiasNoEntregadasListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TrackingAEntregarCol2});
            this.GuiasNoEntregadasListView.HideSelection = false;
            this.GuiasNoEntregadasListView.Location = new System.Drawing.Point(9, 42);
            this.GuiasNoEntregadasListView.Name = "GuiasNoEntregadasListView";
            this.GuiasNoEntregadasListView.Size = new System.Drawing.Size(169, 181);
            this.GuiasNoEntregadasListView.TabIndex = 7;
            this.GuiasNoEntregadasListView.UseCompatibleStateImageBehavior = false;
            this.GuiasNoEntregadasListView.View = System.Windows.Forms.View.Details;
            // 
            // TrackingAEntregarCol2
            // 
            this.TrackingAEntregarCol2.Text = "Tracking";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Guías a retirar por fletero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Guías a entregar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 22);
            this.button1.TabIndex = 13;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LimpiarBtn);
            this.groupBox2.Controls.Add(this.BuscarBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DNIText);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 88);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda por fletero";
            // 
            // LimpiarBtn
            // 
            this.LimpiarBtn.Location = new System.Drawing.Point(476, 44);
            this.LimpiarBtn.Name = "LimpiarBtn";
            this.LimpiarBtn.Size = new System.Drawing.Size(149, 20);
            this.LimpiarBtn.TabIndex = 13;
            this.LimpiarBtn.Text = "Limpiar";
            this.LimpiarBtn.UseVisualStyleBackColor = true;
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(319, 43);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(151, 21);
            this.BuscarBtn.TabIndex = 12;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "DNI:";
            // 
            // DNIText
            // 
            this.DNIText.Location = new System.Drawing.Point(17, 44);
            this.DNIText.Name = "DNIText";
            this.DNIText.Size = new System.Drawing.Size(230, 20);
            this.DNIText.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 22);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RendicionHDRAgenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 421);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "RendicionHDRAgenciaForm";
            this.Text = "RendicionHDRAgenciaForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView GuiasRetiradasListView;
        private System.Windows.Forms.ColumnHeader TrackingRetiroCol2;
        private System.Windows.Forms.ListView GuiasNoEntregadasListView;
        private System.Windows.Forms.ColumnHeader TrackingAEntregarCol2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LimpiarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DNIText;
        private System.Windows.Forms.Button button2;
    }
}
namespace Grupo_E.RendicionHDRAgencia
{
    partial class RendicionHDRAgenciaForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.GuiasRetiradasListView = new System.Windows.Forms.ListView();
            this.NroHDRRetiradasCol1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackingRetiroCol2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GuiasNoEntregadasListView = new System.Windows.Forms.ListView();
            this.NroHDRGuiasNoEntregadasCol1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackingNoEntregadoCol2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HDRAsignadasListView = new System.Windows.Forms.ListView();
            this.NroHDRCol1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoHDRCol2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LimpiarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DNIText = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.GuiasRetiradasListView);
            this.groupBox3.Controls.Add(this.GuiasNoEntregadasListView);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.HDRAsignadasListView);
            this.groupBox3.Location = new System.Drawing.Point(12, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(740, 272);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rendición";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 21);
            this.button1.TabIndex = 13;
            this.button1.Text = "Actualizar HDR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GuiasRetiradasListView
            // 
            this.GuiasRetiradasListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NroHDRRetiradasCol1,
            this.TrackingRetiroCol2});
            this.GuiasRetiradasListView.HideSelection = false;
            this.GuiasRetiradasListView.Location = new System.Drawing.Point(553, 54);
            this.GuiasRetiradasListView.Name = "GuiasRetiradasListView";
            this.GuiasRetiradasListView.Size = new System.Drawing.Size(166, 181);
            this.GuiasRetiradasListView.TabIndex = 8;
            this.GuiasRetiradasListView.UseCompatibleStateImageBehavior = false;
            this.GuiasRetiradasListView.View = System.Windows.Forms.View.Details;
            // 
            // NroHDRRetiradasCol1
            // 
            this.NroHDRRetiradasCol1.Text = "Hoja de ruta";
            this.NroHDRRetiradasCol1.Width = 100;
            // 
            // TrackingRetiroCol2
            // 
            this.TrackingRetiroCol2.Text = "Tracking";
            // 
            // GuiasNoEntregadasListView
            // 
            this.GuiasNoEntregadasListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NroHDRGuiasNoEntregadasCol1,
            this.TrackingNoEntregadoCol2});
            this.GuiasNoEntregadasListView.HideSelection = false;
            this.GuiasNoEntregadasListView.Location = new System.Drawing.Point(319, 54);
            this.GuiasNoEntregadasListView.Name = "GuiasNoEntregadasListView";
            this.GuiasNoEntregadasListView.Size = new System.Drawing.Size(180, 181);
            this.GuiasNoEntregadasListView.TabIndex = 7;
            this.GuiasNoEntregadasListView.UseCompatibleStateImageBehavior = false;
            this.GuiasNoEntregadasListView.View = System.Windows.Forms.View.Details;
            // 
            // NroHDRGuiasNoEntregadasCol1
            // 
            this.NroHDRGuiasNoEntregadasCol1.Text = "Hoja de ruta";
            this.NroHDRGuiasNoEntregadasCol1.Width = 100;
            // 
            // TrackingNoEntregadoCol2
            // 
            this.TrackingNoEntregadoCol2.Text = "Tracking";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Guías retiradas a admitir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Guías no entregadas a devolver a deposito:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "HDR asignadas: Marque las completadas";
            // 
            // HDRAsignadasListView
            // 
            this.HDRAsignadasListView.CheckBoxes = true;
            this.HDRAsignadasListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NroHDRCol1,
            this.TipoHDRCol2});
            this.HDRAsignadasListView.FullRowSelect = true;
            this.HDRAsignadasListView.HideSelection = false;
            this.HDRAsignadasListView.Location = new System.Drawing.Point(17, 54);
            this.HDRAsignadasListView.Name = "HDRAsignadasListView";
            this.HDRAsignadasListView.Size = new System.Drawing.Size(230, 181);
            this.HDRAsignadasListView.TabIndex = 0;
            this.HDRAsignadasListView.UseCompatibleStateImageBehavior = false;
            this.HDRAsignadasListView.View = System.Windows.Forms.View.Details;
            // 
            // NroHDRCol1
            // 
            this.NroHDRCol1.Text = "Nro HDR";
            // 
            // TipoHDRCol2
            // 
            this.TipoHDRCol2.Text = "Entrega / Retiro";
            this.TipoHDRCol2.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LimpiarBtn);
            this.groupBox2.Controls.Add(this.BuscarBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DNIText);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 88);
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
            // RendicionHDRAgenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 390);
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
        private System.Windows.Forms.ColumnHeader NroHDRRetiradasCol1;
        private System.Windows.Forms.ColumnHeader TrackingRetiroCol2;
        private System.Windows.Forms.ListView GuiasNoEntregadasListView;
        private System.Windows.Forms.ColumnHeader NroHDRGuiasNoEntregadasCol1;
        private System.Windows.Forms.ColumnHeader TrackingNoEntregadoCol2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView HDRAsignadasListView;
        private System.Windows.Forms.ColumnHeader NroHDRCol1;
        private System.Windows.Forms.ColumnHeader TipoHDRCol2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LimpiarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DNIText;
    }
}
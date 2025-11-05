using System.Drawing;
using System.Windows.Forms;

namespace Grupo_E.GestionarFletero
{
    partial class F05_GestionarFleteroForm
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
            System.Windows.Forms.ColumnHeader HDRaRetirarCol;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LimpiarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DNIText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NuevasHDRRetirarListViews = new System.Windows.Forms.ListView();
            this.HDRRetirarCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.NuevasHDREntregarListView = new System.Windows.Forms.ListView();
            this.HDREntregarCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NuevasGuiasRetirarListView = new System.Windows.Forms.ListView();
            this.TrackingRetirarCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NuevasGuiasEntregarListView = new System.Windows.Forms.ListView();
            this.HDREntregarCol1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackingEntregarCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GenerarHdrBtn = new System.Windows.Forms.Button();
            HDRaRetirarCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HDRaRetirarCol
            // 
            HDRaRetirarCol.Text = "Hoja de ruta";
            HDRaRetirarCol.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LimpiarBtn);
            this.groupBox2.Controls.Add(this.BuscarBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DNIText);
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 88);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda por fletero";
            // 
            // LimpiarBtn
            // 
            this.LimpiarBtn.Location = new System.Drawing.Point(542, 44);
            this.LimpiarBtn.Name = "LimpiarBtn";
            this.LimpiarBtn.Size = new System.Drawing.Size(212, 20);
            this.LimpiarBtn.TabIndex = 13;
            this.LimpiarBtn.Text = "Limpiar";
            this.LimpiarBtn.UseVisualStyleBackColor = true;
            this.LimpiarBtn.Click += new System.EventHandler(this.LimpiarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(276, 43);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(212, 21);
            this.BuscarBtn.TabIndex = 12;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingrese el DNI del fletero:";
            // 
            // DNIText
            // 
            this.DNIText.Location = new System.Drawing.Point(15, 43);
            this.DNIText.Name = "DNIText";
            this.DNIText.Size = new System.Drawing.Size(200, 20);
            this.DNIText.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GuiasRetiradasListView);
            this.groupBox3.Controls.Add(this.GuiasNoEntregadasListView);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.HDRAsignadasListView);
            this.groupBox3.Location = new System.Drawing.Point(10, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(779, 250);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rendición";
            // 
            // GuiasRetiradasListView
            // 
            this.GuiasRetiradasListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NroHDRRetiradasCol1,
            this.TrackingRetiroCol2});
            this.GuiasRetiradasListView.HideSelection = false;
            this.GuiasRetiradasListView.Location = new System.Drawing.Point(542, 54);
            this.GuiasRetiradasListView.Name = "GuiasRetiradasListView";
            this.GuiasRetiradasListView.Size = new System.Drawing.Size(212, 181);
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
            this.GuiasNoEntregadasListView.Location = new System.Drawing.Point(276, 54);
            this.GuiasNoEntregadasListView.Name = "GuiasNoEntregadasListView";
            this.GuiasNoEntregadasListView.Size = new System.Drawing.Size(212, 181);
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
            this.label4.Location = new System.Drawing.Point(539, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Guías retiradas a admitir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 35);
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
            this.HDRAsignadasListView.Size = new System.Drawing.Size(200, 181);
            this.HDRAsignadasListView.TabIndex = 0;
            this.HDRAsignadasListView.UseCompatibleStateImageBehavior = false;
            this.HDRAsignadasListView.View = System.Windows.Forms.View.Details;
            this.HDRAsignadasListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.HDRAsignadasListView_ItemChecked_1);
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
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(582, 684);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(72, 20);
            this.AceptarBtn.TabIndex = 10;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(717, 684);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(72, 20);
            this.CancelarBtn.TabIndex = 11;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GenerarHdrBtn);
            this.groupBox1.Controls.Add(this.NuevasHDRRetirarListViews);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.NuevasHDREntregarListView);
            this.groupBox1.Controls.Add(this.NuevasGuiasRetirarListView);
            this.groupBox1.Controls.Add(this.NuevasGuiasEntregarListView);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(10, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 296);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generación";
            // 
            // NuevasHDRRetirarListViews
            // 
            this.NuevasHDRRetirarListViews.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HDRRetirarCol});
            this.NuevasHDRRetirarListViews.HideSelection = false;
            this.NuevasHDRRetirarListViews.Location = new System.Drawing.Point(15, 195);
            this.NuevasHDRRetirarListViews.Name = "NuevasHDRRetirarListViews";
            this.NuevasHDRRetirarListViews.Size = new System.Drawing.Size(183, 85);
            this.NuevasHDRRetirarListViews.TabIndex = 11;
            this.NuevasHDRRetirarListViews.UseCompatibleStateImageBehavior = false;
            this.NuevasHDRRetirarListViews.View = System.Windows.Forms.View.Details;
            // 
            // HDRRetirarCol
            // 
            this.HDRRetirarCol.Text = "Hoja de ruta";
            this.HDRRetirarCol.Width = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nuevas HDR a retirar:";
            // 
            // NuevasHDREntregarListView
            // 
            this.NuevasHDREntregarListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HDREntregarCol});
            this.NuevasHDREntregarListView.HideSelection = false;
            this.NuevasHDREntregarListView.Location = new System.Drawing.Point(15, 65);
            this.NuevasHDREntregarListView.Name = "NuevasHDREntregarListView";
            this.NuevasHDREntregarListView.Size = new System.Drawing.Size(183, 86);
            this.NuevasHDREntregarListView.TabIndex = 9;
            this.NuevasHDREntregarListView.UseCompatibleStateImageBehavior = false;
            this.NuevasHDREntregarListView.View = System.Windows.Forms.View.Details;
            // 
            // HDREntregarCol
            // 
            this.HDREntregarCol.Text = "Hoja de ruta";
            this.HDREntregarCol.Width = 100;
            // 
            // NuevasGuiasRetirarListView
            // 
            this.NuevasGuiasRetirarListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            HDRaRetirarCol,
            this.TrackingRetirarCol});
            this.NuevasGuiasRetirarListView.HideSelection = false;
            this.NuevasGuiasRetirarListView.Location = new System.Drawing.Point(542, 65);
            this.NuevasGuiasRetirarListView.Name = "NuevasGuiasRetirarListView";
            this.NuevasGuiasRetirarListView.Size = new System.Drawing.Size(203, 214);
            this.NuevasGuiasRetirarListView.TabIndex = 8;
            this.NuevasGuiasRetirarListView.UseCompatibleStateImageBehavior = false;
            this.NuevasGuiasRetirarListView.View = System.Windows.Forms.View.Details;
            // 
            // TrackingRetirarCol
            // 
            this.TrackingRetirarCol.Text = "Tracking";
            // 
            // NuevasGuiasEntregarListView
            // 
            this.NuevasGuiasEntregarListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HDREntregarCol1,
            this.TrackingEntregarCol});
            this.NuevasGuiasEntregarListView.HideSelection = false;
            this.NuevasGuiasEntregarListView.Location = new System.Drawing.Point(276, 65);
            this.NuevasGuiasEntregarListView.Name = "NuevasGuiasEntregarListView";
            this.NuevasGuiasEntregarListView.Size = new System.Drawing.Size(210, 215);
            this.NuevasGuiasEntregarListView.TabIndex = 7;
            this.NuevasGuiasEntregarListView.UseCompatibleStateImageBehavior = false;
            this.NuevasGuiasEntregarListView.View = System.Windows.Forms.View.Details;
            // 
            // HDREntregarCol1
            // 
            this.HDREntregarCol1.Text = "Hoja de ruta";
            this.HDREntregarCol1.Width = 100;
            // 
            // TrackingEntregarCol
            // 
            this.TrackingEntregarCol.Text = "Tracking";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Guías a retirar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Guías a entregar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nuevas HDR a entregar:";
            // 
            // GenerarHdrBtn
            // 
            this.GenerarHdrBtn.Location = new System.Drawing.Point(15, 16);
            this.GenerarHdrBtn.Name = "GenerarHdrBtn";
            this.GenerarHdrBtn.Size = new System.Drawing.Size(730, 21);
            this.GenerarHdrBtn.TabIndex = 13;
            this.GenerarHdrBtn.Text = "Generar nuevas HDR";
            this.GenerarHdrBtn.UseVisualStyleBackColor = true;
            this.GenerarHdrBtn.Click += new System.EventHandler(this.GenerarHdrBtn_Click);
            // 
            // F05_GestionarFleteroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 713);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "F05_GestionarFleteroForm";
            this.Text = "RendicionHojasDeRuta";
            this.Load += new System.EventHandler(this.F05_GestionarFleteroForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private ListView HDRAsignadasListView;
        private Button AceptarBtn;
        private Button CancelarBtn;
        private ColumnHeader NroHDRCol1;
        private Label label1;
        private TextBox DNIText;
        private Button LimpiarBtn;
        private Button BuscarBtn;
        private ColumnHeader TipoHDRCol2;
        private ListView GuiasRetiradasListView;
        private ColumnHeader NroHDRRetiradasCol1;
        private ColumnHeader TrackingRetiroCol2;
        private ListView GuiasNoEntregadasListView;
        private ColumnHeader NroHDRGuiasNoEntregadasCol1;
        private ColumnHeader TrackingNoEntregadoCol2;
        private Label label4;
        private Label label3;
        private GroupBox groupBox1;
        private ListView NuevasHDRRetirarListViews;
        private ColumnHeader HDRRetirarCol;
        private Label label8;
        private ListView NuevasHDREntregarListView;
        private ColumnHeader HDREntregarCol;
        private ListView NuevasGuiasRetirarListView;
        private ColumnHeader TrackingRetirarCol;
        private ListView NuevasGuiasEntregarListView;
        private ColumnHeader HDREntregarCol1;
        private ColumnHeader TrackingEntregarCol;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button GenerarHdrBtn;
    }
}
using System.Drawing;
using System.Windows.Forms;

namespace Grupo_E.GestionarFletero
{
    partial class GestionarFleteroForm
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
            this.ActualizarHDRBtn = new System.Windows.Forms.Button();
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
            this.HDRRetirarListViews = new System.Windows.Forms.ListView();
            this.HDRRetirarCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.HDREntregarListView = new System.Windows.Forms.ListView();
            this.HDREntregarCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GuiasRetirarListView = new System.Windows.Forms.ListView();
            this.TrackingRetirarCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GuiasEntregarListView = new System.Windows.Forms.ListView();
            this.HDREntregarCol1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackingEntregarCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.groupBox2.Size = new System.Drawing.Size(740, 88);
            this.groupBox2.TabIndex = 7;
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
            this.LimpiarBtn.Click += new System.EventHandler(this.LimpiarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(319, 43);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(151, 21);
            this.BuscarBtn.TabIndex = 12;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ActualizarHDRBtn);
            this.groupBox3.Controls.Add(this.GuiasRetiradasListView);
            this.groupBox3.Controls.Add(this.GuiasNoEntregadasListView);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.HDRAsignadasListView);
            this.groupBox3.Location = new System.Drawing.Point(10, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(740, 272);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rendición";
            // 
            // ActualizarHDRBtn
            // 
            this.ActualizarHDRBtn.Location = new System.Drawing.Point(289, 51);
            this.ActualizarHDRBtn.Name = "ActualizarHDRBtn";
            this.ActualizarHDRBtn.Size = new System.Drawing.Size(430, 21);
            this.ActualizarHDRBtn.TabIndex = 13;
            this.ActualizarHDRBtn.Text = "Actualizar HDR";
            this.ActualizarHDRBtn.UseVisualStyleBackColor = true;
            this.ActualizarHDRBtn.Click += new System.EventHandler(this.ActualizarHDRBtn_Click);
            // 
            // GuiasRetiradasListView
            // 
            this.GuiasRetiradasListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NroHDRRetiradasCol1,
            this.TrackingRetiroCol2});
            this.GuiasRetiradasListView.HideSelection = false;
            this.GuiasRetiradasListView.Location = new System.Drawing.Point(553, 78);
            this.GuiasRetiradasListView.Name = "GuiasRetiradasListView";
            this.GuiasRetiradasListView.Size = new System.Drawing.Size(166, 157);
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
            this.GuiasNoEntregadasListView.Location = new System.Drawing.Point(289, 78);
            this.GuiasNoEntregadasListView.Name = "GuiasNoEntregadasListView";
            this.GuiasNoEntregadasListView.Size = new System.Drawing.Size(228, 157);
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
            this.label3.Location = new System.Drawing.Point(302, 35);
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
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(587, 717);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(72, 20);
            this.AceptarBtn.TabIndex = 10;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(673, 717);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(72, 20);
            this.CancelarBtn.TabIndex = 11;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HDRRetirarListViews);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.HDREntregarListView);
            this.groupBox1.Controls.Add(this.GuiasRetirarListView);
            this.groupBox1.Controls.Add(this.GuiasEntregarListView);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 296);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generación";
            // 
            // HDRRetirarListViews
            // 
            this.HDRRetirarListViews.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HDRRetirarCol});
            this.HDRRetirarListViews.HideSelection = false;
            this.HDRRetirarListViews.Location = new System.Drawing.Point(15, 195);
            this.HDRRetirarListViews.Name = "HDRRetirarListViews";
            this.HDRRetirarListViews.Size = new System.Drawing.Size(183, 85);
            this.HDRRetirarListViews.TabIndex = 11;
            this.HDRRetirarListViews.UseCompatibleStateImageBehavior = false;
            this.HDRRetirarListViews.View = System.Windows.Forms.View.Details;
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
            // HDREntregarListView
            // 
            this.HDREntregarListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HDREntregarCol});
            this.HDREntregarListView.HideSelection = false;
            this.HDREntregarListView.Location = new System.Drawing.Point(15, 65);
            this.HDREntregarListView.Name = "HDREntregarListView";
            this.HDREntregarListView.Size = new System.Drawing.Size(183, 86);
            this.HDREntregarListView.TabIndex = 9;
            this.HDREntregarListView.UseCompatibleStateImageBehavior = false;
            this.HDREntregarListView.View = System.Windows.Forms.View.Details;
            // 
            // HDREntregarCol
            // 
            this.HDREntregarCol.Text = "Hoja de ruta";
            this.HDREntregarCol.Width = 100;
            // 
            // GuiasRetirarListView
            // 
            this.GuiasRetirarListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            HDRaRetirarCol,
            this.TrackingRetirarCol});
            this.GuiasRetirarListView.HideSelection = false;
            this.GuiasRetirarListView.Location = new System.Drawing.Point(551, 56);
            this.GuiasRetirarListView.Name = "GuiasRetirarListView";
            this.GuiasRetirarListView.Size = new System.Drawing.Size(166, 214);
            this.GuiasRetirarListView.TabIndex = 8;
            this.GuiasRetirarListView.UseCompatibleStateImageBehavior = false;
            this.GuiasRetirarListView.View = System.Windows.Forms.View.Details;
            // 
            // TrackingRetirarCol
            // 
            this.TrackingRetirarCol.Text = "Tracking";
            // 
            // GuiasEntregarListView
            // 
            this.GuiasEntregarListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HDREntregarCol1,
            this.TrackingEntregarCol});
            this.GuiasEntregarListView.HideSelection = false;
            this.GuiasEntregarListView.Location = new System.Drawing.Point(319, 55);
            this.GuiasEntregarListView.Name = "GuiasEntregarListView";
            this.GuiasEntregarListView.Size = new System.Drawing.Size(167, 215);
            this.GuiasEntregarListView.TabIndex = 7;
            this.GuiasEntregarListView.UseCompatibleStateImageBehavior = false;
            this.GuiasEntregarListView.View = System.Windows.Forms.View.Details;
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
            this.label5.Location = new System.Drawing.Point(549, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Guías a retirar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Guías en HDR a entregar";
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
            // GestionarFleteroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "GestionarFleteroForm";
            this.Text = "RendicionHojasDeRuta";
            this.Load += new System.EventHandler(this.GestionarFleteroForm_Load);
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
        private ListView HDRRetirarListViews;
        private ColumnHeader HDRRetirarCol;
        private Label label8;
        private ListView HDREntregarListView;
        private ColumnHeader HDREntregarCol;
        private ListView GuiasRetirarListView;
        private ColumnHeader TrackingRetirarCol;
        private ListView GuiasEntregarListView;
        private ColumnHeader HDREntregarCol1;
        private ColumnHeader TrackingEntregarCol;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button ActualizarHDRBtn;
    }
}
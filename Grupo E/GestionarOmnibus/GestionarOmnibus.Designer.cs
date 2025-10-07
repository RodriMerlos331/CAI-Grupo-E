namespace Grupo_E.RendicionHDRLargaDistancia
{

    partial class GestionarOmnibus
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView5 = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtPatente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(563, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búscar Omnibus";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 45);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpiar filtro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(254, 45);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(145, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(13, 48);
            this.txtPatente.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(233, 22);
            this.txtPatente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(20, 150);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(563, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Recepcion";
            // 
            // listView5
            // 
            this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader22,
            this.columnHeader25});
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(8, 76);
            this.listView5.Margin = new System.Windows.Forms.Padding(4);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(547, 123);
            this.listView5.TabIndex = 14;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "ID HDR";
            this.columnHeader13.Width = 102;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Numero de Tracking";
            this.columnHeader22.Width = 282;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Tipo de Bulto";
            this.columnHeader25.Width = 155;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Encomiendas: XX";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 387);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(563, 202);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Despacho ";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 68);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(542, 123);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID HDR";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Numero de Tracking";
            this.columnHeader2.Width = 285;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipo de Bulto";
            this.columnHeader3.Width = 155;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Encomiendas: XX";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1032, 689);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(157, 26);
            this.button7.TabIndex = 14;
            this.button7.Text = "Cancelar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(883, 689);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(141, 26);
            this.button8.TabIndex = 13;
            this.button8.Text = "Aceptar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 869);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 15;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(20, 597);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(279, 36);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(307, 597);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(276, 36);
            this.button6.TabIndex = 18;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 642);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Gestionar Transporte Omnibus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.TextBox txtPatente;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button6;
    }
}
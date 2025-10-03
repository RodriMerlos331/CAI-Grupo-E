using System.Drawing;
using System.Windows.Forms;

namespace Grupo_E.RendicionHDRFletero
{
    partial class RendicionHDRForm
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            checkBox3 = new CheckBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            groupBox3 = new GroupBox();
            label2 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button5 = new Button();
            button6 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 28);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 1;
            label1.Text = "ID Hoja de ruta";
            // 
            // button1
            // 
            button1.Location = new Point(200, 46);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(315, 45);
            button2.Name = "button2";
            button2.Size = new Size(98, 23);
            button2.TabIndex = 3;
            button2.Text = "Limpiar filtro";
            button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(20, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(78, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Cumplida";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(20, 62);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(95, 19);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "No cumplida";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(431, 93);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda por hoja de ruta";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(15, 125);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(431, 138);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rendicion de hoja de ruta";
            // 
            // button3
            // 
            button3.Location = new Point(18, 97);
            button3.Name = "button3";
            button3.Size = new Size(389, 23);
            button3.TabIndex = 8;
            button3.Text = "Actualizar hoja de ruta";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(listView1);
            groupBox3.Location = new Point(12, 289);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(431, 178);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resumen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 22);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 4;
            label2.Text = "Resumen de hojas de ruta:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Location = new Point(15, 40);
            listView1.Name = "listView1";
            listView1.Size = new Size(395, 101);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID HDR";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Estado rendicion";
            columnHeader2.Width = 100;
            // 
            // button5
            // 
            button5.Location = new Point(257, 473);
            button5.Name = "button5";
            button5.Size = new Size(84, 23);
            button5.TabIndex = 10;
            button5.Text = "Aceptar";
            button5.UseVisualStyleBackColor = true;
            
            // 
            // button6
            // 
            button6.Location = new Point(361, 473);
            button6.Name = "button6";
            button6.Size = new Size(84, 23);
            button6.TabIndex = 11;
            button6.Text = "Cancelar";
            button6.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(304, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 37);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 4;
            label3.Text = "Motivo incumpliento:";
            // 
            // RendicionHDRMediaDistanciaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 515);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RendicionHDRMediaDistanciaForm";
            Text = "RendicionHojasDeRuta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private CheckBox checkBox3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button3;
        private GroupBox groupBox3;
        private Label label2;
        private ListView listView1;
        private Button button5;
        private Button button6;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label3;
        private ComboBox comboBox1;
    }
}
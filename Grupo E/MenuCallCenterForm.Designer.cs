namespace Grupo_E
{
    partial class MenuCallCenterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCallCenterForm));
            this.btnImposicionEnCallCenter = new System.Windows.Forms.Button();
            this.btnConsultarEstado = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImposicionEnCallCenter
            // 
            this.btnImposicionEnCallCenter.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImposicionEnCallCenter.Location = new System.Drawing.Point(88, 160);
            this.btnImposicionEnCallCenter.Name = "btnImposicionEnCallCenter";
            this.btnImposicionEnCallCenter.Size = new System.Drawing.Size(189, 36);
            this.btnImposicionEnCallCenter.TabIndex = 9;
            this.btnImposicionEnCallCenter.Text = "Imposicion en Call Center";
            this.btnImposicionEnCallCenter.UseVisualStyleBackColor = true;
            this.btnImposicionEnCallCenter.Click += new System.EventHandler(this.btnImposicionEnCallCenter_Click);
            // 
            // btnConsultarEstado
            // 
            this.btnConsultarEstado.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEstado.Location = new System.Drawing.Point(297, 160);
            this.btnConsultarEstado.Name = "btnConsultarEstado";
            this.btnConsultarEstado.Size = new System.Drawing.Size(189, 36);
            this.btnConsultarEstado.TabIndex = 10;
            this.btnConsultarEstado.Text = "Consultar estado de encomienda";
            this.btnConsultarEstado.UseVisualStyleBackColor = true;
            this.btnConsultarEstado.Click += new System.EventHandler(this.btnConsultarEstado_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(88, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 93);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Menú principal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Liberation Sans", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Call Center";
            // 
            // MenuCallCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 248);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnConsultarEstado);
            this.Controls.Add(this.btnImposicionEnCallCenter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuCallCenterForm";
            this.Text = "Manú Call Center";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImposicionEnCallCenter;
        private System.Windows.Forms.Button btnConsultarEstado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
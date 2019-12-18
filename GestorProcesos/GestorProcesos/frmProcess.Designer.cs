namespace GestorProcesos
{
    partial class frmProcess
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
            this.lstProcesos = new System.Windows.Forms.ListBox();
            this.btnKill = new System.Windows.Forms.Button();
            this.txtPropiedades = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrograma = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProcesos
            // 
            this.lstProcesos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstProcesos.FormattingEnabled = true;
            this.lstProcesos.Location = new System.Drawing.Point(1, 12);
            this.lstProcesos.Name = "lstProcesos";
            this.lstProcesos.ScrollAlwaysVisible = true;
            this.lstProcesos.Size = new System.Drawing.Size(287, 147);
            this.lstProcesos.TabIndex = 0;
            this.lstProcesos.DoubleClick += new System.EventHandler(this.lstProcesos_DoubleClick);
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(462, 172);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(75, 23);
            this.btnKill.TabIndex = 2;
            this.btnKill.Text = "Terminar";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // txtPropiedades
            // 
            this.txtPropiedades.BackColor = System.Drawing.SystemColors.Info;
            this.txtPropiedades.Location = new System.Drawing.Point(322, 12);
            this.txtPropiedades.Multiline = true;
            this.txtPropiedades.Name = "txtPropiedades";
            this.txtPropiedades.Size = new System.Drawing.Size(215, 147);
            this.txtPropiedades.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(322, 172);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrograma
            // 
            this.txtPrograma.Location = new System.Drawing.Point(13, 254);
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.Size = new System.Drawing.Size(153, 20);
            this.txtPrograma.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 333);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPrograma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPropiedades);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstProcesos);
            this.Name = "frmProcess";
            this.Text = "frmProcess";
            this.Load += new System.EventHandler(this.frmProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProcesos;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.TextBox txtPropiedades;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPrograma;
        private System.Windows.Forms.Button button2;
    }
}
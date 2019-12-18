namespace Procesos
{
    partial class frmProcesos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lstProcesos = new System.Windows.Forms.ListBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procesos";
            // 
            // lstProcesos
            // 
            this.lstProcesos.FormattingEnabled = true;
            this.lstProcesos.ItemHeight = 20;
            this.lstProcesos.Location = new System.Drawing.Point(16, 64);
            this.lstProcesos.Name = "lstProcesos";
            this.lstProcesos.ScrollAlwaysVisible = true;
            this.lstProcesos.Size = new System.Drawing.Size(315, 284);
            this.lstProcesos.TabIndex = 1;
            this.lstProcesos.DoubleClick += new System.EventHandler(this.lstProcesos_DoubleClick);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(337, 64);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(314, 284);
            this.txtInfo.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(337, 371);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 33);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Terminar";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(536, 371);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(85, 33);
            this.btnKill.TabIndex = 4;
            this.btnKill.Text = "Kill";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 445);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.lstProcesos);
            this.Controls.Add(this.label1);
            this.Name = "frmProcesos";
            this.Text = "Procesos";
            this.Load += new System.EventHandler(this.frmProcesos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstProcesos;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Timer timer1;
    }
}


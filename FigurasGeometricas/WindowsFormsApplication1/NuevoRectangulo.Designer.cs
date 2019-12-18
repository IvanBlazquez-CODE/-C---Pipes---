namespace WindowsFormsApplication1
{
    partial class NuevoRectangulo
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Nuevo Rectangulo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(12, 150);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 6;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(12, 81);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 5;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(12, 11);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 4;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(12, 205);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 20);
            this.txtH.TabIndex = 8;
            // 
            // NuevoRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Name = "NuevoRectangulo";
            this.Text = "NuevoRectangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtH;
    }
}
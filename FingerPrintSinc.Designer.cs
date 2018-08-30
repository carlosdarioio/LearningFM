namespace RLFingerPrintPro
{
    partial class FingerPrintSinc
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
            this.btnsinc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsinc
            // 
            this.btnsinc.Location = new System.Drawing.Point(90, 124);
            this.btnsinc.Name = "btnsinc";
            this.btnsinc.Size = new System.Drawing.Size(75, 23);
            this.btnsinc.TabIndex = 0;
            this.btnsinc.Text = "Sincronizar";
            this.btnsinc.UseVisualStyleBackColor = true;
            this.btnsinc.Click += new System.EventHandler(this.btnsinc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "cont";
            // 
            // FingerPrintSinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsinc);
            this.Name = "FingerPrintSinc";
            this.Text = "FingerPrintSinc";
            this.Load += new System.EventHandler(this.FingerPrintSinc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsinc;
        private System.Windows.Forms.Label label1;
    }
}
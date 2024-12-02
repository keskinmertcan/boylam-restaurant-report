namespace BoylamRestoranMMRapor
{
    partial class FormHelp
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelHelpText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHelpText
            // 
            this.labelHelpText.AutoSize = true;
            this.labelHelpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHelpText.Location = new System.Drawing.Point(12, 9);
            this.labelHelpText.Name = "labelHelpText";
            this.labelHelpText.Size = new System.Drawing.Size(175, 72);
            this.labelHelpText.TabIndex = 0;
            this.labelHelpText.Text = "Mertcan Keskin\r\nYazılım Geliştirme\r\n0530 501 4882";
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 90);
            this.Controls.Add(this.labelHelpText);
            this.Name = "FormHelp";
            this.Text = "Yardım";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelHelpText;
    }
}

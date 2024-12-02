namespace BoylamRestoranMMRapor
{
    partial class FormStoreAdd
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
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.txtStoreNumber = new System.Windows.Forms.TextBox();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.lblStoreNumber = new System.Windows.Forms.Label();
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStoreName
            // 
            this.txtStoreName.Location = new System.Drawing.Point(150, 30);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(200, 20);
            this.txtStoreName.TabIndex = 0;
            // 
            // txtStoreNumber
            // 
            this.txtStoreNumber.Location = new System.Drawing.Point(150, 70);
            this.txtStoreNumber.Name = "txtStoreNumber";
            this.txtStoreNumber.Size = new System.Drawing.Size(200, 20);
            this.txtStoreNumber.TabIndex = 1;
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(150, 110);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(200, 20);
            this.txtIpAddress.TabIndex = 2;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(150, 150);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(200, 20);
            this.txtPort.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(200, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Location = new System.Drawing.Point(50, 33);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(60, 13);
            this.lblStoreName.TabIndex = 5;
            this.lblStoreName.Text = "Mağaza Adı";
            // 
            // lblStoreNumber
            // 
            this.lblStoreNumber.AutoSize = true;
            this.lblStoreNumber.Location = new System.Drawing.Point(50, 73);
            this.lblStoreNumber.Name = "lblStoreNumber";
            this.lblStoreNumber.Size = new System.Drawing.Size(68, 13);
            this.lblStoreNumber.TabIndex = 6;
            this.lblStoreNumber.Text = "Mağaza No";
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(50, 113);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(51, 13);
            this.lblIpAddress.TabIndex = 7;
            this.lblIpAddress.Text = "IP Adresi";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(50, 153);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 8;
            this.lblPort.Text = "Port";
            // 
            // FormStoreAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIpAddress);
            this.Controls.Add(this.lblStoreNumber);
            this.Controls.Add(this.lblStoreName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIpAddress);
            this.Controls.Add(this.txtStoreNumber);
            this.Controls.Add(this.txtStoreName);
            this.Name = "FormStoreAdd";
            this.Text = "Mağaza Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtStoreName;
        private System.Windows.Forms.TextBox txtStoreNumber;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblStoreNumber;
        private System.Windows.Forms.Label lblIpAddress;
        private System.Windows.Forms.Label lblPort;
    }
}

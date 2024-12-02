namespace BoylamRestoranMMRapor
{
    partial class FormNewReport
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
            this.comboBoxStores = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.lblStore = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxStores
            // 
            this.comboBoxStores.FormattingEnabled = true;
            this.comboBoxStores.Location = new System.Drawing.Point(100, 30);
            this.comboBoxStores.Name = "comboBoxStores";
            this.comboBoxStores.Size = new System.Drawing.Size(200, 21);
            this.comboBoxStores.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(100, 70);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(100, 110);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(200, 30);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "Raporu Oluştur";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(30, 33);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(48, 13);
            this.lblStore.TabIndex = 3;
            this.lblStore.Text = "Mağaza:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(30, 73);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(34, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Tarih:";
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(370, 265);
            this.dataGridViewResults.TabIndex = 5;
            // 
            // FormNewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxStores);
            this.Name = "FormNewReport";
            this.Text = "Yeni Rapor";
            this.Load += new System.EventHandler(this.FormNewReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox comboBoxStores;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dataGridViewResults;
    }
}

namespace BoylamRestoranMMRapor
{
    partial class FormStores
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
            this.dataGridViewStores = new System.Windows.Forms.DataGridView();
            this.StoreNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IpAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStores
            // 
            this.dataGridViewStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreNameColumn,
            this.StoreNumberColumn,
            this.IpAddressColumn,
            this.PortColumn});
            this.dataGridViewStores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStores.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStores.Name = "dataGridViewStores";
            this.dataGridViewStores.Size = new System.Drawing.Size(593, 450);
            this.dataGridViewStores.TabIndex = 0;
            // 
            // StoreNameColumn
            // 
            this.StoreNameColumn.DataPropertyName = "StoreName";
            this.StoreNameColumn.HeaderText = "Mağaza Adı";
            this.StoreNameColumn.Name = "StoreNameColumn";
            this.StoreNameColumn.Width = 200;
            // 
            // StoreNumberColumn
            // 
            this.StoreNumberColumn.DataPropertyName = "StoreNumber";
            this.StoreNumberColumn.HeaderText = "Mağaza No";
            this.StoreNumberColumn.Name = "StoreNumberColumn";
            // 
            // IpAddressColumn
            // 
            this.IpAddressColumn.DataPropertyName = "IpAddress";
            this.IpAddressColumn.HeaderText = "IP Adresi";
            this.IpAddressColumn.Name = "IpAddressColumn";
            this.IpAddressColumn.Width = 150;
            // 
            // PortColumn
            // 
            this.PortColumn.DataPropertyName = "Port";
            this.PortColumn.HeaderText = "Port";
            this.PortColumn.Name = "PortColumn";
            // 
            // FormStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.dataGridViewStores);
            this.Name = "FormStores";
            this.Text = "Mağazalar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStores)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dataGridViewStores;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortColumn;
    }
}

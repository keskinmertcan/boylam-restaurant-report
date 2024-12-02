using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BoylamRestoranMMRapor
{
    public partial class FormStoreAdd : Form
    {
        public FormStoreAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string storeName = txtStoreName.Text;
            string storeNumber = txtStoreNumber.Text;
            string ipAddress = txtIpAddress.Text;
            string port = txtPort.Text;

            if (string.IsNullOrEmpty(storeName) || string.IsNullOrEmpty(storeNumber) ||
                string.IsNullOrEmpty(ipAddress) || string.IsNullOrEmpty(port))
            {
                MessageBox.Show("Tüm alanları doldurmalısınız.");
                return;
            }

            string filePath = "stores.xml";
            XDocument doc;
            if (File.Exists(filePath))
            {
                doc = XDocument.Load(filePath);
            }
            else
            {
                doc = new XDocument(new XElement("Stores"));
            }

            XElement newStore = new XElement("Store",
                new XElement("StoreName", storeName),
                new XElement("StoreNumber", storeNumber),
                new XElement("IpAddress", ipAddress),
                new XElement("Port", port)
            );

            doc.Root.Add(newStore);
            doc.Save(filePath);

            MessageBox.Show("Mağaza başarıyla kaydedildi.");
            this.Close();
        }
    }
}

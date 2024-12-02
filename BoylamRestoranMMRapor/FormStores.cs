using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BoylamRestoranMMRapor
{
    public partial class FormStores : Form
    {
        public FormStores()
        {
            InitializeComponent();
            LoadStores();
        }

        private void LoadStores()
        {
            string filePath = "stores.xml";
            if (File.Exists(filePath))
            {
                XDocument doc = XDocument.Load(filePath);
                var stores = from store in doc.Descendants("Store")
                             select new
                             {
                                 StoreName = store.Element("StoreName").Value,
                                 StoreNumber = store.Element("StoreNumber").Value,
                                 IpAddress = store.Element("IpAddress").Value,
                                 Port = store.Element("Port").Value
                             };

                dataGridViewStores.AutoGenerateColumns = false;
                dataGridViewStores.DataSource = stores.ToList();
            }
            else
            {
                MessageBox.Show("Henüz kayıtlı mağaza yok.");
            }
        }
    }
}

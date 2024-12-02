using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data;

namespace BoylamRestoranMMRapor
{
    public partial class FormNewReport : Form
    {
        public FormNewReport()
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

                comboBoxStores.DataSource = stores.ToList();
                comboBoxStores.DisplayMember = "StoreName";
                comboBoxStores.ValueMember = "IpAddress";
            }
            else
            {
                MessageBox.Show("Henüz kayıtlı mağaza yok.");
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var selectedStore = comboBoxStores.SelectedItem;
            if (selectedStore == null)
            {
                MessageBox.Show("Lütfen bir mağaza seçin.");
                return;
            }

            string storeName = ((dynamic)selectedStore).StoreName;
            string ipAddress = ((dynamic)selectedStore).IpAddress;
            string port = ((dynamic)selectedStore).Port;
            DateTime selectedDate = dateTimePicker.Value;

            string connectionString = String.Format("server={0},{1};database=BYBS;user=BY001;password=3105", ipAddress, port);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT K.KASA_ADI AS [Mağaza Adı], O.TUR_ADI AS [Ödeme Türü], SUM(T.TL_TUTAR) AS Tahsilat 
                        FROM POS_TAHSILAT AS T
                        INNER JOIN POS_HRK_B AS B ON B.BASLIK_ID=T.BASLIK_ID
                        INNER JOIN KASA_TANIMLARI AS K ON K.KASA_ID=B.KASA_ID
                        INNER JOIN ODEME_TUR AS O ON O.TUR_ID=T.TUR_ID
                        WHERE B.OLUS_TARIH >= @StartDate AND B.OLUS_TARIH < @EndDate
                        GROUP BY K.KASA_ADI, O.TUR_ADI";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", selectedDate.Date);
                        command.Parameters.AddWithValue("@EndDate", selectedDate.Date.AddDays(1));
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewResults.DataSource = dataTable;

                        // TAHSILAT sütunu için hücre biçimlendirmesini ayarlayın
                        dataGridViewResults.Columns["Tahsilat"].DefaultCellStyle.Format = "N2";
                        dataGridViewResults.Columns["Tahsilat"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("tr-TR");

                        // DataGridView ayarları
                        dataGridViewResults.ReadOnly = true; // Tablonun sadece okunabilir olmasını sağlar
                        dataGridViewResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Satır bazında seçim yapar
                        dataGridViewResults.MultiSelect = false; // Çoklu seçim yapılamaz
                        dataGridViewResults.AllowUserToAddRows = false; // Kullanıcı yeni satır ekleyemez
                        dataGridViewResults.AllowUserToDeleteRows = false; // Kullanıcı satır silemez
                        dataGridViewResults.AllowUserToResizeColumns = false; // Sütun boyutları değiştirilemez
                        dataGridViewResults.AllowUserToResizeRows = false; // Satır boyutları değiştirilemez
                        dataGridViewResults.AllowUserToOrderColumns = false; // Sütun sıralaması değiştirilemez
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Veritabanına bağlanırken hata meydana geldi: {0}", ex.Message));
            }
        }

        private void FormNewReport_Load(object sender, EventArgs e)
        {
        
        }
    }
}

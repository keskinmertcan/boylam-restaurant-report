using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BoylamRestoranMMRapor
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = "YETKİLİ";
            this.ActiveControl = txtParola; // Parola kutusunu focus yapar
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string parola = txtParola.Text;

            string connectionString = "server=.;database=BYBS;user=BY001;password=3105";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM BY000.SISTEM_KULLANICILARI WHERE LOGIN = @kullaniciAdi AND PAROLA = @parola";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("@parola", parola);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Giriş başarılı!");
                    // Ana formu aç
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya parola hatalı!");
                }
            }
        }

        private void txtParola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                btnGiris_Click(this, new EventArgs());
                e.SuppressKeyPress = true; // Enter tuşu basıldığında bip sesi çıkmamasını sağlar
            }
        }

        private void lblKullaniciAdi_Click(object sender, EventArgs e)
        {

        }
    }
}

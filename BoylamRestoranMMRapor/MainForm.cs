using System;
using System.Windows.Forms;

namespace BoylamRestoranMMRapor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mağazalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStores formStores = new FormStores();
            formStores.MdiParent = this;
            formStores.Show();
        }

        private void mağazaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStoreAdd formStoreAdd = new FormStoreAdd();
            formStoreAdd.MdiParent = this;
            formStoreAdd.Show();
        }

        private void yeniRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewReport formNewReport = new FormNewReport();
            formNewReport.MdiParent = this;
            formNewReport.Show();
        }

        private void destekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog(); // Formu dialog olarak aç
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

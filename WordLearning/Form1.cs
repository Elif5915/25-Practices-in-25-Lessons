using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WordLearning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\elif.yildirim\Documents\DbWordLearning.accdb

        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.JET.OLEDB.4.0;Data Source=C:\Users\elif.yildirim\Documents\DbWordLearning.accdb");
        Random rast = new Random();
        int sure = 90;
        int kelime = 0;

        void getir()
        {
            int sayi;
            sayi = rast.Next(1, 29);
            lblCevap.Text = sayi.ToString(); // lbl cevaba sayıyı yaz demiş olduk.

            connection.Open();
            OleDbCommand komut = new OleDbCommand("select * from Sozcuk where Id= @p1", connection);
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtİnglizce.Text = dr[1].ToString();
                lblCevap.Text = dr[2].ToString();
                lblCevap.Text = lblCevap.Text.ToLower();
            }
            connection.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            timer1.Start();
        }

        private void txtTürkce_TextChanged(object sender, EventArgs e)
        {
            if (txtTürkce.Text == lblCevap.Text)
            {
                kelime++;
                lblKelime.Text = kelime.ToString();
                getir();
                txtTürkce.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if (sure == 0)
            {
                txtTürkce.Enabled = false;
                txtİnglizce.Enabled = false;
                timer1.Stop();
            }
        }
    }
}

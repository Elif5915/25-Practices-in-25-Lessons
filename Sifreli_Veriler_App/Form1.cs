using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Sifreli_Veriler_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=Test;Integrated Security=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void alanTemizle()
        {
            txtAd.Text = "";
            TxtSoyad.Text = "";
            txtMail.Text = "";
            txtSifre.Text = "";
            txtHesapNo.Text = "";
        }

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select *from veriler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            byte[] adDizisi = ASCIIEncoding.ASCII.GetBytes(ad);
            string adSifreVeri = Convert.ToBase64String(adDizisi);
            // label1.Text = adSifreVeri;

            string soyad = TxtSoyad.Text;
            byte[] soyadDizisi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadSifreVeri = Convert.ToBase64String(soyadDizisi);

            string mail = txtMail.Text;
            byte[] mailDizisi = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailSifreVeri = Convert.ToBase64String(mailDizisi);

            string sifre = txtSifre.Text;
            byte[] sifreDizisi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string SifreVeri = Convert.ToBase64String(sifreDizisi);

            string hesapNo = txtHesapNo.Text;
            byte[] hesapNoDizisi = ASCIIEncoding.ASCII.GetBytes(hesapNo);
            string hesapNoSifreVeri = Convert.ToBase64String(hesapNoDizisi);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Veriler (Ad,Soyad,Mail,Sifre,HesapNo) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", adSifreVeri);
            komut.Parameters.AddWithValue("@p2", soyadSifreVeri);
            komut.Parameters.AddWithValue("@p3", mailSifreVeri);
            komut.Parameters.AddWithValue("@p4", SifreVeri);
            komut.Parameters.AddWithValue("@p5", hesapNoSifreVeri);
            komut.ExecuteNonQuery(); //yukarıdaki insert komutumu çalıştır
            baglanti.Close();

            MessageBox.Show("Veriler eklendi.");
            alanTemizle();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSifreCöz_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Ad"].Value != null)
                {
                    string adSifreli = row.Cells["Ad"].Value.ToString();
                    byte[] adSifreliDizisi = Convert.FromBase64String(adSifreli);
                    string adCozulmus = ASCIIEncoding.ASCII.GetString(adSifreliDizisi);
                    row.Cells["Ad"].Value = adCozulmus;
                }

                // Soyad çözme
                if (row.Cells["Soyad"].Value != null)
                {
                    string soyadSifreli = row.Cells["Soyad"].Value.ToString();
                    byte[] soyadSifreliDizisi = Convert.FromBase64String(soyadSifreli);
                    string soyadCozulmus = ASCIIEncoding.ASCII.GetString(soyadSifreliDizisi);
                    row.Cells["Soyad"].Value = soyadCozulmus;
                }

                // Mail çözme
                if (row.Cells["Mail"].Value != null)
                {
                    string mailSifreli = row.Cells["Mail"].Value.ToString();
                    byte[] mailSifreliDizisi = Convert.FromBase64String(mailSifreli);
                    string mailCozulmus = ASCIIEncoding.ASCII.GetString(mailSifreliDizisi);
                    row.Cells["Mail"].Value = mailCozulmus;
                }

                // Şifre çözme
                if (row.Cells["Sifre"].Value != null)
                {
                    string sifreSifreli = row.Cells["Sifre"].Value.ToString();
                    byte[] sifreSifreliDizisi = Convert.FromBase64String(sifreSifreli);
                    string sifreCozulmus = ASCIIEncoding.ASCII.GetString(sifreSifreliDizisi);
                    row.Cells["Sifre"].Value = sifreCozulmus;
                }

                // HesapNo çözme
                if (row.Cells["HesapNo"].Value != null)
                {
                    string hesapNoSifreli = row.Cells["HesapNo"].Value.ToString();
                    byte[] hesapNoSifreliDizisi = Convert.FromBase64String(hesapNoSifreli);
                    string hesapNoCozulmus = ASCIIEncoding.ASCII.GetString(hesapNoSifreliDizisi);
                    row.Cells["HesapNo"].Value = hesapNoCozulmus;
                }
            }
        }
    }
}

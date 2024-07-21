using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankaMatik
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //Data Source=NETCADYAZ;Initial Catalog=DbNotKayit;Integrated Security=True;Trust Server Certificate=True

        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=BankaMatik;Integrated Security=True");
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kisiler(AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", txtBoxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTCkimlikNo.Text);
            komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", mskHesapNo.Text);
            komut.Parameters.AddWithValue("@p6", txtBoxSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Yeni müşteri kaydı başarılı bir şekilde gerçekleştirildi.");
            Temizle();



        }

        void Temizle()
        {
            txtBoxAd.Text = "";
            txtBoxSifre.Text = "";
            txtBoxSoyad.Text = "";
            mskHesapNo.Text = "";
            mskTCkimlikNo.Text = "";
            mskTelefon.Text = "";
        }

        private void btnHesapNoUret_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int sayi = random.Next(100000, 1000000);
            mskHesapNo.Text = sayi.ToString();


        }
    }
}

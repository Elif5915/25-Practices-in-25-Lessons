using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankaMatik
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=BankaMatik;Integrated Security=True");
        public string hesap;
        private void Form2_Load(object sender, EventArgs e)
        {
            lblhesapno.Text = hesap;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Kisiler where hesapno = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[1] + " " + dr[2];
                lblTelefon.Text = dr[4].ToString();
                lblTcNo.Text = dr[3].ToString();
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //gönderilen hesabın para artışı
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update hesap set bakıye = bakıye+@p1 where hesapno=@p2 ", baglanti);
            komut.Parameters.AddWithValue("@p1", decimal.Parse(txttutar.Text));
            komut.Parameters.AddWithValue("@p2", mskHesapNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Havale işlemi yapıldı.");

            mskHesapNo.Text = "";
            txttutar.Text = "";

            //gönderen hesabın para azalışı 
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update hesap set bakıye = bakıye-@k1 where hesapno=@k2 ", baglanti);
            komut2.Parameters.AddWithValue("@k1", decimal.Parse(txttutar.Text));
            komut2.Parameters.AddWithValue("@k2", hesap);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Havale işlemi yapıldı.");

            mskHesapNo.Text = "";
            txttutar.Text = "";

        }
    }
}

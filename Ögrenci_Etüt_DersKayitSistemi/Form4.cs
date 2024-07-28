using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ögrenci_Etüt_DersKayitSistemi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=DersKayitSistemi;Integrated Security=True");


        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Dersler (DersAd) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtYeniDers.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Yeni Ders Oluşturulmuştur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtYeniDers.Text = "";

        }
    }
}

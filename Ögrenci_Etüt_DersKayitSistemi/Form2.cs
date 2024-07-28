using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ögrenci_Etüt_DersKayitSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=DersKayitSistemi;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void dersListesi()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from Dersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxBrans.ValueMember = "DersId"; //valuemember denilen şey ilişkili yapıda yani tablonun id alanı yani ders tablosunun dersid alanı bizim valuemember alanımız oluyor ve bunu hafıza tutacak.büyük-küçük harf duyarlılığı var.
            comboBoxBrans.DisplayMember = "DersAd"; // displaymember ise öm tarafta çalışacak değerimiz. yani valuemember arka tarafta displaymember önö tarafta çalışacak değer gibi düşünelim.
            comboBoxBrans.DataSource = dt;
            baglanti.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dersListesi();
        }

        private void btnOgretmenEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Ogretmen (Ad,Soyad,BransId) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBoxBrans.SelectedValue);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Öğretmen Kaydetme İşlemi Başarılı Şekilde Yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtAd.Text = "";
            txtSoyad.Text = "";
            comboBoxBrans.Text = "";



        }
    }
}

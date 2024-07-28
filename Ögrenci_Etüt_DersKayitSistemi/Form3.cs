using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Ögrenci_Etüt_DersKayitSistemi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=DersKayitSistemi;Integrated Security=True");

        void OgrenciAlanTemizle()
        {
            txtmail.Text = "";
            txtOgrenciAd.Text = "";
            txtOgrencıSoyad.Text = "";
            txtSınıfı.Text = "";
            mskTelefon.Text = "";
            pictureBox2.Image = null;
        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox2.Tag = openFileDialog.FileName; // Dosya yolunu Tag özelliğine atıyoruz
            }
        }

        private void btnOgrencıEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Ogrenci (Ad,Soyad,Fotograf,Sinif,Telefon,Mail) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtOgrenciAd.Text);
            komut.Parameters.AddWithValue("@p2", txtOgrencıSoyad.Text);
            komut.Parameters.AddWithValue("@p3", pictureBox2.Tag.ToString());
            komut.Parameters.AddWithValue("@p4", txtSınıfı.Text);
            komut.Parameters.AddWithValue("@p5", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p6", txtmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Öğrenci Kayıdı Başarılı Şekilde Yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OgrenciAlanTemizle();
        }
    }
}

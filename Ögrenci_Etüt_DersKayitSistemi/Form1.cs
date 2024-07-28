using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ögrenci_Etüt_DersKayitSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Data Source=NETCADYAZ;Initial Catalog=DbNotKayit;Integrated Security=True;Trust Server Certificate=True

        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=DersKayitSistemi;Integrated Security=True");

        void dersListesi()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from Dersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmboxDers.ValueMember = "DersId"; //valuemember denilen şey ilişkili yapıda yani tablonun id alanı yani ders tablosunun dersid alanı bizim valuemember alanımız oluyor ve bunu hafıza tutacak.büyük-küçük harf duyarlılığı var.
            cmboxDers.DisplayMember = "DersAd"; // displaymember ise öm tarafta çalışacak değerimiz. yani valuemember arka tarafta displaymember önö tarafta çalışacak değer gibi düşünelim.
            cmboxDers.DataSource = dt;
            baglanti.Close();
        }

        void EtutOluşturTemizle()
        {
            cmboxDers.Text = "";
            cmboxOgretmen.Text = "";
            mskSaat.Text = "";
            msktarih.Text = "";
        }

        //Etüt Listesi
        void EtutListesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("execute EtutBilgileriProcedure", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dersListesi();
            EtutListesi();

        }

        private void cmboxDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seçilen derse göre öğretmen combosunun öyle dolması 
            SqlDataAdapter da2 = new SqlDataAdapter("select (Ad + ' ' + Soyad) as AdSoyad, *from Ogretmen where BransId = " + cmboxDers.SelectedValue, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmboxOgretmen.ValueMember = "OgrtId";
            cmboxOgretmen.DisplayMember = "AdSoyad";
            cmboxOgretmen.DataSource = dt2;
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Etut (DersId,OgretmenId,Tarih,Saat) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmboxDers.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmboxOgretmen.SelectedValue);
            komut.Parameters.AddWithValue("@p3", msktarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Etüt Başarılı Şekilde Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EtutOluşturTemizle();

        }

        private void lnkOgretmenEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            //datagird viewde tıklanan verini id yazıyoruz
            textBox2.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

        }

        private void btnEtutVer_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Etut set OgrenciId=@p1,Durum=@p2 where Id=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", txtOgrenciNumarasi.Text);
            komut.Parameters.AddWithValue("@p2", "True");
            komut.Parameters.AddWithValue("@p3", textBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Etüt Öğrenciye Verildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtOgrenciNumarasi.Text = "";
            textBox2.Text = "";



        }

        private void lnkOgrenciEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();

        }

        private void lnkDersEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }
    }
}

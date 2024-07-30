using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Sefer_Seyahat_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        // Data Source=NETCADYAZ;Initial Catalog=DbNotKayit;Integrated Security=True;Trust Server Certificate=True

        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=YolcuBiletKayitSistemi;Integrated Security=True");

        void Clear()
        {
            txtAd.Text = string.Empty;
            txtSoyad.Text = "";
            mskTelefon.Text = "";
            mskTc.Text = "";
            cmbCinsiyet.Text = "";
            txtMail.Text = "";
        }

        void SeferListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select *from SeferBilgi", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Yolcular (Ad,Soyad,Telefon,Tc,Cinsiyet,Mail) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", mskTc.Text);
            komut.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Yeni Yolcu Sisteme Başarılı Bir Şekilde Kayıt Edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }

        private void btnKaptanEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into Kaptan (KaptanNo,AdSoyad,TelefonNo) values (@p1,@p2,@p3)", baglanti);
            command.Parameters.AddWithValue("@p1", txtKaptanNo.Text);
            command.Parameters.AddWithValue("@p2", txtKaptanAdSoyad.Text);
            command.Parameters.AddWithValue("@p3", mskKaptanTelefon.Text);
            command.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kaptan Sisteme Başarılı Bir Şekilde Kayıt Edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtKaptanNo.Text = "";
            txtKaptanAdSoyad.Text = "";
            mskKaptanTelefon.Text = "";

        }

        private void btnSeferOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sql = new SqlCommand("insert into SeferBilgi (Kalkis,Varis,Tarih,Saat,Kaptan,Fiyat) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            sql.Parameters.AddWithValue("@p1", txtKalkis.Text);
            sql.Parameters.AddWithValue("@p2", txtVaris.Text);
            sql.Parameters.AddWithValue("@p3", mskTarih.Text);
            sql.Parameters.AddWithValue("@p4", mskSaat.Text);
            sql.Parameters.AddWithValue("@p5", mskKaptan.Text);
            sql.Parameters.AddWithValue("@p6", txtFiyat.Text);
            sql.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Yeni Sefer Sisteme Başarılı Bir Şekilde Oluşturulmuştur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtKalkis.Text = "";
            txtVaris.Text = "";
            mskTarih.Text = "";
            mskSaat.Text = "";
            mskKaptan.Text = "";
            txtFiyat.Text = "";

            SeferListesi();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SeferListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "9";
        }

        private void btnRezerveYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into SeferDetay (YolcuTcNo,Koltuk,SeferNo) values (@p1,@p2,@p3)", baglanti);
            sqlCommand.Parameters.AddWithValue("@p1", mskYolcuTc.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtKoltukNo.Text);
            sqlCommand.Parameters.AddWithValue("@p3", textBox1.Text);
            sqlCommand.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Yeni Sefer Sisteme Başarılı Bir Şekilde Oluşturulmuştur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mskYolcuTc.Text = "";
            txtKoltukNo.Text = "";
            textBox1.Text = "";

        }
    }
}

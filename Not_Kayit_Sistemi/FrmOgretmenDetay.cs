using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Not_Kayit_Sistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=DbNotKayit;Integrated Security=True");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmOgretmenDetay_Load(object sender, EventArgs e) //burada otomatik oluşan kod var aşağıdaki o sihirbazın oluşturduğu işte 
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.TBLDERS' table. You can move, or remove it, as needed.
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERS (OGRNUMARA,OGRAD,OGRSOYAD) values (@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", mskNumara.Text);
            komut.Parameters.AddWithValue("@P2", txtAd.Text);
            komut.Parameters.AddWithValue("@P3", txtSoyad.Text);
            komut.ExecuteNonQuery(); //dml komut işlemlerini gerçekleştirmemize yarar.sorguyu çalıştır ve gerçekleştir diyoruz.
            baglanti.Close();

            MessageBox.Show("Öğrenci başarılı bir şekilde sisteme eklenmiştir.");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS); // bu kod komutu otomatik doldurma yapan kod parçasıdır.
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenRow = dataGridView1.SelectedCells[0].RowIndex;


            mskNumara.Text = dataGridView1.Rows[secilenRow].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilenRow].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilenRow].Cells[3].Value.ToString();

            txtSinav1.Text = dataGridView1.Rows[secilenRow].Cells[4].Value.ToString();
            txtSinav2.Text = dataGridView1.Rows[secilenRow].Cells[5].Value.ToString();
            txtSinav3.Text = dataGridView1.Rows[secilenRow].Cells[6].Value.ToString();
        }
        string durum;
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;

            s1 = Convert.ToDouble(txtSinav1.Text);
            s2 = Convert.ToDouble(txtSinav2.Text);
            s3 = Convert.ToDouble(txtSinav3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            lblOrtalama.Text = Convert.ToString(ortalama);

            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLDERS set OGRS1 = @p1,OGRS2 = @p2, OGRS3 = @p3, ORTALAMA = @p4,DURUM = @p5 Where OGRNUMARA = @p6", baglanti);
            komut.Parameters.AddWithValue("@p1", txtSinav1.Text);
            komut.Parameters.AddWithValue("@p2", txtSinav2.Text);
            komut.Parameters.AddWithValue("@p3", txtSinav3.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(lblOrtalama.Text));
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", mskNumara.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Öğrencinin notları başarıyla güncellendi.");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);
        }

        private void lblGecenOgrenciSayisi_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select COUNT(DURUM) from TBLDERS where DURUM = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", true);

            int count = (int)komut.ExecuteScalar();
            lblGecenOgrenciSayisi.Text = count.ToString();

            baglanti.Close();


        }

        private void lblKalanOgrenciSayisi_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select COUNT(DURUM) from TBLDERS where DURUM = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", false);

            int count = (int)komut.ExecuteScalar();
            lblKalanOgrenciSayisi.Text = count.ToString();

            baglanti.Close();
        }
    }
}

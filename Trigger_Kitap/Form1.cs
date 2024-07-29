using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trigger_Kitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Data Source=NETCADYAZ;Initial Catalog=DbNotKayit;Integrated Security=True;Trust Server Certificate=True
        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=Test;Integrated Security=True");

        void Listele()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select *from Kıtaplar", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void Clear()
        {
            txtAd.Text = "";
            txtYazar.Text = "";
            txtSayfa.Text = "";
            txtYayınEvi.Text = "";
            txtTur.Text = "";
        }

        void Sayac()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from KıtapSayac", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblSayacNo.Text = dr[0].ToString();
            }
            baglanti.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
            Sayac();
        }

        private void btKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kıtaplar (AD,YAZAR,SAYFA,YAYINEVI,TUR) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYazar.Text);
            komut.Parameters.AddWithValue("@p3", txtSayfa.Text);
            komut.Parameters.AddWithValue("@p4", txtYayınEvi.Text);
            komut.Parameters.AddWithValue("@p5", txtTur.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Yeni Kitap Oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            Listele();
            Sayac();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtYayınEvi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtTur.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Kıtaplar where Id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Seçilen Kitap Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Text = "";
            Clear();
            Listele();
            Sayac();
        }
    }
}

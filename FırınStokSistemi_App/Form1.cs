using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace FırınStokSistemi_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Data Source=NETCADYAZ;Initial Catalog=PastaHaneMaliyetStokSistem;Integrated Security=True;Trust Server Certificate=True

        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=PastaHaneMaliyetStokSistem;Integrated Security=True;");

        void MalzemeListe()
        {
            SqlDataAdapter da = new SqlDataAdapter("select *from Malzemeler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void urunListesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select *from Urunler", baglanti);
            DataTable dt2 = new DataTable(); // sanal tablo oluşturuyoruz
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        void kasaGetir()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("select *from Kasa", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        void comboUrunler()
        {
            baglanti.Open();
            //SqlCommand sql = new SqlCommand("select *from Urunler", baglanti);
            //SqlDataReader dr = sql.ExecuteReader();
            //while (dr.Read())
            //{
            //    cmbUrun.Items.Add(dr[1]);
            //}
            SqlDataAdapter da = new SqlDataAdapter("select *from Urunler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbUrun.ValueMember = "Urunİd"; //valuemember denilen alan bu combobox arka planda neyi alacak urunid alacak
            cmbUrun.DisplayMember = "Ad";
            cmbUrun.DataSource = dt;
            baglanti.Close();
        }

        void comboMalzemeler()
        {
            baglanti.Open();
            //SqlCommand sqlCommand = new SqlCommand("select *from Malzemeler", baglanti);
            //SqlDataReader dr = sqlCommand.ExecuteReader();
            //while (dr.Read())
            //{
            //    cmbMalzeme.Items.Add(dr[1]);
            //}
            SqlDataAdapter da = new SqlDataAdapter("select * from Malzemeler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMalzeme.ValueMember = "MalzemeId";
            cmbMalzeme.DisplayMember = "Ad";
            cmbMalzeme.DataSource = dt;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MalzemeListe();
            comboUrunler();
            comboMalzemeler();
        }

        private void btnUrunList_Click(object sender, EventArgs e)
        {
            urunListesi();
        }

        private void btnMalzemeList_Click(object sender, EventArgs e)
        {
            MalzemeListe();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            kasaGetir();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Malzemeler (Ad,Stok,Fiyat,Notlar) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtMalzemeAd.Text);
            komut.Parameters.AddWithValue("@p2", decimal.Parse(txtMalzemeStok.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtMalzemeFiyat.Text));
            komut.Parameters.AddWithValue("@p4", txtMalzemeNotlar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Yeni malzeme bilgileri başarılı şekilde kayıt edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtMalzemeAd.Text = "";
            txtMalzemeStok.Text = "";
            txtMalzemeFiyat.Text = "";
            txtMalzemeNotlar.Text = "";

            MalzemeListe();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("insert into Urunler (Ad) values (@p1)", baglanti);
            kmt.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            kmt.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Yeni ürün bilgisi başarılı şekilde kayıt edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtUrunAd.Text = "";

            urunListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Firin (UrunId,MalzemeId,Miktar,Maliyet) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbMalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtMiktar.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtMaliyet.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ürün Fırına başarılı şekilde eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtMaliyet.Text = "";
            txtMiktar.Text = "";


            listBox1.Items.Add(cmbMalzeme.Text + " - " + txtMaliyet.Text);

        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;

            if (txtMiktar.Text == "")
            {
                txtMiktar.Text = "0";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Malzemeler where MalzemeId =@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbMalzeme.SelectedValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtMaliyet.Text = dr[3].ToString();
            }
            baglanti.Close();

            maliyet = Convert.ToDouble(txtMaliyet.Text) / 1000 * Convert.ToDouble(txtMiktar.Text);
            txtMaliyet.Text = maliyet.ToString();
        }

        private void cmbMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtUrunId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtUrunAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Maliyet) from Firin where UrunId = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunId.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtUrunMaliyetFiyat.Text = dr[0].ToString();
            }
            baglanti.Close();


        }
    }
}

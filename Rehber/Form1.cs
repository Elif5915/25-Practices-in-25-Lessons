using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Rehber
{
    public partial class REHBER : Form
    {
        public REHBER()
        {
            InitializeComponent();
        }
        // Data Source=NETCADYAZ;Initial Catalog=Rehber;Integrated Security=True

        SqlConnection connect = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=Rehber;Integrated Security=True");

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from Kisiler", connect);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTxtBoxTelefon.Text = "";
            txtMail.Text = "";

            txtAd.Focus(); // imleci de temizleme işinden sonra ad odaklasın dedik burada 

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand("insert into Kisiler(AD,SOYAD,TELEFON,MAIL) values (@p1,@p2,@p3,@P4)", connect);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTxtBoxTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtMail.Text);
            komut.ExecuteNonQuery(); //sorguyu çalıştır diyoruz.

            connect.Close();

            MessageBox.Show("Yeni Kişi Başarılı Şekilde Rehberinize Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Listele();
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridviewde herhangi bir hücreye tıklayınca o bilgileri ilgili texxboxlara geri yazsın.

            int secilen = dataGridView1.SelectedCells[0].RowIndex; // o satırın indexsini hafıza tut dedik burada.
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTxtBoxTelefon.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand("delete from Kisiler where ID =" + txtId.Text, connect);
            komut.ExecuteNonQuery();

            connect.Close();

            MessageBox.Show("Kayıtlı Kişi Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            connect.Open();

            SqlCommand komut = new SqlCommand("update Kisiler set AD= @p1, SOYAD= @p2, TELEFON= @p3, MAIL= @p4 where ID=@p5", connect);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTxtBoxTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtMail.Text);
            komut.Parameters.AddWithValue("@p5", txtId.Text);
            komut.ExecuteNonQuery();

            connect.Close();
            MessageBox.Show("Kişi bilgisi güncellendi.");
            Listele();
            Temizle();

        }
    }
}

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veri_Tabanlı_Parti_Seçim_Grafik_İstatistik
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }

        // Data Source=NETCADYAZ;Initial Catalog=DbSecimProje;Integrated Security=True
        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=DbSecimProje;Integrated Security=True");
        private void btnOyGir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (İLCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
            komut.Parameters.AddWithValue("@P1", txtİlceAd.Text);
            komut.Parameters.AddWithValue("@P2", txtAparti.Text);
            komut.Parameters.AddWithValue("@P3", txtBparti.Text);
            komut.Parameters.AddWithValue("@P4", txtCparti.Text);
            komut.Parameters.AddWithValue("@P5", txtDparti.Text);
            komut.Parameters.AddWithValue("@P6", txtEparti.Text);

            komut.ExecuteNonQuery(); //sorguyu gerçekleştir diyoruz.
            baglanti.Close();

            MessageBox.Show("Partilerin oy girişleri başarılı şekilde yapılmıştır.");

            txtİlceAd.Text = "";
            txtAparti.Text = "";
            txtBparti.Text = "";
            txtCparti.Text = "";
            txtDparti.Text = "";
            txtEparti.Text = "";
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm = new FrmGrafikler();
            frm.Show();
        }
    }
}

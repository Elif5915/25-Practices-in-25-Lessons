using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veri_Tabanlı_Parti_Seçim_Grafik_İstatistik
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=DbSecimProje;Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            // ilçe adlarını sf yüklenince combo içine  çekme 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select İLCEAD from TBLILCE", baglanti);
            SqlDataReader rd = komut.ExecuteReader(); //veri okutma 

            while (rd.Read())
            {
                comboBox1.Items.Add(rd[0]);
            }
            baglanti.Close();

            //Grafiğe toplam sonuçları getirme
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select sum(APARTI),sum(BPARTI),sum(CPARTI),sum(DPARTI),sum(EPARTI) from TBLILCE ", baglanti);
            SqlDataReader sqlDataReader = kmt.ExecuteReader();
            while (sqlDataReader.Read())
            {
                grafik.Series["Partiler"].Points.AddXY("A Parti", sqlDataReader[0]);
                grafik.Series["Partiler"].Points.AddXY("B Parti", sqlDataReader[1]);
                grafik.Series["Partiler"].Points.AddXY("C Parti", sqlDataReader[2]);
                grafik.Series["Partiler"].Points.AddXY("D Parti", sqlDataReader[3]);
                grafik.Series["Partiler"].Points.AddXY("E Parti", sqlDataReader[4]);


            }
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand data = new SqlCommand("select *from TBLILCE where İLCEAD = @p1 ", baglanti);
            data.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr = data.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                lblA.Text = dr[2].ToString();
                lblB.Text = dr[3].ToString();
                lblC.Text = dr[4].ToString();
                lblD.Text = dr[5].ToString();
                lblE.Text = dr[6].ToString();
            }
            baglanti.Close();
        }
    }
}

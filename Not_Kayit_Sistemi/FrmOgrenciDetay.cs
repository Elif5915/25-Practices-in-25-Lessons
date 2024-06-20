using System;
using System.Data.SqlClient; //dql kütüphanemizi ekledik.
using System.Windows.Forms;

namespace Not_Kayit_Sistemi
{
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }
        //Data Source=NETCADYAZ;Initial Catalog=DbNotKayit;Integrated Security=True;Trust Server Certificate=True
        private void label7_Click(object sender, EventArgs e)
        {

        }
        public string numara; //global değişken ürettik.

        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=DbNotKayit;Integrated Security=True");
        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from TBLDERS where OGRNUMARA=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);  // where sartındaki paramterenin hangi değerden gelip alması gerektiğini belirledik ve değeri atadık.
            SqlDataReader dr = komut.ExecuteReader();     //veri okuyucu oluşturduk.

            while (dr.Read()) //dr komutun okuma işlemi yaptığı sürece yani db değerleri okuduğu sürece parametreye gelen numara ile karşılaşana kadar 
            {
                lblAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                lblSinav1.Text = dr[4].ToString();
                lblSinav2.Text = dr[5].ToString();
                lblSinav3.Text = dr[6].ToString();
                lblSinavOrt.Text = dr[7].ToString();
                lblSinavDurum.Text = dr[8].ToString();
            }
            baglanti.Close();
        }
    }
}

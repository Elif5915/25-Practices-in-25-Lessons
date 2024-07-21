using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankaMatik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=BankaMatik;Integrated Security=True");
        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void btnGirisYap_Click(object sender, System.EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Kisiler where hesapno=@p1 and sıfre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", mskHesapNo.Text);
            komut.Parameters.AddWithValue("@p2", txtboxSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 frm = new Form2();
                frm.hesap = mskHesapNo.Text;
                frm.Show();
            }
            else
            {
                MessageBox.Show("hatalı giriş yapıyorsunuz,bilgilerinizi kontrol ediniz..");
            }
            baglanti.Close();
            Temizle();
        }

        void Temizle()
        {
            txtboxSifre.Text = "";
            mskHesapNo.Text = "";
        }
    }
}

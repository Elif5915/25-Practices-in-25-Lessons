using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MesajSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Data Source=NETCADYAZ;Initial Catalog=DbNotKayit;Integrated Security=True

        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=MesajlasmaSistemi;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select *from Kisiler where Numara = @p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", mskNumara.Text);
            komut.Parameters.AddWithValue("@p2", txtBoxSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 frm = new Form2();
                frm.numara = mskNumara.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girilen numara veya şifre yanlıştır. Lütfen bilgileri kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }
    }
}

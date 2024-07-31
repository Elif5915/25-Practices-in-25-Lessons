using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Data Source=NETCADYAZ;Initial Catalog=DbNotKayit;Integrated Security=True;Trust Server Certificate=True

        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=PetrolStokTakip;Integrated Security=True");

        void List()
        {
            //kursunsuz95

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Benzin where Petroltur='Kurşunsuz95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblkursunsuz95.Text = dr[3].ToString();
                progressBar1.Value = int.Parse(dr[4].ToString());
                lblkursuzsuz95litre.Text = dr[4].ToString();
            }
            baglanti.Close();

            //kursunsuz97

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select *from Benzin where Petroltur='Kurşunsuz97'", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblkursunsuz97.Text = dr1[3].ToString();
                progressBar2.Value = int.Parse(dr1[4].ToString());
                lblkursuzsuz97litre.Text = dr1[4].ToString();
            }
            baglanti.Close();

            //euro Dizel10

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select *from Benzin where Petroltur='EuroDizel10'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblEuroDizel10.Text = dr2[3].ToString();
                progressBar3.Value = int.Parse(dr2[4].ToString());
                lblEuroDizel10litre.Text = dr2[4].ToString();
            }
            baglanti.Close();

            //yeni prodizel

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select *from Benzin where Petroltur='YeniProDizel'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblYeniProDizel.Text = dr3[3].ToString();
                progressBar4.Value = int.Parse(dr3[4].ToString());
                lblYeniprodizellitre.Text = dr3[4].ToString();
            }
            baglanti.Close();

            //gaz

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select *from Benzin where Petroltur='Gaz'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblGaz.Text = dr4[3].ToString();
                progressBar5.Value = int.Parse(dr4[4].ToString());
                lblgazlitre.Text = dr4[4].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select *from Kasa", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblkasadakitutar.Text = dr6[0].ToString();
            }
            baglanti.Close();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            List();


        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(lblkursunsuz95.Text);
            litre = Convert.ToDouble(numericUpDown1.Value);
            tutar = kursunsuz95 * litre;
            txt95fiyat.Text = tutar.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97, litre, tutar;
            kursunsuz97 = Convert.ToDouble(lblkursunsuz97.Text);
            litre = Convert.ToDouble(numericUpDown2.Value);
            tutar = kursunsuz97 * litre;
            txt97fiyat.Text = tutar.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double euroDizel10, litre, tutar;
            euroDizel10 = Convert.ToDouble(lblEuroDizel10.Text);
            litre = Convert.ToDouble(numericUpDown3.Value);
            tutar = euroDizel10 * litre;
            txtdizel10fiyat.Text = tutar.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double yeniproDizel, litre, tutar;
            yeniproDizel = Convert.ToDouble(lblYeniProDizel.Text);
            litre = Convert.ToDouble(numericUpDown4.Value);
            tutar = yeniproDizel * litre;
            txtprodizelfiyat.Text = tutar.ToString();

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;
            gaz = Convert.ToDouble(lblGaz.Text);
            litre = Convert.ToDouble(numericUpDown5.Value);
            tutar = gaz * litre;
            txtgazfiyat.Text = tutar.ToString();
        }

        private void btndepodoldur_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into SatisHareketleri (Plaka,BenzinTuru,Litre,Fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtplakagir.Text);
                komut.Parameters.AddWithValue("@p2", "Kurşunsuz95");
                komut.Parameters.AddWithValue("@p3", numericUpDown1.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txt95fiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();



                txtplakagir.Text = "";
                numericUpDown1.Value = 0;
                txt95fiyat.Text = "";

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Kasa set Miktar = Miktar+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", txt95fiyat.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();


                baglanti.Open();
                SqlCommand sql = new SqlCommand("update Benzin set Stok=Stok-@p1 where PetrolTur='Kurşunsuz95'", baglanti);
                sql.Parameters.AddWithValue("@p1", numericUpDown1.Value);
                sql.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Satış Gerçekleştirildi.");
                List();
            }
        }
    }
}

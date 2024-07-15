using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MesajSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string numara;

        // Data Source=NETCADYAZ;Initial Catalog=DbNotKayit;Integrated Security=True

        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=MesajlasmaSistemi;Integrated Security=True");

        void GelenKutusu()
        {
            SqlDataAdapter da = new SqlDataAdapter("select *from Mesajlar where Alici =" + numara, baglanti);
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridView1.DataSource = data;
        }

        void GidenKutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select *from Mesajlar where Gonderen =" + numara, baglanti);
            DataTable data2 = new DataTable();
            da2.Fill(data2);
            dataGridView2.DataSource = data2;
        }

        void MesajPaneliTemizle()
        {
            mskAlici.Text = "";
            txtBoxBaslik.Text = "";
            richMesaj.Text = "";
        }
        private void Form2_Load(object sender, EventArgs e)
        {


            lblNumara.Text = numara;

            GelenKutusu();
            GidenKutusu();

            //ad soyad çekme numaraya ait 

            baglanti.Open();

            SqlCommand komut = new SqlCommand(@"select Ad,Soyad from Kisiler where Numara =" + numara, baglanti);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                LblAdSoyad.Text = dataReader[0] + " " + dataReader[1];

            }
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(@"insert into Mesajlar (Gonderen,Alici,Baslik,Icerik) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            komut.Parameters.AddWithValue("@p2", mskAlici.Text);
            komut.Parameters.AddWithValue("@p3", txtBoxBaslik.Text);
            komut.Parameters.AddWithValue("@p4", richMesaj.Text);

            komut.ExecuteNonQuery(); // yukarıdaki insert sorgusunu gerçekleştir/çalıştır
            baglanti.Close();

            MessageBox.Show("Mesajınız iletildi.");
            GidenKutusu();
            MesajPaneliTemizle();


        }
    }
}

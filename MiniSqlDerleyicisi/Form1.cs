using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniSqlDerleyicisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Data Source=NETCADYAZ;Initial Catalog=DbNotKayit;Integrated Security=True

        SqlConnection connection = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=Hareket;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalistir_Click(object sender, EventArgs e)
        {

            try
            {
                string sorgu = richTextBox1.Text;

                SqlDataAdapter sqlData = new SqlDataAdapter(sorgu, connection);
                //SqlDataAdapter da = new SqlDataAdapter("select *from Urunler", connectin);
                DataTable dt = new DataTable();

                sqlData.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Yazmış olduğunuz sorgunuzu kontrol ediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            dataGridView1.DataSource = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = richTextBox1.Text;

            try
            {
                connection.Open();
                SqlCommand komut = new SqlCommand(sorgu, connection);
                komut.ExecuteNonQuery();
                connection.Close();

                SqlDataAdapter da = new SqlDataAdapter("select *from urunler", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yazmış olduğunuz sorgunuzu kontrol ediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btnSqlHakkinda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu sql derleyici Hareket isimli veritabanına bağlıdır. Bu veritabanında hareketler,musteriler,personel,urunler olmak üzere 4 adet tablo mevcuttur. tabloların önce selectlerini çekerek kolonlar ve neler tuttuğunu görebilirsiniz.Daha sonra üzerinde silme,güncelleme,update işlemleri yapabilirsiniz. Kolay gelsin..:)", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

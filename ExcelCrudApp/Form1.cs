using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ExcelCrudApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // C:\Users\elif.yildirim\Desktop\Sınav_1.xlsx
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\elif.yildirim\Desktop\Sınav_1.xlsx; Extended Properties='Excel 12.0 Xml;HDR=YES'"); //exceli db olarak kullanıyor ve excel ile db işlemleri yapacağız
        void Listele()
        {
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select *from [Sayfa1$]", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into [Sayfa1$] (Saat,Ders) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Yeni Ders Bilgisi Eklendi.");
            Listele();
        }
    }
}

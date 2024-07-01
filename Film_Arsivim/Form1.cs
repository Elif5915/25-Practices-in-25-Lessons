using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Film_Arsivim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        // Data Source = NETCADYAZ; Initial Catalog = DbNotKayit; Integrated Security = True; Trust Server Certificate=True

        SqlConnection baglanti = new SqlConnection(@"Data Source=NETCADYAZ;Initial Catalog=FilmArsivim;Integrated Security=True");

        private List<Color> renkListesi = new List<Color> { Color.Yellow, Color.Green, Color.Blue }; //renk listemizi tanımladım
        private int suankiRenk = 0; //şu anki rengi tutacak değişken
        void Filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from FILMLER ", baglanti); //filmleri çekiyoruz
            DataTable dt = new DataTable(); //nesne oluşturup
            da.Fill(dt); // oluşturduğumuz nesnenin içini çektiğimiz datalar ile doldur diyoruz
            dataGridView1.DataSource = dt; // ve doldurduğumuz dataları da datagridview de göster diyoruz
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Filmler();
            this.btnRenkDegis.Click += new EventHandler(this.btnRenkDegis_Click); // renk değiştir butonuna tıklama olayını bağladım.

        }

        private void btnFilmKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sql = new SqlCommand("insert into FILMLER (AD,KATEGORI,LINK) values (@p1,@p2,@p3)", baglanti);
            sql.Parameters.AddWithValue("@p1", txtFilmAd.Text);
            sql.Parameters.AddWithValue("@p2", txtFilmKategori.Text);
            sql.Parameters.AddWithValue("@p3", txtFilmLink.Text);

            sql.ExecuteNonQuery(); // yukarıdaki insert işlemi gerçekleştirebilmek için bunu yazıyoruz.
            baglanti.Close();

            MessageBox.Show("Film başarılı bir şekilde listenize eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Filmler();

            txtFilmAd.Text = "";
            txtFilmKategori.Text = "";
            txtFilmLink.Text = "";



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int secilenFilm = dataGridView1.SelectedCells[0].RowIndex;
            //string link = dataGridView1.Rows[secilenFilm].Cells[3].Value.ToString();

            //webBrowser1.Navigate(link);

            try
            {
                int secilenFilm = e.RowIndex;

                if (secilenFilm >= 0 && dataGridView1.Rows[secilenFilm].Cells[3].Value != null)
                {
                    string link = dataGridView1.Rows[secilenFilm].Cells[3].Value.ToString();
                    if (!string.IsNullOrEmpty(link))
                    {
                        webBrowser1.Navigate(link);
                    }
                    else
                    {
                        MessageBox.Show("Filme Ait Link Alanı Boştur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz satır veya hücre seçimi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Elif YILDIRIM tarafından kodlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRenkDegis_Click(object sender, EventArgs e)
        {
            this.BackColor = renkListesi[suankiRenk];
            suankiRenk = (suankiRenk + 1) % renkListesi.Count; // renk listemizin sonuna gelince tekrar başa dön diyoruz.

        }
    }
}

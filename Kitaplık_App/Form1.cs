using System;
using System.Windows.Forms;

namespace Kitaplık_App
{
    public partial class txtKitapAd : Form
    {
        public txtKitapAd()
        {
            InitializeComponent();
        }
        KitapVT kitapSinif = new KitapVT();
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kitapSinif.Liste();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kitap addKitap = new Kitap();
            addKitap.AD = txtKitapAdi.Text;
            addKitap.YAZAR = txtYazar.Text;

            kitapSinif.Ekle(addKitap);
            MessageBox.Show("Kitap başarılı şekilde kitaplığa eklenmiştir.");

        }
    }
}

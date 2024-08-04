using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ListYapisi_ListOgrenciBilgileriKayitApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList1_Click(object sender, EventArgs e)
        {
            List<string> karakter = new List<string>();
            karakter.Add("Mazhar");
            karakter.Add("Ruhsar");
            karakter.Add("Ecem");
            karakter.Add("Nil Ayça");
            karakter.Add("Murat");
            karakter.Add("Ahmet");

            karakter.Remove("Murat");

            foreach (string kisis in karakter)
            {
                listBox1.Items.Add(kisis);
            }
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(5);
            sayilar.Add(6);
            sayilar.Add(7);
            sayilar.Add(8);
            sayilar.Add(9);
            sayilar.Add(10);

            foreach (int sayis in sayilar)
            {

                if (sayis % 5 == 0)
                    listBox2.Items.Add(sayis);
            }

            if (sayilar.Contains(10))
            {
                MessageBox.Show("Selammm");
            }
            else
            {
                MessageBox.Show("selam yok!");
            }
        }

        private void btnList3_Click(object sender, EventArgs e)
        {
            List<Kisiler> kisi = new List<Kisiler>();

            kisi.Add(new Kisiler()
            {
                ADI = "Elif",
                SOYAD = "Yıldırım",
                YAS = "26"
            });
            foreach (Kisiler k in kisi)
            {
                listBox3.Items.Add(k.ADI + " " + k.SOYAD + " " + k.YAS);
            }

        }
    }
}

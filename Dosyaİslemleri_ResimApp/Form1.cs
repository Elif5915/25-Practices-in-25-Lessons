using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dosyaİslemleri_ResimApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resim;

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;
        }
        Color renk;
        private void btnrenksec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;

        }

        Bitmap bmp;
        private void btnyazdır_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(resim);
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawString(txtMetinGir.Text, new Font("Segoe UI", Convert.ToInt16(txtBoyutGir.Text), FontStyle.Bold), new SolidBrush(renk), 20, 30); //drawstring string formatta üzerine yaz işle diyoruz.
            pictureBox1.Image = bmp;


        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Resim|.jpg";
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }
    }
}

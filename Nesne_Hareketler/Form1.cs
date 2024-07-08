using System;
using System.Windows.Forms;

namespace Nesne_Hareketler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); // form yüklendiği an timer çalışsın.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top -= 5; // üst tarafa doğru 5 pixcel azalsın 

            if (pictureBox2.Top <= 58)
            {
                timer1.Stop();
                timer2.Start();

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left += 5;
            if (pictureBox2.Left >= 750)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top += 5;
            if (pictureBox2.Top >= 425)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left -= 5;
            if (pictureBox2.Left <= 55)
            {
                timer4.Stop();
                timer1.Start();
            }
        }
    }
}

using System.Drawing;
using System.Windows.Forms;

namespace PassaParolaGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruNo)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "içel")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "pırasa")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "save")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "yıldırım")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki Soru";
            soruNo++;
            this.Text = soruNo.ToString();
            textBox1.Text = "";
            button25.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesinin ismi nedir?";
                button2.BackColor = Color.Yellow;
            }

            if (soruNo == 2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü Marmara bölgesinde bulunan ilimiz hangisidir?";
                button3.BackColor = Color.Yellow;
            }

            if (soruNo == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü nedir?";
                button21.BackColor = Color.Yellow;
            }

            if (soruNo == 4)
            {
                richTextBox1.Text = "Karpuzuyla ile ünlü ilimiz hangisidir?";
                button20.BackColor = Color.Yellow;
            }
            if (soruNo == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı nedir?";
                button19.BackColor = Color.Yellow;
            }
            if (soruNo == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı haline ne isim verilir?";
                button18.BackColor = Color.Yellow;
            }
            if (soruNo == 7)
            {
                richTextBox1.Text = "Dünyanın ısı ve ışık kaynağı nedir?";
                button17.BackColor = Color.Yellow;
            }
            if (soruNo == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne nedir?";
                button16.BackColor = Color.Yellow;
            }
            if (soruNo == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz hangisidir?";
                button15.BackColor = Color.Yellow;
            }
            if (soruNo == 10)
            {
                richTextBox1.Text = "Mersin ilimizin bir diğer ismi nedir?";
                button14.BackColor = Color.Yellow;
            }
            if (soruNo == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk verilen ad nedir?";
                button13.BackColor = Color.Yellow;
            }
            if (soruNo == 12)
            {
                richTextBox1.Text = "Malatya ilinin meşhur meyvesi hangisidir?";
                button12.BackColor = Color.Yellow;
            }
            if (soruNo == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali nedir?";
                button11.BackColor = Color.Yellow;
            }
            if (soruNo == 14)
            {
                richTextBox1.Text = "yılın üçüncü ayının ismi nedir?";
                button10.BackColor = Color.Yellow;
            }
            if (soruNo == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aracıdır?";
                button24.BackColor = Color.Yellow;
            }
            if (soruNo == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                button23.BackColor = Color.Yellow;
            }
            if (soruNo == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmediği yapılırken içine pirinç,havuç vs konulan uzun sebze yemeği nedir???";
                button22.BackColor = Color.Yellow;
            }
            if (soruNo == 18)
            {
                richTextBox1.Text = "11 ayın sultanı olarak bilinen aydır?";
                button4.BackColor = Color.Yellow;
            }
            if (soruNo == 19)
            {
                richTextBox1.Text = "ingilizce de kaydet anlamına gelen kelime nedir?";
                button5.BackColor = Color.Yellow;
            }
            if (soruNo == 20)
            {
                richTextBox1.Text = "Türkiyenin megastarı olarak bilinen şarkıcısı kimdir";
                button6.BackColor = Color.Yellow;
            }
            if (soruNo == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı nedir?";
                button7.BackColor = Color.Yellow;
            }
            if (soruNo == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz hangisidir?";
                button8.BackColor = Color.Yellow;
            }
            if (soruNo == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı nedir?";
                button9.BackColor = Color.Yellow;
            }
            if (soruNo == 24)
            {
                richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan yağıda yapılan bir kahvaltı besinidir?";
                button1.BackColor = Color.Yellow;
            }

        }
    }
}

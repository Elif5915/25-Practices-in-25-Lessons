using System;
using System.Windows.Forms;
using System.Xml;

namespace RSS_İnternettenHaberBasliklariCekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMilliyet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // http://www.milliyet.com.tr/rss/rssNew/gundemRss.xml
            XmlTextReader xmloku = new XmlTextReader("http://www.milliyet.com.tr/rss/rssNew/gundemRss.xml");
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }


        }

        private void btnHurriyet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // http://mix.chimpfeedr.com/07479-Hurriyet-Gazetesi
            XmlTextReader xmloku1 = new XmlTextReader("http://mix.chimpfeedr.com/07479-Hurriyet-Gazetesi");
            while (xmloku1.Read())
            {
                if (xmloku1.Name == "title")
                {
                    listBox1.Items.Add(xmloku1.ReadString());
                }
            }
        }

        private void btnSabah_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // http://mix.chimpfeedr.com/d1bed-Sabah-Gazetesi
            XmlTextReader xmloku2 = new XmlTextReader("http://mix.chimpfeedr.com/d1bed-Sabah-Gazetesi");
            while (xmloku2.Read())
            {
                if (xmloku2.Name == "title")
                {
                    listBox1.Items.Add(xmloku2.ReadString());
                }
            }
        }
    }
}

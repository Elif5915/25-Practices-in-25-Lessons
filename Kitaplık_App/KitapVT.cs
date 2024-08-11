using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace Kitaplık_App
{
    public class KitapVT
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Ace.OLEDB.4.0;Data Source=C:\Users\elif.yildirim\Documents\Kitaplik.accdb;");

        public List<Kitap> Liste()
        {
            List<Kitap> ktp = new List<Kitap>();
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("select *from Kitaplar", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Kitap k = new Kitap();
                k.ID = Convert.ToInt16(dr[0].ToString());
                k.AD = dr[1].ToString();
                k.YAZAR = dr[2].ToString();

                ktp.Add(k);

            }
            baglanti.Close();
            return ktp;
        }

        public void Ekle(Kitap ktp)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Kitaplar (KitapAdi,Yazar) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", ktp.AD);
            komut.Parameters.AddWithValue("@p2", ktp.YAZAR);
            komut.ExecuteNonQuery();

            baglanti.Close();



        }

    }
}



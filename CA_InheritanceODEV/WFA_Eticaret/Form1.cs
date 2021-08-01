using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Eticaret
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Array (Diziler)
        /*
            Eleman sayısı zorunluluğu
            Tip bağımlı olması
         */
        //Roman[] romanlar = new Roman[5];

        //Generic Tipler
        List<Roman> romanListesi = new List<Roman>();
        List<Telefon> telefonListesi = new List<Telefon>();
        List<Kulaklik> kulaklikListesi = new List<Kulaklik>();

        List<Urun> urunListesi = new List<Urun>();



        private void Form1_Load(object sender, EventArgs e)
        {
            Roman roman1 = new Roman();
            roman1.Ad = "Balıkçı ve Oğlu";
            roman1.Fiyat = 18.20m;
            roman1.Sayfa = 140;
            roman1.YayinEvi = "İnkılap Kitabevi";
            roman1.Yazar = "Zülfü Livaneli";

            Roman roman2 = new Roman();
            roman2.Yazar = "Ahmet Ümit";
            roman2.Ad = "Kayıp Tanrılar Ülkesi";
            roman2.Fiyat = 25.20m;
            roman2.Sayfa = 504;
            roman2.YayinEvi = "Yapı Kredi Yayınları";

            

            //romanListesi.Add(roman1);
            //romanListesi.Add(roman2);

            Telefon telefon = new Telefon();
            telefon.Marka = "Iphone";
            telefon.Kamera = "12";

            //telefonListesi.Add(telefon);


            Kulaklik kulaklik = new Kulaklik();
            kulaklik.Marka = "Jbl";
            kulaklik.Fiyat = 300m;
            kulaklik.TeknikOzellik = "Ses yalıtımı mükemmel";

            //kulaklikListesi.Add(kulaklik);

            //foreach (Roman roman in romanListesi)
            //{

            //}

            //foreach (Telefon tel in telefonListesi)
            //{

            //}

            //foreach (Kulaklik k in kulaklikListesi)
            //{

            //}

            urunListesi.Add(roman1);//boxing
            urunListesi.Add(roman2);//boxing
            urunListesi.Add(kulaklik);//boxing
            urunListesi.Add(telefon);//boxing

            foreach (Urun urun in urunListesi)
            {
                if(urun is Kulaklik)
                {
                    //unboxing
                    Kulaklik klk = (Kulaklik)urun;
                    MessageBox.Show(klk.TeknikOzellik);
                }
                else if(urun is Telefon)
                {
                    //unboxing
                    Telefon tlf = (Telefon)urun;
                    MessageBox.Show(tlf.Marka);

                }
                else if(urun is Roman)
                {
                    //unboxing
                    Roman rmn = (Roman)urun;
                    MessageBox.Show(rmn.Ad);
                }
            }

        }
    }
}

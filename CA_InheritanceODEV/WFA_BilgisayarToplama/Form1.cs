using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BilgisayarToplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Urun> urunListesi = new List<Urun>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Klavye
            Klavye klavye = new Klavye();
            klavye.Marka = "Logitech";
            klavye.Model = "G5";
            klavye.Tip = "Q";
            klavye.Fiyat = 750;
            

            Klavye klavye2 = new Klavye();
            klavye2.Marka = "Logitech";
            klavye2.Model = "G5";
            klavye2.Tip = "F";
            klavye2.Fiyat = 750;


            Klavye klavye3 = new Klavye();
            klavye3.Marka = "Trust";
            klavye3.Model = "A2";
            klavye3.Tip = "F";
            klavye3.Fiyat = 1000;

            Klavye klavye4 = new Klavye();
            klavye4.Marka = "Samsung";
            klavye4.Model = "S4";
            klavye4.Tip = "F";
            klavye4.Fiyat = 900;
            
            //Monitor
            Monitor monitor = new Monitor();
            monitor.Marka = "Samsung";
            monitor.Model = "Kafa1500";
            monitor.TepkimeSuresi = 1f;
            monitor.Fiyat = 2000;

            Monitor monitor1 = new Monitor();
            monitor1.Marka = "Dell";
            monitor1.Model = "SA200";
            monitor1.TepkimeSuresi = 1.1f;
            monitor1.Fiyat = 1800;

            Monitor monitor2 = new Monitor();
            monitor2.Marka = "casper";
            monitor2.Model = "DR-12";
            monitor2.TepkimeSuresi = 1.2f;
            monitor2.Fiyat = 1800;

            Monitor monitor3 = new Monitor();
            monitor3.Marka = "Asus";
            monitor3.Model = "AK47";
            monitor3.TepkimeSuresi = 1f;
            monitor3.Fiyat = 1900;
           

            //Anakart
            Anakart anakart = new Anakart();
            anakart.Marka = "Msi";
            anakart.Model = "Yzl";
            anakart.SlotSayisi = 4;
            anakart.Fiyat = 500;

            Anakart anakart1 = new Anakart();
            anakart1.Marka = "Moonster";
            anakart1.Model = "AFK";
            anakart1.SlotSayisi = 6;
            anakart1.Fiyat = 450;

            Anakart anakart2 = new Anakart();
            anakart2.Marka = "Intel";
            anakart2.Model = "dasd";
            anakart2.SlotSayisi = 5;
            anakart2.Fiyat = 600;

            Anakart anakart3 = new Anakart();
            anakart3.Marka = "Lenovo";
            anakart3.Model = "asds";
            anakart3.SlotSayisi = 4;
            anakart3.Fiyat = 400;
                

            //Islemci
            Islemci islemci = new Islemci();
            islemci.Marka = "Intel";
            islemci.Model = "I7";
            islemci.Fiyat = 2750;

            Islemci islemci1 = new Islemci();
            islemci1.Marka = "Imtel";
            islemci1.Model = "I5";
            islemci1.Fiyat = 2500;

            Islemci islemci2 = new Islemci();
            islemci2.Marka = "Amd";
            islemci2.Model = "I3";
            islemci2.Fiyat = 1500;

            
            //Ekran Kartı
            EkranKarti ekranKarti = new EkranKarti();
            ekranKarti.Marka = "Nvidia";
            ekranKarti.Model = "Geforce ";
            ekranKarti.Fiyat = 3000;
            ekranKarti.Bellek = 16;

            EkranKarti ekranKarti1 = new EkranKarti();
            ekranKarti1.Marka = "Nvidia";
            ekranKarti.Model = "Geforce";
            ekranKarti1.Fiyat = 2500;
            ekranKarti1.Bellek = 12;

            //Guc Kaynağı
            GucKaynagi gucKaynagi = new GucKaynagi();
            gucKaynagi.Marka = "Armut";
            gucKaynagi.Model = "asd";
            gucKaynagi.Guc = 1000;
            gucKaynagi.Fiyat = 2750;

            GucKaynagi gucKaynagi1 = new GucKaynagi();
            gucKaynagi1.Marka = "Lityum";
            gucKaynagi1.Model = "qwert";
            gucKaynagi1.Guc = 1200;
            gucKaynagi1.Fiyat = 2950;
            



            urunListesi.Add(klavye);
            urunListesi.Add(klavye2);
            urunListesi.Add(klavye3);
            urunListesi.Add(klavye4);
            urunListesi.Add(monitor);
            urunListesi.Add(monitor1);
            urunListesi.Add(monitor2);
            urunListesi.Add(monitor3);
            urunListesi.Add(anakart);
            urunListesi.Add(anakart1);
            urunListesi.Add(anakart2);
            urunListesi.Add(anakart3);
            urunListesi.Add(islemci);
            urunListesi.Add(islemci1);
            urunListesi.Add(islemci2);
            urunListesi.Add(ekranKarti);
            urunListesi.Add(ekranKarti1);
            urunListesi.Add(gucKaynagi);
            urunListesi.Add(gucKaynagi1);

            foreach (Urun urun in urunListesi)
            {
                string format = string.Format("{0} {1} {2}", urun.Marka, urun.Model, urun.Fiyat);
                if(urun is Klavye)
                {
                    lstKlavye.Items.Add(format);
                    lstKlavye.Tag = urun;//(boxing)

                }
                else if(urun is Monitor)
                {
                    lstMonitor.Items.Add(format);
                    lstMonitor.Tag = urun;

                }
                else if(urun is Anakart)
                {
                    lstAnaKart.Items.Add(format);
                    lstAnaKart.Tag = urun;//(boxing)

                }
                else if(urun is EkranKarti)
                {
                    lstEkranKart.Items.Add(format);
                    lstEkranKart.Tag = urun;

                }
                else if (urun is Islemci)
                {
                    lstIslemci.Items.Add(format);
                    lstIslemci.Tag = urun;

                }
                else if (urun is GucKaynagi)
                {
                    lstGucKaynagi.Items.Add(format);
                    lstGucKaynagi.Tag = urun;

                }
            }
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {

            if (lstKlavye.SelectedItems.Count > 0)
            {
                Urun klavye = (Urun)lstKlavye.Tag;
                lblKlavye.Text = klavye.Fiyat.ToString();
            }
            if (lstMonitor.SelectedItems.Count > 0)
            {
                Urun monitor = (Urun)lstMonitor.Tag;
                lblMonitor.Text = monitor.Fiyat.ToString();
            }
            if (lstAnaKart.SelectedItems.Count > 0)
            {
                //string seciliAnakart=(string)lstAnaKart.SelectedItems[0];
                //string[] formatArray= seciliAnakart.Split('-');
                //MessageBox.Show(formatArray[1]);

                Urun anakart = (Urun)lstAnaKart.Tag;//ListAnakart'ın Urun olduğu belirtildi ve anakart değişkenine atıldı.Aslında burda convert.ToInt veya Convert.ToString gibi dönüştürme işlemi uygulandı
                lblAnakart.Text = anakart.Fiyat.ToString();
            }
            if (lstEkranKart.SelectedItems.Count > 0)
            {
                Urun ekrankarti = (Urun)lstEkranKart.Tag;
                lblEkranKarti.Text = ekrankarti.Fiyat.ToString();
            }
            if (lstIslemci.SelectedItems.Count > 0)
            {
                Urun islemci = (Urun)lstIslemci.Tag;
                lblIslemci.Text = islemci.Fiyat.ToString();
            }
            if (lstGucKaynagi.SelectedItems.Count > 0)
            {
                Urun gucKaynagi = (Urun)lstGucKaynagi.Tag;
                lblGucKaynagi.Text = gucKaynagi.Fiyat.ToString();
            }
            decimal toplamFiyat = Convert.ToDecimal(lblKlavye.Text) + Convert.ToDecimal(lblMonitor.Text) + Convert.ToDecimal(lblAnakart.Text) + Convert.ToDecimal(lblEkranKarti.Text) + Convert.ToDecimal(lblIslemci.Text) + Convert.ToDecimal(lblGucKaynagi.Text);
            decimal kdvDahilFiyat = toplamFiyat * 1.18m;
            lblKdvHaric.Text = toplamFiyat.ToString();
            lblKdvDahil.Text = kdvDahilFiyat.ToString();

        }
}
    }


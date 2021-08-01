using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Inheritance2
{
    class Program
    {
        static void Main(string[] args)
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

            //Monitor
            Monitor monitor = new Monitor();
            monitor.Marka = "Samsung";
            monitor.Model = "Kafa1500";
            monitor.TepkimeSuresi = 1f;
            monitor.Fiyat = 2000;


            //Anakart
            Anakart anakart = new Anakart();
            anakart.Marka = "Msi";
            anakart.Model = "Yzl";
            anakart.SlotSayisi = 4;
            anakart.Fiyat = 500;

            //Islemci
            Islemci islemci = new Islemci();
            islemci.Marka = "Intel";
            islemci.Model = "I7";
            islemci.Fiyat = 2750;

            //Ekran Kartı
            EkranKarti ekranKarti = new EkranKarti();
            ekranKarti.Marka = "Nvidia";
            ekranKarti.Model = "Geforce ";
            ekranKarti.Fiyat = 3000;
            ekranKarti.Bellek = 16;

            //Guc Kaynağı
            GucKaynagi gucKaynagi = new GucKaynagi();
            gucKaynagi.Marka = "Armut";
            gucKaynagi.Marka = "asd";
            gucKaynagi.Guc = 1000;


            //Bilgisayar
            Bilgisayar bilgisayar = new Bilgisayar();
            bilgisayar.Klavye = klavye2;
            bilgisayar.Islemci = islemci;
            bilgisayar.Monitor = monitor;
            bilgisayar.GucKaynagi = gucKaynagi;
            bilgisayar.Anakart = anakart;
            bilgisayar.EkranKarti = ekranKarti;
            bilgisayar.Marka = "Canavar";
            bilgisayar.Model = "asdad";
            bilgisayar.Fiyat = 10000;

            Console.WriteLine("Bilgisayar Anakart Markası: " + bilgisayar.Anakart.Marka);
            Console.WriteLine("Bilgisayar Ekrankartı Bellek: " + bilgisayar.EkranKarti.Bellek);

            Console.Read();

        }
    }
}

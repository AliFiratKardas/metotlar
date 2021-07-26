using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WFA_McAdam
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            lblRevenue.Text = GetRevenue();
            lblExtraRevenue.Text = GetRevenueExtra();

            lblBestBurger.Text = BestSellerHamburger();
        }

        string GetRevenue()
        {
            //belirtilen yolda bulunan dosyanın içerisindeki bütün satırları dizi içerisine alın.
            //dizide dönerek sadece fiyatları temsil eden satırın değerini yakalayın.
            //yakalanan değerleri toplayarak bir değişkene aktarın.
            //değişkeni lblRevenue.Text'e yazdırın.
            string path = @"C:\Users\firat\Desktop\klasör";
            string file = @"\hamburgerci.txt";

           string[] orderLines= File.ReadAllLines(path + file);
            int count = 0;

            decimal[] prices = new decimal[orderLines.Length];//Decimal tipte sipariş adedi*sipariş(notpad'deki satır uzunuğu ) içeriği kadar 'prices' adında dizi oluşturuldu.

            for (int i = 4; i < orderLines.Length; i+=6 )//(dizinin uzunluğu kadar döngü oluşturuldu ve fiyat satırı yakalandı)
            {
                prices[count] = Convert.ToDecimal(orderLines[i]);//fiyat satırlarının her biri prices dizisinin içine atıldı ve index numarası 1 arttırıldı.
                count++;
            }

            decimal totalPrice = 0;
            foreach (decimal price in prices)//prices'ların her birinde dön ve bunlara price olarak adlandır ve her bir price'yı totalPrice'ın içine at.
            {
                totalPrice += price;
            }
            return totalPrice.ToString();

        }
        decimal totalExtra = 0;
        decimal extra = 0;
        string GetRevenueExtra()
        {
            string path = @"C:\Users\firat\Desktop\klasör";
            string file = @"\hamburgerci.txt";
            string[] orderLines = File.ReadAllLines(path + file);//orderlines'ın içine tüm siparişler ve içerikleri atıldı.
            //decimal[] extraPrices = new decimal[orderLines.Length];


            for (int i = 1; i < orderLines.Length; i++)
            {
                if (orderLines[i]=="Büyük")
                {
                    extra = 10;
                    totalExtra+=extra;
                }
                else if (orderLines[i]=="King")
                {
                    extra = 15;
                    totalExtra += extra;
                }
                //BİRDEN FAZLA SOS EKLENDİĞİNDE ALMIYOR SADECE 1 ADET SOS HESABA KATILIYOR ÇÖZ!!!
                if (orderLines[i]=="(Ranch )") 
                {
                    extra = 2;
                    totalExtra += extra;
                }
                if (orderLines[i] == "(Bufallo )")
                {
                    extra = 2;
                    totalExtra += extra;
                }
                if (orderLines[i] == "(Mayonez )")
                {
                    extra = 2;
                    totalExtra += extra;
                }
                if (orderLines[i] == "(Barbeku )")
                {
                    extra = 2;
                    totalExtra += extra;
                }
                if (orderLines[i] == "(Hardal )")
                {
                    extra = 2;
                    totalExtra += extra;
                }
                if (orderLines[i] == "(Ballı Hardal )")
                {
                    extra = 2;
                    totalExtra += extra;
                }


            }
            return totalExtra.ToString();
           
            

        }
        string BestSellerHamburger()
        {
            string enCokSatılan = "";
            int counterHamburger = 0;
            int counterAlaturca = 0;
            int counterChicken = 0;
            int counterAdam = 0;
            
            string path = @"C:\Users\firat\Desktop\klasör";
            string file= @"\hamburgerci.txt";
            string[] orderLines = File.ReadAllLines(path+file);
           // string[] countBurger = new string[orderLines.Length];
            for (int i = 0; i < orderLines.Length; i++)
            {
                if (orderLines[i]=="McHamburger")
                {
                    counterHamburger++;
                }
                else if (orderLines[i]=="McAlaturca")
                {
                    counterAlaturca++;
                }
                else if (orderLines[i]=="McChicken")
                {
                    counterChicken++;
                }
                else if (orderLines[i]=="McAdamBurger")
                {
                    counterAdam++;
                }
                
            }
            int[] solds = { counterHamburger, counterAlaturca, counterChicken, counterAdam };
            int biggest = 0;
            for (int i = 0; i < solds.Length; i++)
            {
                if (solds[i]>biggest)
                {
                    biggest = solds[i];
                    if (i==0)
                    {
                        enCokSatılan = "McHamburger";
                    }
                    else if (i==1)
                    {
                        enCokSatılan = "McAlaturca";
                    }
                    else if (i==2)
                    {
                        enCokSatılan = "McChicken";
                    }
                    else if (i==3)
                    {
                        enCokSatılan = "McAdam";
                    }
                }
            }
            return enCokSatılan;
        }

        private void lblExtraRevenue_Click(object sender, EventArgs e)
        {

        }

        private void lblRevenue_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Campaign : Form
    {
        public Campaign()
        {
            InitializeComponent();
        }

        private void Campaign_Load(object sender, EventArgs e)
        {
            btnRandom.Enabled = false;
        }
        string file = @"C:\Users\firat\Desktop\klasör\hamburgerci.txt";
        string path = @"C:\Users\firat\Desktop\klasör";

        double discount = 0;
        double price;
        string totalPrice;
        private void btnIndirim_Click(object sender, EventArgs e)
        {
            btnRandom.Enabled = true;

            string[] orderPrice = File.ReadAllLines(file);
            for (int i = 4; i < orderPrice.Length; i += 6)
            {
                if (Convert.ToInt32(orderPrice[i]) > 0 && Convert.ToInt32(orderPrice[i]) < 50)
                {
                    double discount = Convert.ToDouble(orderPrice[i]) * 0.05;
                    lblIndirim.Text = discount.ToString();
                    price = Convert.ToDouble(orderPrice[i]) - discount;
                     totalPrice = price.ToString();
                }
                else if (Convert.ToInt32(orderPrice[i]) > 50 && Convert.ToInt32(orderPrice[i]) < 100)
                {
                    double discount = Convert.ToDouble(orderPrice[i]) * 0.1;
                    lblIndirim.Text = discount.ToString();
                    price = Convert.ToDouble(orderPrice[i]) - discount;
                     totalPrice = price.ToString();

                }
                else if (Convert.ToInt32(orderPrice[i]) > 100 && Convert.ToInt32(orderPrice[i]) < 200)
                {
                    double discount = Convert.ToDouble(orderPrice[i]) * 0.2;
                    lblIndirim.Text = discount.ToString();
                    price = Convert.ToDouble(orderPrice[i]) - discount;
                     totalPrice = price.ToString();

                }
                else
                {
                    double discount = Convert.ToDouble(orderPrice[i]) * 0.3;
                    lblIndirim.Text = discount.ToString();
                    price = Convert.ToDouble(orderPrice[i]) - discount;
                    totalPrice = price.ToString();

                }

            }
        }
        void TotalOrderPrice()
        {
            string[] orderPrice = File.ReadAllLines(file);
            for (int i = 4; i < orderPrice.Length; i += 6)
            {

            }
        }
        //void WriteDiscount()
        //{
        //    string file = @"C:\Users\firat\Desktop\klasör\hamburgerci.txt";
        //    string path = @"C:\Users\firat\Desktop\klasör";
        //    if (File.Exists(path))
        //    {
        //        if (File.Exists(file))
        //        {
        //            StreamWriter writer = new StreamWriter(file, append: true);
        //            writer.Write(lblIndirim.Text + lblCode.Text);
        //            writer.Close();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Lütfen klasör oluşturun");
        //        }
        //    }
        //}

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] discountCode = new int[6];
            discountCode[0] = rnd.Next(0, 9);
            discountCode[1] = rnd.Next(0, 9);
            discountCode[2] = rnd.Next(65, 91);
            discountCode[3] = rnd.Next(33, 46);
            discountCode[4] = rnd.Next(65, 91);
            discountCode[5] = rnd.Next(97, 123);
            char[] caracter = new char[4];
            caracter[0] = Convert.ToChar(discountCode[2]);
            caracter[1] = Convert.ToChar(discountCode[3]);
            caracter[2] = Convert.ToChar(discountCode[4]);
            caracter[3] = Convert.ToChar(discountCode[5]);
            string getCode;
            getCode = discountCode[0].ToString() + caracter[0].ToString() + caracter[1].ToString() + discountCode[1].ToString() + caracter[2].ToString() + caracter[3].ToString();
            lblCode.Text = getCode;
            string format = string.Format("Kazanılan indirim tutarı: {0}\nNet Fiyat: {1}\nİndirim kodu: {2}", lblIndirim.Text+ " TL", totalPrice+" TL", getCode);
            DialogResult dr = MessageBox.Show(format, "İndirim Kodu siparişinizde tanımlansın mı ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

        }

        private void lblCode_Click(object sender, EventArgs e)
        {

        }
    }
}

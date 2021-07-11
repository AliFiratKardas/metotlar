using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeriyeDegerDondurmeyen_ParametreAlmayanMetodlar
{
    public partial class GeriyeDegerDondurmeyenParametreAlanMetotlar : Form
    {
        public GeriyeDegerDondurmeyenParametreAlanMetotlar()
        {
            InitializeComponent();
        }

        private void GeriyeDegerDondurmeyenParametreAlanMetotlar_Load(object sender, EventArgs e)
        {

        }
        void KelebegiUcur(int sayi)
        {

            pictureBox1.Left +=sayi;
        }


        void DersListele(string[] liste)
        {

            liste = new string[5];
            
            for (int i = 0; i < liste.Length; i++)
            {
                listBox2.Items.Add(liste);

            }

        }
        void SayiSec(decimal sayi)
        {
            numericUpDown1.Value = sayi;
            MessageBox.Show("Secilen sayi" + sayi.ToString());
        }
        void Topla(int s1,int s2)
        {
            textBox1.Text=s1.ToString();
             textBox2.Text=s2.ToString();
            int toplam = s1+s2;
            MessageBox.Show(toplam.ToString());
        }
        void Carp()
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int carpım = sayi1 * sayi2;
            MessageBox.Show(carpım.ToString());
        }
        void ModAl(int s1,int s2)
        {
            textBox1.Text=s1.ToString();
            textBox2.Text=s2.ToString();
            int mod = s1 % s2;
            MessageBox.Show(mod.ToString());
        }
        void TekCift(int s1)
        {
            textBox1.Text = s1.ToString();
            if (s1 % 2 == 0)
            {
                MessageBox.Show("sayı çifttir");
            }
            else
            {
                MessageBox.Show("sayı tektir");
            }
        }
        void ListeyeEkle()
        {
            string liste = textBox1.Text.ToString();
            listBox1.Items.Add(liste);
        }
        void BuyukSayi(int s1, int s2)
        {
            textBox1.Text = s1.ToString();
            textBox2.Text = s2.ToString();
            int secilen = s2;
            if (secilen > s1)
            {
                MessageBox.Show("Büyük sayı: " + secilen);
            }
            else if (s1==secilen)
            {
                MessageBox.Show("iki sayı birbirine eşit");
            }
            else
            {
                MessageBox.Show("büyük sayı: " + s1);
            }
        }

        void RastgeleSayi(int s1, int s2 )
        {
            listBox2.Items.Clear();
            Random rnd = new Random();

            for (int i = 0; i <10; i++)
            {

                listBox2.Items.Add(rnd.Next(s1,s2));
            }
        }
        void ButonOlustur(int x,int y)
        {
            Random rnd = new Random();
            Button btn = new Button();

            btn.Width = 70;
            btn.Height = 40;
            btn.Left = x;
            btn.Top = y;
            int red = rnd.Next(0, 256);
            int green=rnd.Next(0,256);
            int blue = rnd.Next(0, 256);
            btn.BackColor = Color.FromArgb(red, green, blue);
            this.Controls.Add(btn);
        }
           
        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SayiSec(12);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Topla(22, 19);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModAl(49, 8);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TekCift(29);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BuyukSayi(13,13);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            KelebegiUcur(8);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButonOlustur(300, 300);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RastgeleSayi(1, 100);
        }
    }
}

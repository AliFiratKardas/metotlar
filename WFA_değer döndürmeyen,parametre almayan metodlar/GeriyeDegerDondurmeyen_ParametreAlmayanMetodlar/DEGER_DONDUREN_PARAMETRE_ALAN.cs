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
    public partial class DEGER_DONDUREN_PARAMETRE_ALAN : Form
    {
        public DEGER_DONDUREN_PARAMETRE_ALAN()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int  KelebegiUcur(int sayi)
        {
            
            pictureBox1.Left += rnd.Next(0,sayi);
            return sayi;
        }


        void DersListele(string[] liste)
        {

            liste = new string[5];

            for (int i = 0; i < liste.Length; i++)
            {
                listBox2.Items.Add(liste);

            }

        }
        decimal SayiSec(decimal sayi)
        {
            numericUpDown1.Value = sayi;
            MessageBox.Show("Secilen sayi" + sayi.ToString());
            return sayi;
        }
        int Topla(int s1, int s2)
        {
            textBox1.Text = s1.ToString();
            textBox2.Text = s2.ToString();
            int toplam = s1 + s2;
            return toplam;
        }
        int  Carp(int s1,int s2)
        {
            textBox1.Text = s1.ToString();
            textBox2.Text = s2.ToString();
            int carpım = s1+s2;
            MessageBox.Show(carpım.ToString());
            return carpım;
        }
        int ModAl(int s1, int s2)
        {
            textBox1.Text = s1.ToString();
            textBox2.Text = s2.ToString();
            int mod = s1 % s2;
            MessageBox.Show(mod.ToString());
            return mod;
        }
        int TekCift(int s1)
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
            return s1;
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
            else if (s1 == secilen)
            {
                MessageBox.Show("iki sayı birbirine eşit");
            }
            else
            {
                MessageBox.Show("büyük sayı: " + s1);
            }
        }

        int RastgeleSayi(int s1, int s2)
        {
            listBox2.Items.Clear();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {

                listBox2.Items.Add(rnd.Next(s1, s2));
            }
            return s1;
        }
        int ButonOlustur(int x, int y)
        {
            Random rnd = new Random();
            Button btn = new Button();

            btn.Width = 70;
            btn.Height = 40;
            btn.Left = x;
            btn.Top = y;
            int red = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);
            btn.BackColor = Color.FromArgb(red, green, blue);
            this.Controls.Add(btn);
            return x;
        }
        string EnvanterListele(string envanterDetay)
        {
            ListViewItem lvi = new ListViewItem();
            string kitap = "150 adet";
            string kalem = "100 adet";
            string silgi = "350 adet";
            string kalemtraş = "120 adet";
            string sözlük = "85 adet";
            string defter= "55 adet";

           string[] envanterDetay = new string[6];
            envanterDetay[0] = kitap;
            envanterDetay[1] = kalem;
            envanterDetay[2] = silgi;
            envanterDetay[3] = kalemtraş;
            envanterDetay[4] = sözlük;
            envanterDetay[5] = defter;
            for (int i = 0; i < envanterDetay.Length; i++)
            {
                if (i==0)
                {
                    lvi.Text = envanterDetay[i];
                }
                else
                {
                    lvi.SubItems.Add(envanterDetay[i]);
                }
            }
            listView1.Items.Add(lvi);
            return envanterDetay[i];
        }


        private void DEGER_DONDUREN_PARAMETRE_ALAN_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal sayi = SayiSec(15);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayi = KelebegiUcur(20);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = Topla(20,35);
            MessageBox.Show(toplam.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int carpım = Carp(7,8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mod = ModAl(13, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s1 = TekCift(15);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int x = ButonOlustur(450, 385);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //envanter
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int s1 = RastgeleSayi(0,100);
        }
    }
}

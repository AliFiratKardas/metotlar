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
    public partial class GeriyeDegerDondurenParametreAlmayanMetotlar : Form
    {
        public GeriyeDegerDondurenParametreAlmayanMetotlar()
        {
            InitializeComponent();
        }
        int Topla()
        {
            int s1=Convert.ToInt32(textBox1.Text);
            int s2=Convert.ToInt32(textBox2.Text);
            int toplam = s1 + s2;
            MessageBox.Show("toplam= "+ toplam.ToString());
            return toplam;
        }
        int Carp()
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);

            int carpım = s1 * s2;
            MessageBox.Show("çarpım= "+ carpım.ToString());

            return carpım;
        }
        int ModAl()
        {

            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            int mod = s1 % s2;
            MessageBox.Show("Mod= "+ mod.ToString());

            return mod;
        }
        int TekCift()
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            if (s1%2==0)
            {
                MessageBox.Show("sayı çifttir");
            }
            else
            {
                MessageBox.Show("sayı tektir");
            }
            return s1; 
        }
        int BuyukSayi()
        {
            int s1 = 18;
            int s2 = 56;
            if (s2>s1)
            {
                MessageBox.Show("büyük say: " + s2);
            }
            else
            {
                MessageBox.Show("büyük sayı: " + s1); 
            }
            return s1;
        }
        Random rnd = new Random();
        int KelebegiUcur()
        {
            int s1 = 20;
            pictureBox1.Left += rnd.Next(0, s1);
            return s1;
        }
        int ButonOlustur()
        {
            int red = 150;
            int green = 236;
            int blue = 75;
            Button btn = new Button();
            btn.Left = 400;
            btn.Left = 300;
            btn.Width = 90;
            btn.Height = 40;
            btn.BackColor = Color.FromArgb(red, green, blue);
            this.Controls.Add(btn);
            return red;

        }
        int SayiOlustur()
        {
            listBox1.Items.Clear();
            int adet = 20;
            for (int i = 0; i < adet; i++)
            {
                listBox1.Items.Add(rnd.Next(0, 100));
            }
            return adet;
        }
        
        string EnvanterListele()
        {
            string kitap = "75 adet";
            string defter = "96 adet";
            string kalem = "120 adet";
            string silgi = "63 adet";
            string kalemtraş = "77 adet";
            string sözlük = "15 adet";
            string[] tabloOlustur = new string[6];


            tabloOlustur[0] = kitap;
            tabloOlustur[1] = defter;
            tabloOlustur[2] = kalem;
            tabloOlustur[3] = silgi;
            tabloOlustur[4] = kalemtraş;
            tabloOlustur[5] = sözlük;

            ListViewItem lvi = new ListViewItem();
            for (int i = 0; i < tabloOlustur.Length; i++)
            {
                if (i == 0)
                {
                    lvi.Text = tabloOlustur[i];
                }
                else
                {
                    lvi.SubItems.Add(tabloOlustur[i]);
                }
            }
            listView1.Items.Add(lvi);
            return tabloOlustur[5];

        }
        //string DersAktar()
        //{
            
        //    string[] DersListesi = {"matematik,türke,fizik,kimya,biyoloji" };
        //    for (int i = 0; i < DersListesi.Length; i++)
        //    {
        //        listBox2.Items.Add(DersListesi[i]);
        //    }
        //    return DersListesi[5];
        //}
        decimal SayiSec()
        {
            decimal s1 = numericUpDown1.Value;
            MessageBox.Show("seçilen sayı= " + s1);

            return s1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           int toplam= Topla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int carp = Carp();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mod = ModAl();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s1 = TekCift();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int s1 = BuyukSayi();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int s1 = KelebegiUcur();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int red = ButonOlustur();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int adet = SayiOlustur();
        }

        private void GeriyeDegerDondurenParametreAlmayanMetotlar_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            EnvanterListele();
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal s1 =SayiSec();
        }
    }
}

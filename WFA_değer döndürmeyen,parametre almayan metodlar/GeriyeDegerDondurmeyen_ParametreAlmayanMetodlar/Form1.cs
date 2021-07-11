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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void RastgeleSayiAt()
        {
            listBox3.Items.Clear();

            Random rnd = new Random();
            for (int i = 1; i < 10; i++)
            {
                listBox3.Items.Add(rnd.Next(0, 100));
            }

        }
        void FormRenk()
        {
            Form1 fr = new Form1();
            Random rnd = new Random();

            int red = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);

            fr.BackColor = Color.FromArgb(red,green,blue);
            
        }
        void ButonOlustur()
        {
            Random rnd = new Random();
            Button btn = new Button();
            int red = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);

            btn.BackColor = Color.FromArgb(red, green, blue);
            btn.Width = 100;
            btn.Height = 40;
            int x = rnd.Next(0, this.ClientSize.Width - btn.Width);
            int y = rnd.Next(0, this.ClientSize.Height - btn.Height);
            btn.Left = x;
            btn.Top = y;

            this.Controls.Add(btn);
        }
        
        void KelebegiUcur()
        {
            Random rd = new Random();
            timer1.Start();
            pictureBox1.Left += rd.Next(5,15);
        }
       


      
        void TabloyuYazdır()
        {
            string kitap = "500 adet";
            string defter = "300 adet";
            string kalem = "69 adet";
            string silgi = "66 adet";
            string boya = "45 adet";
            string sözlük = "21 adet";


            string[] tabloOlustur =new string[6];
            tabloOlustur[0] = kitap;
            tabloOlustur[1] = defter;
            tabloOlustur[2] = kalem;
            tabloOlustur[3] = silgi;
            tabloOlustur[4] = boya;
            tabloOlustur[5] = sözlük;
            ListViewItem lvi = new ListViewItem();
            for (int i = 0; i < tabloOlustur.Length; i++)
            {
                if (i==0)
                {
                    lvi.Text = tabloOlustur[i];
                }
                else
                {
                    lvi.SubItems.Add(tabloOlustur[i]);
                }
            }
            listView1.Items.Add(lvi);

        }
        void DersListele()
        {
            string[] liste = { "Matematik", "Kimya", "Fizik", "Biyoloji", "Edebiyat", "Felsefe", "Tarih","Coğrafya","Türkçe","Mantık" };
            foreach (string listele in liste)
            {
                listBox2.Items.Add(listele);
            }
            
        }
        void SayiSec()
        {
            string sayi = numericUpDown1.Value.ToString();
            MessageBox.Show("Secilen sayi"+sayi);
        }
        void Topla()
        {
            int sayi1 = Convert.ToInt32(txtsayiBir.Text);
            int sayi2 = Convert.ToInt32(txtsayiki.Text);
            int toplam = sayi1 + sayi2;
            MessageBox.Show(toplam.ToString());
        }
        void Carp()
        {
            int sayi1 = Convert.ToInt32(txtsayiBir.Text);
            int sayi2 = Convert.ToInt32(txtsayiki.Text);
            int carpım = sayi1 * sayi2;
            MessageBox.Show(carpım.ToString());
        }
        void ModAl()
        {
            int sayi1 = Convert.ToInt32(txtsayiBir.Text);
            int sayi2 = Convert.ToInt32(txtsayiki.Text);
            int mod = sayi1 % sayi2;
            MessageBox.Show(mod.ToString());
        }
        void TekCift()
        {
            int sayi1 = Convert.ToInt32(txtsayiBir.Text);
            if (sayi1%2==0)
            {
                MessageBox.Show("sayı çifttir");
            }
            else
            {
                MessageBox.Show("sayı tektir");
            }
        }
        void BuyukSayi()
        {
            int s1 = Convert.ToInt32(txtsayiBir.Text);
            int s2 = Convert.ToInt32(txtsayiki.Text);
            int secilen = s2;
            if (secilen>s1)
            {
                MessageBox.Show("Büyük sayı: " + secilen);
            }
            else
            {
                MessageBox.Show("büyük sayı: " + s1);
            }
        }
        void ListeyeEkle()
        {
            string liste = txtsayiBir.Text.ToString();
            listBox1.Items.Add(liste);
        }

     

        private void btnTopla_Click(object sender, EventArgs e)
        {
            Topla();
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            Carp();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            ModAl();
        }

        private void btnTekCift_Click(object sender, EventArgs e)
        {
            TekCift();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ListeyeEkle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SayiSec();
        }

        private void btnbuyuksayi_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DersListele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TabloyuYazdır();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            KelebegiUcur();

        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            ButonOlustur();   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormRenk();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RastgeleSayiAt();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormRenk();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace WFA_McAdam
{
    public partial class HamburgerMenu : Form
    {
        public HamburgerMenu()
        {
            InitializeComponent();
        }
        public string girisAd;
        public string girisSoyad;
        string[] menuler = { "McHamburger", "McAlaturca", "McChicken", "McAdamBurger" };
        decimal[] fiyatlar = { 40, 30, 15, 25 };

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSiparisiAlan.Text = girisAd+" "+girisSoyad ;//Personel girişpanelindeki textBoxlardan çektik.
            foreach (string menu in menuler)
            {
                cmbMenu.Items.Add(menu);
            }
        }
        

        string[] siparisBilgileri = new string[5];//0-1-2-3-4
        decimal toplamFiyat = 0;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal siparisFiyat = 0;
            siparisFiyat += fiyatlar[cmbMenu.SelectedIndex];
            siparisBilgileri[0] = cmbMenu.Text;

            if (rbOrta.Checked)
            {
                siparisBilgileri[1] = rbOrta.Text;
            }
            else if (rbBuyuk.Checked)
            {
                siparisFiyat += 10;
                siparisBilgileri[1] = rbBuyuk.Text;
            }
            else if (rbKing.Checked)
            {
                siparisFiyat += 15;
                siparisBilgileri[1] = rbKing.Text;
            }

            string ekstraBilgi = "(";
            foreach (CheckBox chk in groupBox1.Controls)
            {
                if (chk.Checked)
                {
                    siparisFiyat += 2;
                    ekstraBilgi += chk.Text + " ";
                   
                }
            }
            ekstraBilgi += ")";
            siparisBilgileri[2] = ekstraBilgi;
            siparisFiyat *= numericUpDown1.Value;
            siparisBilgileri[3] = numericUpDown1.Value.ToString();
            siparisBilgileri[4] = siparisFiyat.ToString();




            ListViewItem lvi = new ListViewItem();
            for (int i = 0; i < siparisBilgileri.Length; i++)
            {
                if (i == 0)
                {
                    lvi.Text = siparisBilgileri[i];
                }
                else
                {
                    lvi.SubItems.Add(siparisBilgileri[i]);
                }
            }
            listView1.Items.Add(lvi);
            toplamFiyat += siparisFiyat;
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            string format = string.Format("Toplam sipariş sayısı {0}\nToplam sipariş tutuarı: {1}", listView1.Items.Count, toplamFiyat + " TL");
            DialogResult dr = MessageBox.Show(format, "Sipariş Tamamla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Kaydet();
                Temizle();
            }
        }

        void Temizle()
        {
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    cmb.SelectedIndex = -1;
                }
                else if(ctrl is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctrl;
                    if (rb.Text == "Orta")
                    {
                        rb.Checked = true;
                    }
                }
                else if(ctrl is GroupBox)
                {
                    GroupBox gb = (GroupBox)ctrl;
                   if(gb.Name== "groupBox1")
                    {
                        foreach (CheckBox chk in gb.Controls)
                        {
                            chk.Checked = false;
                        }
                    }
                }
                else if(ctrl is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)ctrl;
                    nud.Value = 1;
                }
                else if(ctrl is ListView)
                {
                    ListView lv = (ListView)ctrl;
                    lv.Items.Clear();
                }
                toplamFiyat = 0;
            }
        }
        void Kaydet()
        {
            string path = @"C:\Users\firat\Desktop\klasör";
            string file = @"\hamburgerci.txt";
            string orders = "";
            foreach (ListViewItem lvi in listView1.Items)
            {
                foreach (ListViewSubItem item in lvi.SubItems)
                {
                    orders += item.Text + "\n";
                }
                orders += "***********************\n";
            }

            if (Directory.Exists(path))
            {
                if (File.Exists(path + file))
                {
                    StreamWriter writer = new StreamWriter(path + file, append:true);
                    writer.Write(orders);
                    writer.Close();
                }
                else
                {
                   
                    Byte[] orderInfo = new UTF8Encoding(true).GetBytes(orders);
                    FileStream stream = File.Create(path + file);
                    stream.Write(orderInfo,0, orderInfo.Length);
                    stream.Close();
                    
                }
            }
            else
            {
                Directory.CreateDirectory(path);

                //Todo: aşağıdaki işlemlerin yapılması gerekiyor.
                //dosya var mı yok mu?
                //dosya yoksa oluşturulsun ve kaydetsin.
                //dosya varsa kaydetsin.
            }
        }

        private void rbBuyuk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSiparisiAlan_Click(object sender, EventArgs e)
        {

        }
    }
}

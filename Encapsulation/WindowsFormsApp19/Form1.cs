using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnUrun_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.Ad = txtUrunAd.Text;//ürün adı küçük olacak şekilde ayarla.
            urun.Fiyat = Convert.ToDecimal(txtFiyat.Text);
            urun.Stok =Convert.ToInt32(nudStok.Value);
            listBox1.Items.Add(string.Format("{0} {1} {2}", urun.Ad, urun.KdvDahilFİyat, urun.Stok));

        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.KategoriAd = txtKategoriAd.Text;
            kategori.Aciklama = rchAciklama.Text;
            listBox2.Items.Add(string.Format("{0} {1}", kategori.KategoriAd, kategori.Aciklama));
        }

        private void btnTedarikci_Click(object sender, EventArgs e)
        {
            Tedarikci tedarikci = new Tedarikci();
            tedarikci.Ad = txtTedarkciAd.Text;
            tedarikci.TelefonNo = txtTedarikciTel.Text;
            tedarikci.Adres = rchTedarikciAdres.Text;
            listBox3.Items.Add(string.Format("{0} {1} {2}", tedarikci.Ad, tedarikci.TelefonNo ,tedarikci.Adres));
        }

        private void btnNakliyeci_Click(object sender, EventArgs e)
        {
            Nakliyeci nakliyeci = new Nakliyeci();
            nakliyeci.Ad = txtNakliyeAd.Text;
            nakliyeci.Telefon = txtNakliyetel.Text;
            nakliyeci.Adres = rchNakliyeAdres.Text;
            listBox4.Items.Add(string.Format("{0}{1}{2}", nakliyeci.Ad, nakliyeci.Telefon, nakliyeci.Adres));
        }

        

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Ad = txtMusteriAd.Text;
            musteri.Telefon = txtMusteriTel.Text;
            musteri.Email = txtMusteriEmail.Text;
            musteri.Adres = txtMusteriEmail.Text;
            listBox5.Items.Add(string.Format("{0}{1}{2}{3}", musteri.Ad, musteri.Telefon, musteri.Email, musteri.Adres));
        }
    }
}

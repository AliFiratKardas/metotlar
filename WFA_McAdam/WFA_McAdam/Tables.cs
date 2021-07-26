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
    public partial class Masalar : Form
    {
        public Masalar()
        {
            InitializeComponent();
        }
        string file = @"C:\Users\firat\Desktop\klasör\hamburgerci.txt";
        string path = @"C:\Users\firat\Desktop\klasör";
        void ReadFile()
        {
            RichTextBox rch = new RichTextBox();
            string[] orderline = File.ReadAllLines(file);
            for (int i = 0; i < orderline.Length; i++)
            {

            }
        }
        void FormColor()
        {
            Random rnd = new Random();
            int red = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);
            this.BackColor = Color.FromArgb(red, green, blue);
        }
        ListViewItem lvi = new ListViewItem();

       

        private void btnTable1_Click(object sender, EventArgs e)
        {
            FormColor();
            string[] orderList = File.ReadAllLines(file);
            string[] tableOrders = new string[orderList.Length];
            
            for (int i = 0; i + 5 < orderList.Length; i += 6)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = orderList[i];
                lvi.SubItems.Add(orderList[i + 1]);
                lvi.SubItems.Add(orderList[i + 2]);
                lvi.SubItems.Add(orderList[i + 3]);
                lvi.SubItems.Add(orderList[i + 4]);
                lvi.SubItems.Add(orderList[i + 5]);
                listView1.Items.Add(lvi);
            }


        }

        private void btnmasa2_Click(object sender, EventArgs e)
        {
            FormColor();
            string[] orderList = File.ReadAllLines(file);
            string[] tableOrders = new string[orderList.Length];

            for (int i = 0; i + 5 < orderList.Length; i += 6)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = orderList[i];
                lvi.SubItems.Add(orderList[i + 1]);
                lvi.SubItems.Add(orderList[i + 2]);
                lvi.SubItems.Add(orderList[i + 3]);
                lvi.SubItems.Add(orderList[i + 4]);
                lvi.SubItems.Add(orderList[i + 5]);
                listView2.Items.Add(lvi);
            }


        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            FormColor();
            string[] orderList = File.ReadAllLines(file);
            string[] tableOrders = new string[orderList.Length];

            for (int i = 0; i + 5 < orderList.Length; i += 6)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = orderList[i];
                lvi.SubItems.Add(orderList[i + 1]);
                lvi.SubItems.Add(orderList[i + 2]);
                lvi.SubItems.Add(orderList[i + 3]);
                lvi.SubItems.Add(orderList[i + 4]);
                lvi.SubItems.Add(orderList[i + 5]);
                listView3.Items.Add(lvi);

            }



        }
        private void btnMasa4_Click(object sender, EventArgs e)
        {
            FormColor();
            string[] orderList = File.ReadAllLines(file);
            string[] tableOrders = new string[orderList.Length];
            for (int i = 0; i + 5 < orderList.Length; i += 6)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = orderList[i];
                lvi.SubItems.Add(orderList[i + 1]);
                lvi.SubItems.Add(orderList[i + 2]);
                lvi.SubItems.Add(orderList[i + 3]);
                lvi.SubItems.Add(orderList[i + 4]);
                lvi.SubItems.Add(orderList[i + 5]);
                listView4.Items.Add(lvi);

            }


        }

        private void Masalar_Load(object sender, EventArgs e)
        {

        }
    }
}

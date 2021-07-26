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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }
        string file = @"C:\Users\firat\Desktop\klasör\personel.txt";
        string path = @"C:\Users\firat\Desktop\klasör";
        //SİLME İŞLEMİNİ TAMAMLA
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(path))
            {
                if (File.Exists(file))
                {
                    WriteFile();
                }
                else
                {
                    WriteFile();
                }
            }
            else
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("Klasör Oluşturuldu");
            }
        }
        string SaveUsers(string _firstName, string _lastName, string _idenityNumber, string _mail, string _phoneNumber, string _adress)
        {
            string users = string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n", _firstName, _lastName, _idenityNumber, _mail, _phoneNumber, _adress);
            return users;
        }
        void ReadFile()
        {
            string[] usersLine = File.ReadAllLines(file);
            for (int i = 0; i + 5 < usersLine.Length; i += 6)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = usersLine[i];
                lvi.SubItems.Add(usersLine[i + 1]);
                lvi.SubItems.Add(usersLine[i + 2]);
                lvi.SubItems.Add(usersLine[i + 3]);
                lvi.SubItems.Add(usersLine[i + 4]);
                lvi.SubItems.Add(usersLine[i + 5]);
                listView1.Items.Add(lvi);
            }
        }
        string DeleteUsers(string _firstName, string _lastName, string _idenityNumber, string _mail, string _phoneNumber, string _adress)
        {
            string deleteUsers = string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n", _firstName, _lastName, _idenityNumber, _mail, _phoneNumber, _adress);
            return deleteUsers;
        }
        void WriteFile()
        {

            string users = DeleteUsers(txtAdKayit.Text, txtSoyadKayit.Text, txtTCKayit.Text, txtMail.Text, mskTelefon.Text, rchAdres.Text);
            StreamWriter writer = new StreamWriter(file, true);
            writer.Write(users);
            writer.Close();
            MessageBox.Show("Personel Kaydı Yapıldı");
        }
    

        private void btnListele_Click(object sender, EventArgs e)
        {
            ReadFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string girisAd = txtgirisAd.Text;
            string girisSoyad = txtgirisSoyad.Text;
            string[] loginArray = File.ReadAllLines(file);
            for (int i = 0; i < loginArray.Length; i++)
            {
                if (loginArray[i]==txtgirisAd.Text&&loginArray[i+1]==txtgirisSoyad.Text)
                {
                    HamburgerMenu hamburgerMenu = new HamburgerMenu();

                    hamburgerMenu.girisAd = txtgirisAd.Text;
                    hamburgerMenu.girisSoyad = txtgirisSoyad.Text;
                    hamburgerMenu.Show();
                    this.Hide();
                 
                }
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //void UsersList()
        //{
        //    ListViewItem lvi = new ListViewItem();
        //    string[] usersList = new string[6];
        //    usersList[0] = txtAdKayit.Text;
        //    usersList[1] = txtSoyadKayit.Text;
        //    usersList[2] = txtTCKayit.Text;
        //    usersList[3] = txtMail.Text;
        //    usersList[4] = mskTelefon.Text;
        //    usersList[5] = rchAdres.Text;
        //    for (int i = 0; i < usersList.Length; i++)
        //    {
        //        if (i == 0)
        //        {
        //            lvi.Text = usersList[i];
        //        }
        //        else
        //        {
        //            lvi.SubItems.Add(usersList[i]);
        //        }
        //    }
        //    listView1.Items.Add(lvi);

        //}
    }
}

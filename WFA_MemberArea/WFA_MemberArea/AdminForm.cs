using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MemberArea
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user4 = new User();
            user4.UserName = txtName.Text;
            user4.Password = txtPassword.Text;
            user4.Email = txtMail.Text;
            user4.Role = txtRole.Text;
            listBox1.Items.Add(user4);
            User.Users.Add(user4);
        }
    }
}

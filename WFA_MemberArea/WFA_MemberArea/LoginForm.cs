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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User.UserList();

            foreach (User usr in User.Users)
            {
                if (usr.UserName==textBox1.Text.ToLower())
                {
                    if (usr.Role == "admin")
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        break;
                    }
                    else if (usr.Role=="user")
                    {
                        UserForm userForm = new UserForm();
                        userForm.Show();
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı bulunamadı");
                    continue;
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

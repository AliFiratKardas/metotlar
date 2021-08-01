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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

            User.UserList();
            foreach (User user in User.Users)
            {
                if (user.Role=="user")
                {
                    listBox1.Items.Add(user);
                }
            }
        }
    }
}

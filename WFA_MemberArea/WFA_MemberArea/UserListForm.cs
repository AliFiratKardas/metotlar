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
    public partial class UserListForm : Form
    {
        public UserListForm()
        {
            InitializeComponent();
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            foreach (User user in User.Users)// User'ın içinden Users'I çekti (burda Users bizim listemizdi). Users içinden User(tip) çekti user diye adlandırıp listboxa attık. 
            {
                listBox1.Items.Add(user);
            }
        }
    }
}

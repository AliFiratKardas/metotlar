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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            User user = new User();

            User.AddUser(user);
            
            User.UserList();
            User.RemoveUser(user);

            //Todo: Login isimli bir form oluşturun. login yapacak kullanıcı kesinlikle User.Users'da tanımlı olması gerekiyor.
            //Todo: Eğer giriş yapan kullanıcı admin ise adminForm açılsın.
            //Todo: Eğer giriş yapan kullanıcı user ise userForm açılsın.
            //Todo: Admin form içerisinde kullanıcı kayıt formu bulunsun ve giriş yapan admin kullanıcı ekleyebilsin.
            //Todo: userForm içerisinde sadece kullanıcı listesi bulunsun. Herhangi bir işlem yapılamasın.
        }

        private void btnUserForm_Click(object sender, EventArgs e)
        {
            UserListForm userListForm = new UserListForm();
            userListForm.Show();
        }
    }
}

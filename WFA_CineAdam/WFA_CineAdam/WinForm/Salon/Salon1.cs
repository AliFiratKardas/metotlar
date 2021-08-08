using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_CineAdam.WinForm.Salon
{
    public partial class Salon1 : Form
    {
        public Salon1()
        {
            InitializeComponent();
        }
        AddCustomer addCustomer = new AddCustomer();

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.Text = "rezerve";
            button1.Enabled = false;
            addCustomer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Salon1_Load(object sender, EventArgs e)
        {

        }
    }
}

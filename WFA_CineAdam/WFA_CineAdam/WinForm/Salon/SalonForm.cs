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
    public partial class SalonForm : Form
    {
        public SalonForm()
        {
            InitializeComponent();
        }

        private void btnSalon1_Click(object sender, EventArgs e)
        {
            Salon1 salon1 = new Salon1();
            salon1.Show();
        }
    }
}

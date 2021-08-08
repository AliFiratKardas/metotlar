using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_CineAdam.Data;

namespace WFA_CineAdam
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        Button btn = new Button();
        private void btnSeat_Click(object sender, EventArgs e)
        {
            Add();
        }
        public void Add()
        {
            Seat seat = new Seat();
            seat.CustomerName = txtIzleyici.Text;
            seat.SeatNo = Convert.ToInt32(nudSeatNumber.Value);
            seat.TicketPrice = nudPrice.Value;
            DataBase.seats.Add(seat);
            foreach (Seat seat1 in DataBase.seats)
            {
                MessageBox.Show(seat.ToString());
            }
        }
    }
}

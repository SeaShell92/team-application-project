using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BayViewBookings
{
    public partial class frm_Reports : Form
    {
        public frm_Reports()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_exitreports_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Guests_Click(object sender, EventArgs e)
        {
            new frm_GuestDetails().Show();
            Close();
        }

        private void btn_Bookings_Click(object sender, EventArgs e)
        {
            new frm_newBooking().Show();
            Close();
        }

        private void btn_Rooms_Click(object sender, EventArgs e)
        {
            new frm_RoomDetails().Show();
            Close();
        }

        private void btn_view1_Click(object sender, EventArgs e)
        {
            new frm_ViewReports().ShowDialog(this);

        }
    }
}

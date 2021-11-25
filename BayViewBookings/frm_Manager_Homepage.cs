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
    public partial class frm_Manager_Homepage : Form
    {
        public frm_Manager_Homepage()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_newBooking f2 = new frm_newBooking();
            f2.ShowDialog(); // Shows Form2
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_GuestDetails f2 = new frm_GuestDetails();
            f2.ShowDialog(); // Shows Form2
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frm_StaffDetails f2 = new frm_StaffDetails();
            f2.ShowDialog(); // Shows Form2
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frm_Reports f2 = new frm_Reports();
            f2.ShowDialog(); // Shows Form2
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Manager_Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}

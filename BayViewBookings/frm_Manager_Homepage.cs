using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
            frm_RoomDetails f2 = new frm_RoomDetails();
            f2.ShowDialog(); // Shows Form2
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_newBooking f2 = new frm_newBooking();
            f2.ShowDialog(); // Shows Form2
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_GuestDetails f2 = new frm_GuestDetails();
            f2.ShowDialog(); // Shows Form2
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frm_StaffDetails f2 = new frm_StaffDetails();
            f2.ShowDialog(); // Shows Form2
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frm_Reports f2 = new frm_Reports();
            f2.ShowDialog(); // Shows Form2
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = dialog = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frm_Manager_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void btn_exitmgr_Click(object sender, EventArgs e)
        {
            DialogResult dialog = dialog = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm_login = new frm_login();
            frm_login.Closed += (s, args) => this.Close();
            frm_login.Show();
        }
    }
}

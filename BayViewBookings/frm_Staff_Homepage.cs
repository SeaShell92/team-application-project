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
    public partial class frm_Staff_Homepage : Form
    {
        DateTime timeOfDayGreeting = DateTime.Now;
        public string username { get; set; }
        public frm_Staff_Homepage()
        {
            InitializeComponent();
        }

        private void frm_Staff_Homepage_Load(object sender, EventArgs e)
        {

            if (timeOfDayGreeting.Hour >= 5 && timeOfDayGreeting.Hour < 12)
            {
                lbl_Welcome_Msg.Text = "Good morning, " + username + "!";
            }
            else if (timeOfDayGreeting.Hour >= 12 && timeOfDayGreeting.Hour < 16)
            {
                lbl_Welcome_Msg.Text = "Good Afternoon, " + username + "!";
            }
            else if (timeOfDayGreeting.Hour >= 16 && timeOfDayGreeting.Hour < 19)
            {
                lbl_Welcome_Msg.Text = "Good Evening, " + username + "!";
            }
            else
            {
                lbl_Welcome_Msg.Text = "Good Night, " + username + "!";
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm_login = new frm_login();
            frm_login.Closed += (s, args) => this.Close();
            frm_login.Show();
        }

        private void btn_Staff_Guests_Click(object sender, EventArgs e)
        {
            frm_GuestDetails f2 = new frm_GuestDetails();
            f2.ShowDialog(); // Shows Form2
            this.Hide();
        }

        private void btn_Staff_Bookings_Click(object sender, EventArgs e)
        {
            frm_newBooking f2 = new frm_newBooking();
            f2.ShowDialog(); // Shows Form2
            this.Hide();
        }

        private void btn_Staff_Rooms_Click(object sender, EventArgs e)
        {
            frm_RoomDetails f2 = new frm_RoomDetails();
            f2.ShowDialog(); // Shows Form2
            this.Hide();
        }

        private void btn_X_Click(object sender, EventArgs e)
        {

        }
    }
}

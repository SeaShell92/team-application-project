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
        DateTime timeOfDayGreeting = DateTime.Now;
        public string FirstName { get; set; }

        public long UserID { get; set; }

        public frm_Manager_Homepage()
        {
            InitializeComponent();
            
        }

        private void frm_Manager_Homepage_Load(object sender, EventArgs e)
        {

            if (timeOfDayGreeting.Hour >= 5 && timeOfDayGreeting.Hour < 12)
            {
                lbl_Welcome_Msg.Text = "Good morning, " + FirstName + "!";
            }
            else if (timeOfDayGreeting.Hour >= 12 && timeOfDayGreeting.Hour < 16)
            {
                lbl_Welcome_Msg.Text = "Good Afternoon, " + FirstName + "!";
            }
            else if (timeOfDayGreeting.Hour >= 16 && timeOfDayGreeting.Hour < 19)
            {
                lbl_Welcome_Msg.Text = "Good Evening, " + FirstName + "!";
            }
            else
            {
                lbl_Welcome_Msg.Text = "Good Night, " + FirstName + "!";
            }

        }

        private void btn_Rooms_Click(object sender, EventArgs e)
        {
            new frm_RoomDetails().ShowDialog(); // Shows Room Details form on top of original form
            // Original form is not hidden so we can go back to it but control is passed to new form
        }

        private void btn_Bookings_Click(object sender, EventArgs e)
        {
            var BookingForm = new frm_newBooking();
            BookingForm.UserID = UserID; // Sets the ID number of the user who is currently logged in
            BookingForm.ShowDialog(this); // Shows New Booking form on top of original form
        }

        private void btn_Guests_Click(object sender, EventArgs e)
        {
            new frm_GuestDetails().ShowDialog(this); // Shows Guest Details form on top of original form
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            new frm_StaffDetails().ShowDialog(this); // Shows Staff Details form on top of original form
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            new frm_Reports().ShowDialog(this); // Shows Reports form on top of original form
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
            var frm_login = new frm_login();
            frm_login.Show();
            this.Close();
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            btn_exitmgr_Click(sender, e);
        }

        private void btn_Transactions_Click(object sender, EventArgs e)
        {
            new frm_TransactionDetails().ShowDialog(this);
        }

        private void btn_RoomAvail_Click(object sender, EventArgs e)
        {
            new frm_RoomAvailability().ShowDialog(this);
        }

        private void btn_viewBookings_Click(object sender, EventArgs e)
        {
            var ViewBookings = new frm_ViewBookings();
            ViewBookings.UserID = UserID; // Sets the ID number of the user who is currently logged in
            ViewBookings.ShowDialog(this); // Shows View Booking form on top of original form
        }
    }
}

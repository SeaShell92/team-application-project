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

        public string FirstName { get; set; }

        public long UserID { get; set; }

        public frm_Staff_Homepage()
        {
            InitializeComponent();
        }

        private void frm_Staff_Homepage_Load(object sender, EventArgs e)
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

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            var frm_login = new frm_login();
            frm_login.Show();
            this.Close();
        }

        private void btn_Staff_Guests_Click(object sender, EventArgs e)
        {
            new frm_GuestDetails().ShowDialog(this); // Shows Guest Details form on top of original form
            //original form is not hidden so we can go back to it but control is passed to new form
        }

        private void btn_Staff_Bookings_Click(object sender, EventArgs e)
        {
            var BookingForm = new frm_newBooking();
            BookingForm.UserID = UserID;
            BookingForm.ShowDialog(this); // Shows New Booking form on top of original form
        }

        private void btn_Staff_Rooms_Click(object sender, EventArgs e)
        {
            new frm_RoomDetails().ShowDialog(this); // Shows Room Details form on top of original form
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            btn_exitStaff_Click(sender, e);
        }

        private void btn_exitStaff_Click(object sender, EventArgs e)
        {
            DialogResult dialog = dialog = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
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
            new frm_ViewBookings().ShowDialog(this);
        }
    }
}

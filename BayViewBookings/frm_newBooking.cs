using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Data.SQLite;

namespace BayViewBookings
{
    public partial class frm_newBooking : Form
    {
        public frm_newBooking()
        {
            InitializeComponent();
        }

        public long UserID { get; set; }

        SQLiteConnection dbCon = new SQLiteConnection();
        const string details = @"Data Source = ..\..\Database\bookings.db";
        string Has_Paid = "";

        private void btn_viewBookings_Click(object sender, EventArgs e)
        {
         
            frm_ViewBookings f2 = new frm_ViewBookings();
            f2.ShowDialog(this);
        }

        private void btn_exitbook_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_newBooking_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            txt_BookingDate.Text = now.ToShortDateString();
            txt_EmployeeID.Text = UserID.ToString();
        }

        private void btn_Guests_Click(object sender, EventArgs e)
        {
            new frm_GuestDetails().Show();
            Close();
        }

        private void btn_Rooms_Click(object sender, EventArgs e)
        {
            new frm_RoomDetails().Show();
            Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (rb_yes.Checked)
            {
                Has_Paid = "Yes";

            }
            else if (rb_no.Checked)
            {
                Has_Paid = "No";

            }
            try
            {
                long RowID;
                dbCon.ConnectionString = details; //declares connection string

                using (SQLiteCommand guestCmd = dbCon.CreateCommand())
                {

                    guestCmd.CommandText = @"Insert into Guest (Guest_Title, Guest_First_Name, Guest_Surname, Guest_Tel, Guest_Email) 
                    Values (@GuestTitle, @GuestFirstName, @GuestSurname, @GuestTel, @GuestEmail)";
                    guestCmd.Parameters.AddWithValue("GuestTitle", txt_Title.Text);
                    guestCmd.Parameters.AddWithValue("GuestFirstName", txt_FirstName.Text);
                    guestCmd.Parameters.AddWithValue("GuestSurname", txt_Surname.Text);
                    guestCmd.Parameters.AddWithValue("GuestTel", txt_Telephone.Text);
                    guestCmd.Parameters.AddWithValue("GuestEmail", txt_EmailAddress.Text);

                    dbCon.Open();
                    guestCmd.ExecuteNonQuery();
                    RowID = dbCon.LastInsertRowId;

                    dbCon.Close();

                }
                using (SQLiteCommand cmd = dbCon.CreateCommand())
                {
                
                    //allows users to add record

                    cmd.CommandText = @"Insert into Booking(Emplyee_ID, Guest_ID, Booking_Date, Check_In, Check_Out, No_Of_Nights, Total_Guests, Total_Breakfasts, Has_Paid) 
                    Values (@Emplyee_ID, @Guest_ID, @Booking_Date, @Check_In, @Check_Out, @No_Of_Nights, @Total_Guests, @Total_Breakfasts, @Has_Paid)";
                    //cmd.Parameters.AddWithValue("Booking_ID", txt_BookingID.Text);
                    cmd.Parameters.AddWithValue("Emplyee_ID", UserID);
                    cmd.Parameters.AddWithValue("Guest_ID", RowID);
                    cmd.Parameters.AddWithValue("Booking_Date", txt_BookingDate.Text);
                    cmd.Parameters.AddWithValue("Check_In", txt_CheckIn.Text);
                    cmd.Parameters.AddWithValue("Check_Out", txt_CheckOut.Text);
                    cmd.Parameters.AddWithValue("No_Of_Nights", txt_NoOfNights.Text);
                    cmd.Parameters.AddWithValue("Total_Guests", txt_TotalGuests.Text);
                    cmd.Parameters.AddWithValue("Total_Breakfasts", txt_TtlBreakfasts.Text);
                    cmd.Parameters.AddWithValue("Has_Paid", Has_Paid);
                        
                    //adds the new record details
                    dbCon.Open();

                    int recordsChanged = cmd.ExecuteNonQuery();
                    MessageBox.Show(recordsChanged.ToString() + " Records Added"); //message to notify the user that they have added the records
                    dbCon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void clearAll(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    var textBox = (TextBox)control;

                    textBox.Text = null;
                }
                if (control is RadioButton)
                {
                    var radioButton = (RadioButton)control;
                    
                    radioButton.Checked = false;
                }
            }
        }

        private void btn_ClearBooking_Click(object sender, EventArgs e)
        {
            // loop through all the controls on the form and if it is a text box, set it to be empty.
            clearAll(pnl_Booking.Controls);
            clearAll(pnl_GuestDetails.Controls);

        }
    }
}

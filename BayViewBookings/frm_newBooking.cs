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
            lbl_BookingText.Text = now.ToShortDateString();
            lbl_EmployeeIDTxt.Text = UserID.ToString();
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
                if (pnl_GuestDetails.Visible == true)
                {
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
                        //set the RowID to the the last record entered, which would be the newest guest.
                        RowID = dbCon.LastInsertRowId;

                        dbCon.Close();

                    }
                }
                else
                {
                    //set the RowID to be the ID number of the existing guest
                    RowID = Int64.Parse(txt_EGuestID.Text);
                }

                using (SQLiteCommand cmd = dbCon.CreateCommand())
                {
                
                    //allows users to add record

                    cmd.CommandText = @"Insert into Booking(Emplyee_ID, Guest_ID, Booking_Date, Check_In, Check_Out, No_Of_Nights, Total_Guests, Total_Breakfasts, Has_Paid) 
                    Values (@Emplyee_ID, @Guest_ID, @Booking_Date, @Check_In, @Check_Out, @No_Of_Nights, @Total_Guests, @Total_Breakfasts, @Has_Paid)";
                    //cmd.Parameters.AddWithValue("Booking_ID", txt_BookingID.Text);
                    cmd.Parameters.AddWithValue("Emplyee_ID", UserID);
                    cmd.Parameters.AddWithValue("Guest_ID", RowID);
                    cmd.Parameters.AddWithValue("Booking_Date", lbl_BookingText.Text);
                    cmd.Parameters.AddWithValue("Check_In", cldr_Booking.SelectionStart.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("Check_Out", cldr_Booking.SelectionEnd.ToString("yyyy-MM-dd"));
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
                MessageBox.Show("Error: " + ex.Message);
                dbCon.Close();
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
                if (control is MonthCalendar)
                {
                    var calendar = (MonthCalendar)control;

                    calendar.SelectionStart = DateTime.Now;
                    calendar.SelectionEnd = DateTime.Now;
                }
            }
        }

        private void btn_ClearBooking_Click(object sender, EventArgs e)
        {
            // loop through all the controls on the form and reset them as shown above
            clearAll(pnl_Booking.Controls);
            clearAll(pnl_GuestDetails.Controls);
            clearAll(pnl_ExistingGuest.Controls);

        }

        private void cldr_Booking_DateSelected(object sender, DateRangeEventArgs e)
        {
            //put the date froom the calendar in the check-in and check-out text box.
            txt_CheckIn.Text = cldr_Booking.SelectionStart.ToShortDateString();
            txt_CheckOut.Text = cldr_Booking.SelectionEnd.ToShortDateString();

            txt_NoOfNights.Text = (cldr_Booking.SelectionEnd - cldr_Booking.SelectionStart).Days.ToString();
        }

        private void btn_AddNewGuest_Click(object sender, EventArgs e)
        {
            btn_submit.Enabled = true;
            pnl_ExistingGuest.Visible = false;
            pnl_GuestDetails.Visible = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                dbCon.ConnectionString = details; //declares connection string
                using (SQLiteCommand findGuest = dbCon.CreateCommand())
                {
                    findGuest.CommandText = @"SELECT * FROM Guest WHERE Guest_Email = @Email";
                    findGuest.Parameters.AddWithValue("Email", txt_SearchEmail.Text);

                    dbCon.Open();

                    var reader = findGuest.ExecuteReader();

                    if (reader.Read())
                    {
                        txt_EGuestID.Text = reader.GetInt64(0).ToString();
                        txt_EGuestTitle.Text = reader.GetString(1);
                        txt_EGuestName.Text = reader.GetString(2);
                        txt_EGuestSurname.Text = reader.GetString(3);
                        txt_EGuestTel.Text = reader.GetInt64(4).ToString();

                        btn_submit.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Guest not found.  Please double check the email address or add a new guest.");
                    }

                    dbCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                dbCon.Close();
            }
        }
    }
}

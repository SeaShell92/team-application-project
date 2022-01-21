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
        string sqlRoomType = @"SELECT Room_ID, Room_Type, Room_Name, Accessibility FROM Room GROUP BY Room_Type";
        SQLiteDataAdapter daRoomType;
        SQLiteDataAdapter daRooms;
        SQLiteDataAdapter daCheck;
        DataTable dtRoomType = new DataTable();
        DataTable dtRooms = new DataTable();
        DataTable dtCheck = new DataTable();

        private void btn_viewBookings_Click(object sender, EventArgs e)
        {
            var ViewBookings = new frm_ViewBookings();
            ViewBookings.UserID = UserID; // Sets the ID number of the user who is currently logged in
            ViewBookings.ShowDialog(this); // Shows View Booking form on top of original form
        }

        private void btn_exitbook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit? Any data will be discarded", "Exit Form",
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Close();
            }
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            // the two exit butons behave in the same way.
            btn_exitbook_Click(sender, e);
        }

        private void frm_newBooking_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lbl_BookingText.Text = now.ToShortDateString();
            lbl_EmployeeIDTxt.Text = UserID.ToString();
            lb_Rooms.DisplayMember = "value";
            lb_Rooms.ValueMember = "key";

            try
            {
                dbCon.ConnectionString = details;

                daRoomType = new SQLiteDataAdapter(sqlRoomType, dbCon);
                daRoomType.Fill(dtRoomType);

                //bind data table to room type combobox
                cb_RoomTypes.DataSource = dtRoomType;
                cb_RoomTypes.DisplayMember = "Room_Type";
                cb_RoomTypes.ValueMember = "Room_Type";
                cb_RoomTypes.SelectedIndex = -1; //box is blank until user is ready to select a room type


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                dbCon.Close();
            }

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            var Errors = checkIsValid();

            // if the form does not pass all the valid data checks
            if (Errors.Count() > 0)
            {
                MessageBox.Show(String.Join(Environment.NewLine, Errors));
                return; // don't continue with the event until the errors have been resolved
            }

            if (rb_yes.Checked)
            {
                Has_Paid = "Yes"; // convert radio button options to valid data for the database.

            }
            else if (rb_no.Checked)
            {
                Has_Paid = "No";

            }
 
            try
            {
                long RowID;
                long BookingID;
                dbCon.ConnectionString = details; // declares connection string

                if (pnl_GuestDetails.Visible == true) // if they add a new guest
                {
                    using (SQLiteCommand guestCmd = dbCon.CreateCommand())
                    {
                        try
                        {
                            guestCmd.CommandText = @"Insert into Guest (Guest_Title, Guest_First_Name, Guest_Surname, Guest_Tel, Guest_Email) 
                            Values (@GuestTitle, @GuestFirstName, @GuestSurname, @GuestTel, @GuestEmail)";
                            guestCmd.Parameters.AddWithValue("GuestTitle", txt_Title.Text);
                            guestCmd.Parameters.AddWithValue("GuestFirstName", txt_FirstName.Text);
                            guestCmd.Parameters.AddWithValue("GuestSurname", txt_Surname.Text);
                            guestCmd.Parameters.AddWithValue("GuestTel", txt_Telephone.Text);
                            // if the guest does not want to provide an email address
                            if(txt_EmailAddress.TextLength > 0)
                            {
                                guestCmd.Parameters.AddWithValue("GuestEmail", txt_EmailAddress.Text);
                            }
                            else
                            {
                                guestCmd.Parameters.AddWithValue("GuestEmail", null);
                            }
 
                            dbCon.Open();
                            guestCmd.ExecuteNonQuery();
                            //set the RowID to the the last record entered, which would be the newest guest.
                            RowID = dbCon.LastInsertRowId;

                            dbCon.Close();
                        }
                        catch
                        {
                            // email address field set to "unique" in database, so an error will occur if the email entered is not unique.
                            // null values are considered unique by SQLite
                            MessageBox.Show("Guest email address already exists in database.  Please check the email entered or reset form and search for existing guest.");
                            return;
                        }

                    }
                }
                else // if they are using an existing guest
                {
                    // set the RowID to be the ID number of the existing guest
                    // doesn't insert/amend (overwrite) any guest details
                    RowID = Int64.Parse(txt_EGuestID.Text);
                }

                using (SQLiteCommand cmd = dbCon.CreateCommand())
                {
                
                    // allows users to add booking record

                    cmd.CommandText = @"Insert into Booking(Employee_ID, Guest_ID, Booking_Date, Check_In, Check_Out, No_Of_Nights, Total_Guests, Total_Breakfasts, Has_Paid) 
                    Values (@Employee_ID, @Guest_ID, @Booking_Date, @Check_In, @Check_Out, @No_Of_Nights, @Total_Guests, @Total_Breakfasts, @Has_Paid)";
                    cmd.Parameters.AddWithValue("Employee_ID", UserID);
                    cmd.Parameters.AddWithValue("Guest_ID", RowID);
                    cmd.Parameters.AddWithValue("Booking_Date", lbl_BookingText.Text);
                    cmd.Parameters.AddWithValue("Check_In", cldr_Booking.SelectionStart.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("Check_Out", cldr_Booking.SelectionEnd.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("No_Of_Nights", txt_NoOfNights.Text);
                    cmd.Parameters.AddWithValue("Total_Guests", txt_TotalGuests.Text);
                    cmd.Parameters.AddWithValue("Total_Breakfasts", txt_TtlBreakfasts.Text);
                    cmd.Parameters.AddWithValue("Has_Paid", Has_Paid);
                        
                    // adds the new record details
                    dbCon.Open();
                    cmd.ExecuteNonQuery();
                    BookingID = dbCon.LastInsertRowId;

                    dbCon.Close();
                }
                // matches each room ID to the Booking ID and inserts them into the RoomBooking table to link the records.
                foreach (KeyValuePair<int, string> item in lb_Rooms.Items)
                {
                    using (SQLiteCommand roomCmd = dbCon.CreateCommand())
                    {
                        roomCmd.CommandText = @"Insert into RoomBooking (Room_ID, Booking_ID) Values (@Room_ID, @Booking_ID)";
                        roomCmd.Parameters.AddWithValue("Room_ID", item.Key);
                        roomCmd.Parameters.AddWithValue("Booking_ID", BookingID);

                        dbCon.Open();
                        roomCmd.ExecuteNonQuery();

                        dbCon.Close();
                    }

                }

                int roomCount = lb_Rooms.Items.Count;

                MessageBox.Show("New booking with " + roomCount.ToString() + " rooms added."); // message to notify the user that they have added the records

                btn_ClearBooking_Click(sender, e); // resets the form after the booking has been successfully submitted.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with submitting the booking: " + ex.Message);
            }
        }

        // Access the controls on the form and reset them independently to the form
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
                if (control is ComboBox)
                {
                    var comboBox = (ComboBox)control;

                    comboBox.SelectedIndex = -1;
                }
                if (control is ListBox)
                {
                    var listBox = (ListBox)control;

                    listBox.Items.Clear();
                }
            }
        }

        private void btn_ClearBooking_Click(object sender, EventArgs e)
        {
            // loop through all the controls on the form and reset them as shown above
            clearAll(pnl_Booking.Controls);
            clearAll(pnl_GuestDetails.Controls);
            clearAll(pnl_ExistingGuest.Controls);

            if (pnl_ExistingGuest.Visible == false)
            {
                pnl_ExistingGuest.Visible = true;
                pnl_GuestDetails.Visible = false;
            }

            lbl_RoomAlert.ForeColor = Color.Black;
            lbl_RoomAlert.Text = "Please select a room to check availability";
            cb_unavailable.Enabled = false;
            btn_AddNewGuest.Enabled = true;

            // clean up any connections left open
            if (dbCon.State == System.Data.ConnectionState.Open)
            {
                dbCon.Close();
            }

        }

        private void cldr_Booking_DateSelected(object sender, DateRangeEventArgs e)
        {
            //put the date from the calendar in the check-in and check-out text boxes
            txt_CheckIn.Text = cldr_Booking.SelectionStart.ToShortDateString();
            txt_CheckOut.Text = cldr_Booking.SelectionEnd.ToShortDateString();

            txt_NoOfNights.Text = (cldr_Booking.SelectionEnd - cldr_Booking.SelectionStart).Days.ToString();
        }

        private void btn_AddNewGuest_Click(object sender, EventArgs e)
        {
            // update the UI to add a new guest
            pnl_ExistingGuest.Visible = false;
            pnl_GuestDetails.Visible = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                dbCon.ConnectionString = details; 
                using (SQLiteCommand findGuest = dbCon.CreateCommand())
                {
                    findGuest.CommandText = @"SELECT * FROM Guest WHERE Guest_Email = @Email";
                    findGuest.Parameters.AddWithValue("Email", txt_SearchEmail.Text);

                    dbCon.Open();

                    using (var reader = findGuest.ExecuteReader())
                    {
                        if (reader.Read()) // if there is something to read, there is a match
                        {
                            // fill the text boxes with the details from the database
                            txt_EGuestID.Text = reader.GetInt64(0).ToString();
                            txt_EGuestTitle.Text = reader.GetString(1);
                            txt_EGuestName.Text = reader.GetString(2);
                            txt_EGuestSurname.Text = reader.GetString(3);
                            txt_EGuestTel.Text = reader.GetInt64(4).ToString();

                            // don't allow the user to add a new guest if an existing guest has been found
                            btn_AddNewGuest.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Guest not found.  Please double check the email address or add a new guest.");
                            btn_AddNewGuest.Enabled = true;
                        }
                    }

                    dbCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when searching for guest: " + ex.Message);
                dbCon.Close();
            }
        }

        private void cb_RoomTypes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                using(var dbCon = new SQLiteConnection(details))
                {
                    if (checkBox_Disabled.Checked) // if the guest requires disabled access
                    {
                        string sqlRooms =
                            @"Select Room_ID, Room_Name, Room_Description, Room_Name || ' - ' || Room_Description as RoomInfo from Room"
                            + " WHERE Room_Type LIKE '" + cb_RoomTypes.SelectedValue + "'"
                            + " AND Accessibility LIKE 'Disabled'";

                        daRooms = new SQLiteDataAdapter(sqlRooms, dbCon);
                        dtRooms.Clear();
                        daRooms.Fill(dtRooms);

                        cb_RoomWanted.DataSource = dtRooms;
                        cb_RoomWanted.DisplayMember = "RoomInfo";
                        cb_RoomWanted.ValueMember = "Room_ID";
                        cb_RoomWanted.SelectedIndex = -1; // box is blank until user is ready to select a room
                    }
                    else // disabled access rooms are excluded from the options
                    {
                        string sqlRooms =
                            @"Select Room_ID, Room_Name, Room_Description, Room_Name || ' - ' || Room_Description as RoomInfo from Room" 
                            + " WHERE Room_Type LIKE '" + cb_RoomTypes.SelectedValue + "'"
                            + " AND Accessibility NOT LIKE 'Disabled'";

                        daRooms = new SQLiteDataAdapter(sqlRooms, dbCon);
                        dtRooms.Clear();
                        daRooms.Fill(dtRooms);

                        cb_RoomWanted.DataSource = dtRooms;
                        cb_RoomWanted.DisplayMember = "RoomInfo";
                        cb_RoomWanted.ValueMember = "Room_ID";
                        cb_RoomWanted.SelectedIndex = -1; // box is blank until user is ready to select a room
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when fetching all rooms of that type: " + ex.Message);
            }
        }

        private void checkBox_Disabled_CheckedChanged(object sender, EventArgs e)
        {
            // refreshes the box with the different options as the box is checked or unchecked
            cb_RoomTypes_SelectionChangeCommitted(sender, e);
        }

        private void btn_SelectRoom_Click(object sender, EventArgs e)
        {
            if(cb_RoomWanted.SelectedIndex > -1) // the user has selected a room
            {
                bool inList = false; // nothing is in the list yet

                if (lbl_RoomAlert.ForeColor == Color.Green) // the room is available to be booked
                {
                    foreach (KeyValuePair<int, string> item in lb_Rooms.Items) // check what rooms are already in the list box
                    {
                        if (item.Key == Int32.Parse(cb_RoomWanted.SelectedValue.ToString()))
                        {
                            inList = true;
                        }
                        else
                        {
                            inList = false;
                        }
                    }

                    if (!inList) // the room is NOT already in the list of rooms to be booked
                    {
                        // fills the list box with the key value pair of the information from the combo box.
                        lb_Rooms.Items.Add(new KeyValuePair<int, string>(Int32.Parse(cb_RoomWanted.SelectedValue.ToString()), cb_RoomWanted.GetItemText(cb_RoomWanted.SelectedItem)));

                    }
                }
                else
                {
                    MessageBox.Show("Room not available to add."); // message only pops up if user ignores red message and tries to add.
                }

            }
            else // user had not selected a room before pressing the button
            {
                MessageBox.Show("Please first select a room type and then choose a room to add.");
            }

        }

        private void btn_RemoveRoom_Click(object sender, EventArgs e)
        {
            if(lb_Rooms.SelectedIndex > -1)
            {
                lb_Rooms.Items.RemoveAt(lb_Rooms.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a room to remove.");
            }
        }

        private void btn_RemoveAll_Click(object sender, EventArgs e)
        {
            if (lb_Rooms.Items.Count >= 1)
            {
                lb_Rooms.Items.Clear();
            }
            else
            {
                MessageBox.Show("There are no rooms to remove.");
            }
        }

        private List<string> checkIsValid()
        {
            // a list of errors that could pop up if the user has not made a valid booking
            var Errors = new List<string>();
            if(lb_Rooms.Items.Count < 1)
            {
                Errors.Add("Please choose at least one room before making a booking.");
            }
            if(txt_NoOfNights.TextLength < 1 || int.Parse(txt_NoOfNights.Text) < 1)
            {
                Errors.Add("Please select dates using the calendar provided before making a booking.");
            }
            if(pnl_ExistingGuest.Visible == true && txt_EGuestID.TextLength < 1)
            {
                Errors.Add("Please search for an existing guest or add a new guest before submitting the booking.");
            }
            if(pnl_GuestDetails.Visible == true && txt_Title.TextLength < 1 && txt_FirstName.TextLength < 1 && txt_Surname.TextLength < 1)
            {
                Errors.Add("Please complete the guest details before submitting the booking.");
            }
            if (pnl_GuestDetails.Visible == true && txt_Telephone.TextLength < 1 && txt_EmailAddress.TextLength < 1)
            {
                Errors.Add("Please ensure the guest provides a telephone number and/or email address.");
            }
            if (txt_TotalGuests.TextLength < 1 || txt_TtlBreakfasts.TextLength < 1)
            {
                Errors.Add("Please complete the number of guests and/or breakfasts before submitting the booking.");
            }
            if (rb_yes.Checked == false && rb_no.Checked == false)
            {
                Errors.Add("Please indicate if the guest has paid for the booking.");
            }

            return Errors;
        }

        private void cb_RoomWanted_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                // check if the room the guest wants is available to be booked
                using (var dbCon = new SQLiteConnection(details))
                {
                    string sqlCheck =
                        @"Select RoomBooking.Booking_ID, Booking.Check_In, Booking.Check_Out, Booking.Check_In  || ' - ' ||  Booking.Check_Out as Dates from RoomBooking"
                        + " INNER JOIN Booking on RoomBooking.Booking_ID = Booking.Booking_ID"
                        + " WHERE RoomBooking.Room_ID = '" + cb_RoomWanted.SelectedValue + "'"
                        + " AND Booking.Check_Out >= '" + cldr_Booking.SelectionStart.ToString("yyyy-MM-dd") + "'"
                        + " AND Booking.Check_In <= '" + cldr_Booking.SelectionEnd.ToString("yyyy-MM-dd") + "'"
                        + " AND Booking.Cancelled_By IS NULL";

                    daCheck = new SQLiteDataAdapter(sqlCheck, dbCon);
                    dtCheck.Clear();
                    daCheck.Fill(dtCheck);                    

                    if (dtCheck.Rows.Count > 0)
                    {
                        cb_unavailable.DataSource = dtCheck;
                        cb_unavailable.DisplayMember = "Dates";
                        cb_unavailable.ValueMember = "Booking_ID";
                        cb_unavailable.Enabled = true;
                        lbl_RoomAlert.Text = "Room NOT Available!";
                        lbl_RoomAlert.ForeColor = Color.Red;
                        
                    }

                    else
                    {
                        lbl_RoomAlert.Text = "Room Available!";
                        lbl_RoomAlert.ForeColor = Color.Green;
                        cb_unavailable.Enabled = false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking the room availability: " + ex.Message);
            }

        }

    }
}

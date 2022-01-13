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
         
            frm_ViewBookings f2 = new frm_ViewBookings();
            f2.ShowDialog(this);
        }

        private void btn_exitbook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit? You will lose all the data entered.", "Exit Form",
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Close();
            }
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

        private void btn_Guests_Click(object sender, EventArgs e)
        {
            new frm_GuestDetails().Show();
            Close();
            //bug: home page window pops up on top of this new form and the windows are not connected.
        }

        private void btn_Rooms_Click(object sender, EventArgs e)
        {
            new frm_RoomDetails().Show();
            Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            var Errors = checkIsValid();

            if (Errors.Count() > 0)
            {
                MessageBox.Show(String.Join(Environment.NewLine, Errors));
                return;
            }

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
                long BookingID;
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
                    //doesn't insert/amend (overwrite) any guest details
                    RowID = Int64.Parse(txt_EGuestID.Text);
                }

                using (SQLiteCommand cmd = dbCon.CreateCommand())
                {
                
                    //allows users to add record

                    cmd.CommandText = @"Insert into Booking(Emplyee_ID, Guest_ID, Booking_Date, Check_In, Check_Out, No_Of_Nights, Total_Guests, Total_Breakfasts, Has_Paid) 
                    Values (@Emplyee_ID, @Guest_ID, @Booking_Date, @Check_In, @Check_Out, @No_Of_Nights, @Total_Guests, @Total_Breakfasts, @Has_Paid)";
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
                    BookingID = dbCon.LastInsertRowId;
                    MessageBox.Show(recordsChanged.ToString() + " Booking Added"); //message to notify the user that they have added the records

                    dbCon.Close();
                }

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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
            //btn_submit.Enabled = true; 
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

                        //btn_submit.Enabled = true;
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

        //bug: user can double book a room.
        private void cb_RoomTypes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                using(var dbCon = new SQLiteConnection(details))
                {
                    if (checkBox_Disabled.Checked)
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
                    }
                    else
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
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void checkBox_Disabled_CheckedChanged(object sender, EventArgs e)
        {
            cb_RoomTypes_SelectionChangeCommitted(sender, e);
        }

        private void btn_SelectRoom_Click(object sender, EventArgs e)
        {
            if(cb_RoomWanted.SelectedIndex > -1)
            {
                //fills the list box with the key value pair of the information from the combo box.
                lb_Rooms.Items.Add(new KeyValuePair<int, string>(Int32.Parse(cb_RoomWanted.SelectedValue.ToString()), cb_RoomWanted.GetItemText(cb_RoomWanted.SelectedItem)));
                //bug: user can add same room multiple times
            }
            else
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
            var Errors = new List<string>();
            if(lb_Rooms.Items.Count < 1)
            {
                Errors.Add("Please choose at least one room before making a booking.");
            }
            if(txt_NoOfNights.TextLength < 1 || int.Parse(txt_NoOfNights.Text) < 1)
            {
                Errors.Add("Please select dates using the calendar provided before making a booking.");
            }
            //could add more validation error messages here.

            return Errors;
        }

        private void pnl_ExistingGuest_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_RoomWanted_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                using (var dbCon = new SQLiteConnection(details))
                {

                    string sqlCheck =
                        @"Select RoomBooking.Booking_ID, Booking.Check_In, Booking.Check_Out, Booking.Check_In  || ' - ' ||  Booking.Check_Out as Dates from RoomBooking"
                        + " INNER JOIN Booking on RoomBooking.Booking_ID = Booking.Booking_ID"
                        + " WHERE RoomBooking.Room_ID = '" + cb_RoomWanted.SelectedValue + "'";
                          //  + " AND Accessibility NOT LIKE 'Disabled'";

                        daCheck = new SQLiteDataAdapter(sqlCheck, dbCon);
                        dtCheck.Clear();
                        daCheck.Fill(dtCheck);

                        cb_unavailable.DataSource = dtCheck;
                        cb_unavailable.DisplayMember = "Dates";
                        cb_unavailable.ValueMember = "Booking_ID";
                    
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void pnl_Booking_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_RoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_RoomWanted_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

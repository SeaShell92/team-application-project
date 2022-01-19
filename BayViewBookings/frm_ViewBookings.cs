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
using System.Data.OleDb;

namespace BayViewBookings
{
    public partial class frm_ViewBookings : Form
    {
        public long UserID { get; set; }

        public frm_ViewBookings()
        {
            InitializeComponent();
            fill_listbox();
        }

        SQLiteConnection dbCon = new SQLiteConnection();
        const string details = @"Data Source = ..\..\Database\bookings.db";
        int bookingId;

        void fill_listbox() 
        {
            SQLiteConnection dbCon;
            SQLiteDataAdapter dbAdapter;
            DataTable dtBookings = new DataTable();

            try
            {
                using(dbCon = new SQLiteConnection(details))
                {
                    string Query = "Select * From Booking"; //sql code

                    dbAdapter = new SQLiteDataAdapter(Query, dbCon);
                    dbAdapter.Fill(dtBookings);

                    dgv_ViewBookings.DataSource = dtBookings;
                }              
            }
           catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
           }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_guests_Click(object sender, EventArgs e)
        {
            new frm_GuestDetails().Show(this);
            //Close();
            // Keep the view bookings form open and have a series of nested forms
            // This allows the user to go back to the original new booking form
        }

        private void btn_rooms_Click(object sender, EventArgs e)
        {
            new frm_RoomDetails().Show(this);
            //Close();
        }

        private void btn_Transactions_Click(object sender, EventArgs e)
        {
            new frm_TransactionDetails().Show(this);
            //Close();
        }

        private void btn_exitViewBook_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_ViewBookings_Load(object sender, EventArgs e)
        {

        }


        private void btn_cancelBooking_Click(object sender, EventArgs e)
        {
            if(dgv_ViewBookings.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a single booking to cancel.");
                return;
            }
            if(dgv_ViewBookings.SelectedRows[0].Cells["Cancelled_By"].Value.ToString().Length != 0)
            {
                MessageBox.Show("Booking has already been cancelled.  Please select a different booking.");
                return;
            }

            // get the booking ID of the selected booking and set it to a variable.
            bookingId = int.Parse(dgv_ViewBookings.SelectedRows[0].Cells["Booking_ID"].Value.ToString());

            pnl_cancelBooking.Show();
        }

        private void btn_cancelSubmit_Click(object sender, EventArgs e)
        {
            if(cb_confirm.Checked == false)
            {
                MessageBox.Show("Please tick the box to confirm the cancellation.");
                return;
            }

            if(!usernameMatchesLoggedInUser(txt_username.Text))
            {
                MessageBox.Show("Username incorrect.");
                return;
            }

            try
            {
                dbCon.ConnectionString = details;
                using (SQLiteCommand sqlCancel = dbCon.CreateCommand())
                {
                    sqlCancel.CommandText = "UPDATE Booking SET Cancelled_By = " + UserID + " WHERE Booking_ID = " + bookingId;

                    dbCon.Open();

                    sqlCancel.ExecuteNonQuery();
                    MessageBox.Show("Booking Cancelled.");

                    dbCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with cancellation: " + ex.Message);
                return;
            }
            txt_username.Clear();
            cb_confirm.Checked = false;
            pnl_cancelBooking.Hide();
            fill_listbox();
        }

        // check if the username matches the user who is logged in.
        private bool usernameMatchesLoggedInUser(string username)
        {
            try
            {
                dbCon.ConnectionString = details;
                using (SQLiteCommand sqlUserCheck = dbCon.CreateCommand())
                {
                    sqlUserCheck.CommandText = "SELECT Employee_ID, Username from Employee WHERE Username = @Username AND Employee_ID = @ID";
                    sqlUserCheck.Parameters.AddWithValue("Username", txt_username.Text);
                    sqlUserCheck.Parameters.AddWithValue("ID", UserID);

                    dbCon.Open();

                    bool match = false;

                    using (var reader = sqlUserCheck.ExecuteReader())
                    {
                        match = reader.Read();
                    }

                    dbCon.Close();

                    if (!match)
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with username: " + ex.Message);
                return false;
            }

            return true;
        }

        private void btn_cancelBack_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            cb_confirm.Checked = false;
            pnl_cancelBooking.Hide();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

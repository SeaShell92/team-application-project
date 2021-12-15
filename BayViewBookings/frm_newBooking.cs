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
        SQLiteConnection dbCon = new SQLiteConnection();
        SQLiteCommand dbcmd = new SQLiteCommand();
        const string details = @"Data Source = ..\..\Database\bookings.db";
        private void button11_Click(object sender, EventArgs e)
        {
           
            frm_ViewBookings f2 = new frm_ViewBookings(details);
            f2.ShowDialog();
            this.Hide();

        }


        private void btn_exitbook_Click(object sender, EventArgs e)
        {
            new frm_Manager_Homepage().Show();
            Close();
        }

        private void frm_newBooking_Load(object sender, EventArgs e)
        {

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
            try
            {

               
                    using (SQLiteCommand cmd = dbCon.CreateCommand())
                    {
                
                        //allows users to add record


                        dbCon.ConnectionString = details; //declares connection string
                            cmd.CommandText = @"Insert into Booking(Booking_ID) Values (@Booking_ID)";
                            cmd.Parameters.AddWithValue("Booking_ID", txt_BookingID.Text);
                           //cmd.Parameters.AddWithValue("Emplyee_ID", txt_EmployeeID.Text);
                           // cmd.Parameters.AddWithValue("Guest_ID", txt_GuestsID.Text);
                          //  cmd.Parameters.AddWithValue("Booking_Date", txt_BookingID.Text);
                         //   cmd.Parameters.AddWithValue("Check_In", txt_CheckIn.Text);
                         //   cmd.Parameters.AddWithValue("Check_Out", txt_CheckOut.Text);
                        //    cmd.Parameters.AddWithValue("No_Of_Nights", txt_NoOfNights.Text);
                       //     cmd.Parameters.AddWithValue("Total_Guests", txt_TotalGuests.Text);
                       //     cmd.Parameters.AddWithValue("Total_Breakfasts", txt_TtlBreakfasts.Text);
                //        cmd.Parameters.AddWithValue("Has_Paid", txt_al.Text);
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
    }
}

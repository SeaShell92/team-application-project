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
    public partial class frm_GuestDetails : Form
    {
        public frm_GuestDetails()
        {
            InitializeComponent();
            fill_listbox();
        }

        const string details = @"Data Source = ..\..\Database\bookings.db";
        SQLiteConnection dbCon = new SQLiteConnection();

        void fill_listbox()
        {
            SQLiteConnection dbCon;
            SQLiteDataAdapter dbAdapter;
            DataTable dtGuest = new DataTable();

            try
            {
                using (dbCon = new SQLiteConnection(details))
                {
                    string Query = "Select * From Guest"; //sql code

                    dbAdapter = new SQLiteDataAdapter(Query, dbCon);
                    dbAdapter.Fill(dtGuest);

                    dgv_GuestList.DataSource = dtGuest;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_exitguest_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Bookings_Click(object sender, EventArgs e)
        {
            new frm_newBooking().Show();
            Close();
        }

        private void btn_Rooms_Click(object sender, EventArgs e)
        {
            new frm_RoomDetails().Show();
            Close();
        }

        private void btn_AmendGuest_Click(object sender, EventArgs e)
        {
            panelGuest.Show();
           
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            panelGuest.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btn_Enter_Click(object sender, EventArgs e)

        {
            

            string newTitle = txt_Title.Text;
            string newFirstName = txt_FirstName.Text;
            string newSurname = txt_Surname.Text;
            string newTelephone = txt_Telephone.Text;
            string newEmail = txt_Email.Text;

           
            

            if (txt_Title.Text =="")

            {
                MessageBox.Show("Please write Guest Title.");
            }
            else if (txt_FirstName.Text =="")

            {
                MessageBox.Show("Please write Guest First Name.");
            }
            else if (txt_Surname.Text =="")

            {
                MessageBox.Show("Please write Guest Surname.");
            }
            else if (txt_Telephone.Text =="")

            {
                MessageBox.Show("Please write Guest Telephone Number.");
            }
            else if (txt_Email.Text =="")

            {
                MessageBox.Show("Please write Guest Email Address.");
            }
            else

            {
                try
                {

                    {
                        using (SQLiteCommand guestCmd = dbCon.CreateCommand())
                        {
                            //updates records

                            dbCon.ConnectionString = details;
                            guestCmd.CommandText = @"Update Guest Set Guest_Title = @Guest_Title, Guest_First_Name = @Guest_First_Name, Guest_Surname = @Guest_Surname, Guest_Tel = @Guest_Tel, Guest_Email =@Guest_Email Where Guest_ID='" + txt_GuestID.Text + "'";

                            guestCmd.Connection = dbCon;
                            guestCmd.Parameters.Add(new SQLiteParameter("@Guest_Title", txt_Title.Text));
                            guestCmd.Parameters.AddWithValue("@Guest_First_Name", txt_FirstName.Text);
                            guestCmd.Parameters.AddWithValue("@Guest_Surname", txt_Surname.Text);
                            guestCmd.Parameters.AddWithValue("@Guest_Tel", txt_Telephone.Text);
                            guestCmd.Parameters.AddWithValue("@Guest_Email", txt_Email.Text);


                            dbCon.Open();

                            int recordsChanged = guestCmd.ExecuteNonQuery();
                            MessageBox.Show(recordsChanged.ToString() + " Records Updated");
                            dbCon.Close();



                        }

                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }
    }
}

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

        private void btn_AmendGuest_Click(object sender, EventArgs e)
        {
            if (dgv_GuestList.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a single Guest to amend.");
                return;
            }

            // get the cells of the selected Guest and sets them to the appropriate text box.
            txt_GuestID.Text = dgv_GuestList.SelectedRows[0].Cells["Guest_ID"].Value.ToString();
            txt_Title.Text = dgv_GuestList.SelectedRows[0].Cells["Guest_Title"].Value.ToString();
            txt_FirstName.Text = dgv_GuestList.SelectedRows[0].Cells["Guest_First_Name"].Value.ToString();
            txt_Surname.Text = dgv_GuestList.SelectedRows[0].Cells["Guest_Surname"].Value.ToString();
            txt_Telephone.Text = dgv_GuestList.SelectedRows[0].Cells["Guest_Tel"].Value.ToString();
            txt_Email.Text = dgv_GuestList.SelectedRows[0].Cells["Guest_Email"].Value.ToString();

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
            // string were set but then we decided not to use them
            //string newTitle = txt_Title.Text;
            //string newFirstName = txt_FirstName.Text;
            //string newSurname = txt_Surname.Text;
            //string newTelephone = txt_Telephone.Text;
            //string newEmail = txt_Email.Text;                   

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
            // as both of these are optional when adding a guest to the database, there is no need to keep prompting the user.
            //else if (txt_Telephone.Text =="")
            //
            //{
            //    MessageBox.Show("Please write Guest Telephone Number.");
           // }
            //else if (txt_Email.Text =="")
            //
           // {
           //     MessageBox.Show("Please write Guest Email Address.");
           // }
            else

            {
                try
                {
                    using (SQLiteCommand guestCmd = dbCon.CreateCommand())
                    {
                        // updates record

                        dbCon.ConnectionString = details;
                        guestCmd.CommandText = @"Update Guest Set Guest_Title = @Guest_Title, Guest_First_Name = @Guest_First_Name, Guest_Surname = @Guest_Surname, Guest_Tel = @Guest_Tel, Guest_Email = @Guest_Email Where Guest_ID='" + txt_GuestID.Text + "'";

                        guestCmd.Connection = dbCon;
                        guestCmd.Parameters.Add(new SQLiteParameter("@Guest_Title", txt_Title.Text));
                        guestCmd.Parameters.AddWithValue("@Guest_First_Name", txt_FirstName.Text);
                        guestCmd.Parameters.AddWithValue("@Guest_Surname", txt_Surname.Text);
                        guestCmd.Parameters.AddWithValue("@Guest_Tel", txt_Telephone.Text);

                        // if the guest does not have an email address to amend
                        if (txt_Email.TextLength > 0)
                        {
                            guestCmd.Parameters.AddWithValue("@Guest_Email", txt_Email.Text);
                        }
                        else
                        {
                            guestCmd.Parameters.AddWithValue("@Guest_Email", null); // store a null value in the database
                        }

                        dbCon.Open();

                        int recordsChanged = guestCmd.ExecuteNonQuery();
                        MessageBox.Show(recordsChanged.ToString() + " Records Updated");
                        dbCon.Close();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }

                panelGuest.Hide();
                fill_listbox(); // refresh the list of guests to show amended details.

            }
        }
    }
}

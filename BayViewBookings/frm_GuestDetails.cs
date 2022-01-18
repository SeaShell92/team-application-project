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
    public partial class frm_GuestDetails : Form
    {
        public frm_GuestDetails()
        {
            InitializeComponent();
            fill_listbox();
        }

        const string details = @"Data Source = ..\..\Database\bookings.db";

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
                string query = "Update Guest SET Guest_Title = '" + newTitle + "', Guest_First_Name = '" + newFirstName + "', Guest_Surname = '" + newSurname + "', Guest_Tel = '" + newTelephone + "', Guest_Email = '" + newEmail + "' where Guest_ID =  '" + txt_GuestID.Text +"'" ;

                MessageBox.Show(query);
            }
        }
    }
}

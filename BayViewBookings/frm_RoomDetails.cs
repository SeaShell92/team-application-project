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
    public partial class frm_RoomDetails : Form
    {
        public frm_RoomDetails()
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
                    string Query = "Select * From Room"; //sql code

                    dbAdapter = new SQLiteDataAdapter(Query, dbCon);
                    dbAdapter.Fill(dtGuest);

                    dgv_RoomDetails.DataSource = dtGuest;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frm_RoomDetails_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_Manager_Homepage>().Any()) //if the manager home page form is open
            {
                btn_AmendRoom.Visible = true; //the manager can amend the rooms
            }
            else //if the staff home page form is open, the user cannot amend the rooms.
            {
                btn_AmendRoom.Visible = false; 
            }
        }

        private void btn_exitroomd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Guests_Click(object sender, EventArgs e)
        {
            new frm_GuestDetails().Show();
            Close();
        }

        private void btn_Bookings_Click(object sender, EventArgs e)
        {
            new frm_newBooking().Show();
            Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_AmendRoom_Click(object sender, EventArgs e)
        {
            pnl_RoomDetails.Visible = true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            pnl_RoomDetails.Visible = false;
        }


    }
}

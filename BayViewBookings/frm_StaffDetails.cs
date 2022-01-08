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
    public partial class frm_StaffDetails : Form
    {
        public frm_StaffDetails()
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
                    string Query = "Select * From Employee"; //sql code

                    dbAdapter = new SQLiteDataAdapter(Query, dbCon);
                    dbAdapter.Fill(dtGuest);

                    dgv_Staff.DataSource = dtGuest;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_StaffDetails_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_exitstaff_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Staff_Guests_Click(object sender, EventArgs e)
        {
            new frm_GuestDetails().Show();
            Close();
        }

        private void btn_Staff_Bookings_Click(object sender, EventArgs e)
        {
            new frm_newBooking().Show();
            Close();
        }

        private void btn_Staff_Rooms_Click(object sender, EventArgs e)
        {
            new frm_RoomDetails().Show();
            Close();
        }

        private void btn_Amend_Click(object sender, EventArgs e)
        {
            panel_staff.Show();
        }

        private void btn_CancelStaff_Click(object sender, EventArgs e)
        {
            panel_staff.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddStaff_Click(object sender, EventArgs e)
        {
            panel_AddStaff.Show();
        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            panel_AddStaff.Hide();
        }
    }
}

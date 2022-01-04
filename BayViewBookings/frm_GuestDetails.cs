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
        SQLiteConnection dbCon = new SQLiteConnection();
        SQLiteCommand dbcmd = new SQLiteCommand();
        const string details = @"Data Source = ..\..\Database\bookings.db";

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void fill_listbox()
        {
            string Query = "Select * From Guest"; //sql code
            SQLiteConnection dbCon = new SQLiteConnection(details);
            SQLiteCommand cmdDataBase = new SQLiteCommand(Query, dbCon);
            SQLiteDataReader dbreader;
            SQLiteDataAdapter dbadapter;
            DataTable dtBookings = new DataTable();

            try
            {
                dbCon.Open();
                dbreader = cmdDataBase.ExecuteReader();


                dbadapter = new SQLiteDataAdapter(Query, dbCon);
                dbadapter.Fill(dtBookings);
                dgv_GuestList.DataSource = dtBookings;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frm_ViewBookings_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Make_Amendments_Click(object sender, EventArgs e)
        {

        }

        private void btn_exitguest_Click(object sender, EventArgs e)
        {
            new frm_Manager_Homepage().Show();
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

        private void lb_GuestDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_AmendGuest_Click(object sender, EventArgs e)
        {
            panelGuest.Show();
           
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            panelGuest.Hide();
        }
    }
}

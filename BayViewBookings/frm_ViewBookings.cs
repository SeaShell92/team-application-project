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
        public frm_ViewBookings(string inString)
        {
            InitializeComponent();
            fill_listbox();
        }

        SQLiteConnection dbCon = new SQLiteConnection();
        SQLiteCommand dbcmd = new SQLiteCommand();
        const string details = @"Data Source = ..\..\Database\bookings.db";
      
        private void btn_exit_Click(object sender, EventArgs e)
        {

            //   new frm_newBooking().Show();
            this.DialogResult = DialogResult.OK;
        }
        void fill_listbox() 
        {
            string Query = "Select * From Booking"; //sql code
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
                    dgv_ViewBookings.DataSource = dtBookings;
                   
                   
            }
           catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
           }
        }
        private void frm_ViewBookings_Load(object sender, EventArgs e)
        {
          
        }

        private void btn_guests_Click(object sender, EventArgs e)
        {
            new frm_GuestDetails().Show();
            Close();
        }

        private void btn_rooms_Click(object sender, EventArgs e)
        {
            new frm_RoomDetails().Show();
            Close();
        }
    }
}

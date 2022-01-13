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
        public frm_ViewBookings()
        {
            InitializeComponent();
            fill_listbox();
        }

        const string details = @"Data Source = ..\..\Database\bookings.db";
      
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
    }
}

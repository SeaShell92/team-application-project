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
            DataTable dtStaff = new DataTable();

            try
            {
                using (dbCon = new SQLiteConnection(details))
                {
                    string Query = "Select * From Employee"; //sql code

                    dbAdapter = new SQLiteDataAdapter(Query, dbCon);
                    dbAdapter.Fill(dtStaff);

                    dgv_Staff.DataSource = dtStaff;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_exitstaff_Click(object sender, EventArgs e)
        {
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

        private void btn_AddStaff_Click(object sender, EventArgs e)
        {
            panel_AddStaff.Show();
        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            panel_AddStaff.Hide();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

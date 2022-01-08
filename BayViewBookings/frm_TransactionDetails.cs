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
    public partial class frm_TransactionDetails : Form
    {
        public frm_TransactionDetails()
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
                    string Query = "Select * From Transactions"; //sql code

                    dbAdapter = new SQLiteDataAdapter(Query, dbCon);
                    dbAdapter.Fill(dtGuest);

                    dgv_TransDet.DataSource = dtGuest;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_NewTransact_Click(object sender, EventArgs e)
        {
            pnl_Transaction.Visible = true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            pnl_Transaction.Visible = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_TransactExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

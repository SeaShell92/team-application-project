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
    public partial class frm_SalesReport : Form
    {
        public frm_SalesReport()
        {
            InitializeComponent();
        }
        public long UserID { get; set; }
        SQLiteDataAdapter daRoomsCheck;
        DataTable dtdaRoomsCheck = new DataTable();
        SQLiteConnection dbCon = new SQLiteConnection();
        const string details = @"Data Source = ..\..\Database\bookings.db";
        Decimal numberofrows;
      
        
        private void frm_SalesReport_Load(object sender, EventArgs e)
        {

            try //gathers the total amount of rooms
            {
                SQLiteConnection conn = new SQLiteConnection(details);
                SQLiteCommand cmd = new SQLiteCommand("select * from Room");
                SQLiteDataAdapter ap = new SQLiteDataAdapter(cmd.CommandText, conn);
                DataSet ds = new DataSet();

                conn.Open();
                ap.Fill(ds);

                numberofrows = ds.Tables[0].Rows.Count;
                //lbl_profit.Text = numberofrows.ToString();
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }




        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();

                using (var dbCon = new SQLiteConnection(details))
                {

                    string sqlCheck =
                        @"SELECT r.*, b.*, c.No_Of_Nights, r.Price*c.No_Of_Nights AS Total FROM Room r"
                        + " JOIN RoomBooking b ON b.Room_ID = r.Room_ID"
                        + " JOIN Booking c ON b.Booking_ID = c.Booking_ID"
                       + " WHERE c.Check_In BETWEEN '" + Convert.ToDateTime(txt_checkIn.Text).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(txt_checkOut.Text).ToString("yyyy-MM-dd") + "'"
                       + " OR c.Check_Out BETWEEN '" + Convert.ToDateTime(txt_checkIn.Text).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(txt_checkOut.Text).ToString("yyyy-MM-dd") + "'"
                       + " OR (c.Check_In < '" + Convert.ToDateTime(txt_checkIn.Text).ToString("yyyy-MM-dd") + "' AND c.Check_Out > '" + Convert.ToDateTime(txt_checkOut.Text).ToString("yyyy-MM-dd") + "')";

                    daRoomsCheck = new SQLiteDataAdapter(sqlCheck, dbCon);
                    dtdaRoomsCheck.Clear();
                    daRoomsCheck.Fill(dtdaRoomsCheck);

                    dataGridView1.DataSource = dtdaRoomsCheck;
                    int numRows = dataGridView1.Rows.Count - 1;
                    int total = dataGridView1.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToInt32(t.Cells[9].Value));
                    lbl_income.Text = "£" + total.ToString();
                    //  dataGridView1.DisplayMember = "Dates";
                    //  dataGridView1.ValueMember = "Booking_ID";


                    Decimal occupancyrates = numRows / numberofrows * 100;
                    Decimal DEBITAMT = Convert.ToDecimal(string.Format("{0:0.00}", occupancyrates));
                    //   lbl_occupancyrates.Text = DEBITAMT.ToString() + "%";
                    DateTime date1 = Convert.ToDateTime(txt_checkIn.Text);
                    DateTime date2 = Convert.ToDateTime(txt_checkOut.Text);
                    TimeSpan ts = date2 - date1;
                    lbl_daterange.Text = ts.Days.ToString();
                  //  int number = Convert.ToInt32(label1.Text);
                  //  if (number >= 1 && total >= 1000)
               //     {
               //         label1.ForeColor = Color.Green;
              //      }
              //      else if (number > 20 && total >= 10000)
              //      {
              //          label1.ForeColor = Color.Green;
              //      }
                    //        if (occupancyrates >= 70)
                    //     {
                    //         lbl_occupancyrates.ForeColor = Color.Green;
                    //     }
                    //     else
                    //      {
                    //         lbl_occupancyrates.ForeColor = Color.Red;
                    //      }
                    pnl_kpiincome.Visible = true;
                    pnl_daterange.Visible = true;
                    //  pnl_kpiunavaialble.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
       
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_exitViewReport_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


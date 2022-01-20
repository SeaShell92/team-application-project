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
    public partial class frm_ViewReports : Form
    {
        public frm_ViewReports()
        {
            InitializeComponent();
        }
        public long UserID { get; set; }
        SQLiteDataAdapter daRoomsCheck;
        DataTable dtdaRoomsCheck = new DataTable();
        SQLiteConnection dbCon = new SQLiteConnection();
        const string details = @"Data Source = ..\..\Database\bookings.db";
        Decimal numberofrows;
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_ViewReports_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft YaHei UI, 9.75pt", 10.5F, GraphicsUnit.Pixel);


                





            try //gathers the total amount of rooms
                  {
                     SQLiteConnection conn = new SQLiteConnection(details);
                     SQLiteCommand cmd = new SQLiteCommand("select * from Room");
                      SQLiteDataAdapter ap = new SQLiteDataAdapter(cmd.CommandText, conn);
                      DataSet ds = new DataSet();

                     conn.Open();
                     ap.Fill(ds);

                numberofrows = ds.Tables[0].Rows.Count;
                      lbl_totalrooms.Text = numberofrows.ToString();    
                conn.Close(); 
                 }

               catch (Exception ex)
               {
                   MessageBox.Show("Error: " + ex.Message);
            }

           


        }

        private void lb_ViewReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                
                using (var dbCon = new SQLiteConnection(details))
                {

                    string sqlCheck =
                        @"SELECT r.* FROM room r"
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

                    lbl_available_rooms.Text = numRows.ToString();
                    //   dataGridView1.DisplayMember = "Dates";
                    // dataGridView1.ValueMember = "Booking_ID";


                    Decimal occupancyrates = numRows / numberofrows* 100;
                    Decimal DEBITAMT = Convert.ToDecimal(string.Format("{0:0.00}", occupancyrates));
                    lbl_occupancyrates.Text = DEBITAMT.ToString() + "%";
                    if (occupancyrates >= 70)
                    {
                        lbl_occupancyrates.ForeColor = Color.Green;
                    }
                    else
                    {
                        lbl_occupancyrates.ForeColor = Color.Red;
                    }
                    pnl_kpioccupancy.Visible = true;
                    pnl_kpirooms.Visible = true;
                    pnl_kpiunavaialble.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Guests_Click(object sender, EventArgs e)
        {
            new frm_GuestDetails().Show(this);
           //    Close();
        }

        private void btn_Bookings_Click(object sender, EventArgs e)
        {
            new frm_newBooking().Show(this);
           // Close();
        }

        private void btn_Rooms_Click(object sender, EventArgs e)
        {
            new frm_RoomDetails().Show(this);
          //  Close();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {

        }

        private void btn_Quit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
    }
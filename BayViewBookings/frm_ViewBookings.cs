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
            this.Hide();
        }
        void fill_listbox() 
        {
            string Query = "Select * From Booking"; //sql code
            SQLiteConnection dbCon = new SQLiteConnection(details);
            SQLiteCommand cmdDataBase = new SQLiteCommand(Query, dbCon);
            SQLiteDataReader dbreader;

            try
            {
               dbCon.Open();
              dbreader = cmdDataBase.ExecuteReader();

               while (dbreader.Read())
              {

                    //integers
                    int BookingID = 0; 
                    int EmployeeID = 0;
                    int GuestID = 0;
                    int No_Of_Nights = 0;
                    int Total_Guests = 0;
                    int Total_Breakfasts = 0;
                    int Has_Paid = 0;

                    BookingID = dbreader.GetInt32(0); //database reader, int32 as it is integer and not string
                    lb_viewBookings.Items.Add(BookingID);

                    EmployeeID = dbreader.GetInt32(1); 
                    //lb_viewBookings.Items.AddRange(EmployeeID, BookingID);
            //        this.lb_viewBookings.Items.AddRange(new object[] {
      //     BookingID, GuestID});


                    GuestID = dbreader.GetInt32(2); 
                    lb_viewBookings.Items.Add(GuestID);

                    String Booking_Date = dbreader.GetString(3);
                    lb_viewBookings.Items.Add(Booking_Date);

                    String CheckIn = dbreader.GetString(4);
                   lb_viewBookings.Items.Add(CheckIn);

                    String CheckOut = dbreader.GetString(5);
                    lb_viewBookings.Items.Add(CheckOut);

                    No_Of_Nights = dbreader.GetInt32(6);
                    lb_viewBookings.Items.Add(No_Of_Nights);

                    Total_Guests = dbreader.GetInt32(7); 
                    lb_viewBookings.Items.Add(Total_Guests);

                    Total_Breakfasts = dbreader.GetInt32(8);
                    lb_viewBookings.Items.Add(Total_Breakfasts);
                    ;

                    Has_Paid = dbreader.GetInt32(9);
                    lb_viewBookings.Items.Add(Has_Paid);
                    ;

                }
             
            }
           catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
           }
        }
        private void frm_ViewBookings_Load(object sender, EventArgs e)
        {
          
        }
    }
}

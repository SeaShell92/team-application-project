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

namespace BayViewBookings
{
    public partial class frm_login : Form
    {
        Timer t1 = new Timer();
        public frm_login()
        {
            InitializeComponent();
        }

        SQLiteConnection dbCon = new SQLiteConnection();
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.03;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();

            try
            {
                // Takes the current directory of the application and adds on the relative location of the database file.
                string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Database\bookings.db");
                string conString = @"Data source = " + filepath;
                dbCon.ConnectionString = conString;
                dbCon.Open();
            //    MessageBox.Show("Connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       

            pnl_login.Location = new Point(
            this.ClientSize.Width / 2 - pnl_login.Size.Width / 2,
            this.ClientSize.Height / 2 - pnl_login.Size.Height / 2);
            pnl_login.Anchor = AnchorStyles.None;
        }


             private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm_Manager_Homepage = new frm_Manager_Homepage();
            frm_Manager_Homepage.Closed += (s, args) => this.Close();
            frm_Manager_Homepage.Show();
        }
    }
}

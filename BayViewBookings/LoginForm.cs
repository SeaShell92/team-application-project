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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SQLiteConnection dbCon = new SQLiteConnection();

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Takes the current directory of the application and adds on the relative location of the database file.
                string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Database\bookings.db");
                string conString = @"Data source = " + filepath;
                dbCon.ConnectionString = conString;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

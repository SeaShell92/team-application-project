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
        public frm_login()
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
          //  panel1.BackColor = Color.FromArgb(200, Color.White);
          //  btn_login.BackColor = Color.FromArgb(255, 149, 3, 65);
            pnl_login.Location = new Point(
    this.ClientSize.Width / 2 - pnl_login.Size.Width / 2,
    this.ClientSize.Height / 2 - pnl_login.Size.Height / 2);
            pnl_login.Anchor = AnchorStyles.None;
        }


             private void btn_login_Click(object sender, EventArgs e)
        {
            frm_Manager_Homepage f2 = new frm_Manager_Homepage();
            f2.ShowDialog(); // Shows Form2
            this.Close();
        }
    }
}

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
    public partial class frm_newBooking : Form
    {
        public frm_newBooking()
        {
            InitializeComponent();
        }
        SQLiteConnection dbCon = new SQLiteConnection();
        SQLiteCommand dbcmd = new SQLiteCommand();
        const string details = @"Data Source = ..\..\Database\bookings.db";
        private void button11_Click(object sender, EventArgs e)
        {
           
            frm_ViewBookings f2 = new frm_ViewBookings(details);
            f2.ShowDialog();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Telephone_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Surname_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_FirstName_Click(object sender, EventArgs e)
        {

        }

        private void btn_exitbook_Click(object sender, EventArgs e)
        {
            new frm_Manager_Homepage().Show();
            Close();
        }

        private void frm_newBooking_Load(object sender, EventArgs e)
        {

        }

        private void btn_Guests_Click(object sender, EventArgs e)
        {
            new frm_GuestDetails().Show();
            Close();
        }

        private void btn_Rooms_Click(object sender, EventArgs e)
        {
            new frm_RoomDetails().Show();
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BayViewBookings
{
    public partial class frm_newBooking : Form
    {
        public frm_newBooking()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frm_ViewBookings f2 = new frm_ViewBookings();
            f2.ShowDialog(); // Shows Form2
            this.Close();
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
    }
}

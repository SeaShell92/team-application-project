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
    public partial class frm_GuestDetails : Form
    {
        public frm_GuestDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Make_Amendments_Click(object sender, EventArgs e)
        {

        }

        private void btn_exitguest_Click(object sender, EventArgs e)
        {
            new frm_Manager_Homepage().Show();
            Close();
        }
    }
}

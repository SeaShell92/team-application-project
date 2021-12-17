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
    public partial class frm_Staff_Homepage : Form
    {
        public frm_Staff_Homepage()
        {
            InitializeComponent();
        }

        private void frm_Staff_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm_login = new frm_login();
            frm_login.Closed += (s, args) => this.Close();
            frm_login.Show();
        }
    }
}

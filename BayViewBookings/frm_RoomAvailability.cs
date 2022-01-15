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
    public partial class frm_RoomAvailability : Form
    {
        public frm_RoomAvailability()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_RoomAvailExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_RoomAvailability_Load(object sender, EventArgs e)
        {

        }
    }
}

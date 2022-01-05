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
    public partial class frm_TransactionDetails : Form
    {
        public frm_TransactionDetails()
        {
            InitializeComponent();
        }

        private void btn_NewTransact_Click(object sender, EventArgs e)
        {
            pnl_Transaction.Visible = true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            pnl_Transaction.Visible = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

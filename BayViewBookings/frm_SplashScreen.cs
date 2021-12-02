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
    public partial class frm_SplashScreen : Form
    {
        public frm_SplashScreen()
        {
            InitializeComponent();
        }

        private void tmr_splash_Tick(object sender, EventArgs e)
        {
            pnl_loading.Width += 5;
            if (pnl_loading.Width >= 971)
            {
                tmr_splash.Start();
                tmr_splash.Stop();
                this.Hide();
                var frm_login = new frm_login();
                frm_login.Closed += (s, args) => this.Close();
                frm_login.Show();
            }
        }
    }
}

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

        Timer t1 = new Timer();

        private void tmr_splash_Tick(object sender, EventArgs e)
        {
            pnl_loading.Width += 6;
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

        private void frm_SplashScreen_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                t1.Stop();   //this stops the timer if the form is completely displayed
            }                
            else
            {
                Opacity += 0.008;
            }
        }
    }
}

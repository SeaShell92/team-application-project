﻿using System;
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
    public partial class frm_RoomDetails : Form
    {
        public frm_RoomDetails()
        {
            InitializeComponent();
        }

        private void frm_RoomDetails_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_Manager_Homepage>().Any()) //if the manager home page form is open
            {
                btn_AmendRoom.Visible = true; //the manager can amend the rooms
            }
            else //if the staff home page form is open, the user cannot amend the rooms.
            {
                btn_AmendRoom.Visible = false; 
            }
            //there is a bug that if you log out from being a manager and back in as staff the button is visible.
        }

        private void btn_exitroomd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Guests_Click(object sender, EventArgs e)
        {
            new frm_GuestDetails().Show();
            Close();
        }

        private void btn_Bookings_Click(object sender, EventArgs e)
        {
            new frm_newBooking().Show();
            Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_AmendRoom_Click(object sender, EventArgs e)
        {
            pnl_RoomDetails.Visible = true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            pnl_RoomDetails.Visible = false;
        }


    }
}

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
using System.Data.OleDb;

namespace BayViewBookings
{
    public partial class frm_ViewBookings : Form
    {
        public frm_ViewBookings(string inString)
        {
            InitializeComponent();
            fill_listbox();
        }

        SQLiteConnection dbCon = new SQLiteConnection();
        SQLiteCommand dbcmd = new SQLiteCommand();
        const string details = @"Data Source = ..\..\Database\bookings.db";
      
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        void fill_listbox() 
        {
            string Query = "Select * From Booking"; //sql code
            SQLiteConnection dbCon = new SQLiteConnection(details);
            SQLiteCommand cmdDataBase = new SQLiteCommand(Query, dbCon);
            SQLiteDataReader dbreader;

            try
            {
               dbCon.Open();
              dbreader = cmdDataBase.ExecuteReader();

               while (dbreader.Read())
              {
                    String sName = dbreader.GetString(1);
                   lb_viewBookings.Items.Add(sName);
             }
                cmdDataBase.Dispose();
                dbreader.Close();
            }
           catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
           }
        }
        private void frm_ViewBookings_Load(object sender, EventArgs e)
        {
          
        }
    }
}

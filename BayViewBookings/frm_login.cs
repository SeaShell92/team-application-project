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
    public partial class frm_login : Form
    {
       // public string username { get; set; }

        Timer t1 = new Timer();
        public frm_login()
        {
            InitializeComponent();
        }
       // SQLiteConnection connectionstring;
        
        SQLiteConnection dbCon = new SQLiteConnection();
        SQLiteCommand dbcmd = new SQLiteCommand();
        const string details = @"Data Source = ..\..\Database\bookings.db";

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.03;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            lbl_managed_by.Text = null;
            this.Visible = false;
            Opacity = 0;     

            t1.Interval = 10;  
            t1.Tick += new EventHandler(fadeIn); 
            t1.Start();
            this.AcceptButton = btn_login; //this makes it so that when enter is pressed the login button will be executed

            try
            {
                // Takes the current directory of the application and adds on the relative location of the database file.
                const string details = @"Data Source = ..\..\Database\bookings.db";
                dbCon.ConnectionString = details;
                dbCon.Open();
                //    MessageBox.Show("Connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            pnl_login.Location = new Point(
            this.ClientSize.Width / 2 - pnl_login.Size.Width / 2,
            this.ClientSize.Height / 2 - pnl_login.Size.Height / 2);
            pnl_login.Anchor = AnchorStyles.None;



        }


        private void btn_login_Click(object sender, EventArgs e)
        {
      
            

            try
            {
                using (var dbCon = new SQLiteConnection(@"Data Source = ..\..\Database\bookings.db"))
                {
                    dbCon.Open();
                    
                    using (var dbcmd = new SQLiteCommand("SELECT Username, Password FROM Employee WHERE Username=@Username AND Password=@Password", dbCon))
                    {
                        dbcmd.Parameters.AddWithValue("@Username", txt_username.Text);
                        dbcmd.Parameters.AddWithValue("@Password", txt_password.Text);
                        using (var reader = dbcmd.ExecuteReader())
                        {
                            var count = 0;
                            while (reader.Read())
                            {
                                count = count + 1;
                            }
                            if (count == 1)
                            {
                                if(lbl_managed_by.Text == "Manager") //lbl_managed_by 1 takes the "managed_by" field from Employee table, and if its 1 then their managed by someone therefore staff, 0 will be inputed if their managers
                                {
                                   
                                    string username = lbl_firstname.Text;
                                    frm_Manager_Homepage frm2 = new frm_Manager_Homepage();
                                    frm2.username = username;
                                    frm2.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Staff");

                                    string username = lbl_firstname.Text;
                                    frm_Staff_Homepage frm3 = new frm_Staff_Homepage();
                                    frm3.username = username;
                                    frm3.Show();
                                    this.Hide();
                                }
                            }
                            else if (count == 0)
                            {
                                MessageBox.Show("Please recheck your details");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
           
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            lbl_managed_by.Text = "";
            string Query = "Select * From Employee Where Username='" + txt_username.Text + "' ;";
            SQLiteConnection myConn = new SQLiteConnection(details);
            SQLiteCommand cmdDataBase = new SQLiteCommand(Query, myConn);
            SQLiteDataReader dbreader;
            try
            {
                myConn.Open();
                dbreader = cmdDataBase.ExecuteReader();

                while (dbreader.Read())
                {

                    string role = dbreader.GetString(6);
                    string firstName = dbreader.GetString(1);
                    lbl_managed_by.Text = role; //gets role to depend on username and whether staff/manager login
                    lbl_firstname.Text = firstName;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
 }


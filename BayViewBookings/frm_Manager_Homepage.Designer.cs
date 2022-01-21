
namespace BayViewBookings
{
    partial class frm_Manager_Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Manager_Homepage));
            this.pnl_Manager2 = new System.Windows.Forms.Panel();
            this.btn_X = new System.Windows.Forms.Button();
            this.btn_Rooms = new System.Windows.Forms.Button();
            this.btn_Reports = new System.Windows.Forms.Button();
            this.btn_Bookings = new System.Windows.Forms.Button();
            this.btn_Guests = new System.Windows.Forms.Button();
            this.lbl_Welcome_Msg = new System.Windows.Forms.Label();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.pnl_Manager = new System.Windows.Forms.Panel();
            this.btn_Transactions = new System.Windows.Forms.Button();
            this.cms_reports = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.allReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomOccupancyRatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_guests = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewGueststoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_rooms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewRoomstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomAvailabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_bookings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newBookingtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookingstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_exit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logouttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exittoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Manager2.SuspendLayout();
            this.pnl_Manager.SuspendLayout();
            this.cms_reports.SuspendLayout();
            this.cms_guests.SuspendLayout();
            this.cms_rooms.SuspendLayout();
            this.cms_bookings.SuspendLayout();
            this.cms_exit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Manager2
            // 
            this.pnl_Manager2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Manager2.Controls.Add(this.btn_X);
            this.pnl_Manager2.Controls.Add(this.btn_Rooms);
            this.pnl_Manager2.Controls.Add(this.btn_Reports);
            this.pnl_Manager2.Controls.Add(this.btn_Bookings);
            this.pnl_Manager2.Controls.Add(this.btn_Guests);
            this.pnl_Manager2.Controls.Add(this.lbl_Welcome_Msg);
            this.pnl_Manager2.ForeColor = System.Drawing.Color.White;
            this.pnl_Manager2.Location = new System.Drawing.Point(0, 0);
            this.pnl_Manager2.Name = "pnl_Manager2";
            this.pnl_Manager2.Size = new System.Drawing.Size(1241, 48);
            this.pnl_Manager2.TabIndex = 3;
            // 
            // btn_X
            // 
            this.btn_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_X.ForeColor = System.Drawing.Color.White;
            this.btn_X.Location = new System.Drawing.Point(1194, 10);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(33, 28);
            this.btn_X.TabIndex = 6;
            this.btn_X.Text = "X";
            this.btn_X.UseVisualStyleBackColor = false;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
            // 
            // btn_Rooms
            // 
            this.btn_Rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rooms.ForeColor = System.Drawing.Color.White;
            this.btn_Rooms.Location = new System.Drawing.Point(443, -3);
            this.btn_Rooms.Name = "btn_Rooms";
            this.btn_Rooms.Size = new System.Drawing.Size(150, 54);
            this.btn_Rooms.TabIndex = 3;
            this.btn_Rooms.Text = "Rooms";
            this.btn_Rooms.UseVisualStyleBackColor = false;
            this.btn_Rooms.Click += new System.EventHandler(this.btn_Rooms_Click);
            // 
            // btn_Reports
            // 
            this.btn_Reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reports.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Reports.Location = new System.Drawing.Point(590, -4);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Size = new System.Drawing.Size(155, 57);
            this.btn_Reports.TabIndex = 5;
            this.btn_Reports.Text = "Reports";
            this.btn_Reports.UseVisualStyleBackColor = false;
            this.btn_Reports.Click += new System.EventHandler(this.btn_Reports_Click);
            // 
            // btn_Bookings
            // 
            this.btn_Bookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Bookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bookings.ForeColor = System.Drawing.Color.White;
            this.btn_Bookings.Location = new System.Drawing.Point(296, -3);
            this.btn_Bookings.Name = "btn_Bookings";
            this.btn_Bookings.Size = new System.Drawing.Size(150, 54);
            this.btn_Bookings.TabIndex = 2;
            this.btn_Bookings.Text = "Bookings";
            this.btn_Bookings.UseVisualStyleBackColor = false;
            this.btn_Bookings.Click += new System.EventHandler(this.btn_Bookings_Click);
            // 
            // btn_Guests
            // 
            this.btn_Guests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Guests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guests.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guests.ForeColor = System.Drawing.Color.White;
            this.btn_Guests.Location = new System.Drawing.Point(149, -3);
            this.btn_Guests.Name = "btn_Guests";
            this.btn_Guests.Size = new System.Drawing.Size(150, 54);
            this.btn_Guests.TabIndex = 1;
            this.btn_Guests.Text = "Guests";
            this.btn_Guests.UseVisualStyleBackColor = false;
            this.btn_Guests.Click += new System.EventHandler(this.btn_Guests_Click);
            // 
            // lbl_Welcome_Msg
            // 
            this.lbl_Welcome_Msg.AutoSize = true;
            this.lbl_Welcome_Msg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Welcome_Msg.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome_Msg.ForeColor = System.Drawing.Color.White;
            this.lbl_Welcome_Msg.Location = new System.Drawing.Point(778, 9);
            this.lbl_Welcome_Msg.Name = "lbl_Welcome_Msg";
            this.lbl_Welcome_Msg.Size = new System.Drawing.Size(294, 30);
            this.lbl_Welcome_Msg.TabIndex = 0;
            this.lbl_Welcome_Msg.Text = "#GREETING TIME#, #NAME#";
            // 
            // btn_Staff
            // 
            this.btn_Staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff.ForeColor = System.Drawing.Color.White;
            this.btn_Staff.Location = new System.Drawing.Point(7, 0);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(155, 59);
            this.btn_Staff.TabIndex = 4;
            this.btn_Staff.Text = "Staff";
            this.btn_Staff.UseVisualStyleBackColor = false;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // pnl_Manager
            // 
            this.pnl_Manager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Manager.Controls.Add(this.btn_Transactions);
            this.pnl_Manager.Controls.Add(this.btn_Staff);
            this.pnl_Manager.Location = new System.Drawing.Point(-9, 45);
            this.pnl_Manager.Name = "pnl_Manager";
            this.pnl_Manager.Size = new System.Drawing.Size(160, 634);
            this.pnl_Manager.TabIndex = 12;
            // 
            // btn_Transactions
            // 
            this.btn_Transactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Transactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Transactions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Transactions.Location = new System.Drawing.Point(7, 57);
            this.btn_Transactions.Name = "btn_Transactions";
            this.btn_Transactions.Size = new System.Drawing.Size(155, 57);
            this.btn_Transactions.TabIndex = 7;
            this.btn_Transactions.Text = "Transactions";
            this.btn_Transactions.UseVisualStyleBackColor = false;
            this.btn_Transactions.Click += new System.EventHandler(this.btn_Transactions_Click);
            // 
            // cms_reports
            // 
            this.cms_reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cms_reports.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allReportsToolStripMenuItem,
            this.roomOccupancyRatesToolStripMenuItem,
            this.salesReportToolStripMenuItem});
            this.cms_reports.Name = "contextMenuStrip1";
            this.cms_reports.Size = new System.Drawing.Size(201, 92);
            // 
            // allReportsToolStripMenuItem
            // 
            this.allReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.allReportsToolStripMenuItem.Name = "allReportsToolStripMenuItem";
            this.allReportsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.allReportsToolStripMenuItem.Text = "All Reports";
            this.allReportsToolStripMenuItem.Click += new System.EventHandler(this.allReportsToolStripMenuItem_Click);
            // 
            // roomOccupancyRatesToolStripMenuItem
            // 
            this.roomOccupancyRatesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.roomOccupancyRatesToolStripMenuItem.Name = "roomOccupancyRatesToolStripMenuItem";
            this.roomOccupancyRatesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.roomOccupancyRatesToolStripMenuItem.Text = "Room Occupancy Rates";
            this.roomOccupancyRatesToolStripMenuItem.Click += new System.EventHandler(this.roomOccupancyRatesToolStripMenuItem_Click);
            // 
            // salesReportToolStripMenuItem
            // 
            this.salesReportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.salesReportToolStripMenuItem.Text = "Sales Report";
            this.salesReportToolStripMenuItem.Click += new System.EventHandler(this.salesReportToolStripMenuItem_Click);
            // 
            // cms_guests
            // 
            this.cms_guests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cms_guests.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewGueststoolStripMenuItem});
            this.cms_guests.Name = "contextMenuStrip1";
            this.cms_guests.Size = new System.Drawing.Size(138, 26);
            // 
            // viewGueststoolStripMenuItem
            // 
            this.viewGueststoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewGueststoolStripMenuItem.Name = "viewGueststoolStripMenuItem";
            this.viewGueststoolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.viewGueststoolStripMenuItem.Text = "View Guests";
            this.viewGueststoolStripMenuItem.Click += new System.EventHandler(this.viewGueststoolStripMenuItem_Click);
            // 
            // cms_rooms
            // 
            this.cms_rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cms_rooms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewRoomstoolStripMenuItem,
            this.roomAvailabilityToolStripMenuItem});
            this.cms_rooms.Name = "contextMenuStrip1";
            this.cms_rooms.Size = new System.Drawing.Size(168, 48);
            // 
            // viewRoomstoolStripMenuItem
            // 
            this.viewRoomstoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewRoomstoolStripMenuItem.Name = "viewRoomstoolStripMenuItem";
            this.viewRoomstoolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.viewRoomstoolStripMenuItem.Text = "View Rooms";
            this.viewRoomstoolStripMenuItem.Click += new System.EventHandler(this.viewRoomstoolStripMenuItem_Click);
            // 
            // roomAvailabilityToolStripMenuItem
            // 
            this.roomAvailabilityToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.roomAvailabilityToolStripMenuItem.Name = "roomAvailabilityToolStripMenuItem";
            this.roomAvailabilityToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.roomAvailabilityToolStripMenuItem.Text = "Room Availability";
            this.roomAvailabilityToolStripMenuItem.Click += new System.EventHandler(this.roomAvailabilityToolStripMenuItem_Click);
            // 
            // cms_bookings
            // 
            this.cms_bookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cms_bookings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookingtoolStripMenuItem,
            this.viewBookingstoolStripMenuItem});
            this.cms_bookings.Name = "contextMenuStrip1";
            this.cms_bookings.Size = new System.Drawing.Size(152, 48);
            // 
            // newBookingtoolStripMenuItem
            // 
            this.newBookingtoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newBookingtoolStripMenuItem.Name = "newBookingtoolStripMenuItem";
            this.newBookingtoolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.newBookingtoolStripMenuItem.Text = "New Booking";
            this.newBookingtoolStripMenuItem.Click += new System.EventHandler(this.newBookingtoolStripMenuItem_Click);
            // 
            // viewBookingstoolStripMenuItem
            // 
            this.viewBookingstoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewBookingstoolStripMenuItem.Name = "viewBookingstoolStripMenuItem";
            this.viewBookingstoolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.viewBookingstoolStripMenuItem.Text = "View Bookings";
            this.viewBookingstoolStripMenuItem.Click += new System.EventHandler(this.viewBookingstoolStripMenuItem_Click);
            // 
            // cms_exit
            // 
            this.cms_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cms_exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logouttoolStripMenuItem,
            this.exittoolStripMenuItem});
            this.cms_exit.Name = "contextMenuStrip1";
            this.cms_exit.Size = new System.Drawing.Size(113, 48);
            // 
            // logouttoolStripMenuItem
            // 
            this.logouttoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logouttoolStripMenuItem.Name = "logouttoolStripMenuItem";
            this.logouttoolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logouttoolStripMenuItem.Text = "Logout";
            this.logouttoolStripMenuItem.Click += new System.EventHandler(this.logouttoolStripMenuItem_Click);
            // 
            // exittoolStripMenuItem
            // 
            this.exittoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exittoolStripMenuItem.Name = "exittoolStripMenuItem";
            this.exittoolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exittoolStripMenuItem.Text = "Exit";
            this.exittoolStripMenuItem.Click += new System.EventHandler(this.exittoolStripMenuItem_Click);
            // 
            // frm_Manager_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1239, 677);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Manager);
            this.Controls.Add(this.pnl_Manager2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_Manager_Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage | Manager";
            this.Load += new System.EventHandler(this.frm_Manager_Homepage_Load);
            this.pnl_Manager2.ResumeLayout(false);
            this.pnl_Manager2.PerformLayout();
            this.pnl_Manager.ResumeLayout(false);
            this.cms_reports.ResumeLayout(false);
            this.cms_guests.ResumeLayout(false);
            this.cms_rooms.ResumeLayout(false);
            this.cms_bookings.ResumeLayout(false);
            this.cms_exit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Manager2;
        private System.Windows.Forms.Button btn_Bookings;
        private System.Windows.Forms.Button btn_Guests;
        private System.Windows.Forms.Button btn_Rooms;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Button btn_Reports;
        private System.Windows.Forms.Button btn_Staff;
        private System.Windows.Forms.Panel pnl_Manager;
        public System.Windows.Forms.Label lbl_Welcome_Msg;
        private System.Windows.Forms.Button btn_Transactions;
        private System.Windows.Forms.ContextMenuStrip cms_reports;
        private System.Windows.Forms.ToolStripMenuItem allReportsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cms_guests;
        private System.Windows.Forms.ToolStripMenuItem viewGueststoolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cms_rooms;
        private System.Windows.Forms.ToolStripMenuItem viewRoomstoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomAvailabilityToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cms_bookings;
        private System.Windows.Forms.ToolStripMenuItem newBookingtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookingstoolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cms_exit;
        private System.Windows.Forms.ToolStripMenuItem logouttoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exittoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomOccupancyRatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
    }
}
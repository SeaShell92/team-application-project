
namespace BayViewBookings
{
    partial class frm_ViewBookings
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
            this.pnl_viewbookings = new System.Windows.Forms.Panel();
            this.pnl_filters = new System.Windows.Forms.Panel();
            this.btn_filter3 = new System.Windows.Forms.Button();
            this.txt_filter3 = new System.Windows.Forms.TextBox();
            this.btn_filter2 = new System.Windows.Forms.Button();
            this.txt_filter2 = new System.Windows.Forms.TextBox();
            this.btn_filter1 = new System.Windows.Forms.Button();
            this.txt_filter1 = new System.Windows.Forms.TextBox();
            this.pnl_viewbookingsheader = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_rooms = new System.Windows.Forms.Button();
            this.btn_bookings = new System.Windows.Forms.Button();
            this.btn_guests = new System.Windows.Forms.Button();
            this.lbl_viewbookings = new System.Windows.Forms.Label();
            this.dgv_ViewBookings = new System.Windows.Forms.DataGridView();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.pnl_filters.SuspendLayout();
            this.pnl_viewbookingsheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_viewbookings
            // 
            this.pnl_viewbookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_viewbookings.Location = new System.Drawing.Point(-5, 57);
            this.pnl_viewbookings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_viewbookings.Name = "pnl_viewbookings";
            this.pnl_viewbookings.Size = new System.Drawing.Size(205, 788);
            this.pnl_viewbookings.TabIndex = 6;
            // 
            // pnl_filters
            // 
            this.pnl_filters.Controls.Add(this.btn_filter3);
            this.pnl_filters.Controls.Add(this.txt_filter3);
            this.pnl_filters.Controls.Add(this.btn_filter2);
            this.pnl_filters.Controls.Add(this.txt_filter2);
            this.pnl_filters.Controls.Add(this.btn_filter1);
            this.pnl_filters.Controls.Add(this.txt_filter1);
            this.pnl_filters.Location = new System.Drawing.Point(1383, 82);
            this.pnl_filters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_filters.Name = "pnl_filters";
            this.pnl_filters.Size = new System.Drawing.Size(255, 577);
            this.pnl_filters.TabIndex = 8;
            // 
            // btn_filter3
            // 
            this.btn_filter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter3.Location = new System.Drawing.Point(101, 289);
            this.btn_filter3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_filter3.Name = "btn_filter3";
            this.btn_filter3.Size = new System.Drawing.Size(116, 28);
            this.btn_filter3.TabIndex = 5;
            this.btn_filter3.Text = "filter3";
            this.btn_filter3.UseVisualStyleBackColor = true;
            // 
            // txt_filter3
            // 
            this.txt_filter3.Location = new System.Drawing.Point(37, 257);
            this.txt_filter3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_filter3.Name = "txt_filter3";
            this.txt_filter3.Size = new System.Drawing.Size(179, 22);
            this.txt_filter3.TabIndex = 4;
            // 
            // btn_filter2
            // 
            this.btn_filter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter2.Location = new System.Drawing.Point(101, 186);
            this.btn_filter2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_filter2.Name = "btn_filter2";
            this.btn_filter2.Size = new System.Drawing.Size(116, 28);
            this.btn_filter2.TabIndex = 3;
            this.btn_filter2.Text = "filter2";
            this.btn_filter2.UseVisualStyleBackColor = true;
            // 
            // txt_filter2
            // 
            this.txt_filter2.Location = new System.Drawing.Point(37, 154);
            this.txt_filter2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_filter2.Name = "txt_filter2";
            this.txt_filter2.Size = new System.Drawing.Size(179, 22);
            this.txt_filter2.TabIndex = 2;
            // 
            // btn_filter1
            // 
            this.btn_filter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter1.Location = new System.Drawing.Point(101, 86);
            this.btn_filter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_filter1.Name = "btn_filter1";
            this.btn_filter1.Size = new System.Drawing.Size(116, 28);
            this.btn_filter1.TabIndex = 1;
            this.btn_filter1.Text = "filter1";
            this.btn_filter1.UseVisualStyleBackColor = true;
            // 
            // txt_filter1
            // 
            this.txt_filter1.Location = new System.Drawing.Point(37, 54);
            this.txt_filter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_filter1.Name = "txt_filter1";
            this.txt_filter1.Size = new System.Drawing.Size(179, 22);
            this.txt_filter1.TabIndex = 0;
            // 
            // pnl_viewbookingsheader
            // 
            this.pnl_viewbookingsheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_viewbookingsheader.Controls.Add(this.btn_logout);
            this.pnl_viewbookingsheader.Controls.Add(this.btn_exit);
            this.pnl_viewbookingsheader.Controls.Add(this.btn_rooms);
            this.pnl_viewbookingsheader.Controls.Add(this.btn_bookings);
            this.pnl_viewbookingsheader.Controls.Add(this.btn_guests);
            this.pnl_viewbookingsheader.Controls.Add(this.lbl_viewbookings);
            this.pnl_viewbookingsheader.ForeColor = System.Drawing.Color.White;
            this.pnl_viewbookingsheader.Location = new System.Drawing.Point(0, 0);
            this.pnl_viewbookingsheader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_viewbookingsheader.Name = "pnl_viewbookingsheader";
            this.pnl_viewbookingsheader.Size = new System.Drawing.Size(1655, 59);
            this.pnl_viewbookingsheader.TabIndex = 9;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(1485, 11);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(100, 34);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(1593, 11);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(44, 34);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "x";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_rooms
            // 
            this.btn_rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rooms.ForeColor = System.Drawing.Color.White;
            this.btn_rooms.Location = new System.Drawing.Point(591, -4);
            this.btn_rooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_rooms.Name = "btn_rooms";
            this.btn_rooms.Size = new System.Drawing.Size(200, 66);
            this.btn_rooms.TabIndex = 3;
            this.btn_rooms.Text = "Rooms";
            this.btn_rooms.UseVisualStyleBackColor = false;
            this.btn_rooms.Click += new System.EventHandler(this.btn_rooms_Click);
            // 
            // btn_bookings
            // 
            this.btn_bookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_bookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bookings.ForeColor = System.Drawing.Color.White;
            this.btn_bookings.Location = new System.Drawing.Point(395, -4);
            this.btn_bookings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_bookings.Name = "btn_bookings";
            this.btn_bookings.Size = new System.Drawing.Size(200, 66);
            this.btn_bookings.TabIndex = 2;
            this.btn_bookings.Text = "Bookings";
            this.btn_bookings.UseVisualStyleBackColor = false;
            // 
            // btn_guests
            // 
            this.btn_guests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_guests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guests.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guests.ForeColor = System.Drawing.Color.White;
            this.btn_guests.Location = new System.Drawing.Point(199, -4);
            this.btn_guests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guests.Name = "btn_guests";
            this.btn_guests.Size = new System.Drawing.Size(200, 66);
            this.btn_guests.TabIndex = 1;
            this.btn_guests.Text = "Guests";
            this.btn_guests.UseVisualStyleBackColor = false;
            this.btn_guests.Click += new System.EventHandler(this.btn_guests_Click);
            // 
            // lbl_viewbookings
            // 
            this.lbl_viewbookings.AutoSize = true;
            this.lbl_viewbookings.BackColor = System.Drawing.Color.Transparent;
            this.lbl_viewbookings.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viewbookings.ForeColor = System.Drawing.Color.White;
            this.lbl_viewbookings.Location = new System.Drawing.Point(1083, 11);
            this.lbl_viewbookings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_viewbookings.Name = "lbl_viewbookings";
            this.lbl_viewbookings.Size = new System.Drawing.Size(206, 37);
            this.lbl_viewbookings.TabIndex = 0;
            this.lbl_viewbookings.Text = "View Bookings";
            // 
            // dgv_ViewBookings
            // 
            this.dgv_ViewBookings.AllowUserToOrderColumns = true;
            this.dgv_ViewBookings.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewBookings.Location = new System.Drawing.Point(208, 67);
            this.dgv_ViewBookings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_ViewBookings.Name = "dgv_ViewBookings";
            this.dgv_ViewBookings.RowHeadersWidth = 51;
            this.dgv_ViewBookings.Size = new System.Drawing.Size(1167, 751);
            this.dgv_ViewBookings.TabIndex = 10;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // frm_ViewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 833);
            this.Controls.Add(this.dgv_ViewBookings);
            this.Controls.Add(this.pnl_viewbookingsheader);
            this.Controls.Add(this.pnl_filters);
            this.Controls.Add(this.pnl_viewbookings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_ViewBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Bookings";
            this.Load += new System.EventHandler(this.frm_ViewBookings_Load);
            this.pnl_filters.ResumeLayout(false);
            this.pnl_filters.PerformLayout();
            this.pnl_viewbookingsheader.ResumeLayout(false);
            this.pnl_viewbookingsheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewBookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_viewbookings;
        private System.Windows.Forms.Panel pnl_filters;
        private System.Windows.Forms.Button btn_filter3;
        private System.Windows.Forms.TextBox txt_filter3;
        private System.Windows.Forms.Button btn_filter2;
        private System.Windows.Forms.TextBox txt_filter2;
        private System.Windows.Forms.Button btn_filter1;
        private System.Windows.Forms.TextBox txt_filter1;
        private System.Windows.Forms.Panel pnl_viewbookingsheader;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_rooms;
        private System.Windows.Forms.Button btn_bookings;
        private System.Windows.Forms.Button btn_guests;
        private System.Windows.Forms.Label lbl_viewbookings;
        private System.Windows.Forms.DataGridView dgv_ViewBookings;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
    }
}
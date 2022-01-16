
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
            this.btn_exitViewBook = new System.Windows.Forms.Button();
            this.pnl_filters = new System.Windows.Forms.Panel();
            this.btn_filter3 = new System.Windows.Forms.Button();
            this.txt_filter3 = new System.Windows.Forms.TextBox();
            this.btn_filter2 = new System.Windows.Forms.Button();
            this.txt_filter2 = new System.Windows.Forms.TextBox();
            this.btn_filter1 = new System.Windows.Forms.Button();
            this.txt_filter1 = new System.Windows.Forms.TextBox();
            this.pnl_viewbookingsheader = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_rooms = new System.Windows.Forms.Button();
            this.btn_Transactions = new System.Windows.Forms.Button();
            this.btn_guests = new System.Windows.Forms.Button();
            this.lbl_viewbookings = new System.Windows.Forms.Label();
            this.dgv_ViewBookings = new System.Windows.Forms.DataGridView();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.btn_cancelBooking = new System.Windows.Forms.Button();
            this.pnl_cancelBooking = new System.Windows.Forms.Panel();
            this.btn_cancelSubmit = new System.Windows.Forms.Button();
            this.cb_confirm = new System.Windows.Forms.CheckBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_auditMsg = new System.Windows.Forms.Label();
            this.lbl_cancelConfirm = new System.Windows.Forms.Label();
            this.btn_cancelBack = new System.Windows.Forms.Button();
            this.pnl_viewbookings.SuspendLayout();
            this.pnl_filters.SuspendLayout();
            this.pnl_viewbookingsheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewBookings)).BeginInit();
            this.pnl_cancelBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_viewbookings
            // 
            this.pnl_viewbookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_viewbookings.Controls.Add(this.btn_exitViewBook);
            this.pnl_viewbookings.Location = new System.Drawing.Point(-4, 46);
            this.pnl_viewbookings.Name = "pnl_viewbookings";
            this.pnl_viewbookings.Size = new System.Drawing.Size(154, 640);
            this.pnl_viewbookings.TabIndex = 6;
            // 
            // btn_exitViewBook
            // 
            this.btn_exitViewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exitViewBook.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitViewBook.ForeColor = System.Drawing.Color.White;
            this.btn_exitViewBook.Location = new System.Drawing.Point(-3, 536);
            this.btn_exitViewBook.Name = "btn_exitViewBook";
            this.btn_exitViewBook.Size = new System.Drawing.Size(157, 101);
            this.btn_exitViewBook.TabIndex = 8;
            this.btn_exitViewBook.Text = "Back";
            this.btn_exitViewBook.UseVisualStyleBackColor = true;
            this.btn_exitViewBook.Click += new System.EventHandler(this.btn_exitViewBook_Click);
            // 
            // pnl_filters
            // 
            this.pnl_filters.Controls.Add(this.btn_filter3);
            this.pnl_filters.Controls.Add(this.txt_filter3);
            this.pnl_filters.Controls.Add(this.btn_filter2);
            this.pnl_filters.Controls.Add(this.txt_filter2);
            this.pnl_filters.Controls.Add(this.btn_filter1);
            this.pnl_filters.Controls.Add(this.txt_filter1);
            this.pnl_filters.Location = new System.Drawing.Point(1037, 67);
            this.pnl_filters.Name = "pnl_filters";
            this.pnl_filters.Size = new System.Drawing.Size(191, 469);
            this.pnl_filters.TabIndex = 8;
            // 
            // btn_filter3
            // 
            this.btn_filter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter3.Location = new System.Drawing.Point(76, 235);
            this.btn_filter3.Name = "btn_filter3";
            this.btn_filter3.Size = new System.Drawing.Size(87, 23);
            this.btn_filter3.TabIndex = 5;
            this.btn_filter3.Text = "filter3";
            this.btn_filter3.UseVisualStyleBackColor = true;
            // 
            // txt_filter3
            // 
            this.txt_filter3.Location = new System.Drawing.Point(28, 209);
            this.txt_filter3.Name = "txt_filter3";
            this.txt_filter3.Size = new System.Drawing.Size(135, 20);
            this.txt_filter3.TabIndex = 4;
            // 
            // btn_filter2
            // 
            this.btn_filter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter2.Location = new System.Drawing.Point(76, 151);
            this.btn_filter2.Name = "btn_filter2";
            this.btn_filter2.Size = new System.Drawing.Size(87, 23);
            this.btn_filter2.TabIndex = 3;
            this.btn_filter2.Text = "filter2";
            this.btn_filter2.UseVisualStyleBackColor = true;
            // 
            // txt_filter2
            // 
            this.txt_filter2.Location = new System.Drawing.Point(28, 125);
            this.txt_filter2.Name = "txt_filter2";
            this.txt_filter2.Size = new System.Drawing.Size(135, 20);
            this.txt_filter2.TabIndex = 2;
            // 
            // btn_filter1
            // 
            this.btn_filter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter1.Location = new System.Drawing.Point(76, 70);
            this.btn_filter1.Name = "btn_filter1";
            this.btn_filter1.Size = new System.Drawing.Size(87, 23);
            this.btn_filter1.TabIndex = 1;
            this.btn_filter1.Text = "filter1";
            this.btn_filter1.UseVisualStyleBackColor = true;
            // 
            // txt_filter1
            // 
            this.txt_filter1.Location = new System.Drawing.Point(28, 44);
            this.txt_filter1.Name = "txt_filter1";
            this.txt_filter1.Size = new System.Drawing.Size(135, 20);
            this.txt_filter1.TabIndex = 0;
            // 
            // pnl_viewbookingsheader
            // 
            this.pnl_viewbookingsheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_viewbookingsheader.Controls.Add(this.btn_exit);
            this.pnl_viewbookingsheader.Controls.Add(this.btn_rooms);
            this.pnl_viewbookingsheader.Controls.Add(this.btn_Transactions);
            this.pnl_viewbookingsheader.Controls.Add(this.btn_guests);
            this.pnl_viewbookingsheader.Controls.Add(this.lbl_viewbookings);
            this.pnl_viewbookingsheader.ForeColor = System.Drawing.Color.White;
            this.pnl_viewbookingsheader.Location = new System.Drawing.Point(0, 0);
            this.pnl_viewbookingsheader.Name = "pnl_viewbookingsheader";
            this.pnl_viewbookingsheader.Size = new System.Drawing.Size(1241, 48);
            this.pnl_viewbookingsheader.TabIndex = 9;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(1195, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(33, 28);
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
            this.btn_rooms.Location = new System.Drawing.Point(443, -3);
            this.btn_rooms.Name = "btn_rooms";
            this.btn_rooms.Size = new System.Drawing.Size(150, 54);
            this.btn_rooms.TabIndex = 3;
            this.btn_rooms.Text = "Rooms";
            this.btn_rooms.UseVisualStyleBackColor = false;
            this.btn_rooms.Click += new System.EventHandler(this.btn_rooms_Click);
            // 
            // btn_Transactions
            // 
            this.btn_Transactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Transactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Transactions.ForeColor = System.Drawing.Color.White;
            this.btn_Transactions.Location = new System.Drawing.Point(296, -3);
            this.btn_Transactions.Name = "btn_Transactions";
            this.btn_Transactions.Size = new System.Drawing.Size(150, 54);
            this.btn_Transactions.TabIndex = 2;
            this.btn_Transactions.Text = "Transactions";
            this.btn_Transactions.UseVisualStyleBackColor = false;
            this.btn_Transactions.Click += new System.EventHandler(this.btn_Transactions_Click);
            // 
            // btn_guests
            // 
            this.btn_guests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_guests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guests.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guests.ForeColor = System.Drawing.Color.White;
            this.btn_guests.Location = new System.Drawing.Point(149, -3);
            this.btn_guests.Name = "btn_guests";
            this.btn_guests.Size = new System.Drawing.Size(150, 54);
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
            this.lbl_viewbookings.Location = new System.Drawing.Point(812, 9);
            this.lbl_viewbookings.Name = "lbl_viewbookings";
            this.lbl_viewbookings.Size = new System.Drawing.Size(159, 30);
            this.lbl_viewbookings.TabIndex = 0;
            this.lbl_viewbookings.Text = "View Bookings";
            // 
            // dgv_ViewBookings
            // 
            this.dgv_ViewBookings.AllowUserToAddRows = false;
            this.dgv_ViewBookings.AllowUserToDeleteRows = false;
            this.dgv_ViewBookings.AllowUserToOrderColumns = true;
            this.dgv_ViewBookings.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewBookings.Location = new System.Drawing.Point(156, 54);
            this.dgv_ViewBookings.Name = "dgv_ViewBookings";
            this.dgv_ViewBookings.ReadOnly = true;
            this.dgv_ViewBookings.RowHeadersWidth = 31;
            this.dgv_ViewBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewBookings.Size = new System.Drawing.Size(875, 610);
            this.dgv_ViewBookings.TabIndex = 10;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // btn_cancelBooking
            // 
            this.btn_cancelBooking.BackColor = System.Drawing.Color.White;
            this.btn_cancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelBooking.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelBooking.Location = new System.Drawing.Point(1065, 628);
            this.btn_cancelBooking.Name = "btn_cancelBooking";
            this.btn_cancelBooking.Size = new System.Drawing.Size(135, 36);
            this.btn_cancelBooking.TabIndex = 24;
            this.btn_cancelBooking.Text = "Cancel Booking";
            this.btn_cancelBooking.UseVisualStyleBackColor = false;
            this.btn_cancelBooking.Click += new System.EventHandler(this.btn_cancelBooking_Click);
            // 
            // pnl_cancelBooking
            // 
            this.pnl_cancelBooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_cancelBooking.Controls.Add(this.btn_cancelBack);
            this.pnl_cancelBooking.Controls.Add(this.lbl_cancelConfirm);
            this.pnl_cancelBooking.Controls.Add(this.lbl_auditMsg);
            this.pnl_cancelBooking.Controls.Add(this.txt_username);
            this.pnl_cancelBooking.Controls.Add(this.cb_confirm);
            this.pnl_cancelBooking.Controls.Add(this.btn_cancelSubmit);
            this.pnl_cancelBooking.Location = new System.Drawing.Point(481, 255);
            this.pnl_cancelBooking.Name = "pnl_cancelBooking";
            this.pnl_cancelBooking.Size = new System.Drawing.Size(275, 166);
            this.pnl_cancelBooking.TabIndex = 25;
            this.pnl_cancelBooking.Visible = false;
            // 
            // btn_cancelSubmit
            // 
            this.btn_cancelSubmit.Location = new System.Drawing.Point(45, 126);
            this.btn_cancelSubmit.Name = "btn_cancelSubmit";
            this.btn_cancelSubmit.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelSubmit.TabIndex = 0;
            this.btn_cancelSubmit.Text = "Submit";
            this.btn_cancelSubmit.UseVisualStyleBackColor = true;
            this.btn_cancelSubmit.Click += new System.EventHandler(this.btn_cancelSubmit_Click);
            // 
            // cb_confirm
            // 
            this.cb_confirm.AutoSize = true;
            this.cb_confirm.Location = new System.Drawing.Point(35, 103);
            this.cb_confirm.Name = "cb_confirm";
            this.cb_confirm.Size = new System.Drawing.Size(205, 17);
            this.cb_confirm.TabIndex = 1;
            this.cb_confirm.Text = "I confirm I want to cancel this booking";
            this.cb_confirm.UseVisualStyleBackColor = true;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(73, 73);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(128, 20);
            this.txt_username.TabIndex = 2;
            // 
            // lbl_auditMsg
            // 
            this.lbl_auditMsg.Location = new System.Drawing.Point(14, 34);
            this.lbl_auditMsg.Name = "lbl_auditMsg";
            this.lbl_auditMsg.Size = new System.Drawing.Size(246, 26);
            this.lbl_auditMsg.TabIndex = 3;
            this.lbl_auditMsg.Text = "For audit purposes, please type your username in the box below:";
            // 
            // lbl_cancelConfirm
            // 
            this.lbl_cancelConfirm.AutoSize = true;
            this.lbl_cancelConfirm.Location = new System.Drawing.Point(84, 12);
            this.lbl_cancelConfirm.Name = "lbl_cancelConfirm";
            this.lbl_cancelConfirm.Size = new System.Drawing.Size(107, 13);
            this.lbl_cancelConfirm.TabIndex = 4;
            this.lbl_cancelConfirm.Text = "Booking Cancellation";
            // 
            // btn_cancelBack
            // 
            this.btn_cancelBack.Location = new System.Drawing.Point(154, 126);
            this.btn_cancelBack.Name = "btn_cancelBack";
            this.btn_cancelBack.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelBack.TabIndex = 5;
            this.btn_cancelBack.Text = "Back";
            this.btn_cancelBack.UseVisualStyleBackColor = true;
            this.btn_cancelBack.Click += new System.EventHandler(this.btn_cancelBack_Click);
            // 
            // frm_ViewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 677);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_cancelBooking);
            this.Controls.Add(this.btn_cancelBooking);
            this.Controls.Add(this.dgv_ViewBookings);
            this.Controls.Add(this.pnl_viewbookingsheader);
            this.Controls.Add(this.pnl_filters);
            this.Controls.Add(this.pnl_viewbookings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_ViewBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Bookings";
            this.Load += new System.EventHandler(this.frm_ViewBookings_Load);
            this.pnl_viewbookings.ResumeLayout(false);
            this.pnl_filters.ResumeLayout(false);
            this.pnl_filters.PerformLayout();
            this.pnl_viewbookingsheader.ResumeLayout(false);
            this.pnl_viewbookingsheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewBookings)).EndInit();
            this.pnl_cancelBooking.ResumeLayout(false);
            this.pnl_cancelBooking.PerformLayout();
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
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_rooms;
        private System.Windows.Forms.Button btn_Transactions;
        private System.Windows.Forms.Button btn_guests;
        private System.Windows.Forms.Label lbl_viewbookings;
        private System.Windows.Forms.DataGridView dgv_ViewBookings;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Button btn_exitViewBook;
        private System.Windows.Forms.Button btn_cancelBooking;
        private System.Windows.Forms.Panel pnl_cancelBooking;
        private System.Windows.Forms.Label lbl_cancelConfirm;
        private System.Windows.Forms.Label lbl_auditMsg;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.CheckBox cb_confirm;
        private System.Windows.Forms.Button btn_cancelSubmit;
        private System.Windows.Forms.Button btn_cancelBack;
    }
}
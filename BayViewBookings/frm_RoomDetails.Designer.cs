﻿
namespace BayViewBookings
{
    partial class frm_RoomDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exitroomd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_AmendRoom = new System.Windows.Forms.Button();
            this.btn_filter3 = new System.Windows.Forms.Button();
            this.txt_filter3 = new System.Windows.Forms.TextBox();
            this.btn_filter2 = new System.Windows.Forms.Button();
            this.txt_filter2 = new System.Windows.Forms.TextBox();
            this.btn_filter1 = new System.Windows.Forms.Button();
            this.txt_filter1 = new System.Windows.Forms.TextBox();
            this.pnl_Manager2 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_Rooms = new System.Windows.Forms.Button();
            this.btn_Bookings = new System.Windows.Forms.Button();
            this.btn_Guests = new System.Windows.Forms.Button();
            this.lbl_RoomDetails = new System.Windows.Forms.Label();
            this.pnl_RoomDetails = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.lbl_Room_Details = new System.Windows.Forms.Label();
            this.lbl_RoomDescription = new System.Windows.Forms.Label();
            this.lbl_Accessibility = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_RoomName = new System.Windows.Forms.Label();
            this.lbl_RoomType = new System.Windows.Forms.Label();
            this.lbl_RoomID = new System.Windows.Forms.Label();
            this.txt_RoomDescription = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Accessibility = new System.Windows.Forms.TextBox();
            this.txt_RoomName = new System.Windows.Forms.TextBox();
            this.txt_RoomType = new System.Windows.Forms.TextBox();
            this.txt_RoomID = new System.Windows.Forms.TextBox();
            this.dgv_RoomDetails = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_Manager2.SuspendLayout();
            this.pnl_RoomDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RoomDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_exitroomd);
            this.panel1.Location = new System.Drawing.Point(-4, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 640);
            this.panel1.TabIndex = 14;
            // 
            // btn_exitroomd
            // 
            this.btn_exitroomd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exitroomd.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitroomd.ForeColor = System.Drawing.Color.White;
            this.btn_exitroomd.Location = new System.Drawing.Point(0, 536);
            this.btn_exitroomd.Name = "btn_exitroomd";
            this.btn_exitroomd.Size = new System.Drawing.Size(154, 101);
            this.btn_exitroomd.TabIndex = 6;
            this.btn_exitroomd.Text = "Exit";
            this.btn_exitroomd.UseVisualStyleBackColor = true;
            this.btn_exitroomd.Click += new System.EventHandler(this.btn_exitroomd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_AmendRoom);
            this.panel3.Controls.Add(this.btn_filter3);
            this.panel3.Controls.Add(this.txt_filter3);
            this.panel3.Controls.Add(this.btn_filter2);
            this.panel3.Controls.Add(this.txt_filter2);
            this.panel3.Controls.Add(this.btn_filter1);
            this.panel3.Controls.Add(this.txt_filter1);
            this.panel3.Location = new System.Drawing.Point(1037, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 469);
            this.panel3.TabIndex = 17;
            // 
            // btn_AmendRoom
            // 
            this.btn_AmendRoom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AmendRoom.Location = new System.Drawing.Point(56, 408);
            this.btn_AmendRoom.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AmendRoom.Name = "btn_AmendRoom";
            this.btn_AmendRoom.Size = new System.Drawing.Size(94, 32);
            this.btn_AmendRoom.TabIndex = 20;
            this.btn_AmendRoom.Text = "Amend Room";
            this.btn_AmendRoom.UseVisualStyleBackColor = true;
            this.btn_AmendRoom.Visible = false;
            this.btn_AmendRoom.Click += new System.EventHandler(this.btn_AmendRoom_Click);
            // 
            // btn_filter3
            // 
            this.btn_filter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter3.Location = new System.Drawing.Point(76, 236);
            this.btn_filter3.Name = "btn_filter3";
            this.btn_filter3.Size = new System.Drawing.Size(87, 23);
            this.btn_filter3.TabIndex = 5;
            this.btn_filter3.Text = "filter3";
            this.btn_filter3.UseVisualStyleBackColor = true;
            // 
            // txt_filter3
            // 
            this.txt_filter3.Location = new System.Drawing.Point(28, 210);
            this.txt_filter3.Name = "txt_filter3";
            this.txt_filter3.Size = new System.Drawing.Size(135, 20);
            this.txt_filter3.TabIndex = 4;
            // 
            // btn_filter2
            // 
            this.btn_filter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter2.Location = new System.Drawing.Point(76, 152);
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
            this.btn_filter1.Location = new System.Drawing.Point(76, 71);
            this.btn_filter1.Name = "btn_filter1";
            this.btn_filter1.Size = new System.Drawing.Size(87, 23);
            this.btn_filter1.TabIndex = 1;
            this.btn_filter1.Text = "filter1";
            this.btn_filter1.UseVisualStyleBackColor = true;
            // 
            // txt_filter1
            // 
            this.txt_filter1.Location = new System.Drawing.Point(28, 45);
            this.txt_filter1.Name = "txt_filter1";
            this.txt_filter1.Size = new System.Drawing.Size(135, 20);
            this.txt_filter1.TabIndex = 0;
            // 
            // pnl_Manager2
            // 
            this.pnl_Manager2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Manager2.Controls.Add(this.btn_exit);
            this.pnl_Manager2.Controls.Add(this.btn_Rooms);
            this.pnl_Manager2.Controls.Add(this.btn_Bookings);
            this.pnl_Manager2.Controls.Add(this.btn_Guests);
            this.pnl_Manager2.Controls.Add(this.lbl_RoomDetails);
            this.pnl_Manager2.ForeColor = System.Drawing.Color.White;
            this.pnl_Manager2.Location = new System.Drawing.Point(0, 0);
            this.pnl_Manager2.Name = "pnl_Manager2";
            this.pnl_Manager2.Size = new System.Drawing.Size(1247, 48);
            this.pnl_Manager2.TabIndex = 18;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(1195, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(33, 28);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_Rooms
            // 
            this.btn_Rooms.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Rooms.Enabled = false;
            this.btn_Rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rooms.ForeColor = System.Drawing.Color.White;
            this.btn_Rooms.Location = new System.Drawing.Point(443, -3);
            this.btn_Rooms.Name = "btn_Rooms";
            this.btn_Rooms.Size = new System.Drawing.Size(150, 54);
            this.btn_Rooms.TabIndex = 3;
            this.btn_Rooms.Text = "Rooms";
            this.btn_Rooms.UseVisualStyleBackColor = false;
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
            // lbl_RoomDetails
            // 
            this.lbl_RoomDetails.AutoSize = true;
            this.lbl_RoomDetails.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RoomDetails.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoomDetails.ForeColor = System.Drawing.Color.White;
            this.lbl_RoomDetails.Location = new System.Drawing.Point(812, 9);
            this.lbl_RoomDetails.Name = "lbl_RoomDetails";
            this.lbl_RoomDetails.Size = new System.Drawing.Size(143, 30);
            this.lbl_RoomDetails.TabIndex = 0;
            this.lbl_RoomDetails.Text = "Room Details";
            // 
            // pnl_RoomDetails
            // 
            this.pnl_RoomDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_RoomDetails.Controls.Add(this.btn_Cancel);
            this.pnl_RoomDetails.Controls.Add(this.btn_Enter);
            this.pnl_RoomDetails.Controls.Add(this.lbl_Room_Details);
            this.pnl_RoomDetails.Controls.Add(this.lbl_RoomDescription);
            this.pnl_RoomDetails.Controls.Add(this.lbl_Accessibility);
            this.pnl_RoomDetails.Controls.Add(this.lbl_Price);
            this.pnl_RoomDetails.Controls.Add(this.lbl_RoomName);
            this.pnl_RoomDetails.Controls.Add(this.lbl_RoomType);
            this.pnl_RoomDetails.Controls.Add(this.lbl_RoomID);
            this.pnl_RoomDetails.Controls.Add(this.txt_RoomDescription);
            this.pnl_RoomDetails.Controls.Add(this.txt_Price);
            this.pnl_RoomDetails.Controls.Add(this.txt_Accessibility);
            this.pnl_RoomDetails.Controls.Add(this.txt_RoomName);
            this.pnl_RoomDetails.Controls.Add(this.txt_RoomType);
            this.pnl_RoomDetails.Controls.Add(this.txt_RoomID);
            this.pnl_RoomDetails.Location = new System.Drawing.Point(470, 81);
            this.pnl_RoomDetails.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_RoomDetails.Name = "pnl_RoomDetails";
            this.pnl_RoomDetails.Size = new System.Drawing.Size(297, 574);
            this.pnl_RoomDetails.TabIndex = 19;
            this.pnl_RoomDetails.Visible = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(190, 505);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(72, 53);
            this.btn_Cancel.TabIndex = 37;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(39, 505);
            this.btn_Enter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(72, 53);
            this.btn_Enter.TabIndex = 36;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = true;
            // 
            // lbl_Room_Details
            // 
            this.lbl_Room_Details.AutoSize = true;
            this.lbl_Room_Details.Location = new System.Drawing.Point(113, 18);
            this.lbl_Room_Details.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Room_Details.Name = "lbl_Room_Details";
            this.lbl_Room_Details.Size = new System.Drawing.Size(70, 13);
            this.lbl_Room_Details.TabIndex = 35;
            this.lbl_Room_Details.Text = "Room Details";
            // 
            // lbl_RoomDescription
            // 
            this.lbl_RoomDescription.AutoSize = true;
            this.lbl_RoomDescription.Location = new System.Drawing.Point(49, 396);
            this.lbl_RoomDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_RoomDescription.Name = "lbl_RoomDescription";
            this.lbl_RoomDescription.Size = new System.Drawing.Size(91, 13);
            this.lbl_RoomDescription.TabIndex = 32;
            this.lbl_RoomDescription.Text = "Room Description";
            // 
            // lbl_Accessibility
            // 
            this.lbl_Accessibility.AutoSize = true;
            this.lbl_Accessibility.Location = new System.Drawing.Point(49, 321);
            this.lbl_Accessibility.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Accessibility.Name = "lbl_Accessibility";
            this.lbl_Accessibility.Size = new System.Drawing.Size(64, 13);
            this.lbl_Accessibility.TabIndex = 30;
            this.lbl_Accessibility.Text = "Accessibility";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(49, 249);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(31, 13);
            this.lbl_Price.TabIndex = 31;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_RoomName
            // 
            this.lbl_RoomName.AutoSize = true;
            this.lbl_RoomName.Location = new System.Drawing.Point(49, 187);
            this.lbl_RoomName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_RoomName.Name = "lbl_RoomName";
            this.lbl_RoomName.Size = new System.Drawing.Size(66, 13);
            this.lbl_RoomName.TabIndex = 29;
            this.lbl_RoomName.Text = "Room Name";
            // 
            // lbl_RoomType
            // 
            this.lbl_RoomType.AutoSize = true;
            this.lbl_RoomType.Location = new System.Drawing.Point(49, 121);
            this.lbl_RoomType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_RoomType.Name = "lbl_RoomType";
            this.lbl_RoomType.Size = new System.Drawing.Size(62, 13);
            this.lbl_RoomType.TabIndex = 28;
            this.lbl_RoomType.Text = "Room Type";
            // 
            // lbl_RoomID
            // 
            this.lbl_RoomID.AutoSize = true;
            this.lbl_RoomID.Location = new System.Drawing.Point(49, 56);
            this.lbl_RoomID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_RoomID.Name = "lbl_RoomID";
            this.lbl_RoomID.Size = new System.Drawing.Size(49, 13);
            this.lbl_RoomID.TabIndex = 27;
            this.lbl_RoomID.Text = "Room ID";
            // 
            // txt_RoomDescription
            // 
            this.txt_RoomDescription.Location = new System.Drawing.Point(52, 427);
            this.txt_RoomDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txt_RoomDescription.Multiline = true;
            this.txt_RoomDescription.Name = "txt_RoomDescription";
            this.txt_RoomDescription.Size = new System.Drawing.Size(210, 39);
            this.txt_RoomDescription.TabIndex = 26;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(52, 278);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(114, 20);
            this.txt_Price.TabIndex = 25;
            // 
            // txt_Accessibility
            // 
            this.txt_Accessibility.Location = new System.Drawing.Point(52, 350);
            this.txt_Accessibility.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Accessibility.Name = "txt_Accessibility";
            this.txt_Accessibility.Size = new System.Drawing.Size(114, 20);
            this.txt_Accessibility.TabIndex = 24;
            // 
            // txt_RoomName
            // 
            this.txt_RoomName.Location = new System.Drawing.Point(52, 212);
            this.txt_RoomName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_RoomName.Name = "txt_RoomName";
            this.txt_RoomName.Size = new System.Drawing.Size(114, 20);
            this.txt_RoomName.TabIndex = 23;
            // 
            // txt_RoomType
            // 
            this.txt_RoomType.Location = new System.Drawing.Point(52, 142);
            this.txt_RoomType.Margin = new System.Windows.Forms.Padding(2);
            this.txt_RoomType.Name = "txt_RoomType";
            this.txt_RoomType.Size = new System.Drawing.Size(79, 20);
            this.txt_RoomType.TabIndex = 22;
            // 
            // txt_RoomID
            // 
            this.txt_RoomID.Location = new System.Drawing.Point(52, 81);
            this.txt_RoomID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_RoomID.Name = "txt_RoomID";
            this.txt_RoomID.Size = new System.Drawing.Size(79, 20);
            this.txt_RoomID.TabIndex = 21;
            // 
            // dgv_RoomDetails
            // 
            this.dgv_RoomDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgv_RoomDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RoomDetails.Location = new System.Drawing.Point(183, 79);
            this.dgv_RoomDetails.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_RoomDetails.Name = "dgv_RoomDetails";
            this.dgv_RoomDetails.RowHeadersWidth = 51;
            this.dgv_RoomDetails.RowTemplate.Height = 24;
            this.dgv_RoomDetails.Size = new System.Drawing.Size(734, 360);
            this.dgv_RoomDetails.TabIndex = 20;
            // 
            // frm_RoomDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 677);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_RoomDetails);
            this.Controls.Add(this.pnl_Manager2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_RoomDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_RoomDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Details";
            this.Load += new System.EventHandler(this.frm_RoomDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnl_Manager2.ResumeLayout(false);
            this.pnl_Manager2.PerformLayout();
            this.pnl_RoomDetails.ResumeLayout(false);
            this.pnl_RoomDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RoomDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exitroomd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_filter3;
        private System.Windows.Forms.TextBox txt_filter3;
        private System.Windows.Forms.Button btn_filter2;
        private System.Windows.Forms.TextBox txt_filter2;
        private System.Windows.Forms.Button btn_filter1;
        private System.Windows.Forms.TextBox txt_filter1;
        private System.Windows.Forms.Panel pnl_Manager2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_Rooms;
        private System.Windows.Forms.Button btn_Bookings;
        private System.Windows.Forms.Button btn_Guests;
        private System.Windows.Forms.Label lbl_RoomDetails;
        private System.Windows.Forms.Panel pnl_RoomDetails;
        private System.Windows.Forms.Label lbl_Room_Details;
        private System.Windows.Forms.Label lbl_RoomDescription;
        private System.Windows.Forms.Label lbl_Accessibility;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_RoomName;
        private System.Windows.Forms.Label lbl_RoomType;
        private System.Windows.Forms.Label lbl_RoomID;
        private System.Windows.Forms.TextBox txt_RoomDescription;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Accessibility;
        private System.Windows.Forms.TextBox txt_RoomName;
        private System.Windows.Forms.TextBox txt_RoomType;
        private System.Windows.Forms.TextBox txt_RoomID;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Button btn_AmendRoom;
        private System.Windows.Forms.DataGridView dgv_RoomDetails;
    }
}
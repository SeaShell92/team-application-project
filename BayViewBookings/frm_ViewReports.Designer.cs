
namespace BayViewBookings
{
    partial class frm_ViewReports
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
            this.btn_exitViewReport = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_Manager2 = new System.Windows.Forms.Panel();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.lbl_Welcome_Msg = new System.Windows.Forms.Label();
            this.lbl_available_rooms = new System.Windows.Forms.Label();
            this.txt_checkIn = new System.Windows.Forms.TextBox();
            this.txt_checkOut = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_totalrooms = new System.Windows.Forms.Label();
            this.lbl_occupancyrates = new System.Windows.Forms.Label();
            this.lbl_checkIn = new System.Windows.Forms.Label();
            this.lbl_checkOut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_kpirooms = new System.Windows.Forms.Panel();
            this.pnl_kpiunavaialble = new System.Windows.Forms.Panel();
            this.pnl_kpioccupancy = new System.Windows.Forms.Panel();
            this.saveFileDialogTest = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.pnl_Manager2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_kpirooms.SuspendLayout();
            this.pnl_kpiunavaialble.SuspendLayout();
            this.pnl_kpioccupancy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_exitViewReport);
            this.panel1.Location = new System.Drawing.Point(-4, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 640);
            this.panel1.TabIndex = 15;
            // 
            // btn_exitViewReport
            // 
            this.btn_exitViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exitViewReport.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitViewReport.ForeColor = System.Drawing.Color.White;
            this.btn_exitViewReport.Location = new System.Drawing.Point(-3, 536);
            this.btn_exitViewReport.Name = "btn_exitViewReport";
            this.btn_exitViewReport.Size = new System.Drawing.Size(157, 101);
            this.btn_exitViewReport.TabIndex = 7;
            this.btn_exitViewReport.Text = "Exit";
            this.btn_exitViewReport.UseVisualStyleBackColor = true;
            this.btn_exitViewReport.Click += new System.EventHandler(this.btn_exitViewReport_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(889, 629);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(135, 36);
            this.btn_close.TabIndex = 25;
            this.btn_close.Text = "Discard Report";
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.White;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.Black;
            this.btn_print.Location = new System.Drawing.Point(1030, 629);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(135, 36);
            this.btn_print.TabIndex = 24;
            this.btn_print.Text = "Print Report";
            this.btn_print.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(748, 629);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(135, 36);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "Save Report";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pnl_Manager2
            // 
            this.pnl_Manager2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Manager2.Controls.Add(this.btn_Quit);
            this.pnl_Manager2.Controls.Add(this.lbl_Welcome_Msg);
            this.pnl_Manager2.ForeColor = System.Drawing.Color.White;
            this.pnl_Manager2.Location = new System.Drawing.Point(0, 0);
            this.pnl_Manager2.Name = "pnl_Manager2";
            this.pnl_Manager2.Size = new System.Drawing.Size(1245, 48);
            this.pnl_Manager2.TabIndex = 27;
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.ForeColor = System.Drawing.Color.White;
            this.btn_Quit.Location = new System.Drawing.Point(1198, 9);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(29, 28);
            this.btn_Quit.TabIndex = 43;
            this.btn_Quit.Text = "X";
            this.btn_Quit.UseVisualStyleBackColor = false;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click_1);
            // 
            // lbl_Welcome_Msg
            // 
            this.lbl_Welcome_Msg.AutoSize = true;
            this.lbl_Welcome_Msg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Welcome_Msg.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome_Msg.ForeColor = System.Drawing.Color.White;
            this.lbl_Welcome_Msg.Location = new System.Drawing.Point(578, 9);
            this.lbl_Welcome_Msg.Name = "lbl_Welcome_Msg";
            this.lbl_Welcome_Msg.Size = new System.Drawing.Size(179, 30);
            this.lbl_Welcome_Msg.TabIndex = 0;
            this.lbl_Welcome_Msg.Text = "Occupancy Rates";
            // 
            // lbl_available_rooms
            // 
            this.lbl_available_rooms.AutoSize = true;
            this.lbl_available_rooms.BackColor = System.Drawing.Color.White;
            this.lbl_available_rooms.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_available_rooms.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_available_rooms.Location = new System.Drawing.Point(82, 36);
            this.lbl_available_rooms.Name = "lbl_available_rooms";
            this.lbl_available_rooms.Size = new System.Drawing.Size(28, 31);
            this.lbl_available_rooms.TabIndex = 28;
            this.lbl_available_rooms.Text = "2";
            this.lbl_available_rooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_checkIn
            // 
            this.txt_checkIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txt_checkIn.Location = new System.Drawing.Point(173, 105);
            this.txt_checkIn.Multiline = true;
            this.txt_checkIn.Name = "txt_checkIn";
            this.txt_checkIn.Size = new System.Drawing.Size(138, 29);
            this.txt_checkIn.TabIndex = 29;
            this.txt_checkIn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_checkOut
            // 
            this.txt_checkOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txt_checkOut.Location = new System.Drawing.Point(370, 105);
            this.txt_checkOut.Multiline = true;
            this.txt_checkOut.Name = "txt_checkOut";
            this.txt_checkOut.Size = new System.Drawing.Size(138, 29);
            this.txt_checkOut.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(173, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 419);
            this.dataGridView1.TabIndex = 31;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(564, 111);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 32;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_totalrooms
            // 
            this.lbl_totalrooms.AutoSize = true;
            this.lbl_totalrooms.BackColor = System.Drawing.Color.White;
            this.lbl_totalrooms.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_totalrooms.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_totalrooms.Location = new System.Drawing.Point(72, 38);
            this.lbl_totalrooms.Name = "lbl_totalrooms";
            this.lbl_totalrooms.Size = new System.Drawing.Size(42, 31);
            this.lbl_totalrooms.TabIndex = 33;
            this.lbl_totalrooms.Text = "10";
            this.lbl_totalrooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_occupancyrates
            // 
            this.lbl_occupancyrates.AutoSize = true;
            this.lbl_occupancyrates.BackColor = System.Drawing.Color.White;
            this.lbl_occupancyrates.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_occupancyrates.Location = new System.Drawing.Point(50, 40);
            this.lbl_occupancyrates.Name = "lbl_occupancyrates";
            this.lbl_occupancyrates.Size = new System.Drawing.Size(83, 31);
            this.lbl_occupancyrates.TabIndex = 34;
            this.lbl_occupancyrates.Text = "7.40%";
            this.lbl_occupancyrates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_checkIn
            // 
            this.lbl_checkIn.AutoSize = true;
            this.lbl_checkIn.BackColor = System.Drawing.Color.White;
            this.lbl_checkIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkIn.Location = new System.Drawing.Point(170, 82);
            this.lbl_checkIn.Name = "lbl_checkIn";
            this.lbl_checkIn.Size = new System.Drawing.Size(65, 19);
            this.lbl_checkIn.TabIndex = 35;
            this.lbl_checkIn.Text = "Check in:";
            // 
            // lbl_checkOut
            // 
            this.lbl_checkOut.AutoSize = true;
            this.lbl_checkOut.BackColor = System.Drawing.Color.White;
            this.lbl_checkOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkOut.Location = new System.Drawing.Point(367, 82);
            this.lbl_checkOut.Name = "lbl_checkOut";
            this.lbl_checkOut.Size = new System.Drawing.Size(75, 19);
            this.lbl_checkOut.TabIndex = 36;
            this.lbl_checkOut.Text = "Check Out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Occupancy Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Total Rooms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Unavailable Rooms";
            // 
            // pnl_kpirooms
            // 
            this.pnl_kpirooms.BackColor = System.Drawing.Color.White;
            this.pnl_kpirooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_kpirooms.Controls.Add(this.label2);
            this.pnl_kpirooms.Controls.Add(this.lbl_totalrooms);
            this.pnl_kpirooms.Location = new System.Drawing.Point(991, 115);
            this.pnl_kpirooms.Name = "pnl_kpirooms";
            this.pnl_kpirooms.Size = new System.Drawing.Size(190, 143);
            this.pnl_kpirooms.TabIndex = 40;
            this.pnl_kpirooms.Visible = false;
            // 
            // pnl_kpiunavaialble
            // 
            this.pnl_kpiunavaialble.BackColor = System.Drawing.Color.White;
            this.pnl_kpiunavaialble.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_kpiunavaialble.Controls.Add(this.label3);
            this.pnl_kpiunavaialble.Controls.Add(this.lbl_available_rooms);
            this.pnl_kpiunavaialble.Location = new System.Drawing.Point(991, 274);
            this.pnl_kpiunavaialble.Name = "pnl_kpiunavaialble";
            this.pnl_kpiunavaialble.Size = new System.Drawing.Size(190, 143);
            this.pnl_kpiunavaialble.TabIndex = 41;
            this.pnl_kpiunavaialble.Visible = false;
            // 
            // pnl_kpioccupancy
            // 
            this.pnl_kpioccupancy.BackColor = System.Drawing.Color.White;
            this.pnl_kpioccupancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_kpioccupancy.Controls.Add(this.label1);
            this.pnl_kpioccupancy.Controls.Add(this.lbl_occupancyrates);
            this.pnl_kpioccupancy.Location = new System.Drawing.Point(991, 433);
            this.pnl_kpioccupancy.Name = "pnl_kpioccupancy";
            this.pnl_kpioccupancy.Size = new System.Drawing.Size(190, 143);
            this.pnl_kpioccupancy.TabIndex = 42;
            this.pnl_kpioccupancy.Visible = false;
            // 
            // frm_ViewReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1239, 677);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_checkOut);
            this.Controls.Add(this.lbl_checkIn);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_checkOut);
            this.Controls.Add(this.txt_checkIn);
            this.Controls.Add(this.pnl_Manager2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_kpirooms);
            this.Controls.Add(this.pnl_kpiunavaialble);
            this.Controls.Add(this.pnl_kpioccupancy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_ViewReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Reports";
            this.Load += new System.EventHandler(this.frm_ViewReports_Load);
            this.panel1.ResumeLayout(false);
            this.pnl_Manager2.ResumeLayout(false);
            this.pnl_Manager2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_kpirooms.ResumeLayout(false);
            this.pnl_kpirooms.PerformLayout();
            this.pnl_kpiunavaialble.ResumeLayout(false);
            this.pnl_kpiunavaialble.PerformLayout();
            this.pnl_kpioccupancy.ResumeLayout(false);
            this.pnl_kpioccupancy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exitViewReport;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel pnl_Manager2;
        private System.Windows.Forms.Label lbl_Welcome_Msg;
        private System.Windows.Forms.Label lbl_available_rooms;
        private System.Windows.Forms.TextBox txt_checkIn;
        private System.Windows.Forms.TextBox txt_checkOut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_totalrooms;
        private System.Windows.Forms.Label lbl_occupancyrates;
        private System.Windows.Forms.Label lbl_checkIn;
        private System.Windows.Forms.Label lbl_checkOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_kpirooms;
        private System.Windows.Forms.Panel pnl_kpiunavaialble;
        private System.Windows.Forms.Panel pnl_kpioccupancy;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTest;
    }
}
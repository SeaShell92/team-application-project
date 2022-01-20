
namespace BayViewBookings
{
    partial class frm_SalesReport
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
            this.pnl_Manager2 = new System.Windows.Forms.Panel();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.lbl_Welcome_Msg = new System.Windows.Forms.Label();
            this.btn_exitViewReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_checkOut = new System.Windows.Forms.Label();
            this.lbl_checkIn = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_checkOut = new System.Windows.Forms.TextBox();
            this.txt_checkIn = new System.Windows.Forms.TextBox();
            this.pnl_kpiincome = new System.Windows.Forms.Panel();
            this.lbl_incometext = new System.Windows.Forms.Label();
            this.lbl_income = new System.Windows.Forms.Label();
            this.pnl_daterange = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_daterange = new System.Windows.Forms.Label();
            this.pnl_kpioccupancy = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_occupancyrates = new System.Windows.Forms.Label();
            this.pnl_Manager2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_kpiincome.SuspendLayout();
            this.pnl_daterange.SuspendLayout();
            this.pnl_kpioccupancy.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Manager2
            // 
            this.pnl_Manager2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Manager2.Controls.Add(this.btn_Quit);
            this.pnl_Manager2.Controls.Add(this.lbl_Welcome_Msg);
            this.pnl_Manager2.ForeColor = System.Drawing.Color.White;
            this.pnl_Manager2.Location = new System.Drawing.Point(1, -3);
            this.pnl_Manager2.Name = "pnl_Manager2";
            this.pnl_Manager2.Size = new System.Drawing.Size(1245, 48);
            this.pnl_Manager2.TabIndex = 29;
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
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // lbl_Welcome_Msg
            // 
            this.lbl_Welcome_Msg.AutoSize = true;
            this.lbl_Welcome_Msg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Welcome_Msg.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome_Msg.ForeColor = System.Drawing.Color.White;
            this.lbl_Welcome_Msg.Location = new System.Drawing.Point(578, 9);
            this.lbl_Welcome_Msg.Name = "lbl_Welcome_Msg";
            this.lbl_Welcome_Msg.Size = new System.Drawing.Size(135, 30);
            this.lbl_Welcome_Msg.TabIndex = 0;
            this.lbl_Welcome_Msg.Text = "Sales Report";
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_exitViewReport);
            this.panel1.Location = new System.Drawing.Point(-3, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 640);
            this.panel1.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(194, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 419);
            this.dataGridView1.TabIndex = 32;
            // 
            // lbl_checkOut
            // 
            this.lbl_checkOut.AutoSize = true;
            this.lbl_checkOut.BackColor = System.Drawing.Color.White;
            this.lbl_checkOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkOut.Location = new System.Drawing.Point(395, 69);
            this.lbl_checkOut.Name = "lbl_checkOut";
            this.lbl_checkOut.Size = new System.Drawing.Size(75, 19);
            this.lbl_checkOut.TabIndex = 41;
            this.lbl_checkOut.Text = "Check Out";
            // 
            // lbl_checkIn
            // 
            this.lbl_checkIn.AutoSize = true;
            this.lbl_checkIn.BackColor = System.Drawing.Color.White;
            this.lbl_checkIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkIn.Location = new System.Drawing.Point(198, 69);
            this.lbl_checkIn.Name = "lbl_checkIn";
            this.lbl_checkIn.Size = new System.Drawing.Size(65, 19);
            this.lbl_checkIn.TabIndex = 40;
            this.lbl_checkIn.Text = "Check in:";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(592, 98);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 39;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_checkOut
            // 
            this.txt_checkOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txt_checkOut.Location = new System.Drawing.Point(398, 92);
            this.txt_checkOut.Multiline = true;
            this.txt_checkOut.Name = "txt_checkOut";
            this.txt_checkOut.Size = new System.Drawing.Size(138, 29);
            this.txt_checkOut.TabIndex = 38;
            // 
            // txt_checkIn
            // 
            this.txt_checkIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txt_checkIn.Location = new System.Drawing.Point(201, 92);
            this.txt_checkIn.Multiline = true;
            this.txt_checkIn.Name = "txt_checkIn";
            this.txt_checkIn.Size = new System.Drawing.Size(138, 29);
            this.txt_checkIn.TabIndex = 37;
            // 
            // pnl_kpiincome
            // 
            this.pnl_kpiincome.BackColor = System.Drawing.Color.White;
            this.pnl_kpiincome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_kpiincome.Controls.Add(this.lbl_incometext);
            this.pnl_kpiincome.Controls.Add(this.lbl_income);
            this.pnl_kpiincome.Location = new System.Drawing.Point(998, 122);
            this.pnl_kpiincome.Name = "pnl_kpiincome";
            this.pnl_kpiincome.Size = new System.Drawing.Size(190, 143);
            this.pnl_kpiincome.TabIndex = 43;
            this.pnl_kpiincome.Visible = false;
            // 
            // lbl_incometext
            // 
            this.lbl_incometext.AutoSize = true;
            this.lbl_incometext.BackColor = System.Drawing.Color.White;
            this.lbl_incometext.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_incometext.Location = new System.Drawing.Point(40, 88);
            this.lbl_incometext.Name = "lbl_incometext";
            this.lbl_incometext.Size = new System.Drawing.Size(110, 21);
            this.lbl_incometext.TabIndex = 38;
            this.lbl_incometext.Text = "Total Income";
            // 
            // lbl_income
            // 
            this.lbl_income.AutoSize = true;
            this.lbl_income.BackColor = System.Drawing.Color.White;
            this.lbl_income.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_income.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_income.Location = new System.Drawing.Point(55, 38);
            this.lbl_income.Name = "lbl_income";
            this.lbl_income.Size = new System.Drawing.Size(42, 31);
            this.lbl_income.TabIndex = 33;
            this.lbl_income.Text = "10";
            this.lbl_income.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_daterange
            // 
            this.pnl_daterange.BackColor = System.Drawing.Color.White;
            this.pnl_daterange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_daterange.Controls.Add(this.label3);
            this.pnl_daterange.Controls.Add(this.lbl_daterange);
            this.pnl_daterange.Location = new System.Drawing.Point(998, 281);
            this.pnl_daterange.Name = "pnl_daterange";
            this.pnl_daterange.Size = new System.Drawing.Size(190, 143);
            this.pnl_daterange.TabIndex = 44;
            this.pnl_daterange.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Days";
            // 
            // lbl_daterange
            // 
            this.lbl_daterange.AutoSize = true;
            this.lbl_daterange.BackColor = System.Drawing.Color.White;
            this.lbl_daterange.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_daterange.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_daterange.Location = new System.Drawing.Point(82, 36);
            this.lbl_daterange.Name = "lbl_daterange";
            this.lbl_daterange.Size = new System.Drawing.Size(28, 31);
            this.lbl_daterange.TabIndex = 28;
            this.lbl_daterange.Text = "2";
            this.lbl_daterange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_kpioccupancy
            // 
            this.pnl_kpioccupancy.BackColor = System.Drawing.Color.White;
            this.pnl_kpioccupancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_kpioccupancy.Controls.Add(this.label4);
            this.pnl_kpioccupancy.Controls.Add(this.lbl_occupancyrates);
            this.pnl_kpioccupancy.Location = new System.Drawing.Point(998, 440);
            this.pnl_kpioccupancy.Name = "pnl_kpioccupancy";
            this.pnl_kpioccupancy.Size = new System.Drawing.Size(190, 143);
            this.pnl_kpioccupancy.TabIndex = 45;
            this.pnl_kpioccupancy.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Occupancy Rate";
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
            // frm_SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1243, 681);
            this.Controls.Add(this.pnl_kpiincome);
            this.Controls.Add(this.pnl_daterange);
            this.Controls.Add(this.pnl_kpioccupancy);
            this.Controls.Add(this.lbl_checkOut);
            this.Controls.Add(this.lbl_checkIn);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_checkOut);
            this.Controls.Add(this.txt_checkIn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnl_Manager2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_SalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SalesReport";
            this.Load += new System.EventHandler(this.frm_SalesReport_Load);
            this.pnl_Manager2.ResumeLayout(false);
            this.pnl_Manager2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_kpiincome.ResumeLayout(false);
            this.pnl_kpiincome.PerformLayout();
            this.pnl_daterange.ResumeLayout(false);
            this.pnl_daterange.PerformLayout();
            this.pnl_kpioccupancy.ResumeLayout(false);
            this.pnl_kpioccupancy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Manager2;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Label lbl_Welcome_Msg;
        private System.Windows.Forms.Button btn_exitViewReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_checkOut;
        private System.Windows.Forms.Label lbl_checkIn;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_checkOut;
        private System.Windows.Forms.TextBox txt_checkIn;
        private System.Windows.Forms.Panel pnl_kpiincome;
        private System.Windows.Forms.Label lbl_incometext;
        private System.Windows.Forms.Label lbl_income;
        private System.Windows.Forms.Panel pnl_daterange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_daterange;
        private System.Windows.Forms.Panel pnl_kpioccupancy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_occupancyrates;
    }
}
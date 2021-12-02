
namespace BayViewBookings
{
    partial class frm_SplashScreen
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
            this.lbl_bayviewbookings = new System.Windows.Forms.Label();
            this.lbl_loading = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.pnl_loadingbar = new System.Windows.Forms.Panel();
            this.pnl_loading = new System.Windows.Forms.Panel();
            this.tmr_splash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_bayviewbookings
            // 
            this.lbl_bayviewbookings.AutoSize = true;
            this.lbl_bayviewbookings.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bayviewbookings.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bayviewbookings.ForeColor = System.Drawing.Color.Green;
            this.lbl_bayviewbookings.Location = new System.Drawing.Point(220, 160);
            this.lbl_bayviewbookings.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_bayviewbookings.Name = "lbl_bayviewbookings";
            this.lbl_bayviewbookings.Size = new System.Drawing.Size(730, 98);
            this.lbl_bayviewbookings.TabIndex = 1;
            this.lbl_bayviewbookings.Text = "BayView Bookings";
            // 
            // lbl_loading
            // 
            this.lbl_loading.AutoSize = true;
            this.lbl_loading.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loading.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_loading.Location = new System.Drawing.Point(494, 776);
            this.lbl_loading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_loading.Name = "lbl_loading";
            this.lbl_loading.Size = new System.Drawing.Size(209, 50);
            this.lbl_loading.TabIndex = 2;
            this.lbl_loading.Text = "Loading...";
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::BayViewBookings.Properties.Resources.bayviewlogo;
            this.pb_logo.Location = new System.Drawing.Point(238, 262);
            this.pb_logo.Margin = new System.Windows.Forms.Padding(6);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(710, 223);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 3;
            this.pb_logo.TabStop = false;
            // 
            // pnl_loadingbar
            // 
            this.pnl_loadingbar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_loadingbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_loadingbar.Location = new System.Drawing.Point(0, 850);
            this.pnl_loadingbar.Name = "pnl_loadingbar";
            this.pnl_loadingbar.Size = new System.Drawing.Size(1224, 50);
            this.pnl_loadingbar.TabIndex = 4;
            // 
            // pnl_loading
            // 
            this.pnl_loading.BackColor = System.Drawing.Color.Green;
            this.pnl_loading.Location = new System.Drawing.Point(0, 850);
            this.pnl_loading.Name = "pnl_loading";
            this.pnl_loading.Size = new System.Drawing.Size(34, 56);
            this.pnl_loading.TabIndex = 5;
            // 
            // tmr_splash
            // 
            this.tmr_splash.Enabled = true;
            this.tmr_splash.Interval = 1;
            this.tmr_splash.Tick += new System.EventHandler(this.tmr_splash_Tick);
            // 
            // frm_SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1224, 900);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_loading);
            this.Controls.Add(this.pnl_loadingbar);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.lbl_loading);
            this.Controls.Add(this.lbl_bayviewbookings);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BayView Bookings";
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_bayviewbookings;
        private System.Windows.Forms.Label lbl_loading;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Panel pnl_loadingbar;
        private System.Windows.Forms.Panel pnl_loading;
        private System.Windows.Forms.Timer tmr_splash;
    }
}
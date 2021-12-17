
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
            this.pnl_loadingbar = new System.Windows.Forms.Panel();
            this.pnl_loading = new System.Windows.Forms.Panel();
            this.tmr_splash = new System.Windows.Forms.Timer(this.components);
            this.lbl_loading = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.pnl_loadingbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_loadingbar
            // 
            this.pnl_loadingbar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_loadingbar.Controls.Add(this.pnl_loading);
            this.pnl_loadingbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_loadingbar.Location = new System.Drawing.Point(0, 505);
            this.pnl_loadingbar.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_loadingbar.Name = "pnl_loadingbar";
            this.pnl_loadingbar.Size = new System.Drawing.Size(823, 15);
            this.pnl_loadingbar.TabIndex = 4;
            // 
            // pnl_loading
            // 
            this.pnl_loading.BackColor = System.Drawing.Color.Green;
            this.pnl_loading.Location = new System.Drawing.Point(0, 0);
            this.pnl_loading.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_loading.Name = "pnl_loading";
            this.pnl_loading.Size = new System.Drawing.Size(16, 15);
            this.pnl_loading.TabIndex = 5;
            // 
            // tmr_splash
            // 
            this.tmr_splash.Enabled = true;
            this.tmr_splash.Interval = 1;
            this.tmr_splash.Tick += new System.EventHandler(this.tmr_splash_Tick);
            // 
            // lbl_loading
            // 
            this.lbl_loading.AutoSize = true;
            this.lbl_loading.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loading.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_loading.Location = new System.Drawing.Point(0, 487);
            this.lbl_loading.Name = "lbl_loading";
            this.lbl_loading.Size = new System.Drawing.Size(72, 16);
            this.lbl_loading.TabIndex = 2;
            this.lbl_loading.Text = "Loading...";
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.Image = global::BayViewBookings.Properties.Resources.bayviewlogo;
            this.pb_logo.Location = new System.Drawing.Point(131, 67);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(556, 200);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 8;
            this.pb_logo.TabStop = false;
            // 
            // frm_SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 520);
            this.ControlBox = false;
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.pnl_loadingbar);
            this.Controls.Add(this.lbl_loading);
            this.Name = "frm_SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BayView Bookings";
            this.Load += new System.EventHandler(this.frm_SplashScreen_Load);
            this.pnl_loadingbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_loadingbar;
        private System.Windows.Forms.Panel pnl_loading;
        private System.Windows.Forms.Timer tmr_splash;
        private System.Windows.Forms.Label lbl_loading;
        private System.Windows.Forms.PictureBox pb_logo;
    }
}

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
            this.prb_splashscreen = new System.Windows.Forms.ProgressBar();
            this.lbl_bayviewbookings = new System.Windows.Forms.Label();
            this.lbl_loading = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // prb_splashscreen
            // 
            this.prb_splashscreen.BackColor = System.Drawing.Color.Lime;
            this.prb_splashscreen.Location = new System.Drawing.Point(236, 579);
            this.prb_splashscreen.Name = "prb_splashscreen";
            this.prb_splashscreen.Size = new System.Drawing.Size(690, 10);
            this.prb_splashscreen.TabIndex = 0;
            this.prb_splashscreen.Value = 80;
            // 
            // lbl_bayviewbookings
            // 
            this.lbl_bayviewbookings.AutoSize = true;
            this.lbl_bayviewbookings.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bayviewbookings.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bayviewbookings.ForeColor = System.Drawing.Color.Green;
            this.lbl_bayviewbookings.Location = new System.Drawing.Point(379, 74);
            this.lbl_bayviewbookings.Name = "lbl_bayviewbookings";
            this.lbl_bayviewbookings.Size = new System.Drawing.Size(364, 50);
            this.lbl_bayviewbookings.TabIndex = 1;
            this.lbl_bayviewbookings.Text = "BayView Bookings";
            // 
            // lbl_loading
            // 
            this.lbl_loading.AutoSize = true;
            this.lbl_loading.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loading.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_loading.Location = new System.Drawing.Point(241, 550);
            this.lbl_loading.Name = "lbl_loading";
            this.lbl_loading.Size = new System.Drawing.Size(104, 26);
            this.lbl_loading.TabIndex = 2;
            this.lbl_loading.Text = "Loading...";
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::BayViewBookings.Properties.Resources.bayviewlogo;
            this.pb_logo.Location = new System.Drawing.Point(388, 127);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(355, 116);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 3;
            this.pb_logo.TabStop = false;
            // 
            // frm_SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 601);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.lbl_loading);
            this.Controls.Add(this.lbl_bayviewbookings);
            this.Controls.Add(this.prb_splashscreen);
            this.Name = "frm_SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BayView Bookings";
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prb_splashscreen;
        private System.Windows.Forms.Label lbl_bayviewbookings;
        private System.Windows.Forms.Label lbl_loading;
        private System.Windows.Forms.PictureBox pb_logo;
    }
}
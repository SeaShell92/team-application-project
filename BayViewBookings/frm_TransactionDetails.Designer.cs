
namespace BayViewBookings
{
    partial class frm_TransactionDetails
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
            this.pnl_filters = new System.Windows.Forms.Panel();
            this.btn_NewTransact = new System.Windows.Forms.Button();
            this.btn_filter3 = new System.Windows.Forms.Button();
            this.txt_filter3 = new System.Windows.Forms.TextBox();
            this.btn_filter2 = new System.Windows.Forms.Button();
            this.txt_filter2 = new System.Windows.Forms.TextBox();
            this.btn_filter1 = new System.Windows.Forms.Button();
            this.txt_filter1 = new System.Windows.Forms.TextBox();
            this.pnl_transactions = new System.Windows.Forms.Panel();
            this.btn_TransactExit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pnl_transactionsHeader = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_Rooms = new System.Windows.Forms.Button();
            this.btn_Bookings = new System.Windows.Forms.Button();
            this.btn_Guests = new System.Windows.Forms.Button();
            this.lbl_Transactions = new System.Windows.Forms.Label();
            this.pnl_Transaction = new System.Windows.Forms.Panel();
            this.lbl_PaymentMethod = new System.Windows.Forms.Label();
            this.txt_PaymentMethod = new System.Windows.Forms.TextBox();
            this.txt_PaymentDate = new System.Windows.Forms.TextBox();
            this.lbl_Transactions_Details = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.lbl_AmountPaid = new System.Windows.Forms.Label();
            this.lbl_AmountDue = new System.Windows.Forms.Label();
            this.lbl_Payment_Date = new System.Windows.Forms.Label();
            this.lbl_BookingID = new System.Windows.Forms.Label();
            this.lbl_EmployeeID = new System.Windows.Forms.Label();
            this.lbl_TransactionID = new System.Windows.Forms.Label();
            this.txt_AmountPaid = new System.Windows.Forms.TextBox();
            this.txt_AmountDue = new System.Windows.Forms.TextBox();
            this.txt_BookingID = new System.Windows.Forms.TextBox();
            this.txt_EmployeeID = new System.Windows.Forms.TextBox();
            this.txt_TransactionID = new System.Windows.Forms.TextBox();
            this.dgv_TransDet = new System.Windows.Forms.DataGridView();
            this.pnl_filters.SuspendLayout();
            this.pnl_transactions.SuspendLayout();
            this.pnl_transactionsHeader.SuspendLayout();
            this.pnl_Transaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransDet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_filters
            // 
            this.pnl_filters.Controls.Add(this.btn_NewTransact);
            this.pnl_filters.Controls.Add(this.btn_filter3);
            this.pnl_filters.Controls.Add(this.txt_filter3);
            this.pnl_filters.Controls.Add(this.btn_filter2);
            this.pnl_filters.Controls.Add(this.txt_filter2);
            this.pnl_filters.Controls.Add(this.btn_filter1);
            this.pnl_filters.Controls.Add(this.txt_filter1);
            this.pnl_filters.Location = new System.Drawing.Point(1037, 67);
            this.pnl_filters.Name = "pnl_filters";
            this.pnl_filters.Size = new System.Drawing.Size(191, 469);
            this.pnl_filters.TabIndex = 12;
            // 
            // btn_NewTransact
            // 
            this.btn_NewTransact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_NewTransact.Location = new System.Drawing.Point(47, 414);
            this.btn_NewTransact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_NewTransact.Name = "btn_NewTransact";
            this.btn_NewTransact.Size = new System.Drawing.Size(105, 32);
            this.btn_NewTransact.TabIndex = 7;
            this.btn_NewTransact.Text = "New Transaction";
            this.btn_NewTransact.UseVisualStyleBackColor = true;
            this.btn_NewTransact.Click += new System.EventHandler(this.btn_NewTransact_Click);
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
            // pnl_transactions
            // 
            this.pnl_transactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_transactions.Controls.Add(this.btn_TransactExit);
            this.pnl_transactions.Controls.Add(this.button5);
            this.pnl_transactions.Location = new System.Drawing.Point(-4, 46);
            this.pnl_transactions.Name = "pnl_transactions";
            this.pnl_transactions.Size = new System.Drawing.Size(154, 640);
            this.pnl_transactions.TabIndex = 12;
            // 
            // btn_TransactExit
            // 
            this.btn_TransactExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TransactExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TransactExit.ForeColor = System.Drawing.Color.White;
            this.btn_TransactExit.Location = new System.Drawing.Point(0, 536);
            this.btn_TransactExit.Name = "btn_TransactExit";
            this.btn_TransactExit.Size = new System.Drawing.Size(157, 101);
            this.btn_TransactExit.TabIndex = 7;
            this.btn_TransactExit.Text = "Exit";
            this.btn_TransactExit.UseVisualStyleBackColor = true;
            this.btn_TransactExit.Click += new System.EventHandler(this.btn_TransactExit_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(3, 429);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 101);
            this.button5.TabIndex = 6;
            this.button5.Text = "button";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pnl_transactionsHeader
            // 
            this.pnl_transactionsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_transactionsHeader.Controls.Add(this.btn_exit);
            this.pnl_transactionsHeader.Controls.Add(this.btn_Rooms);
            this.pnl_transactionsHeader.Controls.Add(this.btn_Bookings);
            this.pnl_transactionsHeader.Controls.Add(this.btn_Guests);
            this.pnl_transactionsHeader.Controls.Add(this.lbl_Transactions);
            this.pnl_transactionsHeader.ForeColor = System.Drawing.Color.White;
            this.pnl_transactionsHeader.Location = new System.Drawing.Point(0, 0);
            this.pnl_transactionsHeader.Name = "pnl_transactionsHeader";
            this.pnl_transactionsHeader.Size = new System.Drawing.Size(1242, 48);
            this.pnl_transactionsHeader.TabIndex = 8;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(1191, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(33, 28);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "x";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
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
            // lbl_Transactions
            // 
            this.lbl_Transactions.AutoSize = true;
            this.lbl_Transactions.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Transactions.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Transactions.ForeColor = System.Drawing.Color.White;
            this.lbl_Transactions.Location = new System.Drawing.Point(812, 9);
            this.lbl_Transactions.Name = "lbl_Transactions";
            this.lbl_Transactions.Size = new System.Drawing.Size(134, 30);
            this.lbl_Transactions.TabIndex = 0;
            this.lbl_Transactions.Text = "Transactions";
            // 
            // pnl_Transaction
            // 
            this.pnl_Transaction.Controls.Add(this.lbl_PaymentMethod);
            this.pnl_Transaction.Controls.Add(this.txt_PaymentMethod);
            this.pnl_Transaction.Controls.Add(this.txt_PaymentDate);
            this.pnl_Transaction.Controls.Add(this.lbl_Transactions_Details);
            this.pnl_Transaction.Controls.Add(this.btn_Cancel);
            this.pnl_Transaction.Controls.Add(this.btn_Enter);
            this.pnl_Transaction.Controls.Add(this.lbl_AmountPaid);
            this.pnl_Transaction.Controls.Add(this.lbl_AmountDue);
            this.pnl_Transaction.Controls.Add(this.lbl_Payment_Date);
            this.pnl_Transaction.Controls.Add(this.lbl_BookingID);
            this.pnl_Transaction.Controls.Add(this.lbl_EmployeeID);
            this.pnl_Transaction.Controls.Add(this.lbl_TransactionID);
            this.pnl_Transaction.Controls.Add(this.txt_AmountPaid);
            this.pnl_Transaction.Controls.Add(this.txt_AmountDue);
            this.pnl_Transaction.Controls.Add(this.txt_BookingID);
            this.pnl_Transaction.Controls.Add(this.txt_EmployeeID);
            this.pnl_Transaction.Controls.Add(this.txt_TransactionID);
            this.pnl_Transaction.Location = new System.Drawing.Point(470, 79);
            this.pnl_Transaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Transaction.Name = "pnl_Transaction";
            this.pnl_Transaction.Size = new System.Drawing.Size(297, 574);
            this.pnl_Transaction.TabIndex = 13;
            this.pnl_Transaction.Visible = false;
            // 
            // lbl_PaymentMethod
            // 
            this.lbl_PaymentMethod.AutoSize = true;
            this.lbl_PaymentMethod.Location = new System.Drawing.Point(49, 402);
            this.lbl_PaymentMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_PaymentMethod.Name = "lbl_PaymentMethod";
            this.lbl_PaymentMethod.Size = new System.Drawing.Size(87, 13);
            this.lbl_PaymentMethod.TabIndex = 33;
            this.lbl_PaymentMethod.Text = "Payment Method";
            // 
            // txt_PaymentMethod
            // 
            this.txt_PaymentMethod.Location = new System.Drawing.Point(46, 425);
            this.txt_PaymentMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_PaymentMethod.Name = "txt_PaymentMethod";
            this.txt_PaymentMethod.Size = new System.Drawing.Size(193, 20);
            this.txt_PaymentMethod.TabIndex = 25;
            // 
            // txt_PaymentDate
            // 
            this.txt_PaymentDate.Location = new System.Drawing.Point(46, 264);
            this.txt_PaymentDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_PaymentDate.Name = "txt_PaymentDate";
            this.txt_PaymentDate.Size = new System.Drawing.Size(193, 20);
            this.txt_PaymentDate.TabIndex = 25;
            // 
            // lbl_Transactions_Details
            // 
            this.lbl_Transactions_Details.AutoSize = true;
            this.lbl_Transactions_Details.Location = new System.Drawing.Point(114, 17);
            this.lbl_Transactions_Details.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Transactions_Details.Name = "lbl_Transactions_Details";
            this.lbl_Transactions_Details.Size = new System.Drawing.Size(88, 13);
            this.lbl_Transactions_Details.TabIndex = 35;
            this.lbl_Transactions_Details.Text = "New Transaction";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(167, 486);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(72, 53);
            this.btn_Cancel.TabIndex = 34;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(46, 486);
            this.btn_Enter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(72, 53);
            this.btn_Enter.TabIndex = 33;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = true;
            // 
            // lbl_AmountPaid
            // 
            this.lbl_AmountPaid.AutoSize = true;
            this.lbl_AmountPaid.Location = new System.Drawing.Point(44, 348);
            this.lbl_AmountPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AmountPaid.Name = "lbl_AmountPaid";
            this.lbl_AmountPaid.Size = new System.Drawing.Size(67, 13);
            this.lbl_AmountPaid.TabIndex = 32;
            this.lbl_AmountPaid.Text = "Amount Paid";
            // 
            // lbl_AmountDue
            // 
            this.lbl_AmountDue.AutoSize = true;
            this.lbl_AmountDue.Location = new System.Drawing.Point(44, 294);
            this.lbl_AmountDue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AmountDue.Name = "lbl_AmountDue";
            this.lbl_AmountDue.Size = new System.Drawing.Size(66, 13);
            this.lbl_AmountDue.TabIndex = 30;
            this.lbl_AmountDue.Text = "Amount Due";
            // 
            // lbl_Payment_Date
            // 
            this.lbl_Payment_Date.AutoSize = true;
            this.lbl_Payment_Date.Location = new System.Drawing.Point(44, 240);
            this.lbl_Payment_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Payment_Date.Name = "lbl_Payment_Date";
            this.lbl_Payment_Date.Size = new System.Drawing.Size(72, 13);
            this.lbl_Payment_Date.TabIndex = 31;
            this.lbl_Payment_Date.Text = "Payment date";
            // 
            // lbl_BookingID
            // 
            this.lbl_BookingID.AutoSize = true;
            this.lbl_BookingID.Location = new System.Drawing.Point(44, 182);
            this.lbl_BookingID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BookingID.Name = "lbl_BookingID";
            this.lbl_BookingID.Size = new System.Drawing.Size(60, 13);
            this.lbl_BookingID.TabIndex = 29;
            this.lbl_BookingID.Text = "Booking ID";
            // 
            // lbl_EmployeeID
            // 
            this.lbl_EmployeeID.AutoSize = true;
            this.lbl_EmployeeID.Location = new System.Drawing.Point(44, 126);
            this.lbl_EmployeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_EmployeeID.Name = "lbl_EmployeeID";
            this.lbl_EmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lbl_EmployeeID.TabIndex = 28;
            this.lbl_EmployeeID.Text = "Employee ID";
            // 
            // lbl_TransactionID
            // 
            this.lbl_TransactionID.AutoSize = true;
            this.lbl_TransactionID.Location = new System.Drawing.Point(44, 78);
            this.lbl_TransactionID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TransactionID.Name = "lbl_TransactionID";
            this.lbl_TransactionID.Size = new System.Drawing.Size(77, 13);
            this.lbl_TransactionID.TabIndex = 27;
            this.lbl_TransactionID.Text = "Transaction ID";
            // 
            // txt_AmountPaid
            // 
            this.txt_AmountPaid.Location = new System.Drawing.Point(46, 364);
            this.txt_AmountPaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_AmountPaid.Name = "txt_AmountPaid";
            this.txt_AmountPaid.Size = new System.Drawing.Size(193, 20);
            this.txt_AmountPaid.TabIndex = 26;
            // 
            // txt_AmountDue
            // 
            this.txt_AmountDue.Location = new System.Drawing.Point(46, 313);
            this.txt_AmountDue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_AmountDue.Name = "txt_AmountDue";
            this.txt_AmountDue.Size = new System.Drawing.Size(193, 20);
            this.txt_AmountDue.TabIndex = 24;
            // 
            // txt_BookingID
            // 
            this.txt_BookingID.Location = new System.Drawing.Point(46, 202);
            this.txt_BookingID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_BookingID.Name = "txt_BookingID";
            this.txt_BookingID.Size = new System.Drawing.Size(87, 20);
            this.txt_BookingID.TabIndex = 23;
            // 
            // txt_EmployeeID
            // 
            this.txt_EmployeeID.Location = new System.Drawing.Point(46, 146);
            this.txt_EmployeeID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_EmployeeID.Name = "txt_EmployeeID";
            this.txt_EmployeeID.Size = new System.Drawing.Size(87, 20);
            this.txt_EmployeeID.TabIndex = 22;
            // 
            // txt_TransactionID
            // 
            this.txt_TransactionID.Location = new System.Drawing.Point(46, 97);
            this.txt_TransactionID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TransactionID.Name = "txt_TransactionID";
            this.txt_TransactionID.Size = new System.Drawing.Size(87, 20);
            this.txt_TransactionID.TabIndex = 21;
            // 
            // dgv_TransDet
            // 
            this.dgv_TransDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TransDet.Location = new System.Drawing.Point(164, 71);
            this.dgv_TransDet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_TransDet.Name = "dgv_TransDet";
            this.dgv_TransDet.RowHeadersWidth = 51;
            this.dgv_TransDet.RowTemplate.Height = 24;
            this.dgv_TransDet.Size = new System.Drawing.Size(860, 380);
            this.dgv_TransDet.TabIndex = 14;
            // 
            // frm_TransactionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 677);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Transaction);
            this.Controls.Add(this.pnl_transactionsHeader);
            this.Controls.Add(this.pnl_transactions);
            this.Controls.Add(this.pnl_filters);
            this.Controls.Add(this.dgv_TransDet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_TransactionDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Details";
            this.pnl_filters.ResumeLayout(false);
            this.pnl_filters.PerformLayout();
            this.pnl_transactions.ResumeLayout(false);
            this.pnl_transactionsHeader.ResumeLayout(false);
            this.pnl_transactionsHeader.PerformLayout();
            this.pnl_Transaction.ResumeLayout(false);
            this.pnl_Transaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransDet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_filters;
        private System.Windows.Forms.Button btn_filter3;
        private System.Windows.Forms.TextBox txt_filter3;
        private System.Windows.Forms.Button btn_filter2;
        private System.Windows.Forms.TextBox txt_filter2;
        private System.Windows.Forms.Button btn_filter1;
        private System.Windows.Forms.TextBox txt_filter1;
        private System.Windows.Forms.Panel pnl_transactions;
        private System.Windows.Forms.Button btn_TransactExit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnl_transactionsHeader;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_Rooms;
        private System.Windows.Forms.Button btn_Bookings;
        private System.Windows.Forms.Button btn_Guests;
        private System.Windows.Forms.Label lbl_Transactions;
        private System.Windows.Forms.Panel pnl_Transaction;
        private System.Windows.Forms.Label lbl_Transactions_Details;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Label lbl_AmountPaid;
        private System.Windows.Forms.Label lbl_AmountDue;
        private System.Windows.Forms.Label lbl_Payment_Date;
        private System.Windows.Forms.Label lbl_BookingID;
        private System.Windows.Forms.Label lbl_EmployeeID;
        private System.Windows.Forms.Label lbl_TransactionID;
        private System.Windows.Forms.TextBox txt_AmountPaid;
        private System.Windows.Forms.TextBox txt_AmountDue;
        private System.Windows.Forms.TextBox txt_BookingID;
        private System.Windows.Forms.TextBox txt_EmployeeID;
        private System.Windows.Forms.TextBox txt_TransactionID;
        private System.Windows.Forms.Label lbl_PaymentMethod;
        private System.Windows.Forms.TextBox txt_PaymentMethod;
        private System.Windows.Forms.TextBox txt_PaymentDate;
        private System.Windows.Forms.Button btn_NewTransact;
        private System.Windows.Forms.DataGridView dgv_TransDet;
    }
}
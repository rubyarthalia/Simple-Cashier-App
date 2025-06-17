namespace ALP
{
    partial class FormPayment
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
            this.lbl_applypromo = new System.Windows.Forms.Label();
            this.dgv_pesanan = new System.Windows.Forms.DataGridView();
            this.lb_staffID = new System.Windows.Forms.Label();
            this.lb_tableNo = new System.Windows.Forms.Label();
            this.lb_daftarP = new System.Windows.Forms.Label();
            this.lb_noTable = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtb_amount = new System.Windows.Forms.RichTextBox();
            this.btn_backspace = new System.Windows.Forms.Button();
            this.btn_zeroo = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_one = new System.Windows.Forms.Button();
            this.cb_promo = new System.Windows.Forms.ComboBox();
            this.btn_cash = new System.Windows.Forms.Button();
            this.btn_credit = new System.Windows.Forms.Button();
            this.btn_debit = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.lbl_totalqty = new System.Windows.Forms.Label();
            this.lbl_promo = new System.Windows.Forms.Label();
            this.lbl_ppn = new System.Windows.Forms.Label();
            this.lbl_service = new System.Windows.Forms.Label();
            this.lbl_totalprice = new System.Windows.Forms.Label();
            this.tb_totalqty = new System.Windows.Forms.TextBox();
            this.tb_diskon = new System.Windows.Forms.TextBox();
            this.tb_ppn = new System.Windows.Forms.TextBox();
            this.tb_service = new System.Windows.Forms.TextBox();
            this.tb_totalprice = new System.Windows.Forms.TextBox();
            this.btn_pay = new System.Windows.Forms.Button();
            this.timer_kasir = new System.Windows.Forms.Timer(this.components);
            this.stat_date = new System.Windows.Forms.StatusStrip();
            this.dateStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tb_subtotal = new System.Windows.Forms.TextBox();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.tb_pay = new System.Windows.Forms.TextBox();
            this.lbl_pay = new System.Windows.Forms.Label();
            this.tb_paymentmethod = new System.Windows.Forms.TextBox();
            this.lbl_paymentmethod = new System.Windows.Forms.Label();
            this.tb_kodepromo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesanan)).BeginInit();
            this.panel1.SuspendLayout();
            this.stat_date.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_applypromo
            // 
            this.lbl_applypromo.AutoSize = true;
            this.lbl_applypromo.Location = new System.Drawing.Point(40, 578);
            this.lbl_applypromo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_applypromo.Name = "lbl_applypromo";
            this.lbl_applypromo.Size = new System.Drawing.Size(63, 20);
            this.lbl_applypromo.TabIndex = 0;
            this.lbl_applypromo.Text = "Promo :";
            // 
            // dgv_pesanan
            // 
            this.dgv_pesanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pesanan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_pesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pesanan.Location = new System.Drawing.Point(476, 138);
            this.dgv_pesanan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_pesanan.Name = "dgv_pesanan";
            this.dgv_pesanan.ReadOnly = true;
            this.dgv_pesanan.RowHeadersVisible = false;
            this.dgv_pesanan.RowHeadersWidth = 62;
            this.dgv_pesanan.RowTemplate.Height = 28;
            this.dgv_pesanan.Size = new System.Drawing.Size(488, 340);
            this.dgv_pesanan.TabIndex = 1;
            // 
            // lb_staffID
            // 
            this.lb_staffID.AutoSize = true;
            this.lb_staffID.Location = new System.Drawing.Point(767, 33);
            this.lb_staffID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_staffID.Name = "lb_staffID";
            this.lb_staffID.Size = new System.Drawing.Size(14, 20);
            this.lb_staffID.TabIndex = 61;
            this.lb_staffID.Text = "-";
            // 
            // lb_tableNo
            // 
            this.lb_tableNo.AutoSize = true;
            this.lb_tableNo.Location = new System.Drawing.Point(808, 70);
            this.lb_tableNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tableNo.Name = "lb_tableNo";
            this.lb_tableNo.Size = new System.Drawing.Size(14, 20);
            this.lb_tableNo.TabIndex = 60;
            this.lb_tableNo.Text = "-";
            // 
            // lb_daftarP
            // 
            this.lb_daftarP.AutoSize = true;
            this.lb_daftarP.Location = new System.Drawing.Point(472, 102);
            this.lb_daftarP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_daftarP.Name = "lb_daftarP";
            this.lb_daftarP.Size = new System.Drawing.Size(125, 20);
            this.lb_daftarP.TabIndex = 59;
            this.lb_daftarP.Text = "Daftar Pesanan:";
            // 
            // lb_noTable
            // 
            this.lb_noTable.AutoSize = true;
            this.lb_noTable.Location = new System.Drawing.Point(698, 69);
            this.lb_noTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_noTable.Name = "lb_noTable";
            this.lb_noTable.Size = new System.Drawing.Size(112, 20);
            this.lb_noTable.TabIndex = 58;
            this.lb_noTable.Text = "Table Number:";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(698, 33);
            this.lb_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(69, 20);
            this.lb_ID.TabIndex = 57;
            this.lb_ID.Text = "Staff ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.rtb_amount);
            this.panel1.Controls.Add(this.btn_backspace);
            this.panel1.Controls.Add(this.btn_zeroo);
            this.panel1.Controls.Add(this.btn_zero);
            this.panel1.Controls.Add(this.btn_nine);
            this.panel1.Controls.Add(this.btn_eight);
            this.panel1.Controls.Add(this.btn_seven);
            this.panel1.Controls.Add(this.btn_six);
            this.panel1.Controls.Add(this.btn_five);
            this.panel1.Controls.Add(this.btn_four);
            this.panel1.Controls.Add(this.btn_three);
            this.panel1.Controls.Add(this.btn_two);
            this.panel1.Controls.Add(this.btn_one);
            this.panel1.Location = new System.Drawing.Point(45, 138);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 340);
            this.panel1.TabIndex = 62;
            // 
            // rtb_amount
            // 
            this.rtb_amount.Enabled = false;
            this.rtb_amount.Location = new System.Drawing.Point(25, 25);
            this.rtb_amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtb_amount.Name = "rtb_amount";
            this.rtb_amount.Size = new System.Drawing.Size(330, 33);
            this.rtb_amount.TabIndex = 76;
            this.rtb_amount.Text = "";
            // 
            // btn_backspace
            // 
            this.btn_backspace.Enabled = false;
            this.btn_backspace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backspace.Location = new System.Drawing.Point(266, 276);
            this.btn_backspace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_backspace.Name = "btn_backspace";
            this.btn_backspace.Size = new System.Drawing.Size(90, 45);
            this.btn_backspace.TabIndex = 74;
            this.btn_backspace.Text = "Delete";
            this.btn_backspace.UseVisualStyleBackColor = true;
            this.btn_backspace.Click += new System.EventHandler(this.btn_backspace_Click);
            // 
            // btn_zeroo
            // 
            this.btn_zeroo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_zeroo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_zeroo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zeroo.Location = new System.Drawing.Point(146, 276);
            this.btn_zeroo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_zeroo.Name = "btn_zeroo";
            this.btn_zeroo.Size = new System.Drawing.Size(90, 45);
            this.btn_zeroo.TabIndex = 73;
            this.btn_zeroo.Text = "000";
            this.btn_zeroo.UseVisualStyleBackColor = false;
            this.btn_zeroo.Click += new System.EventHandler(this.btn_zeroo_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_zero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zero.Location = new System.Drawing.Point(25, 276);
            this.btn_zero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(90, 45);
            this.btn_zero.TabIndex = 72;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = false;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // btn_nine
            // 
            this.btn_nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(128)))));
            this.btn_nine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nine.Location = new System.Drawing.Point(266, 213);
            this.btn_nine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(90, 45);
            this.btn_nine.TabIndex = 71;
            this.btn_nine.Text = "9";
            this.btn_nine.UseVisualStyleBackColor = false;
            this.btn_nine.Click += new System.EventHandler(this.btn_nine_Click);
            // 
            // btn_eight
            // 
            this.btn_eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_eight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eight.Location = new System.Drawing.Point(146, 213);
            this.btn_eight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(90, 45);
            this.btn_eight.TabIndex = 70;
            this.btn_eight.Text = "8";
            this.btn_eight.UseVisualStyleBackColor = false;
            this.btn_eight.Click += new System.EventHandler(this.btn_eight_Click);
            // 
            // btn_seven
            // 
            this.btn_seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_seven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seven.Location = new System.Drawing.Point(25, 213);
            this.btn_seven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(90, 45);
            this.btn_seven.TabIndex = 69;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = false;
            this.btn_seven.Click += new System.EventHandler(this.btn_seven_Click);
            // 
            // btn_six
            // 
            this.btn_six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_six.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_six.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_six.Location = new System.Drawing.Point(266, 150);
            this.btn_six.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(90, 45);
            this.btn_six.TabIndex = 68;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = false;
            this.btn_six.Click += new System.EventHandler(this.btn_six_Click);
            // 
            // btn_five
            // 
            this.btn_five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_five.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_five.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_five.Location = new System.Drawing.Point(146, 150);
            this.btn_five.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(90, 45);
            this.btn_five.TabIndex = 67;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = false;
            this.btn_five.Click += new System.EventHandler(this.btn_five_Click);
            // 
            // btn_four
            // 
            this.btn_four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_four.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_four.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_four.Location = new System.Drawing.Point(25, 150);
            this.btn_four.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(90, 45);
            this.btn_four.TabIndex = 66;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = false;
            this.btn_four.Click += new System.EventHandler(this.btn_four_Click);
            // 
            // btn_three
            // 
            this.btn_three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_three.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_three.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_three.Location = new System.Drawing.Point(266, 87);
            this.btn_three.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(90, 45);
            this.btn_three.TabIndex = 65;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = false;
            this.btn_three.Click += new System.EventHandler(this.btn_three_Click);
            // 
            // btn_two
            // 
            this.btn_two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_two.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_two.Location = new System.Drawing.Point(146, 87);
            this.btn_two.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(90, 45);
            this.btn_two.TabIndex = 64;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = false;
            this.btn_two.Click += new System.EventHandler(this.btn_two_Click);
            // 
            // btn_one
            // 
            this.btn_one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_one.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_one.Location = new System.Drawing.Point(25, 87);
            this.btn_one.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(90, 45);
            this.btn_one.TabIndex = 63;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = false;
            this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            // 
            // cb_promo
            // 
            this.cb_promo.FormattingEnabled = true;
            this.cb_promo.Location = new System.Drawing.Point(184, 576);
            this.cb_promo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_promo.Name = "cb_promo";
            this.cb_promo.Size = new System.Drawing.Size(180, 28);
            this.cb_promo.TabIndex = 63;
            this.cb_promo.SelectionChangeCommitted += new System.EventHandler(this.cb_promo_SelectionChangeCommitted);
            // 
            // btn_cash
            // 
            this.btn_cash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cash.Location = new System.Drawing.Point(45, 55);
            this.btn_cash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cash.Name = "btn_cash";
            this.btn_cash.Size = new System.Drawing.Size(100, 50);
            this.btn_cash.TabIndex = 64;
            this.btn_cash.Text = "CASH";
            this.btn_cash.UseVisualStyleBackColor = true;
            this.btn_cash.Click += new System.EventHandler(this.btn_cash_Click);
            // 
            // btn_credit
            // 
            this.btn_credit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_credit.Location = new System.Drawing.Point(184, 55);
            this.btn_credit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_credit.Name = "btn_credit";
            this.btn_credit.Size = new System.Drawing.Size(100, 50);
            this.btn_credit.TabIndex = 65;
            this.btn_credit.Text = "CREDIT";
            this.btn_credit.UseVisualStyleBackColor = true;
            this.btn_credit.Click += new System.EventHandler(this.btn_credit_Click);
            // 
            // btn_debit
            // 
            this.btn_debit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_debit.Location = new System.Drawing.Point(326, 55);
            this.btn_debit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_debit.Name = "btn_debit";
            this.btn_debit.Size = new System.Drawing.Size(100, 50);
            this.btn_debit.TabIndex = 66;
            this.btn_debit.Text = "DEBIT";
            this.btn_debit.UseVisualStyleBackColor = true;
            this.btn_debit.Click += new System.EventHandler(this.btn_debit_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Enabled = false;
            this.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_apply.Location = new System.Drawing.Point(184, 618);
            this.btn_apply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(112, 33);
            this.btn_apply.TabIndex = 67;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // lbl_totalqty
            // 
            this.lbl_totalqty.AutoSize = true;
            this.lbl_totalqty.Location = new System.Drawing.Point(474, 498);
            this.lbl_totalqty.Name = "lbl_totalqty";
            this.lbl_totalqty.Size = new System.Drawing.Size(115, 20);
            this.lbl_totalqty.TabIndex = 68;
            this.lbl_totalqty.Text = "Total Quantity :";
            // 
            // lbl_promo
            // 
            this.lbl_promo.AutoSize = true;
            this.lbl_promo.Location = new System.Drawing.Point(474, 578);
            this.lbl_promo.Name = "lbl_promo";
            this.lbl_promo.Size = new System.Drawing.Size(66, 20);
            this.lbl_promo.TabIndex = 69;
            this.lbl_promo.Text = "Diskon :";
            // 
            // lbl_ppn
            // 
            this.lbl_ppn.AutoSize = true;
            this.lbl_ppn.Location = new System.Drawing.Point(472, 618);
            this.lbl_ppn.Name = "lbl_ppn";
            this.lbl_ppn.Size = new System.Drawing.Size(94, 20);
            this.lbl_ppn.TabIndex = 70;
            this.lbl_ppn.Text = "PPN (10%) :";
            // 
            // lbl_service
            // 
            this.lbl_service.AutoSize = true;
            this.lbl_service.Location = new System.Drawing.Point(472, 658);
            this.lbl_service.Name = "lbl_service";
            this.lbl_service.Size = new System.Drawing.Size(162, 20);
            this.lbl_service.TabIndex = 71;
            this.lbl_service.Text = "Service Charge (5%) :";
            // 
            // lbl_totalprice
            // 
            this.lbl_totalprice.AutoSize = true;
            this.lbl_totalprice.Location = new System.Drawing.Point(472, 698);
            this.lbl_totalprice.Name = "lbl_totalprice";
            this.lbl_totalprice.Size = new System.Drawing.Size(87, 20);
            this.lbl_totalprice.TabIndex = 72;
            this.lbl_totalprice.Text = "Total Price:";
            // 
            // tb_totalqty
            // 
            this.tb_totalqty.Enabled = false;
            this.tb_totalqty.Location = new System.Drawing.Point(654, 496);
            this.tb_totalqty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_totalqty.Name = "tb_totalqty";
            this.tb_totalqty.Size = new System.Drawing.Size(184, 26);
            this.tb_totalqty.TabIndex = 73;
            // 
            // tb_diskon
            // 
            this.tb_diskon.Enabled = false;
            this.tb_diskon.Location = new System.Drawing.Point(654, 576);
            this.tb_diskon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_diskon.Name = "tb_diskon";
            this.tb_diskon.Size = new System.Drawing.Size(184, 26);
            this.tb_diskon.TabIndex = 74;
            // 
            // tb_ppn
            // 
            this.tb_ppn.Enabled = false;
            this.tb_ppn.Location = new System.Drawing.Point(654, 616);
            this.tb_ppn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ppn.Name = "tb_ppn";
            this.tb_ppn.Size = new System.Drawing.Size(184, 26);
            this.tb_ppn.TabIndex = 75;
            // 
            // tb_service
            // 
            this.tb_service.Enabled = false;
            this.tb_service.Location = new System.Drawing.Point(654, 656);
            this.tb_service.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_service.Name = "tb_service";
            this.tb_service.Size = new System.Drawing.Size(184, 26);
            this.tb_service.TabIndex = 76;
            // 
            // tb_totalprice
            // 
            this.tb_totalprice.Enabled = false;
            this.tb_totalprice.Location = new System.Drawing.Point(654, 696);
            this.tb_totalprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_totalprice.Name = "tb_totalprice";
            this.tb_totalprice.Size = new System.Drawing.Size(184, 26);
            this.tb_totalprice.TabIndex = 77;
            // 
            // btn_pay
            // 
            this.btn_pay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pay.Location = new System.Drawing.Point(654, 776);
            this.btn_pay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(112, 33);
            this.btn_pay.TabIndex = 78;
            this.btn_pay.Text = "Pay";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // timer_kasir
            // 
            this.timer_kasir.Enabled = true;
            this.timer_kasir.Interval = 1000;
            this.timer_kasir.Tick += new System.EventHandler(this.timer_kasir_Tick);
            // 
            // stat_date
            // 
            this.stat_date.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.stat_date.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateStatus});
            this.stat_date.Location = new System.Drawing.Point(0, 809);
            this.stat_date.Name = "stat_date";
            this.stat_date.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.stat_date.Size = new System.Drawing.Size(1016, 32);
            this.stat_date.TabIndex = 79;
            this.stat_date.Text = "stat_date";
            // 
            // dateStatus
            // 
            this.dateStatus.Name = "dateStatus";
            this.dateStatus.Size = new System.Drawing.Size(179, 25);
            this.dateStatus.Text = "toolStripStatusLabel1";
            // 
            // tb_subtotal
            // 
            this.tb_subtotal.Enabled = false;
            this.tb_subtotal.Location = new System.Drawing.Point(654, 536);
            this.tb_subtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_subtotal.Name = "tb_subtotal";
            this.tb_subtotal.Size = new System.Drawing.Size(184, 26);
            this.tb_subtotal.TabIndex = 81;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Location = new System.Drawing.Point(474, 538);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(77, 20);
            this.lbl_subtotal.TabIndex = 80;
            this.lbl_subtotal.Text = "Subtotal :";
            // 
            // tb_pay
            // 
            this.tb_pay.Enabled = false;
            this.tb_pay.Location = new System.Drawing.Point(654, 736);
            this.tb_pay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pay.Name = "tb_pay";
            this.tb_pay.Size = new System.Drawing.Size(184, 26);
            this.tb_pay.TabIndex = 83;
            // 
            // lbl_pay
            // 
            this.lbl_pay.AutoSize = true;
            this.lbl_pay.Location = new System.Drawing.Point(472, 738);
            this.lbl_pay.Name = "lbl_pay";
            this.lbl_pay.Size = new System.Drawing.Size(43, 20);
            this.lbl_pay.TabIndex = 82;
            this.lbl_pay.Text = "Pay :";
            // 
            // tb_paymentmethod
            // 
            this.tb_paymentmethod.Enabled = false;
            this.tb_paymentmethod.Location = new System.Drawing.Point(184, 533);
            this.tb_paymentmethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_paymentmethod.Name = "tb_paymentmethod";
            this.tb_paymentmethod.Size = new System.Drawing.Size(180, 26);
            this.tb_paymentmethod.TabIndex = 85;
            // 
            // lbl_paymentmethod
            // 
            this.lbl_paymentmethod.AutoSize = true;
            this.lbl_paymentmethod.Location = new System.Drawing.Point(40, 536);
            this.lbl_paymentmethod.Name = "lbl_paymentmethod";
            this.lbl_paymentmethod.Size = new System.Drawing.Size(137, 20);
            this.lbl_paymentmethod.TabIndex = 84;
            this.lbl_paymentmethod.Text = "Payment Method :";
            // 
            // tb_kodepromo
            // 
            this.tb_kodepromo.Enabled = false;
            this.tb_kodepromo.Location = new System.Drawing.Point(184, 674);
            this.tb_kodepromo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_kodepromo.Name = "tb_kodepromo";
            this.tb_kodepromo.Size = new System.Drawing.Size(180, 26);
            this.tb_kodepromo.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 674);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Kode Promo :";
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1042, 840);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_kodepromo);
            this.Controls.Add(this.tb_paymentmethod);
            this.Controls.Add(this.lbl_paymentmethod);
            this.Controls.Add(this.tb_pay);
            this.Controls.Add(this.lbl_pay);
            this.Controls.Add(this.tb_subtotal);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.stat_date);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.tb_totalprice);
            this.Controls.Add(this.tb_service);
            this.Controls.Add(this.tb_ppn);
            this.Controls.Add(this.tb_diskon);
            this.Controls.Add(this.tb_totalqty);
            this.Controls.Add(this.lbl_totalprice);
            this.Controls.Add(this.lbl_service);
            this.Controls.Add(this.lbl_ppn);
            this.Controls.Add(this.lbl_promo);
            this.Controls.Add(this.lbl_totalqty);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.btn_debit);
            this.Controls.Add(this.btn_credit);
            this.Controls.Add(this.btn_cash);
            this.Controls.Add(this.cb_promo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_staffID);
            this.Controls.Add(this.lb_tableNo);
            this.Controls.Add(this.lb_daftarP);
            this.Controls.Add(this.lb_noTable);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.dgv_pesanan);
            this.Controls.Add(this.lbl_applypromo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPayment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesanan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.stat_date.ResumeLayout(false);
            this.stat_date.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_applypromo;
        private System.Windows.Forms.DataGridView dgv_pesanan;
        private System.Windows.Forms.Label lb_staffID;
        private System.Windows.Forms.Label lb_tableNo;
        private System.Windows.Forms.Label lb_daftarP;
        private System.Windows.Forms.Label lb_noTable;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_backspace;
        private System.Windows.Forms.Button btn_zeroo;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_nine;
        private System.Windows.Forms.Button btn_eight;
        private System.Windows.Forms.Button btn_seven;
        private System.Windows.Forms.Button btn_six;
        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.ComboBox cb_promo;
        private System.Windows.Forms.Button btn_cash;
        private System.Windows.Forms.Button btn_credit;
        private System.Windows.Forms.Button btn_debit;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label lbl_totalqty;
        private System.Windows.Forms.Label lbl_promo;
        private System.Windows.Forms.Label lbl_ppn;
        private System.Windows.Forms.Label lbl_service;
        private System.Windows.Forms.Label lbl_totalprice;
        private System.Windows.Forms.TextBox tb_totalqty;
        private System.Windows.Forms.TextBox tb_diskon;
        private System.Windows.Forms.TextBox tb_ppn;
        private System.Windows.Forms.TextBox tb_service;
        private System.Windows.Forms.TextBox tb_totalprice;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Timer timer_kasir;
        private System.Windows.Forms.StatusStrip stat_date;
        private System.Windows.Forms.TextBox tb_subtotal;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.TextBox tb_pay;
        private System.Windows.Forms.Label lbl_pay;
        private System.Windows.Forms.TextBox tb_paymentmethod;
        private System.Windows.Forms.Label lbl_paymentmethod;
        private System.Windows.Forms.RichTextBox rtb_amount;
        private System.Windows.Forms.ToolStripStatusLabel dateStatus;
        private System.Windows.Forms.TextBox tb_kodepromo;
        private System.Windows.Forms.Label label1;
    }
}
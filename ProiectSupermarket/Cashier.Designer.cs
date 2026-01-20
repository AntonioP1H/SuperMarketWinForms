namespace ProiectSupermarket
{
    partial class Cashier
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnLogout = new Button();
            btnPass = new Button();
            btnDSales = new Button();
            btnClear = new Button();
            btnSettle = new Button();
            btnDiscount = new Button();
            btnSearch = new Button();
            btnNTran = new Button();
            panel2 = new Panel();
            lblUsername = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panelSlide = new Panel();
            panel4 = new Panel();
            picClose = new PictureBox();
            pictureBox1 = new PictureBox();
            lblname = new Label();
            panel5 = new Panel();
            txtQty = new TextBox();
            lblTimer = new Label();
            lblVatable = new Label();
            lblVat = new Label();
            lblDiscount = new Label();
            lblSalesTotal = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtBarcode = new TextBox();
            label6 = new Label();
            lblDate = new Label();
            label5 = new Label();
            lblTranNo = new Label();
            label2 = new Label();
            lblDisplayTotal = new Label();
            dgvCash = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            colAdd = new DataGridViewImageColumn();
            colReduce = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCash).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 0, 179);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnPass);
            panel1.Controls.Add(btnDSales);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSettle);
            panel1.Controls.Add(btnDiscount);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnNTran);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 753);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.Logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 710);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(202, 43);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnPass
            // 
            btnPass.Dock = DockStyle.Top;
            btnPass.FlatAppearance.BorderSize = 0;
            btnPass.FlatStyle = FlatStyle.Flat;
            btnPass.ForeColor = Color.White;
            btnPass.Image = Properties.Resources.Password;
            btnPass.ImageAlign = ContentAlignment.MiddleLeft;
            btnPass.Location = new Point(0, 423);
            btnPass.Name = "btnPass";
            btnPass.Size = new Size(202, 43);
            btnPass.TabIndex = 7;
            btnPass.Text = "Change Password";
            btnPass.TextAlign = ContentAlignment.MiddleRight;
            btnPass.UseVisualStyleBackColor = true;
            btnPass.Click += btnPass_Click;
            // 
            // btnDSales
            // 
            btnDSales.Dock = DockStyle.Top;
            btnDSales.FlatAppearance.BorderSize = 0;
            btnDSales.FlatStyle = FlatStyle.Flat;
            btnDSales.ForeColor = Color.White;
            btnDSales.Image = Properties.Resources.Sales;
            btnDSales.ImageAlign = ContentAlignment.MiddleLeft;
            btnDSales.Location = new Point(0, 380);
            btnDSales.Name = "btnDSales";
            btnDSales.Size = new Size(202, 43);
            btnDSales.TabIndex = 6;
            btnDSales.Text = "Daily sales";
            btnDSales.TextAlign = ContentAlignment.MiddleRight;
            btnDSales.UseVisualStyleBackColor = true;
            btnDSales.Click += btnDSales_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Top;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Image = Properties.Resources.Cart;
            btnClear.ImageAlign = ContentAlignment.MiddleLeft;
            btnClear.Location = new Point(0, 337);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(202, 43);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear Cart";
            btnClear.TextAlign = ContentAlignment.MiddleRight;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSettle
            // 
            btnSettle.Dock = DockStyle.Top;
            btnSettle.FlatAppearance.BorderSize = 0;
            btnSettle.FlatStyle = FlatStyle.Flat;
            btnSettle.ForeColor = Color.White;
            btnSettle.Image = Properties.Resources.Payment;
            btnSettle.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettle.Location = new Point(0, 294);
            btnSettle.Name = "btnSettle";
            btnSettle.Size = new Size(202, 43);
            btnSettle.TabIndex = 4;
            btnSettle.Text = "Settle Payment";
            btnSettle.TextAlign = ContentAlignment.MiddleRight;
            btnSettle.UseVisualStyleBackColor = true;
            btnSettle.Click += btnSettle_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.Dock = DockStyle.Top;
            btnDiscount.FlatAppearance.BorderSize = 0;
            btnDiscount.FlatStyle = FlatStyle.Flat;
            btnDiscount.ForeColor = Color.White;
            btnDiscount.Image = Properties.Resources.Discount;
            btnDiscount.ImageAlign = ContentAlignment.MiddleLeft;
            btnDiscount.Location = new Point(0, 251);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(202, 43);
            btnDiscount.TabIndex = 3;
            btnDiscount.Text = "Add Discount";
            btnDiscount.TextAlign = ContentAlignment.MiddleRight;
            btnDiscount.UseVisualStyleBackColor = true;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Top;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = Properties.Resources.Search;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(0, 208);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(202, 43);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search Product";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnNTran
            // 
            btnNTran.Dock = DockStyle.Top;
            btnNTran.FlatAppearance.BorderSize = 0;
            btnNTran.FlatStyle = FlatStyle.Flat;
            btnNTran.ForeColor = Color.White;
            btnNTran.Image = Properties.Resources.Transaction;
            btnNTran.ImageAlign = ContentAlignment.MiddleLeft;
            btnNTran.Location = new Point(0, 165);
            btnNTran.Name = "btnNTran";
            btnNTran.Size = new Size(202, 43);
            btnNTran.TabIndex = 1;
            btnNTran.Text = " New Transaction";
            btnNTran.TextAlign = ContentAlignment.MiddleRight;
            btnNTran.UseVisualStyleBackColor = true;
            btnNTran.Click += btnNTran_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(202, 165);
            panel2.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(48, 120);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(99, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Purchase;
            pictureBox2.Location = new Point(48, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 87);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(55, 0, 179);
            panel3.Controls.Add(panelSlide);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(202, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(8, 753);
            panel3.TabIndex = 1;
            // 
            // panelSlide
            // 
            panelSlide.Location = new Point(0, 165);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(8, 50);
            panelSlide.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(55, 0, 179);
            panel4.Controls.Add(picClose);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(lblname);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(210, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1272, 50);
            panel4.TabIndex = 2;
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picClose.Image = Properties.Resources.Close;
            picClose.Location = new Point(1228, 7);
            picClose.Name = "picClose";
            picClose.Size = new Size(32, 35);
            picClose.TabIndex = 4;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User;
            pictureBox1.Location = new Point(18, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 30);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.ForeColor = Color.White;
            lblname.Location = new Point(57, 15);
            lblname.Name = "lblname";
            lblname.Size = new Size(145, 25);
            lblname.TabIndex = 2;
            lblname.Text = "Name and Role";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtQty);
            panel5.Controls.Add(lblTimer);
            panel5.Controls.Add(lblVatable);
            panel5.Controls.Add(lblVat);
            panel5.Controls.Add(lblDiscount);
            panel5.Controls.Add(lblSalesTotal);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(txtBarcode);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(lblDate);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(lblTranNo);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(lblDisplayTotal);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(1205, 50);
            panel5.Name = "panel5";
            panel5.Size = new Size(277, 703);
            panel5.TabIndex = 3;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(174, 287);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(58, 30);
            txtQty.TabIndex = 17;
            txtQty.Text = "1";
            txtQty.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTimer
            // 
            lblTimer.BackColor = Color.FromArgb(3, 218, 197);
            lblTimer.Dock = DockStyle.Bottom;
            lblTimer.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = Color.White;
            lblTimer.Location = new Point(0, 643);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(277, 60);
            lblTimer.TabIndex = 15;
            lblTimer.Text = "00:00:00";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVatable
            // 
            lblVatable.Location = new Point(127, 490);
            lblVatable.Name = "lblVatable";
            lblVatable.Size = new Size(138, 25);
            lblVatable.TabIndex = 14;
            lblVatable.Text = "0.00";
            lblVatable.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVat
            // 
            lblVat.Location = new Point(127, 457);
            lblVat.Name = "lblVat";
            lblVat.Size = new Size(138, 25);
            lblVat.TabIndex = 13;
            lblVat.Text = "0.00";
            lblVat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            lblDiscount.Location = new Point(127, 426);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(138, 25);
            lblDiscount.TabIndex = 12;
            lblDiscount.Text = "0.00";
            lblDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSalesTotal
            // 
            lblSalesTotal.Location = new Point(127, 392);
            lblSalesTotal.Name = "lblSalesTotal";
            lblSalesTotal.Size = new Size(138, 25);
            lblSalesTotal.TabIndex = 11;
            lblSalesTotal.Text = "0.00";
            lblSalesTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 490);
            label10.Name = "label10";
            label10.Size = new Size(91, 25);
            label10.TabIndex = 10;
            label10.Text = "VATable :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 457);
            label9.Name = "label9";
            label9.Size = new Size(54, 25);
            label9.TabIndex = 9;
            label9.Text = "VAT :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 426);
            label8.Name = "label8";
            label8.Size = new Size(97, 25);
            label8.TabIndex = 8;
            label8.Text = "Discount :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 392);
            label7.Name = "label7";
            label7.Size = new Size(115, 25);
            label7.TabIndex = 7;
            label7.Text = "Sales Total :";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(14, 286);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(139, 30);
            txtBarcode.TabIndex = 6;
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 247);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 5;
            label6.Text = "Barcode";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(14, 199);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(108, 25);
            lblDate.TabIndex = 4;
            lblDate.Text = "00000000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 165);
            label5.Name = "label5";
            label5.Size = new Size(52, 25);
            label5.TabIndex = 3;
            label5.Text = "Date";
            // 
            // lblTranNo
            // 
            lblTranNo.AutoSize = true;
            lblTranNo.Location = new Point(14, 124);
            lblTranNo.Name = "lblTranNo";
            lblTranNo.Size = new Size(192, 25);
            lblTranNo.TabIndex = 2;
            lblTranNo.Text = "000000000000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 90);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 1;
            label2.Text = "Transaction no";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.BackColor = Color.FromArgb(55, 0, 179);
            lblDisplayTotal.Dock = DockStyle.Top;
            lblDisplayTotal.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplayTotal.ForeColor = Color.White;
            lblDisplayTotal.Location = new Point(0, 0);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(277, 32);
            lblDisplayTotal.TabIndex = 0;
            lblDisplayTotal.Text = "0.00";
            lblDisplayTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvCash
            // 
            dgvCash.AllowUserToAddRows = false;
            dgvCash.BackgroundColor = SystemColors.Control;
            dgvCash.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCash.ColumnHeadersHeight = 30;
            dgvCash.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCash.Columns.AddRange(new DataGridViewColumn[] { Column1, Column9, Column2, Column4, Column7, Column5, Column6, Column8, colAdd, colReduce, Delete });
            dgvCash.Dock = DockStyle.Fill;
            dgvCash.EnableHeadersVisualStyles = false;
            dgvCash.Location = new Point(210, 50);
            dgvCash.Name = "dgvCash";
            dgvCash.RowHeadersVisible = false;
            dgvCash.RowHeadersWidth = 51;
            dgvCash.Size = new Size(995, 703);
            dgvCash.TabIndex = 5;
            dgvCash.SelectionChanged += dgvCash_SelectionChanged;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 63;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.HeaderText = "Id";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 55;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Pcode";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 92;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Description";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column7.DefaultCellStyle = dataGridViewCellStyle2;
            Column7.HeaderText = "Price";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 82;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column5.DefaultCellStyle = dataGridViewCellStyle3;
            Column5.HeaderText = "Qty";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 67;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column6.DefaultCellStyle = dataGridViewCellStyle4;
            Column6.HeaderText = "Discount";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 114;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column8.DefaultCellStyle = dataGridViewCellStyle5;
            Column8.HeaderText = "Total";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 81;
            // 
            // colAdd
            // 
            colAdd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colAdd.HeaderText = "";
            colAdd.Image = Properties.Resources.Plus1;
            colAdd.MinimumWidth = 6;
            colAdd.Name = "colAdd";
            colAdd.Width = 6;
            // 
            // colReduce
            // 
            colReduce.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colReduce.HeaderText = "";
            colReduce.Image = Properties.Resources.Minus1;
            colReduce.MinimumWidth = 6;
            colReduce.Name = "colReduce";
            colReduce.Width = 6;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.DeleteBin;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 6;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 753);
            ControlBox = false;
            Controls.Add(dgvCash);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Cashier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cashier";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCash).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnNTran;
        private Panel panel4;
        private Panel panel5;
        private Button btnPass;
        private Button btnDSales;
        private Button btnClear;
        private Button btnSettle;
        private Button btnDiscount;
        private Button btnSearch;
        private Button btnLogout;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblname;
        private PictureBox picClose;
        private Panel panelSlide;
        private DataGridView dgvCash;
        private Label label2;
        private Label lblDisplayTotal;
        private Label lblSalesTotal;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label lblDate;
        private Label label5;
        private Label lblVatable;
        private Label lblVat;
        private Label lblDiscount;
        private Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        public Label lblUsername;
        public Label lblTranNo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewImageColumn colAdd;
        private DataGridViewImageColumn colReduce;
        private DataGridViewImageColumn Delete;
        private TextBox txtQty;
        public TextBox txtBarcode;
    }
}
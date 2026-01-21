namespace ProiectSupermarket
{
    partial class DailySale
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            picClose = new PictureBox();
            label1 = new Label();
            dgvSold = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Cancel = new DataGridViewImageColumn();
            dtFrom = new DateTimePicker();
            dtTo = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            lblTotal = new Label();
            cbCashier = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSold).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 0, 179);
            panel1.Controls.Add(picClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 50);
            panel1.TabIndex = 9;
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Left;
            picClose.Image = Properties.Resources.Close;
            picClose.Location = new Point(1055, 9);
            picClose.Name = "picClose";
            picClose.Size = new Size(33, 35);
            picClose.TabIndex = 2;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 1;
            label1.Text = "Sold Items";
            // 
            // dgvSold
            // 
            dgvSold.AllowUserToAddRows = false;
            dgvSold.BackgroundColor = SystemColors.Control;
            dgvSold.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSold.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSold.ColumnHeadersHeight = 30;
            dgvSold.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSold.Columns.AddRange(new DataGridViewColumn[] { Column1, Column9, Column3, Column2, Column4, Column7, Column5, Column6, Column8, Cancel });
            dgvSold.Dock = DockStyle.Top;
            dgvSold.EnableHeadersVisualStyles = false;
            dgvSold.Location = new Point(0, 50);
            dgvSold.Name = "dgvSold";
            dgvSold.RowHeadersVisible = false;
            dgvSold.RowHeadersWidth = 51;
            dgvSold.Size = new Size(1100, 417);
            dgvSold.TabIndex = 10;
            dgvSold.CellContentClick += dgvSold_CellContentClick;
            dgvSold.KeyDown += dgvSold_KeyDown;
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
            Column9.Visible = false;
            Column9.Width = 125;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Invoice#";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 111;
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
            // Cancel
            // 
            Cancel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Cancel.HeaderText = "";
            Cancel.Image = Properties.Resources.Minus1;
            Cancel.MinimumWidth = 6;
            Cancel.Name = "Cancel";
            Cancel.Width = 6;
            // 
            // dtFrom
            // 
            dtFrom.Format = DateTimePickerFormat.Short;
            dtFrom.Location = new Point(203, 500);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(183, 30);
            dtFrom.TabIndex = 11;
            dtFrom.ValueChanged += dtFrom_ValueChanged;
            // 
            // dtTo
            // 
            dtTo.Format = DateTimePickerFormat.Short;
            dtTo.Location = new Point(457, 501);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(183, 30);
            dtTo.TabIndex = 12;
            dtTo.ValueChanged += dtTo_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 500);
            label2.Name = "label2";
            label2.Size = new Size(185, 25);
            label2.TabIndex = 13;
            label2.Text = "Filter by Date From :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(409, 501);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 14;
            label3.Text = "To :";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(890, 500);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(198, 25);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbCashier
            // 
            cbCashier.FormattingEnabled = true;
            cbCashier.Location = new Point(682, 501);
            cbCashier.Name = "cbCashier";
            cbCashier.Size = new Size(151, 33);
            cbCashier.TabIndex = 16;
            cbCashier.Text = "Select Cashier";
            cbCashier.SelectedIndexChanged += cbCashier_SelectedIndexChanged;
            // 
            // DailySale
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 562);
            Controls.Add(cbCashier);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtTo);
            Controls.Add(dtFrom);
            Controls.Add(dgvSold);
            Controls.Add(panel1);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "DailySale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DailySale";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSold).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox picClose;
        private Label label1;
        public DataGridView dgvSold;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewImageColumn Cancel;
        private DateTimePicker dtFrom;
        private DateTimePicker dtTo;
        private Label label2;
        private Label label3;
        private Label lblTotal;
        private ComboBox cbCashier;
    }
}
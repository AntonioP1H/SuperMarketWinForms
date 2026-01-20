namespace ProiectSupermarket
{
    partial class StockIn
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
            panel1 = new Panel();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnEnter = new Button();
            dgvStockIn = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            panel2 = new Panel();
            txtAddress = new TextBox();
            txtConPerson = new TextBox();
            cbSupplier = new ComboBox();
            lblId = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            linGenerate = new LinkLabel();
            linProduct = new LinkLabel();
            dtStockIn = new DateTimePicker();
            txtStockInBy = new TextBox();
            txtRefNo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockIn).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 0, 179);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 490);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 63);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Image = Properties.Resources.Cart;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(12, -7);
            label2.Name = "label2";
            label2.Size = new Size(126, 78);
            label2.TabIndex = 0;
            label2.Text = "Stock In Module";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1082, 490);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnEnter);
            tabPage1.Controls.Add(dgvStockIn);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1074, 452);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Stock In";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            btnEnter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEnter.BackColor = Color.FromArgb(55, 0, 179);
            btnEnter.FlatAppearance.BorderSize = 0;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.ForeColor = SystemColors.ControlLightLight;
            btnEnter.Location = new Point(930, 405);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(136, 41);
            btnEnter.TabIndex = 11;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // dgvStockIn
            // 
            dgvStockIn.AllowUserToAddRows = false;
            dgvStockIn.BackgroundColor = SystemColors.Control;
            dgvStockIn.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 0, 179);
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStockIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStockIn.ColumnHeadersHeight = 30;
            dgvStockIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStockIn.Columns.AddRange(new DataGridViewColumn[] { Column1, Column9, Column10, Column2, Column4, Column5, Column6, Column7, Column8, Delete });
            dgvStockIn.Dock = DockStyle.Top;
            dgvStockIn.EnableHeadersVisualStyles = false;
            dgvStockIn.Location = new Point(3, 188);
            dgvStockIn.Name = "dgvStockIn";
            dgvStockIn.RowHeadersVisible = false;
            dgvStockIn.RowHeadersWidth = 51;
            dgvStockIn.Size = new Size(1068, 211);
            dgvStockIn.TabIndex = 4;
            dgvStockIn.CellContentClick += dgvStockIn_CellContentClick;
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
            Column9.HeaderText = "Id";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Visible = false;
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "Reference#";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
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
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Qty";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 67;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Stock In Date";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 153;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Stock In By";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 134;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Supplier";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 110;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.Delete;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(txtConPerson);
            panel2.Controls.Add(cbSupplier);
            panel2.Controls.Add(lblId);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(linGenerate);
            panel2.Controls.Add(linProduct);
            panel2.Controls.Add(dtStockIn);
            panel2.Controls.Add(txtStockInBy);
            panel2.Controls.Add(txtRefNo);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1068, 185);
            panel2.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(685, 107);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(340, 30);
            txtAddress.TabIndex = 14;
            // 
            // txtConPerson
            // 
            txtConPerson.Location = new Point(685, 64);
            txtConPerson.Name = "txtConPerson";
            txtConPerson.Size = new Size(340, 30);
            txtConPerson.TabIndex = 13;
            // 
            // cbSupplier
            // 
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(685, 21);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(340, 33);
            cbSupplier.TabIndex = 12;
            cbSupplier.SelectedIndexChanged += cbSupplier_SelectedIndexChanged;
            cbSupplier.KeyPress += cbSupplier_KeyPress;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(517, 143);
            lblId.Name = "lblId";
            lblId.Size = new Size(59, 25);
            lblId.TabIndex = 11;
            lblId.Text = "lblId :";
            lblId.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(517, 105);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 10;
            label7.Text = "Address :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(517, 64);
            label6.Name = "label6";
            label6.Size = new Size(153, 25);
            label6.TabIndex = 9;
            label6.Text = "Contact Person :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(517, 21);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 8;
            label5.Text = "Supplier :";
            // 
            // linGenerate
            // 
            linGenerate.AutoSize = true;
            linGenerate.ForeColor = SystemColors.ActiveCaptionText;
            linGenerate.LinkColor = SystemColors.ActiveCaption;
            linGenerate.Location = new Point(378, 21);
            linGenerate.Name = "linGenerate";
            linGenerate.Size = new Size(112, 25);
            linGenerate.TabIndex = 7;
            linGenerate.TabStop = true;
            linGenerate.Text = "[ Generate ]";
            linGenerate.LinkClicked += linGenerate_LinkClicked;
            // 
            // linProduct
            // 
            linProduct.AutoSize = true;
            linProduct.LinkColor = SystemColors.ActiveCaption;
            linProduct.Location = new Point(148, 143);
            linProduct.Name = "linProduct";
            linProduct.Size = new Size(288, 25);
            linProduct.TabIndex = 6;
            linProduct.TabStop = true;
            linProduct.Text = "[ Click here to browse products ]";
            linProduct.LinkClicked += linProduct_LinkClicked;
            // 
            // dtStockIn
            // 
            dtStockIn.Location = new Point(147, 105);
            dtStockIn.Name = "dtStockIn";
            dtStockIn.Size = new Size(340, 30);
            dtStockIn.TabIndex = 5;
            // 
            // txtStockInBy
            // 
            txtStockInBy.Location = new Point(147, 59);
            txtStockInBy.Name = "txtStockInBy";
            txtStockInBy.Size = new Size(340, 30);
            txtStockInBy.TabIndex = 4;
            // 
            // txtRefNo
            // 
            txtRefNo.Location = new Point(148, 16);
            txtRefNo.Name = "txtRefNo";
            txtRefNo.Size = new Size(224, 30);
            txtRefNo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 105);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 2;
            label4.Text = "Stock In Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 59);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 1;
            label3.Text = "Stock In By :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 21);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 0;
            label1.Text = "Reference No :";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1074, 457);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Stock In Record";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // StockIn
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1082, 553);
            ControlBox = false;
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "StockIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockIn";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStockIn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel2;
        private DataGridView dgvStockIn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewImageColumn Delete;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        public Button btnEnter;
        public LinkLabel linGenerate;
        public LinkLabel linProduct;
        public DateTimePicker dtStockIn;
        public TextBox txtStockInBy;
        public TextBox txtRefNo;
        public Label lblId;
        public TextBox txtAddress;
        public TextBox txtConPerson;
        public ComboBox cbSupplier;
    }
}
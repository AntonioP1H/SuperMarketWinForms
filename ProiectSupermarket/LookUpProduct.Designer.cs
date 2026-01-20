namespace ProiectSupermarket
{
    partial class LookUpProduct
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
            dgvProduct = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Select = new DataGridViewImageColumn();
            panel1 = new Panel();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            txtSearch = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.BackgroundColor = SystemColors.Control;
            dgvProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 0, 179);
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduct.ColumnHeadersHeight = 30;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Select });
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.Location = new Point(0, 0);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(1082, 464);
            dgvProduct.TabIndex = 5;
            dgvProduct.CellContentClick += dgvProduct_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 63;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Pcode";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 92;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Barcode";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 110;
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
            Column5.HeaderText = "Brand";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 91;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Category";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 115;
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
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column8.DefaultCellStyle = dataGridViewCellStyle3;
            Column8.HeaderText = "Qty";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 67;
            // 
            // Select
            // 
            Select.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Select.HeaderText = "";
            Select.Image = Properties.Resources.CartPurple;
            Select.MinimumWidth = 6;
            Select.Name = "Select";
            Select.Width = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 0, 179);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 464);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 89);
            panel1.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(176, 0, 32);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(915, 29);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(136, 32);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Search;
            pictureBox1.Location = new Point(232, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Bottom;
            txtSearch.Location = new Point(305, 31);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(495, 30);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Image = Properties.Resources.Search_Property;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(12, 6);
            label2.Name = "label2";
            label2.Size = new Size(126, 78);
            label2.TabIndex = 0;
            label2.Text = "Search Product";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LookUpProduct
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 553);
            ControlBox = false;
            Controls.Add(dgvProduct);
            Controls.Add(panel1);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "LookUpProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LookUpProduct";
            KeyDown += LookUpProduct_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProduct;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtSearch;
        private Label label2;
        private Button btnClose;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewImageColumn Select;
    }
}
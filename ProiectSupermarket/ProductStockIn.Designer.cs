namespace ProiectSupermarket
{
    partial class ProductStockIn
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductStockIn));
            dgvProduct = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Select = new DataGridViewImageColumn();
            panel1 = new Panel();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            txtSearch = new TextBox();
            btnAdd = new Button();
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(55, 0, 179);
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProduct.ColumnHeadersHeight = 30;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column8, Select });
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.Location = new Point(0, 0);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(732, 464);
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
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Description";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Qty";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 67;
            // 
            // Select
            // 
            Select.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Select.HeaderText = "";
            Select.Image = Properties.Resources.cHECKED;
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
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 464);
            panel1.Name = "panel1";
            panel1.Size = new Size(732, 89);
            panel1.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(176, 0, 32);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(584, 31);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(136, 32);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Search;
            pictureBox1.Location = new Point(167, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(205, 31);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(321, 30);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(914, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(39, 42);
            btnAdd.TabIndex = 1;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Image = Properties.Resources.Box;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(12, 6);
            label2.Name = "label2";
            label2.Size = new Size(126, 78);
            label2.TabIndex = 0;
            label2.Text = "Product Stock In";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ProductStockIn
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 553);
            ControlBox = false;
            Controls.Add(dgvProduct);
            Controls.Add(panel1);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "ProductStockIn";
            Text = "ProductStockIn";
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
        private Button btnAdd;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewImageColumn Select;
        private Button btnClose;
    }
}
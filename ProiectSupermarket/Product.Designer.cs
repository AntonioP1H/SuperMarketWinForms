namespace ProiectSupermarket
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            dgvProduct = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1 = new Panel();
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
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Edit, Delete });
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.Location = new Point(0, 0);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(982, 464);
            dgvProduct.TabIndex = 3;
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
            Column7.HeaderText = "Price";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 82;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Re-Order";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 115;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = Properties.Resources.Edit_Pencil;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 6;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 0, 179);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 464);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 89);
            panel1.TabIndex = 2;
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
            txtSearch.Location = new Point(270, 31);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(495, 30);
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
            btnAdd.Click += btnAdd_Click;
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
            label2.Text = "Manage Product";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            ControlBox = false;
            Controls.Add(dgvProduct);
            Controls.Add(panel1);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Product";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProduct;
        private Panel panel1;
        private Button btnAdd;
        private Label label2;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}
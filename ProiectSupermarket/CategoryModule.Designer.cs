namespace ProiectSupermarket
{
    partial class CategoryModule
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
            panel1 = new Panel();
            picClose = new PictureBox();
            label1 = new Label();
            lblId = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            label2 = new Label();
            btnSave = new Button();
            txtCategory = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
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
            panel1.Size = new Size(1082, 50);
            panel1.TabIndex = 8;
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picClose.Image = Properties.Resources.Close;
            picClose.Location = new Point(1037, 8);
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
            label1.Location = new Point(30, 14);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 1;
            label1.Text = "Category Module";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(60, 156);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 23);
            lblId.TabIndex = 14;
            lblId.Text = "ID";
            lblId.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Location = new Point(933, 132);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(136, 41);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.Olive;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(791, 132);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(136, 41);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 84);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 11;
            label2.Text = "Category Name:";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(55, 0, 179);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(649, 132);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(136, 41);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(259, 79);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(803, 28);
            txtCategory.TabIndex = 9;
            // 
            // CategoryModule
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 183);
            Controls.Add(panel1);
            Controls.Add(lblId);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(txtCategory);
            Font = new Font("Franklin Gothic Medium", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CategoryModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryModule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox picClose;
        private Label label1;
        public Label lblId;
        private Button btnCancel;
        public Button btnUpdate;
        private Label label2;
        public Button btnSave;
        public TextBox txtCategory;
    }
}
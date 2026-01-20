namespace ProiectSupermarket
{
    partial class BrandModule
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
            txtBrand = new TextBox();
            btnSave = new Button();
            label2 = new Label();
            btnUpdate = new Button();
            btnCancel = new Button();
            lblId = new Label();
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
            panel1.Size = new Size(1100, 50);
            panel1.TabIndex = 0;
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picClose.Image = Properties.Resources.Close;
            picClose.Location = new Point(1038, 9);
            picClose.Name = "picClose";
            picClose.Size = new Size(31, 35);
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
            label1.Size = new Size(145, 25);
            label1.TabIndex = 1;
            label1.Text = "Brand Module";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(259, 92);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(803, 30);
            txtBrand.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(55, 0, 179);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(649, 168);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(136, 41);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 97);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 3;
            label2.Text = "Brand Name:";
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.Olive;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(791, 168);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(136, 41);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Location = new Point(933, 168);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(136, 41);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(60, 169);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 25);
            lblId.TabIndex = 7;
            lblId.Text = "ID";
            lblId.Visible = false;
            // 
            // BrandModule
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 230);
            Controls.Add(lblId);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(txtBrand);
            Controls.Add(panel1);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "BrandModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BrandModule";
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
        public TextBox txtBrand;
        public Button btnSave;
        private Label label2;
        public Button btnUpdate;
        private Button btnCancel;
        private Label label3;
        public Label lblId;
    }
}
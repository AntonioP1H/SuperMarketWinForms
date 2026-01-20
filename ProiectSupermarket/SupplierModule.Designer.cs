namespace ProiectSupermarket
{
    partial class SupplierModule
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
            txtEmail = new TextBox();
            txtFax = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblId = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            label2 = new Label();
            btnSave = new Button();
            txtSupplier = new TextBox();
            picClose = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            txtContact = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(189, 290);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(803, 30);
            txtEmail.TabIndex = 48;
            // 
            // txtFax
            // 
            txtFax.Location = new Point(737, 234);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(255, 30);
            txtFax.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 290);
            label7.Name = "label7";
            label7.Size = new Size(150, 25);
            label7.TabIndex = 42;
            label7.Text = "E-mail Address :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 234);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 41;
            label6.Text = "Phone No :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 186);
            label5.Name = "label5";
            label5.Size = new Size(153, 25);
            label5.TabIndex = 40;
            label5.Text = "Contact Person :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 127);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 39;
            label4.Text = "Address :";
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblId.AutoSize = true;
            lblId.Location = new Point(30, 354);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 25);
            lblId.TabIndex = 37;
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
            btnCancel.Location = new Point(883, 346);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(136, 41);
            btnCancel.TabIndex = 36;
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
            btnUpdate.Location = new Point(737, 346);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(136, 41);
            btnUpdate.TabIndex = 35;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 71);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 34;
            label2.Text = "Supplier Name :";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(55, 0, 179);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(593, 346);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(136, 41);
            btnSave.TabIndex = 33;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(189, 68);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(803, 30);
            txtSupplier.TabIndex = 32;
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picClose.Image = Properties.Resources.Close;
            picClose.Location = new Point(1040, 9);
            picClose.Name = "picClose";
            picClose.Size = new Size(30, 38);
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
            label1.Size = new Size(167, 25);
            label1.TabIndex = 1;
            label1.Text = "Supplier Module";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(614, 234);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 38;
            label3.Text = "Fax no :";
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
            panel1.TabIndex = 31;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(189, 186);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(803, 30);
            txtContact.TabIndex = 49;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(189, 234);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(397, 30);
            txtPhone.TabIndex = 50;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(189, 127);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(803, 30);
            txtAddress.TabIndex = 51;
            // 
            // SupplierModule
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 397);
            ControlBox = false;
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtContact);
            Controls.Add(txtEmail);
            Controls.Add(txtFax);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblId);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(txtSupplier);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SupplierModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupplierModule";
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public NumericUpDown UDReOrder;
        public TextBox txtEmail;
        public ComboBox cboBrand;
        public ComboBox cboCategory;
        public TextBox txtPdesc;
        public TextBox txtFax;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        public Label lblId;
        private Button btnCancel;
        public Button btnUpdate;
        private Label label2;
        public Button btnSave;
        public TextBox txtSupplier;
        private PictureBox picClose;
        private Label label1;
        private Label label3;
        private Panel panel1;
        public TextBox txtContact;
        public TextBox txtPhone;
        public TextBox txtAddress;
    }
}
namespace ProiectSupermarket
{
    partial class UserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnAdd = new Button();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnAccCancel = new Button();
            btnAccSave = new Button();
            label6 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cbRole = new ComboBox();
            txtRePass = new TextBox();
            txtPass = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnPassCancel = new Button();
            btnPassSave = new Button();
            txtRePass2 = new TextBox();
            label10 = new Label();
            txtNPass = new TextBox();
            label9 = new Label();
            txtPass2 = new TextBox();
            label8 = new Label();
            txtPassUsername = new TextBox();
            label7 = new Label();
            tabPage3 = new TabPage();
            dgvUser = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 0, 179);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 464);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 89);
            panel1.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Right;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(1696, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(39, 42);
            btnAdd.TabIndex = 1;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Image = Properties.Resources.Settings;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(12, 6);
            label2.Name = "label2";
            label2.Size = new Size(130, 78);
            label2.TabIndex = 0;
            label2.Text = "User Settings";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(958, 430);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAccCancel);
            tabPage1.Controls.Add(btnAccSave);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cbRole);
            tabPage1.Controls.Add(txtRePass);
            tabPage1.Controls.Add(txtPass);
            tabPage1.Controls.Add(txtUsername);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(950, 392);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create Account";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAccCancel
            // 
            btnAccCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAccCancel.BackColor = Color.Gray;
            btnAccCancel.FlatAppearance.BorderSize = 0;
            btnAccCancel.FlatStyle = FlatStyle.Flat;
            btnAccCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnAccCancel.Location = new Point(726, 326);
            btnAccCancel.Name = "btnAccCancel";
            btnAccCancel.Size = new Size(136, 41);
            btnAccCancel.TabIndex = 38;
            btnAccCancel.Text = "Cancel";
            btnAccCancel.UseVisualStyleBackColor = false;
            btnAccCancel.Click += btnAccCancel_Click;
            // 
            // btnAccSave
            // 
            btnAccSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAccSave.BackColor = Color.FromArgb(55, 0, 179);
            btnAccSave.FlatAppearance.BorderSize = 0;
            btnAccSave.FlatStyle = FlatStyle.Flat;
            btnAccSave.ForeColor = SystemColors.ControlLightLight;
            btnAccSave.Location = new Point(549, 326);
            btnAccSave.Name = "btnAccSave";
            btnAccSave.Size = new Size(136, 41);
            btnAccSave.TabIndex = 37;
            btnAccSave.Text = "Save";
            btnAccSave.UseVisualStyleBackColor = false;
            btnAccSave.Click += btnAccSave_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 256);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 9;
            label6.Text = "Full Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(256, 251);
            txtName.Name = "txtName";
            txtName.Size = new Size(606, 30);
            txtName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 205);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 7;
            label5.Text = "Role :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 151);
            label4.Name = "label4";
            label4.Size = new Size(180, 25);
            label4.TabIndex = 6;
            label4.Text = "Confirm Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 97);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 5;
            label3.Text = "Password :";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Cashier" });
            cbRole.Location = new Point(256, 197);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(606, 33);
            cbRole.TabIndex = 4;
            // 
            // txtRePass
            // 
            txtRePass.Location = new Point(256, 146);
            txtRePass.Name = "txtRePass";
            txtRePass.Size = new Size(606, 30);
            txtRePass.TabIndex = 3;
            txtRePass.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(256, 94);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(606, 30);
            txtPass.TabIndex = 2;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(256, 48);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(606, 30);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 48);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnPassCancel);
            tabPage2.Controls.Add(btnPassSave);
            tabPage2.Controls.Add(txtRePass2);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(txtNPass);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txtPass2);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtPassUsername);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(950, 397);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Change Password";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPassCancel
            // 
            btnPassCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPassCancel.BackColor = Color.Gray;
            btnPassCancel.FlatAppearance.BorderSize = 0;
            btnPassCancel.FlatStyle = FlatStyle.Flat;
            btnPassCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnPassCancel.Location = new Point(725, 334);
            btnPassCancel.Name = "btnPassCancel";
            btnPassCancel.Size = new Size(136, 41);
            btnPassCancel.TabIndex = 40;
            btnPassCancel.Text = "Cancel";
            btnPassCancel.UseVisualStyleBackColor = false;
            // 
            // btnPassSave
            // 
            btnPassSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPassSave.BackColor = Color.FromArgb(55, 0, 179);
            btnPassSave.FlatAppearance.BorderSize = 0;
            btnPassSave.FlatStyle = FlatStyle.Flat;
            btnPassSave.ForeColor = SystemColors.ControlLightLight;
            btnPassSave.Location = new Point(553, 334);
            btnPassSave.Name = "btnPassSave";
            btnPassSave.Size = new Size(136, 41);
            btnPassSave.TabIndex = 39;
            btnPassSave.Text = "Save";
            btnPassSave.UseVisualStyleBackColor = false;
            // 
            // txtRePass2
            // 
            txtRePass2.Location = new Point(255, 227);
            txtRePass2.Name = "txtRePass2";
            txtRePass2.Size = new Size(606, 30);
            txtRePass2.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(53, 232);
            label10.Name = "label10";
            label10.Size = new Size(180, 25);
            label10.TabIndex = 8;
            label10.Text = "Confirm Password :";
            // 
            // txtNPass
            // 
            txtNPass.Location = new Point(255, 167);
            txtNPass.Name = "txtNPass";
            txtNPass.Size = new Size(606, 30);
            txtNPass.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(53, 172);
            label9.Name = "label9";
            label9.Size = new Size(148, 25);
            label9.TabIndex = 6;
            label9.Text = "New Password :";
            // 
            // txtPass2
            // 
            txtPass2.Location = new Point(255, 105);
            txtPass2.Name = "txtPass2";
            txtPass2.Size = new Size(606, 30);
            txtPass2.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 105);
            label8.Name = "label8";
            label8.Size = new Size(175, 25);
            label8.TabIndex = 4;
            label8.Text = "Current Password :";
            // 
            // txtPassUsername
            // 
            txtPassUsername.Location = new Point(255, 48);
            txtPassUsername.Name = "txtPassUsername";
            txtPassUsername.Size = new Size(606, 30);
            txtPassUsername.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 48);
            label7.Name = "label7";
            label7.Size = new Size(109, 25);
            label7.TabIndex = 2;
            label7.Text = "Username :";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvUser);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(950, 397);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Activate/Unactivate Account";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.BackgroundColor = SystemColors.Control;
            dgvUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 0, 179);
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUser.ColumnHeadersHeight = 30;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Edit, Delete });
            dgvUser.Dock = DockStyle.Fill;
            dgvUser.EnableHeadersVisualStyles = false;
            dgvUser.Location = new Point(3, 3);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersVisible = false;
            dgvUser.RowHeadersWidth = 51;
            dgvUser.Size = new Size(944, 391);
            dgvUser.TabIndex = 3;
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
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Id";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Visible = false;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Brand";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
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
            // UserAccount
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            ControlBox = false;
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "UserAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserAccount";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAdd;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cbRole;
        private TextBox txtRePass;
        private TextBox txtPass;
        private TextBox txtUsername;
        private Label label1;
        private Label label6;
        private TextBox txtName;
        private Button btnAccCancel;
        public Button btnAccSave;
        private Button btnPassCancel;
        public Button btnPassSave;
        private TextBox txtRePass2;
        private Label label10;
        private TextBox txtNPass;
        private Label label9;
        private TextBox txtPass2;
        private Label label8;
        private TextBox txtPassUsername;
        private Label label7;
        private DataGridView dgvUser;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}
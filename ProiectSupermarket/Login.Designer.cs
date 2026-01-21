namespace ProiectSupermarket
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            picClose = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            txtName = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            txtPass = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 0, 179);
            panel1.Controls.Add(picClose);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 71);
            panel1.TabIndex = 9;
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Right;
            picClose.Image = Properties.Resources.Close;
            picClose.Location = new Point(905, 22);
            picClose.Name = "picClose";
            picClose.Size = new Size(33, 35);
            picClose.TabIndex = 4;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 50);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(75, 18);
            label1.Name = "label1";
            label1.Size = new Size(225, 39);
            label1.TabIndex = 1;
            label1.Text = "Super Market";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(450, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(357, 310);
            txtName.Name = "txtName";
            txtName.Size = new Size(370, 30);
            txtName.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Enabled = false;
            textBox1.Location = new Point(261, 310);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(98, 30);
            textBox1.TabIndex = 13;
            textBox1.Text = "Username :";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(261, 382);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(98, 30);
            textBox2.TabIndex = 15;
            textBox2.Text = "Password :";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(357, 382);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(370, 30);
            txtPass.TabIndex = 14;
            txtPass.UseSystemPasswordChar = true;
            txtPass.KeyPress += txtPass_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(458, 262);
            label2.Name = "label2";
            label2.Size = new Size(87, 38);
            label2.TabIndex = 16;
            label2.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(55, 0, 179);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(261, 456);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(466, 41);
            btnLogin.TabIndex = 17;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 650);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(txtPass);
            Controls.Add(textBox1);
            Controls.Add(txtName);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox txtName;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtPass;
        private Label label2;
        public Button btnLogin;
        private PictureBox picClose;
    }
}
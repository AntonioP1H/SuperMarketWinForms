namespace ProiectSupermarket
{
    partial class Void
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
            textBox2 = new TextBox();
            txtPass = new TextBox();
            textBox1 = new TextBox();
            txtUsername = new TextBox();
            btnVoid = new Button();
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
            panel1.Size = new Size(458, 50);
            panel1.TabIndex = 9;
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Left;
            picClose.Image = Properties.Resources.Close;
            picClose.Location = new Point(413, 3);
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
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 1;
            label1.Text = "Void Cancel Order";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(65, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(104, 30);
            textBox2.TabIndex = 19;
            textBox2.Text = "Password :";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(175, 136);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(210, 30);
            txtPass.TabIndex = 18;
            txtPass.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Enabled = false;
            textBox1.Location = new Point(65, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(104, 30);
            textBox1.TabIndex = 17;
            textBox1.Text = "Username :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(175, 78);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 30);
            txtUsername.TabIndex = 16;
            // 
            // btnVoid
            // 
            btnVoid.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVoid.BackColor = Color.FromArgb(55, 0, 179);
            btnVoid.FlatAppearance.BorderSize = 0;
            btnVoid.FlatStyle = FlatStyle.Flat;
            btnVoid.ForeColor = SystemColors.ControlLightLight;
            btnVoid.Location = new Point(65, 199);
            btnVoid.Name = "btnVoid";
            btnVoid.Size = new Size(320, 41);
            btnVoid.TabIndex = 20;
            btnVoid.Text = "Void";
            btnVoid.UseVisualStyleBackColor = false;
            btnVoid.Click += btnVoid_Click;
            // 
            // Void
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 337);
            Controls.Add(btnVoid);
            Controls.Add(textBox2);
            Controls.Add(txtPass);
            Controls.Add(textBox1);
            Controls.Add(txtUsername);
            Controls.Add(panel1);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Void";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Void";
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
        private TextBox textBox2;
        private TextBox txtPass;
        private TextBox textBox1;
        public Button btnVoid;
        public TextBox txtUsername;
    }
}
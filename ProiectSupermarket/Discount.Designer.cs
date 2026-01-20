namespace ProiectSupermarket
{
    partial class Discount
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
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDiscAmount = new TextBox();
            txtDiscount = new TextBox();
            txtTotalPrice = new TextBox();
            lblId = new Label();
            btnConfirm = new Button();
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
            panel1.Size = new Size(901, 50);
            panel1.TabIndex = 9;
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Right;
            picClose.Image = Properties.Resources.Close;
            picClose.Location = new Point(852, 9);
            picClose.Name = "picClose";
            picClose.Size = new Size(37, 35);
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
            label1.Size = new Size(95, 25);
            label1.TabIndex = 1;
            label1.Text = "Discount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 104);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 10;
            label2.Text = "Total Price :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 151);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 11;
            label4.Text = "Discount (%) :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 196);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 12;
            label5.Text = "Discount Amount";
            // 
            // txtDiscAmount
            // 
            txtDiscAmount.Enabled = false;
            txtDiscAmount.Location = new Point(221, 196);
            txtDiscAmount.Name = "txtDiscAmount";
            txtDiscAmount.Size = new Size(635, 30);
            txtDiscAmount.TabIndex = 13;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(221, 151);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(635, 30);
            txtDiscount.TabIndex = 14;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Enabled = false;
            txtTotalPrice.Location = new Point(221, 104);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(635, 30);
            txtTotalPrice.TabIndex = 15;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(30, 244);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 25);
            lblId.TabIndex = 16;
            lblId.Text = "ID";
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirm.BackColor = Color.FromArgb(55, 0, 179);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.ForeColor = SystemColors.ControlLightLight;
            btnConfirm.Location = new Point(720, 236);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(136, 41);
            btnConfirm.TabIndex = 17;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // Discount
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 286);
            Controls.Add(btnConfirm);
            Controls.Add(lblId);
            Controls.Add(txtTotalPrice);
            Controls.Add(txtDiscount);
            Controls.Add(txtDiscAmount);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Discount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Discount";
            KeyDown += Discount_KeyDown;
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
        private Label label2;
        private Label label4;
        private Label label5;
        public Button btnConfirm;
        public TextBox txtTotalPrice;
        public Label lblId;
        public TextBox txtDiscAmount;
        public TextBox txtDiscount;
    }
}
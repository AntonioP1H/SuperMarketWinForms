namespace ProiectSupermarket
{
    partial class CancelOrder
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
            Panel panel1;
            picClose = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtPcode = new TextBox();
            txtDesc = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtQty = new TextBox();
            txtPrice = new TextBox();
            txtTransno = new TextBox();
            label7 = new Label();
            txtDisc = new TextBox();
            txtTotal = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label15 = new Label();
            label16 = new Label();
            txtCancelBy = new TextBox();
            txtVoid = new TextBox();
            label17 = new Label();
            cbInventory = new ComboBox();
            label11 = new Label();
            txtReason = new TextBox();
            label12 = new Label();
            btnEnter = new Button();
            udCancelQty = new NumericUpDown();
            panel1 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udCancelQty).BeginInit();
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
            panel1.TabIndex = 10;
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Left;
            picClose.Image = Properties.Resources.Close;
            picClose.Location = new Point(1055, 9);
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
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 1;
            label1.Text = "Cancel Order Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 111);
            label2.Name = "label2";
            label2.Size = new Size(40, 25);
            label2.TabIndex = 11;
            label2.Text = "ID :";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(210, 106);
            txtId.Name = "txtId";
            txtId.Size = new Size(291, 30);
            txtId.TabIndex = 12;
            // 
            // txtPcode
            // 
            txtPcode.Enabled = false;
            txtPcode.Location = new Point(210, 156);
            txtPcode.Name = "txtPcode";
            txtPcode.Size = new Size(291, 30);
            txtPcode.TabIndex = 13;
            // 
            // txtDesc
            // 
            txtDesc.Enabled = false;
            txtDesc.Location = new Point(210, 209);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(291, 113);
            txtDesc.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 159);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 15;
            label3.Text = "Product Code :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 209);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 16;
            label4.Text = "Description :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(574, 214);
            label5.Name = "label5";
            label5.Size = new Size(145, 25);
            label5.TabIndex = 22;
            label5.Text = "Qty \\ Discount :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(574, 164);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 21;
            label6.Text = "Price :";
            // 
            // txtQty
            // 
            txtQty.Enabled = false;
            txtQty.Location = new Point(735, 214);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(122, 30);
            txtQty.TabIndex = 20;
            // 
            // txtPrice
            // 
            txtPrice.Enabled = false;
            txtPrice.Location = new Point(735, 164);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(303, 30);
            txtPrice.TabIndex = 19;
            // 
            // txtTransno
            // 
            txtTransno.Enabled = false;
            txtTransno.Location = new Point(735, 111);
            txtTransno.Name = "txtTransno";
            txtTransno.Size = new Size(303, 30);
            txtTransno.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(574, 111);
            label7.Name = "label7";
            label7.Size = new Size(149, 25);
            label7.TabIndex = 17;
            label7.Text = "Transaction no :";
            // 
            // txtDisc
            // 
            txtDisc.Enabled = false;
            txtDisc.Location = new Point(898, 214);
            txtDisc.Name = "txtDisc";
            txtDisc.Size = new Size(140, 30);
            txtDisc.TabIndex = 23;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(735, 274);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(303, 30);
            txtTotal.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(574, 274);
            label8.Name = "label8";
            label8.Size = new Size(64, 25);
            label8.TabIndex = 24;
            label8.Text = "Total :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Franklin Gothic Medium", 16.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(255, 128, 0);
            label9.Location = new Point(16, 65);
            label9.Name = "label9";
            label9.Size = new Size(159, 36);
            label9.TabIndex = 26;
            label9.Text = "SOLD ITEM :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Franklin Gothic Medium", 16.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(255, 128, 0);
            label10.Location = new Point(16, 346);
            label10.Name = "label10";
            label10.Size = new Size(221, 36);
            label10.TabIndex = 27;
            label10.Text = "CANCEL ITEM(S) :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(37, 498);
            label15.Name = "label15";
            label15.Size = new Size(167, 25);
            label15.TabIndex = 33;
            label15.Text = "Add to Inventory ?";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(37, 448);
            label16.Name = "label16";
            label16.Size = new Size(131, 25);
            label16.TabIndex = 32;
            label16.Text = "Cancelled by :";
            // 
            // txtCancelBy
            // 
            txtCancelBy.Enabled = false;
            txtCancelBy.Location = new Point(210, 448);
            txtCancelBy.Name = "txtCancelBy";
            txtCancelBy.Size = new Size(291, 30);
            txtCancelBy.TabIndex = 30;
            // 
            // txtVoid
            // 
            txtVoid.Location = new Point(210, 395);
            txtVoid.Name = "txtVoid";
            txtVoid.Size = new Size(291, 30);
            txtVoid.TabIndex = 29;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(37, 395);
            label17.Name = "label17";
            label17.Size = new Size(86, 25);
            label17.TabIndex = 28;
            label17.Text = "Void By :";
            // 
            // cbInventory
            // 
            cbInventory.FormattingEnabled = true;
            cbInventory.Items.AddRange(new object[] { "Yes", "No" });
            cbInventory.Location = new Point(210, 498);
            cbInventory.Name = "cbInventory";
            cbInventory.Size = new Size(291, 33);
            cbInventory.TabIndex = 34;
            cbInventory.KeyPress += cbInventory_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(570, 453);
            label11.Name = "label11";
            label11.Size = new Size(87, 25);
            label11.TabIndex = 38;
            label11.Text = "Reason :";
            // 
            // txtReason
            // 
            txtReason.Location = new Point(731, 453);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(303, 78);
            txtReason.TabIndex = 37;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(570, 400);
            label12.Name = "label12";
            label12.Size = new Size(111, 25);
            label12.TabIndex = 35;
            label12.Text = "Cancel qty :";
            // 
            // btnEnter
            // 
            btnEnter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEnter.BackColor = Color.FromArgb(55, 0, 179);
            btnEnter.FlatAppearance.BorderSize = 0;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.ForeColor = SystemColors.ControlLightLight;
            btnEnter.Location = new Point(898, 547);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(136, 41);
            btnEnter.TabIndex = 39;
            btnEnter.Text = "Cancel Order";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // udCancelQty
            // 
            udCancelQty.Location = new Point(735, 398);
            udCancelQty.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            udCancelQty.Name = "udCancelQty";
            udCancelQty.Size = new Size(150, 30);
            udCancelQty.TabIndex = 40;
            // 
            // CancelOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(udCancelQty);
            Controls.Add(btnEnter);
            Controls.Add(label11);
            Controls.Add(txtReason);
            Controls.Add(label12);
            Controls.Add(cbInventory);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(txtCancelBy);
            Controls.Add(txtVoid);
            Controls.Add(label17);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtTotal);
            Controls.Add(label8);
            Controls.Add(txtDisc);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtQty);
            Controls.Add(txtPrice);
            Controls.Add(txtTransno);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDesc);
            Controls.Add(txtPcode);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "CancelOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CancelOrder";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)udCancelQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label15;
        private Label label16;
        private TextBox txtVoid;
        private Label label17;
        private Label label11;
        private Label label12;
        public Button btnEnter;
        public TextBox txtId;
        public TextBox txtPcode;
        public TextBox txtDesc;
        public TextBox txtQty;
        public TextBox txtPrice;
        public TextBox txtTransno;
        public TextBox txtDisc;
        public TextBox txtTotal;
        public TextBox txtCancelBy;
        public TextBox txtReason;
        public NumericUpDown udCancelQty;
        public ComboBox cbInventory;
    }
}
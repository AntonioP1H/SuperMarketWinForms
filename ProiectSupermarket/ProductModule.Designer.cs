namespace ProiectSupermarket
{
    partial class ProductModule
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
            txtPcode = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtBarcode = new TextBox();
            txtPdesc = new TextBox();
            cboCategory = new ComboBox();
            cboBrand = new ComboBox();
            txtPrice = new TextBox();
            UDReOrder = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UDReOrder).BeginInit();
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
            panel1.TabIndex = 8;
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picClose.Image = Properties.Resources.Close;
            picClose.Location = new Point(1057, 9);
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
            label1.Size = new Size(145, 25);
            label1.TabIndex = 1;
            label1.Text = "Brand Module";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(30, 396);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 25);
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
            btnCancel.Location = new Point(883, 388);
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
            btnUpdate.Location = new Point(737, 388);
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
            label2.Size = new Size(138, 25);
            label2.TabIndex = 11;
            label2.Text = "Product Code :";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(55, 0, 179);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(593, 388);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(136, 41);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtPcode
            // 
            txtPcode.Location = new Point(180, 84);
            txtPcode.Name = "txtPcode";
            txtPcode.Size = new Size(382, 30);
            txtPcode.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(582, 89);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 15;
            label3.Text = "Barcode :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 143);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 16;
            label4.Text = "Description :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 194);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 17;
            label5.Text = "Brand :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 250);
            label6.Name = "label6";
            label6.Size = new Size(98, 25);
            label6.TabIndex = 18;
            label6.Text = "Category :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 306);
            label7.Name = "label7";
            label7.Size = new Size(65, 25);
            label7.TabIndex = 19;
            label7.Text = "Price :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(614, 311);
            label8.Name = "label8";
            label8.Size = new Size(147, 25);
            label8.TabIndex = 20;
            label8.Text = "Re-Order Level: ";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(728, 89);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(255, 30);
            txtBarcode.TabIndex = 21;
            // 
            // txtPdesc
            // 
            txtPdesc.Location = new Point(180, 143);
            txtPdesc.Name = "txtPdesc";
            txtPdesc.Size = new Size(803, 30);
            txtPdesc.TabIndex = 22;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(180, 250);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(803, 33);
            cboCategory.TabIndex = 27;
            // 
            // cboBrand
            // 
            cboBrand.FormattingEnabled = true;
            cboBrand.Location = new Point(180, 194);
            cboBrand.Name = "cboBrand";
            cboBrand.Size = new Size(803, 33);
            cboBrand.TabIndex = 28;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(180, 306);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(382, 30);
            txtPrice.TabIndex = 29;
            // 
            // UDReOrder
            // 
            UDReOrder.Location = new Point(767, 309);
            UDReOrder.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            UDReOrder.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UDReOrder.Name = "UDReOrder";
            UDReOrder.Size = new Size(216, 30);
            UDReOrder.TabIndex = 30;
            UDReOrder.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ProductModule
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 444);
            Controls.Add(UDReOrder);
            Controls.Add(txtPrice);
            Controls.Add(cboBrand);
            Controls.Add(cboCategory);
            Controls.Add(txtPdesc);
            Controls.Add(txtBarcode);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(lblId);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(txtPcode);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ProductModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductModule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)UDReOrder).EndInit();
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
        public TextBox txtPcode;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        public TextBox txtBarcode;
        public TextBox txtPdesc;
        public ComboBox cboCategory;
        public ComboBox cboBrand;
        public TextBox txtPrice;
        public NumericUpDown UDReOrder;
    }
}
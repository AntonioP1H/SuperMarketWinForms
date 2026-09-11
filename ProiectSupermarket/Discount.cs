using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectSupermarket
{
    public partial class Discount : Form
    {
        DBConnect dbcon = new DBConnect();
        Cashier cashier;

        public Discount(Cashier cash)
        {
            InitializeComponent();
            cashier = cash;
            txtDiscount.Focus();
            this.KeyPreview = true;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Dispose(); }
            else if (e.KeyCode == Keys.Enter) { btnConfirm.PerformClick(); }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double disc = double.Parse(txtTotalPrice.Text) * double.Parse(txtDiscount.Text) * 0.01;
                txtDiscAmount.Text = disc.ToString("#,##0.00");
            }
            catch (Exception)
            {
                txtDiscAmount.Text = "0.00";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Add discount?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.ExecuteNonQuery("sp_UpdateDiscount",
                        new SqlParameter("@disc_percent", double.Parse(txtDiscount.Text)),
                        new SqlParameter("@id", int.Parse(lblId.Text))
                    );

                    cashier.LoadCart();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
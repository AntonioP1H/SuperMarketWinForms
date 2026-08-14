using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProiectSupermarket
{
    public partial class BrandModule : Form
    {
        DBConnect dbcon = new DBConnect();
        Brand brand;
        public BrandModule(Brand br) { InitializeComponent(); brand = br; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save this brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbcon.ExecuteNonQuery("sp_InsertBrand", new SqlParameter("@brand", txtBrand.Text));
                MessageBox.Show("Record has been saved successfully.", "POS");
                Clear();
                brand.LoadBrand();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this Record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbcon.ExecuteNonQuery("sp_UpdateBrand", new SqlParameter("@id", lblId.Text), new SqlParameter("@brand", txtBrand.Text));
                MessageBox.Show("Record has been updated successfully.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                this.Dispose();
            }
        }

        public void Clear() { txtBrand.Clear(); btnUpdate.Enabled = false; btnSave.Enabled = true; txtBrand.Focus(); }
        private void btnCancel_Click(object sender, EventArgs e) => Clear();
        private void picClose_Click(object sender, EventArgs e) => this.Dispose();
    }
}
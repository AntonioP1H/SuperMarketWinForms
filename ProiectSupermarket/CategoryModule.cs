using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProiectSupermarket
{
    public partial class CategoryModule : Form
    {
        DBConnect dbcon = new DBConnect();
        Category category;
        public CategoryModule(Category ct) { InitializeComponent(); category = ct; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save this category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbcon.ExecuteNonQuery("sp_InsertCategory", new SqlParameter("@category", txtCategory.Text));
                MessageBox.Show("Record has been saved successfully.", "POS");
                Clear();
                category.LoadCategory();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this Record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbcon.ExecuteNonQuery("sp_UpdateCategory", new SqlParameter("@id", lblId.Text), new SqlParameter("@category", txtCategory.Text));
                MessageBox.Show("Record has been updated successfully.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                this.Dispose();
            }
        }

        public void Clear() { txtCategory.Clear(); btnUpdate.Enabled = false; btnSave.Enabled = true; txtCategory.Focus(); }
        private void btnCancel_Click(object sender, EventArgs e) => Clear();
        private void picClose_Click(object sender, EventArgs e) => this.Dispose();
    }
}
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProiectSupermarket
{
    public partial class Category : Form
    {
        DBConnect dbcon = new DBConnect();
        public Category() { InitializeComponent(); LoadCategory(); }

        public void LoadCategory()
        {
            dgvCategory.Rows.Clear();
            DataTable dt = dbcon.GetTable("sp_GetCategories");
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                i++;
                dgvCategory.Rows.Add(i, row["id"].ToString(), row["category"].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) => new CategoryModule(this).ShowDialog();

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            string id = dgvCategory[1, e.RowIndex].Value.ToString();

            if (colName == "Delete" && MessageBox.Show("Are you sure you want to delete this Record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbcon.ExecuteNonQuery("sp_DeleteCategory", new SqlParameter("@id", id));
                MessageBox.Show("Record has been deleted successfully.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (colName == "Edit")
            {
                CategoryModule cm = new CategoryModule(this);
                cm.lblId.Text = id;
                cm.txtCategory.Text = dgvCategory[2, e.RowIndex].Value.ToString();
                cm.btnSave.Enabled = false;
                cm.btnUpdate.Enabled = true;
                cm.ShowDialog();
            }
            LoadCategory();
        }
    }
}
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProiectSupermarket
{
    public partial class Brand : Form
    {
        DBConnect dbcon = new DBConnect();
        public Brand() { InitializeComponent(); LoadBrand(); }

        public void LoadBrand()
        {
            dgvBrand.Rows.Clear();
            DataTable dt = dbcon.GetTable("sp_GetBrands");
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                i++;
                dgvBrand.Rows.Add(i, row["id"].ToString(), row["brand"].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) => new BrandModule(this).ShowDialog();

        private void dgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvBrand.Columns[e.ColumnIndex].Name;
            string id = dgvBrand[1, e.RowIndex].Value.ToString();

            if (colName == "Delete" && MessageBox.Show("Are you sure you want to delete this Record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbcon.ExecuteNonQuery("sp_DeleteBrand", new SqlParameter("@id", id));
                MessageBox.Show("Record has been deleted successfully.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (colName == "Edit")
            {
                BrandModule bm = new BrandModule(this);
                bm.lblId.Text = id;
                bm.txtBrand.Text = dgvBrand[2, e.RowIndex].Value.ToString();
                bm.btnSave.Enabled = false;
                bm.btnUpdate.Enabled = true;
                bm.ShowDialog();
            }
            LoadBrand();
        }
    }
}
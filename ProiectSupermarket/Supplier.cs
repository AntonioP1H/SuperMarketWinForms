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

    public partial class Supplier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Supplier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadSupplier();
        }
        public void LoadSupplier()
        {
            int i = 0;
            dgvSupplier.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbSupplier", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvSupplier.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SupplierModule supplierModule = new SupplierModule(this);
            supplierModule.ShowDialog();
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvSupplier.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this Record?", "Delete Record", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Delete from tbSupplier Where id Like '" + dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been deleted successfuly.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (colName == "Edit")
            {
                SupplierModule supplier = new SupplierModule(this);
                supplier.lblId.Text = dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
                supplier.txtSupplier.Text = dgvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
                supplier.txtAddress.Text = dgvSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
                supplier.txtContact.Text = dgvSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
                supplier.txtPhone.Text = dgvSupplier.Rows[e.RowIndex].Cells[5].Value.ToString();
                supplier.txtEmail.Text = dgvSupplier.Rows[e.RowIndex].Cells[6].Value.ToString();
                supplier.txtFax.Text = dgvSupplier.Rows[e.RowIndex].Cells[7].Value.ToString();

                supplier.btnSave.Enabled = false;
                supplier.btnUpdate.Enabled = true;
                supplier.ShowDialog();
            }
            LoadSupplier();
        }
    }
}

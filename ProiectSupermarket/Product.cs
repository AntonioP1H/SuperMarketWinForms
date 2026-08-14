using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
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
    public partial class Product : Form
    {
        DBConnect dbcon = new DBConnect();

        public Product()
        {
            InitializeComponent();
            LoadProduct();
        }

        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();

            DataTable dt = dbcon.GetTable(
                "SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.reorder " +
                "FROM tbProduct AS p " +
                "INNER JOIN tbBrand AS b ON b.id = p.bid " +
                "INNER JOIN tbCategory AS c ON c.id = p.cid " +
                "WHERE CONCAT(p.pdesc, b.brand, c.category) LIKE @search",
                new SqlParameter("@search", "%" + txtSearch.Text + "%")
            );

            foreach (DataRow row in dt.Rows)
            {
                i++;
                dgvProduct.Rows.Add(i, row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModule productModule = new ProductModule(this);
            productModule.ShowDialog();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;

            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this Record?", "Delete Record", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string pcode = dgvProduct[1, e.RowIndex].Value.ToString();
                    dbcon.ExecuteNonQuery("DELETE FROM tbProduct WHERE pcode = @pcode", new SqlParameter("@pcode", pcode));
                    MessageBox.Show("Product has been deleted successfully.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (colName == "Edit")
            {
                ProductModule product = new ProductModule(this);
                product.txtPcode.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                product.txtBarcode.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                product.txtPdesc.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                product.cboBrand.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                product.cboCategory.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                product.txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                product.UDReOrder.Value = int.Parse(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString());

                product.txtPcode.Enabled = false;
                product.btnSave.Enabled = false;
                product.btnUpdate.Enabled = true;
                product.ShowDialog();
            }
            else if (colName == "Column2")
            {
                string id = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                object result = dbcon.ExecuteScalar("sp_GetForPcode", new SqlParameter("@pcode", id));

                if (result != null && result != DBNull.Value)
                {
                    decimal total = Convert.ToDecimal(result);
                    txtTotal.Text = total.ToString();
                }
                else
                {
                    txtTotal.Text = "0.00";
                }
            }
            LoadProduct();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = dbcon.GetTable("SELECT * FROM tbProduct");
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.WriteXml(@"C:\Users\antonio\source\repos\WinForms\ProiectSupermarket\ProiectSupermarket\tbProduct.xml", XmlWriteMode.WriteSchema);
            MessageBox.Show("Data exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xmlFile = @"C:\Users\antonio\source\repos\WinForms\ProiectSupermarket\ProiectSupermarket\tbProduct.xml";
            DataSet ds = new DataSet();
            ds.ReadXml(xmlFile);

            using (SqlConnection sqlcon = new SqlConnection(dbcon.myConnection()))
            {
                sqlcon.Open();
                using (SqlBulkCopy bulk = new SqlBulkCopy(sqlcon))
                {
                    bulk.DestinationTableName = "tbProduct";
                    bulk.ColumnMappings.Add("pcode", "pcode");
                    bulk.ColumnMappings.Add("barcode", "barcode");
                    bulk.ColumnMappings.Add("pdesc", "pdesc");
                    bulk.ColumnMappings.Add("bid", "bid");
                    bulk.ColumnMappings.Add("cid", "cid");
                    bulk.ColumnMappings.Add("price", "price");
                    bulk.ColumnMappings.Add("qty", "qty");
                    bulk.ColumnMappings.Add("reorder", "reorder");

                    bulk.WriteToServer(ds.Tables[0]);
                }
            }
            LoadProduct();
            MessageBox.Show("Data imported successfully!", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
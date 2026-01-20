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
    public partial class ProductModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "Point of sales";
        Product product;
        public ProductModule(Product pd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            product = pd;
            LoadCategory();
            LoadBrand();
        }
        public void LoadCategory()
        {
            cboCategory.Items.Clear();
            cboCategory.DataSource = dbcon.getTable("SELECT * from tbCategory");
            cboCategory.DisplayMember = "category";
            cboCategory.ValueMember = "id";
        }
        public void LoadBrand()
        {
            cboBrand.Items.Clear();
            cboBrand.DataSource = dbcon.getTable("SELECT * from tbBrand");
            cboBrand.DisplayMember = "brand";
            cboBrand.ValueMember = "id";
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbProduct(pcode, barcode, pdesc, bid, cid, price, reorder)Values(@pcode,@barcode,@pdesc,@bid,@cid,@price,@reorder)", cn);
                    cm.Parameters.Add("@pcode", SqlDbType.VarChar).Value = txtPcode.Text;
                    cm.Parameters.Add("@barcode", SqlDbType.VarChar).Value = txtBarcode.Text;
                    cm.Parameters.Add("@pdesc", SqlDbType.VarChar).Value = txtPdesc.Text;
                    cm.Parameters.Add("@bid", SqlDbType.Int).Value = Convert.ToInt32(cboBrand.SelectedValue);
                    cm.Parameters.Add("@cid", SqlDbType.Int).Value = Convert.ToInt32(cboCategory.SelectedValue);
                    cm.Parameters.Add("@price", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPrice.Text);
                    cm.Parameters.Add("@reorder", SqlDbType.Int).Value = Convert.ToInt32(UDReOrder.Value);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been saved successfuly.", stitle);
                    Clear();

                }
                product.LoadProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            txtPcode.Clear();
            txtBarcode.Clear();
            txtPdesc.Clear();
            txtPrice.Clear();
            cboBrand.SelectedIndex = 0;
            cboCategory.SelectedIndex = 0;
            UDReOrder.Value = 1;

            txtPcode.Enabled = true;
            txtPcode.Focus();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Record?", "Update Record", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbProduct SET barcode=@barcode, pdesc=@pdesc, bid=@bid, cid=@cid, price=@price,reorder=@reorder WHERE pcode = @pcode)", cn);
                    cm.Parameters.Add("@pcode", SqlDbType.VarChar).Value = txtPcode.Text;
                    cm.Parameters.Add("@barcode", SqlDbType.VarChar).Value = txtBarcode.Text;
                    cm.Parameters.Add("@pdesc", SqlDbType.VarChar).Value = txtPdesc.Text;
                    cm.Parameters.Add("@bid", SqlDbType.Int).Value = Convert.ToInt32(cboBrand.SelectedValue);
                    cm.Parameters.Add("@cid", SqlDbType.Int).Value = Convert.ToInt32(cboCategory.SelectedValue);
                    cm.Parameters.Add("@price", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPrice.Text);
                    cm.Parameters.Add("@reorder", SqlDbType.Int).Value = Convert.ToInt32(UDReOrder.Value);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been updated.", stitle);
                    Clear();
                    this.Dispose();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

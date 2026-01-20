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
    public partial class SupplierModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "Point of sales";
        Supplier supplier;
        public SupplierModule(Supplier sp)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            supplier = sp;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Clear()
        {
            txtSupplier.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtFax.Clear();

            txtSupplier.Focus();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Record", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbSupplier (supplier, address, contactperson, phone, email, fax) Values(@supplier,@address,@contactperson,@phone,@email,@fax)", cn);
                    cm.Parameters.Add("@supplier", SqlDbType.VarChar).Value = txtSupplier.Text;
                    cm.Parameters.Add("@address", SqlDbType.VarChar).Value = txtAddress.Text;
                    cm.Parameters.Add("@contactperson", SqlDbType.VarChar).Value = txtContact.Text;
                    cm.Parameters.Add("@phone", SqlDbType.VarChar).Value = txtPhone.Text;
                    cm.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;
                    cm.Parameters.Add("@fax", SqlDbType.VarChar).Value = txtFax.Text;
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been saved successfuly.", stitle);
                    Clear();

                }
                supplier.LoadSupplier();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    cm = new SqlCommand("UPDATE tbSupplier SET supplier=@supplier, address=@address, contactperson=@contactperson, phone=@phone, email=@email, fax=@fax WHERE id = @id", cn);
                    cm.Parameters.Add("@id", SqlDbType.VarChar).Value = lblId.Text;
                    cm.Parameters.Add("@supplier", SqlDbType.VarChar).Value = txtSupplier.Text;
                    cm.Parameters.Add("@address", SqlDbType.VarChar).Value = txtAddress.Text;
                    cm.Parameters.Add("@contactperson", SqlDbType.VarChar).Value = txtContact.Text;
                    cm.Parameters.Add("@phone", SqlDbType.VarChar).Value = txtPhone.Text;
                    cm.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;
                    cm.Parameters.Add("@fax", SqlDbType.VarChar).Value = txtFax.Text;
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been updated.", stitle);
                    Clear();
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

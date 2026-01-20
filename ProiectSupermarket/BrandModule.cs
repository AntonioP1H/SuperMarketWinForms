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
    public partial class BrandModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Brand brand;
        public BrandModule(Brand br)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            brand = br;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbBrand(brand)Values(@brand)", cn);
                    cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been saved successfuly.", "POS");
                    Clear();
                    
                }
                brand.LoadBrand();
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

        public void Clear()
        {
            txtBrand.Clear();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            txtBrand.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this Record?", "Update Record", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tbBrand SET brand = @brand WHERE id Like '" + lblId.Text + "'", cn);
                cm.Parameters.AddWithValue("@brand",txtBrand.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been updated successfuly.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                this.Dispose();
            }
        }
    }
}

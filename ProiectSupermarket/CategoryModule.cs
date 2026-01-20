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
    public partial class CategoryModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Category category;
        public CategoryModule(Category ct)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            category = ct;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Clear()
        {
            txtCategory.Clear();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            txtCategory.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbCategory(category)Values(@category)", cn);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been saved successfuly.", "POS");
                    Clear();
                    
                }
                category.LoadCategory();
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
            if (MessageBox.Show("Are you sure you want to update this Record?", "Update Record", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tbCategory SET category = @category WHERE id Like '" + lblId.Text + "'", cn);
                cm.Parameters.AddWithValue("@category", txtCategory.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been updated successfuly.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                this.Dispose();
            }
        }

    }
}

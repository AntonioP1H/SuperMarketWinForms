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
    public partial class Brand : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Brand()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadBrand();
        }

        //Get data from tbBrand
        public void LoadBrand()
        {
            int i = 0;
            dgvBrand.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select * from tbBrand ORDER BY brand", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvBrand.Rows.Add(i, dr["id"].ToString(), dr["brand"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BrandModule moduleForm = new BrandModule(this);
            moduleForm.ShowDialog();
        }

        private void dgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvBrand.Columns[e.ColumnIndex].Name;
            if(colName == "Delete") 
            {
                if (MessageBox.Show("Are you sure you want to delete this Record?", "Delete Record", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes) {
                    cn.Open();
                    cm = new SqlCommand("Delete from tbBrand Where id Like '" + dgvBrand[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been deleted successfuly.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (colName == "Edit")
            {
                BrandModule brandModule = new BrandModule(this);
                brandModule.lblId.Text = dgvBrand[1, e.RowIndex].Value.ToString();
                brandModule.txtBrand.Text = dgvBrand[2, e.RowIndex].Value.ToString();
                brandModule.btnSave.Enabled = false;
                brandModule.btnUpdate.Enabled = true;
                brandModule.ShowDialog();
            }
            LoadBrand();
        }
    }
}

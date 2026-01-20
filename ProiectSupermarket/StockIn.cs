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
    public partial class StockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public StockIn()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadSupplier();
            GetRefNo();
            LoadStockIn();
        }
        public void GetRefNo()
        {
            Random rnd = new Random();
            txtRefNo.Clear();
            txtRefNo.Text += rnd.Next();
        }
        public void LoadStockIn()
        {
            int i = 0;
            dgvStockIn.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM vwStockIn", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvStockIn.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void LoadSupplier()
        {
            cbSupplier.Items.Clear();
            cbSupplier.DataSource = dbcon.getTable("select * from tbSupplier");
            cbSupplier.DisplayMember = "supplier";
        }

        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbSupplier WHERE supplier LIKE '" + cbSupplier.Text + "'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                lblId.Text = dr["id"].ToString();
                txtConPerson.Text = dr["contactperson"].ToString();
                txtAddress.Text = dr["address"].ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void cbSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void linGenerate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetRefNo();
        }

        private void linProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductStockIn producstockin = new ProductStockIn(this);
            producstockin.ShowDialog();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this record?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvStockIn.RowCount; i++)
                    {
                        cn.Open();
                        cm = new SqlCommand("UPDATE tbProduct SET qty = qty + " +
                            int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString()) + " WHERE pcode LIKE '" +
                            dgvStockIn.Rows[i].Cells[3].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("UPDATE tbStockIn SET qty = qty + " +
                            int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString()) + ", status='Done' WHERE id LIKE '" +
                            dgvStockIn.Rows[i].Cells[3].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                    Clear();
                    LoadStockIn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            txtRefNo.Clear();
            txtStockInBy.Clear();
            dtStockIn.Value = DateTime.Now;
        }

        private void dgvStockIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvStockIn.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Remove this item?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                ==
                DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbStockIn WHERE id='" + dgvStockIn.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn); cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item has been successfully removed", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information); LoadStockIn();
                }
            }
        }
    }
}
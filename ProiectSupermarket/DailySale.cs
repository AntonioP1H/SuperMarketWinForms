using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProiectSupermarket
{
    public partial class DailySale : Form
    {
        DBConnect dbcon = new DBConnect();
        public string solduser;

        public DailySale()
        {
            InitializeComponent();
            LoadCashier();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadCashier()
        {
            cbCashier.Items.Clear();
            cbCashier.Items.Add("All cashiers");

            DataTable dt = dbcon.GetTable("SELECT username FROM tbUser WHERE role LIKE 'Cashier'");
            foreach (DataRow row in dt.Rows)
            {
                cbCashier.Items.Add(row["username"].ToString());
            }
            if (cbCashier.Items.Count > 0) cbCashier.SelectedIndex = 0;
        }

        public void LoadSold()
        {
            try
            {
                dgvSold.Rows.Clear();
                int i = 0;
                double total = 0;

                string cashierFilter = string.IsNullOrEmpty(cbCashier.Text) ? "All cashiers" : cbCashier.Text;

                DataTable dt = dbcon.GetTable("sp_GetDailySales",
                    new SqlParameter("@dateFrom", dtFrom.Value),
                    new SqlParameter("@dateTo", dtTo.Value),
                    new SqlParameter("@cashier", cashierFilter)
                );

                foreach (DataRow row in dt.Rows)
                {
                    i++;
                    double rowTotal = Convert.ToDouble(row["total"]);
                    total += rowTotal;

                    dgvSold.Rows.Add(
                        i,
                        row["id"].ToString(),
                        row["transno"].ToString(),
                        row["pcode"].ToString(),
                        row["pdesc"].ToString(),
                        row["price"].ToString(),
                        row["qty"].ToString(),
                        row["disc"].ToString(),
                        rowTotal.ToString("#,##0.00")
                    );
                }
                lblTotal.Text = total.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbCashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSold();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadSold();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            LoadSold();
        }

        private void dgvSold_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Dispose(); }
        }

        private void dgvSold_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string colname = dgvSold.Columns[e.ColumnIndex].Name;

            if (colname == "Cancel")
            {
                CancelOrder cancelOrder = new CancelOrder(this);
                cancelOrder.txtId.Text = dgvSold.Rows[e.RowIndex].Cells[1].Value.ToString();
                cancelOrder.txtTransno.Text = dgvSold.Rows[e.RowIndex].Cells[2].Value.ToString();
                cancelOrder.txtPcode.Text = dgvSold.Rows[e.RowIndex].Cells[3].Value.ToString();
                cancelOrder.txtDesc.Text = dgvSold.Rows[e.RowIndex].Cells[4].Value.ToString();
                cancelOrder.txtPrice.Text = dgvSold.Rows[e.RowIndex].Cells[5].Value.ToString();
                cancelOrder.txtQty.Text = dgvSold.Rows[e.RowIndex].Cells[6].Value.ToString();
                cancelOrder.txtDisc.Text = dgvSold.Rows[e.RowIndex].Cells[7].Value.ToString();
                cancelOrder.txtTotal.Text = dgvSold.Rows[e.RowIndex].Cells[8].Value.ToString();
                cancelOrder.txtCancelBy.Text = solduser;
                cancelOrder.ShowDialog();
            }
        }
    }
}
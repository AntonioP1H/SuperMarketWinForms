using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProiectSupermarket
{
    public partial class Cashier : Form
    {
        DBConnect dbcon = new DBConnect();
        public string transno = "";
        string id, price;

        public Cashier()
        {
            InitializeComponent();
            GetTranNo();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void slide(Button button)
        {
            panelSlide.BackColor = Color.White;
            panelSlide.Height = button.Height;
            panelSlide.Top = button.Top;
        }

        #region Buttons
        private void btnNTran_Click(object sender, EventArgs e)
        {
            slide(btnNTran);
            GetTranNo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            slide(btnSearch);
            LookUpProduct lookup = new LookUpProduct(this);
            lookup.LoadProduct();
            lookup.ShowDialog();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            slide(btnDiscount);
            Discount discount = new Discount(this);
            discount.lblId.Text = id;
            discount.txtTotalPrice.Text = price;
            discount.ShowDialog();
        }

        private void btnSettle_Click(object sender, EventArgs e)
        {
            slide(btnSettle);
            SettlePayment settle = new SettlePayment(this);
            settle.txtSale.Text = lblDisplayTotal.Text;
            settle.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            slide(btnClear);
            if (MessageBox.Show("Remove all items from cart?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbcon.ExecuteNonQuery("sp_ClearCartByTransNo", new SqlParameter("@transno", lblTranNo.Text));
                MessageBox.Show("All items have been removed from cart", "Remove item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCart();
            }
        }

        private void btnDSales_Click(object sender, EventArgs e)
        {
            slide(btnDSales);
            DailySale dailysale = new DailySale();
            dailysale.solduser = lblUsername.Text;
            dailysale.ShowDialog();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            slide(btnPass);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            slide(btnLogout);
            if (dgvCash.Rows.Count > 0)
            {
                MessageBox.Show("Finish transactions before exiting?", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Quit App?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
        }
        #endregion Buttons

        public void LoadCart()
        {
            try
            {
                bool hascart = false;
                int i = 0;
                double total = 0;
                double discount = 0;
                dgvCash.Rows.Clear();

                DataTable dt = dbcon.GetTable("sp_LoadCartItems", new SqlParameter("@transno", lblTranNo.Text));
                foreach (DataRow row in dt.Rows)
                {
                    i++;
                    double rowTotal = Convert.ToDouble(row["total"]);
                    double rowDisc = Convert.ToDouble(row["disc"]);
                    total += rowTotal;
                    discount += rowDisc;

                    dgvCash.Rows.Add(i, row["id"].ToString(), row["pcode"].ToString(), row["pdesc"].ToString(), row["price"].ToString(), row["qty"].ToString(), row["disc"].ToString(), rowTotal.ToString("#,##0.00"));
                    hascart = true;
                }

                lblSalesTotal.Text = total.ToString("#,##0.00");
                lblDiscount.Text = discount.ToString("#,##0.00");
                GetCartTotal(total, discount);

                btnClear.Enabled = hascart;
                btnSettle.Enabled = hascart;
                btnDiscount.Enabled = hascart;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetCartTotal(double totalSales, double totalDiscount)
        {
            double sales = totalSales;
            double vat = sales * 0.12;
            double vatable = sales - vat;

            lblVat.Text = vat.ToString("#,##0.00");
            lblVatable.Text = vatable.ToString("#,##0.00");
            lblDisplayTotal.Text = sales.ToString("#,##0.00");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public void GetTranNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                object result = dbcon.ExecuteScalar("sp_GetLatestTranNo", new SqlParameter("@datePrefix", sdate));

                if (result != null && result != DBNull.Value)
                {
                    string transno = result.ToString();
                    int count = int.Parse(transno.Substring(8, 4));
                    lblTranNo.Text = sdate + (count + 1);
                }
                else
                {
                    lblTranNo.Text = sdate + "1001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBarcode.Text) || txtBarcode.Text.Length < 5) return;

                int _qty = string.IsNullOrEmpty(txtQty.Text) ? 1 : int.Parse(txtQty.Text);
                DataTable dt = dbcon.GetTable("sp_GetProductByBarcode", new SqlParameter("@barcode", txtBarcode.Text));

                if (dt.Rows.Count > 0)
                {
                    string _pcode = dt.Rows[0]["pcode"].ToString();
                    double _price = Convert.ToDouble(dt.Rows[0]["price"]);
                    AddToCart(_pcode, _price, _qty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddToCart(string _pcode, double _price, int _qty)
        {
            try
            {
                DataTable dtProd = dbcon.GetTable("sp_GetProductTotalQtyByPcode", new SqlParameter("@pcode", _pcode));
                int stockQty = dtProd.Rows.Count > 0 && dtProd.Rows[0]["qty"] != DBNull.Value ? Convert.ToInt32(dtProd.Rows[0]["qty"]) : 0;

                DataTable dtCart = dbcon.GetTable("sp_CheckCartItem", new SqlParameter("@transno", lblTranNo.Text), new SqlParameter("@pcode", _pcode));
                int cart_qty = 0;
                bool found = false;

                if (dtCart.Rows.Count > 0)
                {
                    cart_qty = Convert.ToInt32(dtCart.Rows[0]["qty"]);
                    found = true;
                }

                if (stockQty < (_qty + (found ? cart_qty : 0)))
                {
                    MessageBox.Show("Unable to proceed. Remaining quantity is " + stockQty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (found)
                {
                    dbcon.ExecuteNonQuery("sp_UpdateCartQuantityAdd",
                        new SqlParameter("@transno", lblTranNo.Text),
                        new SqlParameter("@pcode", _pcode),
                        new SqlParameter("@addQty", _qty));
                }
                else
                {
                    dbcon.ExecuteNonQuery("sp_AddToCart",
                        new SqlParameter("@transno", lblTranNo.Text),
                        new SqlParameter("@pcode", _pcode),
                        new SqlParameter("@price", _price),
                        new SqlParameter("@qty", _qty),
                        new SqlParameter("@sdate", DateTime.Now),
                        new SqlParameter("@cashier", lblUsername.Text));
                }

                txtBarcode.Clear();
                txtBarcode.Focus();
                LoadCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCash_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCash.CurrentRow == null || dgvCash.CurrentRow.Index < 0) return;

            int i = dgvCash.CurrentRow.Index;
            id = dgvCash[1, i].Value?.ToString() ?? "";
            price = dgvCash[7, i].Value?.ToString() ?? "0.00";
        }

        private void dgvCash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string colName = dgvCash.Columns[e.ColumnIndex].Name;
            string cartId = dgvCash.Rows[e.RowIndex].Cells[1].Value?.ToString();
            string pcode = dgvCash.Rows[e.RowIndex].Cells[2].Value?.ToString();

            int qtyInput;
            if (!int.TryParse(txtQty.Text, out qtyInput))
            {
                qtyInput = 1;
            }

            if (colName == "Delete")
            {
                if (MessageBox.Show("Remove item from cart?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.ExecuteNonQuery("sp_DeleteCartItemById", new SqlParameter("@id", cartId));
                    MessageBox.Show("Item has been removed from cart.", "Remove item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart();
                }
            }
            else if (colName == "colAdd")
            {
                DataTable dt = dbcon.GetTable("sp_GetProductTotalQtyByPcode", new SqlParameter("@pcode", pcode));
                int stockQty = dt.Rows.Count > 0 && dt.Rows[0]["qty"] != DBNull.Value ? Convert.ToInt32(dt.Rows[0]["qty"]) : 0;
                int currentCartQty = Convert.ToInt32(dgvCash.Rows[e.RowIndex].Cells[5].Value);

                if ((currentCartQty + qtyInput) <= stockQty)
                {
                    dbcon.ExecuteNonQuery("sp_UpdateCartQuantityAdd",
                        new SqlParameter("@transno", lblTranNo.Text),
                        new SqlParameter("@pcode", pcode),
                        new SqlParameter("@addQty", qtyInput));
                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Remaining qty on hand is " + stockQty + "!", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (colName == "colReduce")
            {
                int currentCartQty = Convert.ToInt32(dgvCash.Rows[e.RowIndex].Cells[5].Value);

                if ((currentCartQty - qtyInput) >= 1)
                {
                    dbcon.ExecuteNonQuery("sp_UpdateCartQuantityReduce",
                        new SqlParameter("@transno", lblTranNo.Text),
                        new SqlParameter("@pcode", pcode),
                        new SqlParameter("@reduceQty", qtyInput));
                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Cannot reduce below 1. Use Delete to remove the item entirely.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
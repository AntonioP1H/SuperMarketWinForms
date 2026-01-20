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
    public partial class Cashier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Cashier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            GetTranNo();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application?", "Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        }

        private void btnSettle_Click(object sender, EventArgs e)
        {
            slide(btnSettle);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            slide(btnClear);
        }

        private void btnDSales_Click(object sender, EventArgs e)
        {
            slide(btnDSales);
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            slide(btnPass);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            slide(btnLogout);
        }
        #endregion Buttons

        public void LoadCart()
        {
            int i = 0;
            double total = 0;
            double discount = 0;
            dgvCash.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT c.id, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total FROM tbCart AS c " +
                "INNER JOIN tbProduct AS p ON c.pcode=p.pcode WHERE c.transno LIKE @transno and c.status LIKE 'Pending'",cn);
            cm.Parameters.AddWithValue("@transno",lblTranNo.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                total += Convert.ToDouble(dr["total"].ToString());
                discount += Convert.ToDouble(dr["disc"].ToString());
                dgvCash.Rows.Add(i, dr["id"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00" ));
            }
            dr.Close();
            cn.Close();
            lblSalesTotal.Text = total.ToString("#,##0.00");
            lblDiscount.Text = discount.ToString("#,##0.00");
            GetCartTotal();
        }
        public void GetCartTotal()
        {
            double discount = double.Parse(lblDiscount.Text);
            double sales = double.Parse(lblSalesTotal.Text) - discount;
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
                int count;
                string transno;
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 transno FROM tbCart WHERE transno LIKE '" + sdate + "%' ORDER BY id desc", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse((transno.Substring(8, 4)));
                    lblTranNo.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "1001";
                    lblTranNo.Text = transno;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

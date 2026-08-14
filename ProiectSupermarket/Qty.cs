using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProiectSupermarket
{
    public partial class Qty : Form
    {
        DBConnect dbcon = new DBConnect();
        private string pcode;
        private decimal price;
        private string transno;
        private Cashier cashier;
        private string user;

        public Qty(Cashier cash)
        {
            InitializeComponent();
            cashier = cash;
        }

        public void ProductDetails(string pcod, decimal prc, string tno, string usr)
        {
            pcode = pcod;
            price = prc;
            transno = tno;
            user = usr;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (string.IsNullOrEmpty(txtQty.Text)) return;
                int qty = int.Parse(txtQty.Text);

                dbcon.ExecuteNonQuery("sp_AddToCart",
                    new SqlParameter("@transno", transno),
                    new SqlParameter("@pcode", pcode),
                    new SqlParameter("@price", price),
                    new SqlParameter("@qty", qty),
                    new SqlParameter("@cashier", user)
                );

                cashier.LoadCart();
                this.Dispose();
            }
        }
    }
}
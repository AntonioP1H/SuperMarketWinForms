using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProiectSupermarket
{
    public partial class Void : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        CancelOrder cancelOrder;

        public Void(CancelOrder cancel)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            cancelOrder = cancel;
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == cancelOrder.txtCancelBy.Text)
                {
                    MessageBox.Show("Void and Cancel By can't be the same.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string user;
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tbUser WHERE username = @username AND password = @password", cn);
                cm.Parameters.AddWithValue("@username", txtUsername.Text);
                cm.Parameters.AddWithValue("@password", txtPass.Text);
                dr = cm.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    user = dr["username"].ToString();
                    dr.Close();
                    cn.Close();

                    SaveCancelOrder(user);

                    if (cancelOrder.cbInventory.Text == "yes")
                    {
                        dbcon.ExecuteQuery("UPDATE tbProduct SET qty = qty + " + cancelOrder.udCancelQty.Value + " WHERE pcode = '" + cancelOrder.txtPcode.Text + "'");
                    }

                    int originalQty = int.Parse(cancelOrder.txtQty.Text);
                    int cancelQty = (int)cancelOrder.udCancelQty.Value;
                    int remainingQty = originalQty - cancelQty;

                    if (remainingQty > 0)
                    {
                        double originalDisc = double.Parse(cancelOrder.txtDisc.Text);
                        double originalTotal = double.Parse(cancelOrder.txtTotal.Text);

                        double newDisc = (originalDisc / originalQty) * remainingQty;
                        double newTotal = (originalTotal / originalQty) * remainingQty;

                        dbcon.ExecuteQuery("UPDATE tbCart SET qty = " + remainingQty + ", disc = " + newDisc + ", total = " + newTotal + " WHERE id = '" + cancelOrder.txtId.Text + "'");
                    }
                    else
                    {
                        dbcon.ExecuteQuery("UPDATE tbCart SET qty = 0, disc = 0, total = 0, status = 'Cancelled' WHERE id = '" + cancelOrder.txtId.Text + "'");
                    }

                    MessageBox.Show("Order transaction successfully cancelled!", "Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    cancelOrder.ReloadSoldList();
                    cancelOrder.Dispose();
                }
                else
                {
                    dr.Close();
                    cn.Close();
                    MessageBox.Show("Invalid Username or Password for authorization!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveCancelOrder(string user)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("insert into tbCancel (transno, pcode, price, qty, total, sdate, voidby, cancelledby, reason, action) values (@transno, @pcode, @price, @qty, @total, @sdate, @voidby, @cancelledby, @reason, @action)", cn);

                cm.Parameters.AddWithValue("@transno", cancelOrder.txtTransno.Text);
                cm.Parameters.AddWithValue("@pcode", cancelOrder.txtPcode.Text);
                cm.Parameters.AddWithValue("@price", double.Parse(cancelOrder.txtPrice.Text));
                cm.Parameters.AddWithValue("@qty", int.Parse(cancelOrder.txtQty.Text));
                cm.Parameters.AddWithValue("@total", double.Parse(cancelOrder.txtTotal.Text));
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@voidby", user);
                cm.Parameters.AddWithValue("@cancelledby", cancelOrder.txtCancelBy.Text);
                cm.Parameters.AddWithValue("@reason", cancelOrder.txtReason.Text);
                cm.Parameters.AddWithValue("@action", cancelOrder.cbInventory.Text);
                cm.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                throw;
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
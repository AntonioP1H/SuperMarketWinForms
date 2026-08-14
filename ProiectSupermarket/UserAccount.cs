using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProiectSupermarket
{
    public partial class UserAccount : Form
    {
        DBConnect dbcon = new DBConnect();
        public UserAccount() { InitializeComponent(); }

        public void Clear() { txtName.Clear(); txtPass.Clear(); txtUsername.Clear(); cbRole.Text = ""; txtUsername.Focus(); }

        private void btnAccSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text != txtRePass.Text)
                {
                    MessageBox.Show("Password does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dbcon.ExecuteNonQuery("sp_InsertUser",
                    new SqlParameter("@username", txtUsername.Text),
                    new SqlParameter("@password", txtPass.Text),
                    new SqlParameter("@role", cbRole.Text),
                    new SqlParameter("@name", txtName.Text)
                );
                MessageBox.Show("Record has been saved successfully.");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAccCancel_Click(object sender, EventArgs e) => Clear();
    }
}
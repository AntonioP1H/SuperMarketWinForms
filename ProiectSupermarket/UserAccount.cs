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
    public partial class UserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public UserAccount()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }
        public void Clear()
        {
            txtName.Clear();
            txtPass.Clear();
            txtUsername.Clear();
            cbRole.Text = "";
            txtUsername.Focus();
        }
        private void btnAccSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text != txtRePass.Text) { 
                    MessageBox.Show("Password does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cm = new SqlCommand("INSERT INTO tbUser(username, password, role, name)Values(@username,@password,@role,@name)", cn);
                cm.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUsername.Text;
                cm.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPass.Text;
                cm.Parameters.Add("@role", SqlDbType.VarChar).Value = cbRole.Text;
                cm.Parameters.Add("@name", SqlDbType.VarChar).Value = txtName.Text;
                cn.Open();
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been saved successfuly.");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}

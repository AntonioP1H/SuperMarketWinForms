using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProiectSupermarket
{
    public partial class Login : Form
    {
        DBConnect dbcon = new DBConnect();
        public string _pass = "";
        public bool _isactive;

        public Login() { InitializeComponent(); }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = dbcon.GetTable("sp_AuthenticateUser",
                    new SqlParameter("@username", txtName.Text),
                    new SqlParameter("@password", txtPass.Text));

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    string _username = row["username"].ToString();
                    string _name = row["name"].ToString();
                    string _role = row["role"].ToString();
                    _pass = row["password"].ToString();
                    _isactive = bool.Parse(row["isactive"].ToString());

                    if (!_isactive)
                    {
                        MessageBox.Show("Account is inactive. Unable to login", "Inactive account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    MessageBox.Show("Welcome.", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Clear(); txtPass.Clear(); this.Hide();

                    if (_role == "Cashier")
                    {
                        Cashier cashier = new Cashier();
                        cashier.lblUsername.Text = _username;
                        cashier.lblname.Text = _name + " | " + _role;
                        cashier.ShowDialog();
                    }
                    else
                    {
                        Form1 main = new Form1();
                        main.lblUsername.Text = _username;
                        main.lblName.Text = _name + " | " + _role;
                        main.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username or password !", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picClose_Click(object sender, EventArgs e) { if (MessageBox.Show("Quit App?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Application.Exit(); }
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == 13) btnLogin.PerformClick(); }
    }
}
using System;
using System.Data;
using System.Windows.Forms;
using StudentManagementSystem2.Database;

namespace StudentManagementSystem2.Forms
{
    public partial class LoginForm : Form
    {
        // Stores logged in user's role for access control
        public static string LoggedInRole = "";
        public static string LoggedInUser = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        // Login button click event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate empty fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check credentials in database
            string query = "SELECT * FROM Users WHERE Username=@username AND Password=@password AND IsActive=1";
            MySql.Data.MySqlClient.MySqlParameter[] parameters = {
                new MySql.Data.MySqlClient.MySqlParameter("@username", username),
                new MySql.Data.MySqlClient.MySqlParameter("@password", password)
            };

            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                // Save logged in user info
                LoggedInRole = result.Rows[0]["Role"].ToString();
                LoggedInUser = result.Rows[0]["Username"].ToString();

                MessageBox.Show("Login Successful! Welcome " + LoggedInUser,
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //TODO: Uncomment when DashboardForm is created
                 DashboardForm dashboard = new DashboardForm();
                 dashboard.Show();
                 this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Allow pressing Enter to login
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnLogin_Click(sender, e);
        }
    }
}
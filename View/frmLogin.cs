using System.Data.SqlClient;
using FisheriesAgency.Properties;
using FisheriesAgency.Utils;
using FisheriesAgency.View;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FisheriesAgency
{

    public partial class frmLogin : Form
    {
        public int UserID { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
        }
        private int GetUserID(string username)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT UserID FROM [User] WHERE Username = @username", connection);
                command.Parameters.AddWithValue("@username", username);

                connection.Open();
                object userIDObj = command.ExecuteScalar();
                connection.Close();

                if (userIDObj != null && userIDObj != DBNull.Value)
                {
                    return (int)userIDObj;
                }

                return -1; // Return -1 if the user ID is not found
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == string.Empty && password == string.Empty)
            {
                MessageBox.Show("Please enter your username and password");
            }
            else if (username == string.Empty)
            {
                MessageBox.Show("Please enter your username");
            }
            else if (password == string.Empty)
            {
                MessageBox.Show("Please enter your password");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand("SELECT isAdministrator FROM [User] WHERE Username = @username AND Password = @password", connection);

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();
                    object isAdminObj = command.ExecuteScalar();
                    connection.Close();

                    if (isAdminObj != null && isAdminObj != DBNull.Value)
                    {
                        bool isAdmin = (bool)isAdminObj;
                        if (isAdmin)
                        {
                            this.Hide();
                            frmAdminsPanel frmAdminsPanel = new frmAdminsPanel();
                            frmAdminsPanel.ShowDialog();
                        }
                        else
                        {
                            int userID = GetUserID(username); // Add this method to retrieve the user ID

                            this.Hide();
                            frmUser frmUser = new frmUser();
                            frmUser.UserID = userID; // Pass the user ID to the frmUser form
                            frmUser.ShowDialog();
                        }
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
                }
            }
        }


        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            PasswordToggle.Toggle(txtPassword, btnViewPassword);
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnLogin);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnLogin);
        }

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnRegister);
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnRegister);
        }
        private void btnLogin_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnLogin);
        }

        private void btnLogin_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnLogin);
        }
        private void btnRegister_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnRegister);
        }

        private void btnRegister_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnRegister);
        }
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                btnRegister.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txtPassword.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (txtPassword.Text == string.Empty)
                {
                    txtPassword.Focus();
                }
                else if (txtUsername.Text == string.Empty)
                {
                    txtUsername.Focus();
                }
                else
                {
                    btnLogin.Focus();
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtUsername.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                btnLogin.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (txtUsername.Text == string.Empty)
                {
                    txtUsername.Focus();
                }
                if (txtPassword.Text == string.Empty)
                {
                    txtPassword.Focus();
                }
                else
                {
                    btnLogin.Focus();
                }
            }
        }

        private void btnViewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtUsername.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txtPassword.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                btnLogin.Focus();
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtPassword.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                btnViewPassword.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                btnRegister.Focus();
            }
        }

        private void btnRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                btnLogin.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txtUsername.Focus();
            }
        }
    }

}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FisheriesAgency.Model;
using FisheriesAgency.Controller;
using System.Data.SqlClient;
using System.ComponentModel.Design;
using FisheriesAgency.Utils;

namespace FisheriesAgency.View
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Logout.LogoutHelper(this);
        }

        //Making password visible
        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            PasswordToggle.ToggleRegister(txtPassword, txtConfirmPassword, btnViewPassword);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password) && string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please enter your username, password and confirm password");
            }
            else if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your username and password");
            }
            else if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please enter your username and confirm password");
            }
            else if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter your username");
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your password");
            }
            else if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please enter your confirm password");
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Your password and confirm password must be the same");
            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(Program.connectionString))
                    {
                        connection.Open();
                        string selectSql = "SELECT COUNT(*) FROM [User] WHERE Username = @username";
                        using (SqlCommand selectCommand = new SqlCommand(selectSql, connection))
                        {
                            selectCommand.Parameters.AddWithValue("@username", username);
                            int count = (int)selectCommand.ExecuteScalar();
                            if (count > 0)
                            {
                                txtUsername.Focus();
                                txtUsername.Text = string.Empty;
                                MessageBox.Show($"Username \"{username}\" already exists. Please choose a different username.");
                            }
                            else
                            {
                                string insertSql = "INSERT INTO [User] (Username, Password) VALUES (@username, @password)";
                                using (SqlCommand insertCommand = new SqlCommand(insertSql, connection))
                                {
                                    insertCommand.Parameters.AddWithValue("@username", username);
                                    insertCommand.Parameters.AddWithValue("@password", password);
                                    int result = insertCommand.ExecuteNonQuery();
                                    if (result > 0)
                                    {
                                        this.Hide();
                                        frmLogin frmLogin = new frmLogin();
                                        frmLogin.ShowDialog();
                                        this.Show();
                                        MessageBox.Show("Registration successful!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Registration failed. Please try again.");
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while registering user: {ex.Message}");
                }
            }
        }
        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnRegister);
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnRegister);
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnBack);
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnBack);
        }
        private void btnRegister_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnRegister);
        }

        private void btnRegister_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnRegister);
        }

        private void btnBack_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnBack);
        }

        private void btnBack_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnBack);
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                btnBack.Focus();
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
                else if (txtConfirmPassword.Text == string.Empty)
                {
                    txtConfirmPassword.Focus();
                }
                else if (txtUsername.Text == string.Empty)
                {
                    txtUsername.Focus();
                }
                else
                {
                    btnRegister.Focus();
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
                txtConfirmPassword.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (txtUsername.Text == string.Empty)
                {
                    txtUsername.Focus();
                }
                else if (txtConfirmPassword.Text == string.Empty)
                {
                    txtConfirmPassword.Focus();
                }
                else if (txtPassword.Text == string.Empty)
                {
                    txtPassword.Focus();
                }
                else
                {
                    btnRegister.Focus();
                }
            }
        }

        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtPassword.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                btnRegister.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (txtUsername.Text == string.Empty)
                {
                    txtUsername.Focus();
                }
                else if (txtConfirmPassword.Text == string.Empty)
                {
                    txtConfirmPassword.Focus();
                }
                else if (txtPassword.Text == string.Empty)
                {
                    txtPassword.Focus();
                }
                else
                {
                    btnRegister.Focus();
                }
            }
        }

        private void btnRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtConfirmPassword.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                btnBack.Focus();
            }
        }

        private void btnBack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                btnRegister.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                btnViewPassword.Focus();
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
                btnRegister.Focus();
            }
        }
    }
}

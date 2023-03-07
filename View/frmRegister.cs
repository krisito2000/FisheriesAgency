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
            frmLogin frmLogin = new frmLogin();
            this.Hide();      
            frmLogin.Show();
        }

        //Making password visible

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
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
                                        frmLogin.Show();
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
    }
}

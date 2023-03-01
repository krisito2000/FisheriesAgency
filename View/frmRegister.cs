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
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (username == string.Empty && password == string.Empty && confirmPassword == string.Empty)
            {
                MessageBox.Show("Please enter your username, password and confirm password");
            }
            else if (username == string.Empty && password == string.Empty)
            {
                MessageBox.Show("Please enter your username and password");
            }
            else if (username == string.Empty && confirmPassword == string.Empty)
            {
                MessageBox.Show("Please enter your username and confirm password");
            }
            else if (username == string.Empty)
            {
                MessageBox.Show("Please enter your username");
            }
            else if (password == string.Empty)
            {
                MessageBox.Show("Please enter your password");
            }
            else if (confirmPassword == string.Empty)
            {
                MessageBox.Show("Please enter your confirm password");
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Your password and confirm password must be the same");
            }

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                string selectSql = "SELECT COUNT(*) FROM [User] WHERE Username = @username";
                string insertSql = "INSERT INTO [User] (Username, Password) VALUES (@username, @password)";

                using (SqlCommand selectCommand = new SqlCommand(selectSql, connection))
                using (SqlCommand insertCommand = new SqlCommand(insertSql, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", username);
                    insertCommand.Parameters.AddWithValue("@username", username);
                    insertCommand.Parameters.AddWithValue("@password", password);

                    connection.Open();

                    int count = (int)selectCommand.ExecuteScalar();
                    int result = insertCommand.ExecuteNonQuery();

                    if (count > 0)
                    {
                        MessageBox.Show($"Username{username} already exists. Please choose a different username.");
                    }
                    else
                    {
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
                    connection.Close();
                }
            }
        }
    }
}

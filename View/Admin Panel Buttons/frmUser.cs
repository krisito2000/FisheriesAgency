using FisheriesAgency.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    public partial class frmUser : Form
    {
        private static void UpdateUsersDataGridView(DataGridView dgvFisheriesAgencyDB)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT UserID, Username, Password, isAdministrator FROM [User]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvFisheriesAgencyDB.DataSource = dt;
        }
        public frmUser()
        {
            InitializeComponent();
            UpdateUsersDataGridView(dgvUser);
        }

        private void dgvReset()
        {
            UpdateUsersDataGridView(dgvUser);
            dgvUser.Refresh();
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            PasswordToggle.Toggle(txtPassword, btnViewPassword);
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool admin = cbAdmin.Checked;

            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and password");
                return;
            }
            else if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username");
                return;
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password");
                return;
            }

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                string selectSql = "SELECT COUNT(*) FROM [User] WHERE Username = @username";
                string insertSql = "INSERT INTO [User] (Username, Password, isAdministrator) VALUES (@username, @password, @admin)";

                using (SqlCommand selectCommand = new SqlCommand(selectSql, connection))
                using (SqlCommand insertCommand = new SqlCommand(insertSql, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", username);
                    insertCommand.Parameters.AddWithValue("@username", username);
                    insertCommand.Parameters.AddWithValue("@password", password);
                    insertCommand.Parameters.AddWithValue("@admin", admin);

                    try
                    {
                        connection.Open();

                        int count = (int)selectCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show($"Username \"{username}\" already exists. Please choose a different username.");
                        }
                        else
                        {
                            int result = insertCommand.ExecuteNonQuery();
                            if (result > 0)
                            {
                                dgvReset();
                            }
                            else
                            {
                                MessageBox.Show("Registration failed. Please try again.");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error occurred while registering the user. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        //Delete button is working but it does not refresh the table
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            int userId = (int)dgvUser.SelectedRows[0].Cells["UserID"].Value;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this vessel?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("DELETE FROM [User] WHERE UserID = @UserId", connection);
                    command.Parameters.AddWithValue("@UserId", userId);

                    command.ExecuteNonQuery();
                    connection.Close();

                    dgvReset();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            // Get the selected row
            DataGridViewRow row = dgvUser.SelectedRows[0];

            // Get the user ID from the selected row
            int userId = (int)row.Cells["UserID"].Value;

            // Get the new username and password from the textboxes
            string newUsername = txtUsername.Text.Trim();
            string newPassword = txtPassword.Text.Trim();
            bool newAdmin = cbAdmin.Checked;

            // Check if the new username already exists in the database
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE Username = @Username AND UserID <> @UserId", connection);
                checkCommand.Parameters.AddWithValue("@Username", newUsername);
                checkCommand.Parameters.AddWithValue("@UserId", userId);
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                    return;
                }
            }

            // Update the user in the local database
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [User] SET Username = @Username, Password = @Password, isAdministrator = @newAdmin WHERE UserID = @UserId", connection);
                updateCommand.Parameters.AddWithValue("@Username", newUsername);
                updateCommand.Parameters.AddWithValue("@Password", newPassword);
                updateCommand.Parameters.AddWithValue("@newAdmin", newAdmin);
                updateCommand.Parameters.AddWithValue("@UserId", userId);
                updateCommand.ExecuteNonQuery();

                connection.Close();
            }

            dgvReset();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUser.Rows[e.RowIndex];

                if (e.RowIndex == 0)
                {
                    string columnName = row.Cells[0].Value?.ToString()?.Trim() ?? string.Empty;
                    if (columnName != "UserID")
                    {
                        MessageBox.Show("You can't change the main owner.");
                        return;
                    }
                }

                string username = row.Cells["Username"].Value?.ToString()?.Trim() ?? string.Empty;
                string password = row.Cells["Password"].Value?.ToString()?.Trim() ?? string.Empty;
                bool isAdmin = (bool)row.Cells["isAdministrator"].Value;

                txtUsername.Text = username;
                txtPassword.Text = password;
                cbAdmin.Checked = isAdmin;
            }
        }
    }
}

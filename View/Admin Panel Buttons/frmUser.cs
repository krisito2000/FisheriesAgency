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
using FisheriesAgency.Controller;

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

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            PasswordToggle.Toggle(txtPassword, btnViewPassword);
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool admin = cbAdmin.Checked;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all spaces");
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
                                UpdateUsersDataGridView(dgvUser);
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
                AdminPanelController.UserDeleteController(userId);
                UpdateUsersDataGridView(dgvUser);
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

            AdminPanelController.UserEditController(txtUsername, txtPassword, cbAdmin, dgvUser);
            UpdateUsersDataGridView(dgvUser);
        }
    }
}

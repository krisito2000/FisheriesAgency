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
    public partial class frmOwner : Form
    {
        private static void UpdateUsersDataGridView(DataGridView dgvFisheriesAgencyDB)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT OwnerID, name, address FROM [Owner]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvFisheriesAgencyDB.DataSource = dt;
        }
        public frmOwner()
        {
            InitializeComponent();
            UpdateUsersDataGridView(dgvOwner);
        }
        private void dgvReset()
        {
            UpdateUsersDataGridView(dgvOwner);
            dgvOwner.Refresh();
        }

        private void dgvOwner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOwner.Rows[e.RowIndex];


                string name = row.Cells["name"].Value.ToString().Trim();
                string address = row.Cells["address"].Value.ToString().Trim();

                txtName.Text = name;
                txtAddress.Text = address;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill all spaces");
            }

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                // Create a SQL INSERT statement with parameter placeholders
                string sql = "INSERT INTO Owner (name, address) VALUES (@Name, @Address)";

                // Create a SqlCommand object with the SQL statement and connection
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Set the parameter values from the text boxes
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@Address", txtAddress.Text);

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }
                dgvReset();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(address))
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM Owner WHERE name = @Name AND address = @Address";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Address", address);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Clear the text boxes
                            txtName.Text = string.Empty;
                            txtAddress.Text = string.Empty;
                            dgvReset();
                        }
                        else
                        {
                            MessageBox.Show("Owner not found or deletion failed.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter the name and address of the owner to delete.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvOwner.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            DataGridViewRow row = dgvOwner.SelectedRows[0];
            int ownerId = (int)row.Cells["OwnerID"].Value;
            string newName = txtName.Text.Trim();
            string newAddress = txtAddress.Text.Trim();

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [Owner] WHERE name = @name AND address <> @address", connection);
                checkCommand.Parameters.AddWithValue("@name", newName);
                checkCommand.Parameters.AddWithValue("@address", newAddress);
                checkCommand.Parameters.AddWithValue("@OwnerId", ownerId);
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Owner already exists. Please choose a different username.");
                    return;
                }
            }

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [Owner] SET name = @name, address = @address WHERE OwnerID = @OwnerId", connection);
                updateCommand.Parameters.AddWithValue("@name", newName);
                updateCommand.Parameters.AddWithValue("@address", newAddress);
                updateCommand.Parameters.AddWithValue("@OwnerId", ownerId);
                updateCommand.ExecuteNonQuery();

                connection.Close();
            }
            dgvReset();
        }
    }
}

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
    public partial class frmCaptain : Form
    {
        private static void UpdateCaptainsDataGridView(DataGridView dgvFisheriesAgencyDB)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT CaptainId, Name, Address FROM [Captain]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvFisheriesAgencyDB.DataSource = dt;
        }
        private void dgvReset()
        {
            UpdateCaptainsDataGridView(dgvCaptain);
            dgvCaptain.Refresh();
        }
        public frmCaptain()
        {
            InitializeComponent();
            UpdateCaptainsDataGridView(dgvCaptain);
        }

        private void dgvCaptain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCaptain.Rows[e.RowIndex];


                string name = row.Cells["Name"].Value?.ToString()?.Trim() ?? string.Empty;
                string address = row.Cells["Address"].Value?.ToString()?.Trim() ?? string.Empty;

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

                // Check if the name already exists in the database
                string checkSql = "SELECT COUNT(*) FROM Captain WHERE Name = @Name";
                using (SqlCommand checkCommand = new SqlCommand(checkSql, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Name", name);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Name already exists");
                        return;
                    }
                }
                // Create a SQL INSERT statement with parameter placeholders
                string sql = "INSERT INTO Captain (Name, Address) VALUES (@Name, @Address)";

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

            if (dgvCaptain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this captain?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) 
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM Captain WHERE Name = @Name AND Address = @Address";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        command.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());


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
                            MessageBox.Show("Captain not found or deletion failed.");
                        }
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCaptain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            DataGridViewRow row = dgvCaptain.SelectedRows[0];
            int captainId = (int)row.Cells["CaptainId"].Value;
            string newName = txtName.Text.Trim();
            string newAddress = txtAddress.Text.Trim();

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [Captain] WHERE Name = @Name AND Address <> @Address AND CaptainId <> @CaptainId", connection);
                checkCommand.Parameters.AddWithValue("@Name", newName);
                checkCommand.Parameters.AddWithValue("@Address", newAddress);
                checkCommand.Parameters.AddWithValue("@CaptainId", captainId);


                using (SqlConnection conn = new SqlConnection(Program.connectionString))
                {
                    conn.Open();

                    SqlCommand updateCommand = new SqlCommand("UPDATE [Captain] SET Name = @Name, Address = @Address WHERE CaptainId = @CaptainId", conn);
                    updateCommand.Parameters.AddWithValue("@Name", newName);
                    updateCommand.Parameters.AddWithValue("@Address", newAddress);
                    updateCommand.Parameters.AddWithValue("@CaptainId", captainId);
                    updateCommand.ExecuteNonQuery();

                    conn.Close();
                }
                connection.Close();
            }
            dgvReset();
        }
    }
}

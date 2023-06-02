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
    public partial class frmMember : Form
    {
        private static void UpdateMembersDataGridView(DataGridView dgvFisheriesAgencyDB)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT MemberId, Name, Address FROM [Member]", con))
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
            UpdateMembersDataGridView(dgvMember);
            dgvMember.Refresh();
        }
        public frmMember()
        {
            InitializeComponent();
            UpdateMembersDataGridView(dgvMember);
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMember.Rows[e.RowIndex];


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
                string checkSql = "SELECT COUNT(*) FROM Member WHERE Name = @Name";
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
                string sql = "INSERT INTO Member (Name, Address) VALUES (@Name, @Address)";

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

                DialogResult result = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) 
                {
                    using (SqlConnection connection = new SqlConnection(Program.connectionString))
                    {
                        connection.Open();

                        string sql = "DELETE FROM Member WHERE Name = @Name AND Address = @Address";

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
            }
            else
            {
                MessageBox.Show("Please enter the name and address of the owner to delete.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMember.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            DataGridViewRow row = dgvMember.SelectedRows[0];
            int memberId = (int)row.Cells["MemberId"].Value;
            string newName = txtName.Text.Trim();
            string newAddress = txtAddress.Text.Trim();

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [Member] WHERE Name = @Name AND Address <> @Address", connection);
                checkCommand.Parameters.AddWithValue("@Name", newName);
                checkCommand.Parameters.AddWithValue("@Address", newAddress);
                checkCommand.Parameters.AddWithValue("@MemberId", memberId);
            }

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [Member] SET Name = @Name, Address = @Address WHERE MemberId = @MemberId", connection);
                updateCommand.Parameters.AddWithValue("@Name", newName);
                updateCommand.Parameters.AddWithValue("@Address", newAddress);
                updateCommand.Parameters.AddWithValue("@MemberId", memberId);
                updateCommand.ExecuteNonQuery();

                connection.Close();
            }
            dgvReset();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FisheriesAgency;
using static FisheriesAgency.View.Admin_Panel_Buttons.frmTicket;

namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    public partial class frmTicket : Form
    {
        private static void UpdateUsersDataGridView(DataGridView dgvFisheriesAgencyDB)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TicketID, StartDate, EndDate, Price, IsPensioner, IsDisabled, TelkDecisionNum FROM [Ticket]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvFisheriesAgencyDB.DataSource = dt;
        }
        public frmTicket()
        {
            InitializeComponent();
            UpdateUsersDataGridView(dgvTicket);

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "SELECT MemberId, Name FROM Member";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int memberId = reader.GetInt32(0);
                            string name = reader.GetString(1);

                            // Create a new Member object
                            Member member = new Member(memberId, name);

                            // Add the member to the combo box
                            cmbMember.Items.Add(member);
                        }
                    }
                }
            }
        }

        private void dgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTicket.Rows[e.RowIndex];

                string startDate = row.Cells["StartDate"].Value?.ToString()?.Trim() ?? string.Empty;
                string endDate = row.Cells["EndDate"].Value?.ToString()?.Trim() ?? string.Empty;
                string price = row.Cells["Price"].Value?.ToString()?.Trim() ?? string.Empty;
                bool pensioner = (bool)row.Cells["IsPensioner"].Value;
                bool disabled = (bool)row.Cells["IsDisabled"].Value;
                string telk = row.Cells["TelkDecisionNum"].Value?.ToString()?.Trim() ?? string.Empty;

                dtpStartDate.Text = startDate;
                dtpEndDate.Text = endDate;
                txtPrice.Text = price;
                cbIsPensioner.Checked = pensioner;
                cbIsDisabled.Checked = disabled;
                txtTelk.Text = telk;
            }
        }

        private void cbMember_DragDrop(object sender, DragEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "SELECT MemberId, Name FROM Member";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int memberId = reader.GetInt32(0);
                            string name = reader.GetString(1);

                            // Create a new Member object
                            Member member = new Member(memberId, name);

                            // Add the member to the combo box
                            cmbMember.Items.Add(member);
                        }
                    }
                }
            }
        }
        public class Member
        {
            public int MemberId { get; set; }
            public string Name { get; set; }

            public Member(int memberId, string name)
            {
                MemberId = memberId;
                Name = name;
            }

            public override string ToString()
            {
                return Name;
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cmbMember.SelectedIndex == -1)
            {
                cmbMember.ForeColor = Color.Red;
                MessageBox.Show("Please select an owner and a captain.");
                return;
            }

            // Get the selected member from the ComboBox
            Member selectedMember = (Member)cmbMember.SelectedItem;

            // Check if a valid member is selected
            if (selectedMember != null)
            {
                // Retrieve the selected member details
                int memberId = selectedMember.MemberId;

                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO Ticket (MemberId, StartDate, EndDate, Price, IsPensioner, IsDisabled, TelkDecisionNum) " +
                                 "VALUES (@MemberId, @StartDate, @EndDate, @Price, @IsPensioner, @IsDisabled, @TelkDecisionNum)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@MemberId", memberId);
                        command.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                        command.Parameters.AddWithValue("@EndDate", dtpEndDate.Value);
                        command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                        command.Parameters.AddWithValue("@IsPensioner", cbIsPensioner.Checked);
                        command.Parameters.AddWithValue("@IsDisabled", cbIsDisabled.Checked);
                        command.Parameters.AddWithValue("@TelkDecisionNum", txtTelk.Text);

                        command.ExecuteNonQuery();
                    }
                }

                UpdateUsersDataGridView(dgvTicket);
            }
            else
            {
                // Invalid member selection
                MessageBox.Show("Invalid member selection!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTicket.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvTicket.SelectedRows[0];

                // Get the TicketID value from the selected row
                int ticketId = Convert.ToInt32(selectedRow.Cells["TicketID"].Value);

                // Execute a SQL DELETE statement to remove the record from the database
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM Ticket WHERE TicketID = @TicketID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@TicketID", ticketId);

                        command.ExecuteNonQuery();
                    }
                }

                // Remove the selected row from the DataGridView
                dgvTicket.Rows.Remove(selectedRow);

            }
            else
            {
                // No row is selected, show an error message
                MessageBox.Show("Please select a row to delete!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvTicket.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            // Get the selected row
            DataGridViewRow row = dgvTicket.SelectedRows[0];

            // Get the ticket ID from the selected row
            int ticketId = (int)row.Cells["TicketID"].Value;

            // Get the new start date, end date, price, and other values from the respective controls
            string newStartDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string newEndDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
            string newPrice = txtPrice.Text.Trim();
            bool newIsPensioner = cbIsPensioner.Checked;
            bool newIsDisabled = cbIsDisabled.Checked;
            // Retrieve other relevant values as needed

            // Update the ticket in the database
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE Ticket SET StartDate = @StartDate, EndDate = @EndDate, Price = @Price, IsPensioner = @IsPensioner, IsDisabled = @IsDisabled WHERE TicketID = @TicketId", connection);
                updateCommand.Parameters.AddWithValue("@StartDate", newStartDate);
                updateCommand.Parameters.AddWithValue("@EndDate", newEndDate);
                updateCommand.Parameters.AddWithValue("@Price", newPrice);
                updateCommand.Parameters.AddWithValue("@IsPensioner", newIsPensioner);
                updateCommand.Parameters.AddWithValue("@IsDisabled", newIsDisabled);
                updateCommand.Parameters.AddWithValue("@TicketId", ticketId);
                // Add parameters for other relevant columns if needed

                updateCommand.ExecuteNonQuery();

                connection.Close();
            }

            // Refresh the DataGridView to reflect the updated data
            UpdateUsersDataGridView(dgvTicket);
        }

        private void cmbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMember.ForeColor = Color.Black;
        }
    }
}

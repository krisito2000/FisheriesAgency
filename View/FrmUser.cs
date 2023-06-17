using FisheriesAgency.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FisheriesAgency.View
{
    public partial class frmUser : Form
    {
        public int UserID { get; set; }
        public frmUser()
        {
            InitializeComponent();
            dgvLoad();
        }
        private void dgvLoad()
        {
            // Retrieve and display available tickets in dgvTickets
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT TicketId, StartDate, EndDate, Price, IsPensioner, IsDisabled, TelkDecisionNum FROM Ticket WHERE UserId IS NULL";
                    SqlCommand command = new SqlCommand(query, connection);
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    dgvTickets.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                lblTickets.Text = "Error";
                MessageBox.Show("Error retrieving available tickets: " + ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (logout == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMyTickets_Click(object sender, EventArgs e)
        {
            int userId = UserID;
            try
            {
                lblTickets.Text = "Tickets";
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT TicketId, StartDate, EndDate, Price, IsPensioner, IsDisabled, TelkDecisionNum FROM Ticket WHERE UserId = @UserId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserId", userId);
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    dgvTickets.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                lblTickets.Text = "Error";
                MessageBox.Show("Error retrieving user tickets: " + ex.Message);
            }
        }

        private void dgvTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are you sure you want to buy this ticket?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (logout == DialogResult.Yes)
            {
                if (e.RowIndex >= 0)
                {
                    // Get the selected ticket's ID from the DataGridView
                    int ticketId = Convert.ToInt32(dgvTickets.Rows[e.RowIndex].Cells["TicketId"].Value);

                    // Perform the ticket purchase (set UserId for the selected ticket)
                    int userId = UserID; // Replace with your code to get the current user's ID

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(Program.connectionString))
                        {
                            connection.Open();
                            string query = @"UPDATE Ticket SET UserId = @UserId WHERE TicketId = @TicketId";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@UserId", userId);
                            command.Parameters.AddWithValue("@TicketId", ticketId);
                            command.ExecuteNonQuery();
                        }

                        // Refresh the available tickets in dgvTickets
                        dgvLoad();
                    }
                    catch (Exception ex)
                    {
                        lblTickets.Text = "Error";
                        MessageBox.Show("Error purchasing ticket: " + ex.Message);
                    }
                }
            }
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            dgvLoad();
            lblTickets.Text = "Store";
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static FisheriesAgency.View.Admin_Panel_Buttons.frmFishingPermit;

namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    public partial class frmCatch : Form
    {
        private static void UpdateCatchDataGridView(DataGridView dgvCatch)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT CatchId, Weight, Quantity FROM [Catch]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvCatch.DataSource = dt;
        }

        private void dgvReset()
        {
            UpdateCatchDataGridView(dgvCatch);
            dgvCatch.Refresh();
        }

        public frmCatch()
        {
            InitializeComponent();
            UpdateCatchDataGridView(dgvCatch);

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "SELECT TripId, VesselId FROM [FishingTrip]";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int tripId = reader.GetInt32(0);
                            int vesselId = reader.GetInt32(1);

                            // Create a new trip object
                            Trip trip = new Trip(tripId, vesselId);

                            // Add the trip to the combo box
                            cmbTrip.Items.Add(trip);
                        }
                    }
                }
            }
        }

        private void dgvCatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCatch.Rows[e.RowIndex];

                string weight = row.Cells["Weight"].Value?.ToString()?.Trim() ?? string.Empty;
                string quantity = row.Cells["Quantity"].Value?.ToString()?.Trim() ?? string.Empty;

                txtWeight.Text = weight;
                txtQuantity.Text = quantity;
            }
        }

        private class Trip
        {
            public int TripId { get; set; }
            public int VesselId { get; set; }

            public Trip(int tripId, int vesselId)
            {
                TripId = tripId;
                VesselId = vesselId;
            }

            public override string ToString()
            {
                return VesselId.ToString();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Trip selectedTrip = (Trip)cmbTrip.SelectedItem;
            
            if (selectedTrip != null)
            {
                int tripId = selectedTrip.TripId;
                string weight = txtWeight.Text;
                string quantity = txtQuantity.Text;

                if (string.IsNullOrWhiteSpace(weight) || string.IsNullOrWhiteSpace(quantity))
                {
                    MessageBox.Show("Please fill all spaces");
                }
                else
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(Program.connectionString))
                        {
                            connection.Open();

                            // Create a SQL INSERT statement with parameter placeholders
                            string sql = "INSERT INTO Catch (FishingTripId, Weight, Quantity) VALUES (@TripId, @Weight, @Quantity)";

                            // Create a SqlCommand object with the SQL statement and connection
                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                // Set the parameter values from the text boxes
                                command.Parameters.AddWithValue("@Weight", weight);
                                command.Parameters.AddWithValue("@Quantity", quantity);
                                command.Parameters.AddWithValue("@TripId", tripId);

                                // Execute the SQL command
                                command.ExecuteNonQuery();
                            }

                            dgvReset();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                cmbTrip.ForeColor = Color.Red;
                MessageBox.Show("Invalid trip selection!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCatch.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvCatch.SelectedRows[0];

                // Get the TicketID value from the selected row
                int catchId = Convert.ToInt32(selectedRow.Cells["CatchId"].Value);

                // Execute a SQL DELETE statement to remove the record from the database
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM [Catch] WHERE CatchId = @CatchId";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@CatchId", catchId);

                        command.ExecuteNonQuery();
                    }
                }

                // Remove the selected row from the DataGridView
                dgvCatch.Rows.Remove(selectedRow);

            }
            else
            {
                // No row is selected, show an error message
                MessageBox.Show("Please select a row to delete!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCatch.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            DataGridViewRow row = dgvCatch.SelectedRows[0];
            int catchId = (int)row.Cells["CatchId"].Value;
            string weight = txtWeight.Text.Trim();
            string quantity = txtQuantity.Text.Trim();

            Trip selectedTrip = (Trip)cmbTrip.SelectedItem;
            if (selectedTrip == null)
            {
                MessageBox.Show("Invalid trip selection!");
                return;
            }

            int tripId = selectedTrip.TripId;

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "UPDATE [Catch] SET FishingTripId = @TripId, Weight = @Weight, Quantity = @Quantity WHERE CatchId = @CatchId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TripId", tripId);
                    command.Parameters.AddWithValue("@Weight", weight);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@CatchId", catchId);

                    command.ExecuteNonQuery();
                    dgvReset();
                }
            }
        }

        private void cmbTrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTrip.ForeColor = Color.Black;
        }
    }
}

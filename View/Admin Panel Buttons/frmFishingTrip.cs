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
using System.Xml.Linq;
using static FisheriesAgency.View.Admin_Panel_Buttons.frmFishingPermit;
using static FisheriesAgency.View.Admin_Panel_Buttons.frmTicket;
using FisheriesAgency.Model;

namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    public partial class frmFishingTrip : Form
    {
        private static void UpdateTripsDataGridView(DataGridView dgvFisheriesAgencyDB)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TripId, TripStart, TripEnd, CatchAmount FROM [FishingTrip]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvFisheriesAgencyDB.DataSource = dt;
        }
        public frmFishingTrip()
        {
            InitializeComponent();
            UpdateTripsDataGridView(dgvTrip);

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "SELECT VesselId, InternationalNumber FROM Vessel";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int vesselId = reader.GetInt32(0);
                            string internationalNumber = reader.GetString(1);

                            // Add the vessel to the ComboBox items and store the ID as the item value
                            cbVessels.Items.Add(new ComboBoxVessel(internationalNumber, vesselId));
                        }
                    }
                }
            }
        }
        private void dgvReset()
        {
            UpdateTripsDataGridView(dgvTrip);
            dgvTrip.Refresh();
        }

        private void dgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTrip.Rows[e.RowIndex];


            string tripStart = row.Cells["TripStart"].Value?.ToString()?.Trim() ?? string.Empty;
            string tripEnd = row.Cells["TripEnd"].Value?.ToString()?.Trim() ?? string.Empty;
            string catchAmount = row.Cells["CatchAmount"].Value?.ToString()?.Trim() ?? string.Empty;

            dtpTripStart.Text = tripStart;
            dtpTripEnd.Text = tripEnd;
            txtCatchAmount.Text = catchAmount;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ComboBoxVessel selectedVessel = (ComboBoxVessel)cbVessels.SelectedItem;

            if (selectedVessel != null)
            {
                int vesselId = selectedVessel.VesselId;

                string query = "INSERT INTO [FishingTrip] (TripStart, TripEnd, CatchAmount, VesselId) VALUES (@TripStart, @TripEnd, @CatchAmount, @VesselId)";

                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TripStart", dtpTripStart.Value.Date);
                        command.Parameters.AddWithValue("@TripEnd", dtpTripEnd.Value.Date);
                        command.Parameters.AddWithValue("@CatchAmount", txtCatchAmount.Text);
                        command.Parameters.AddWithValue("@VesselId", vesselId);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                dgvReset();
                            }
                            else
                            {
                                // Insert failed
                                MessageBox.Show("Failed to create fishing trip.");
                            }
                        }
                        catch (SqlException ex)
                        {
                            // Handle SQL exception
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                cbVessels.ForeColor = Color.Red;
                MessageBox.Show("Invalid vessel selection!");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTrip.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            int tripId = (int)dgvTrip.SelectedRows[0].Cells["TripId"].Value;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this fishing permit?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    connection.Open();

                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM [FishingTrip] WHERE TripId = @TripId", connection);
                    deleteCommand.Parameters.AddWithValue("@TripId", tripId);
                    deleteCommand.ExecuteNonQuery();

                    connection.Close();
                }

                UpdateTripsDataGridView(dgvTrip);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvTrip.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            // Get the selected row
            DataGridViewRow row = dgvTrip.SelectedRows[0];

            // Get the ticket ID from the selected row
            int tripId = (int)row.Cells["TripId"].Value;

            // Get the new start date, end date, price, and other values from the respective controls
            string newTripStart = dtpTripStart.Value.ToString("yyyy-MM-dd");
            string newTripEnd = dtpTripEnd.Value.ToString("yyyy-MM-dd");
            string newCatch = txtCatchAmount.Text.Trim();

            // Update the ticket in the database
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [FishingTrip] SET TripStart = @TripStart, TripEnd = @TripEnd, CatchAmount = @CatchAmount WHERE TripID = @TripId", connection);
                updateCommand.Parameters.AddWithValue("@TripStart", newTripStart);
                updateCommand.Parameters.AddWithValue("@TripEnd", newTripEnd);
                updateCommand.Parameters.AddWithValue("@CatchAmount", newCatch);
                updateCommand.Parameters.AddWithValue("@TripId", tripId);
                // Add parameters for other relevant columns if needed

                updateCommand.ExecuteNonQuery();

                connection.Close();
            }

            // Refresh the DataGridView to reflect the updated data
            UpdateTripsDataGridView(dgvTrip);
        }

        private void cbVessels_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbVessels.ForeColor = Color.Black;
        }
    }
}

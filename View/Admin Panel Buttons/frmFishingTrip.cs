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
using static FisheriesAgency.View.Admin_Panel_Buttons.frmFishingPermit;

namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    public partial class frmFishingTrip : Form
    {
        private static void UpdateUsersDataGridView(DataGridView dgvFisheriesAgencyDB)
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
            UpdateUsersDataGridView(dgvTrip);

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

        private void dgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTrip.Rows[e.RowIndex];


            string tripStart = row.Cells["TripStart"].Value.ToString().Trim();
            string tripEnd = row.Cells["TripEnd"].Value.ToString().Trim();
            string catchAmount = row.Cells["CatchAmount"].Value.ToString().Trim();

            dtpTripStart.Text = tripStart;
            dtpTripEnd.Text = tripEnd;
            txtCatchAmount.Text = catchAmount;
        }
        private void dgvReset()
        {
            UpdateUsersDataGridView(dgvTrip);
            dgvTrip.Refresh();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO [FishingTrip] (Trip_Start, Trip_End, Catch_Amount) VALUES (@TripStart, @TripEnd, @CatchAmount)";

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TripStart", dtpTripStart.Value.Date);
                    command.Parameters.AddWithValue("@TripEnd", dtpTripEnd.Value.Date);
                    command.Parameters.AddWithValue("@CatchAmount", txtCatchAmount.Text);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Insert successful
                            MessageBox.Show("Fishing trip created successfully.");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTrip.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            int permitId = (int)dgvTrip.SelectedRows[0].Cells["TripId"].Value;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this fishing permit?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    connection.Open();

                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM [FishingTrip] WHERE PermitId = @PermitId", connection);
                    deleteCommand.Parameters.AddWithValue("@TripId", permitId);
                    deleteCommand.ExecuteNonQuery();

                    connection.Close();
                }

                UpdateUsersDataGridView(dgvTrip);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}

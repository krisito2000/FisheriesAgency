using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static FisheriesAgency.View.Admin_Panel_Buttons.frmFishingPermit;
using FisheriesAgency.Model;
using FisheriesAgency.Controller;
using System.Xml.Linq;

namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    public partial class frmCatch : Form
    {
        private static void UpdateCatchesDataGridView(DataGridView dgvCatch)
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

        public frmCatch()
        {
            InitializeComponent();
            UpdateCatchesDataGridView(dgvCatch);

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
                            ComboBoxTrip trip = new ComboBoxTrip(tripId, vesselId);

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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ComboBoxTrip selectedTrip = (ComboBoxTrip)cmbTrip.SelectedItem;

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
                        AdminPanelController.CatchCreateController(weight, quantity, tripId);
                        UpdateCatchesDataGridView(dgvCatch);
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
            DialogResult result = MessageBox.Show("Are you sure you want to delete this catch?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dgvCatch.SelectedRows.Count > 0 && result == DialogResult.Yes)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvCatch.SelectedRows[0];

                // Get the TicketID value from the selected row
                int catchId = Convert.ToInt32(selectedRow.Cells["CatchId"].Value);

                AdminPanelController.CatchDeleteController(catchId);

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
            if (string.IsNullOrEmpty(txtWeight.Text) || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please fill all spaces");
                return;
            }

            DataGridViewRow row = dgvCatch.SelectedRows[0];
            int catchId = (int)row.Cells["CatchId"].Value;
            string weight = txtWeight.Text.Trim();
            string quantity = txtQuantity.Text.Trim();

            ComboBoxTrip selectedTrip = (ComboBoxTrip)cmbTrip.SelectedItem;
            if (selectedTrip == null)
            {
                MessageBox.Show("Invalid trip selection!");
                return;
            }

            int tripId = selectedTrip.TripId;

            AdminPanelController.CatchEditController(tripId, weight, quantity, catchId);
            UpdateCatchesDataGridView(dgvCatch);
        }

        private void cmbTrip_DropDown(object sender, EventArgs e)
        {
            cmbTrip.ForeColor = Color.Aqua;
        }
    }
}

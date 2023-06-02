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
using FisheriesAgency.Model;

namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    public partial class frmVessel : Form
    {
        private static void UpdateVesselsDataGridView(DataGridView dgvFisheriesAgencyDB)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT VesselID, InternationalNumber, CallSign, Marking, Length, Width, Tonnage, Gas, Engine, Fuel FROM [Vessel]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvFisheriesAgencyDB.DataSource = dt;
        }

        public frmVessel()
        {
            InitializeComponent();
            UpdateVesselsDataGridView(dgvVessel);


            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "SELECT OwnerId, Name FROM Owner";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ownerId = reader.GetInt32(0);
                            string name = reader.GetString(1);

                            // Add the name to the ComboBox items and store the ID as the item value
                            cmbOwners.Items.Add(new ComboBoxModel.ComboBoxOwner(name, ownerId));
                        }
                    }
                }
            }
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "SELECT CaptainId, Name FROM Captain";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int captainId = reader.GetInt32(0);
                            string name = reader.GetString(1);


                            // Add the name to the ComboBox items and store the ID as the item value
                            cmbCaptains.Items.Add(new ComboBoxCaptain(name, captainId));
                        }
                    }
                }
            }


        }
        private void dgvReset()
        {
            UpdateVesselsDataGridView(dgvVessel);
            dgvVessel.Refresh();
        }

        private void dgvVessel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVessel.Rows[e.RowIndex];


                string internationalNumber = row.Cells["InternationalNumber"].Value?.ToString()?.Trim() ?? string.Empty;
                string callSign = row.Cells["CallSign"].Value?.ToString()?.Trim() ?? string.Empty;
                string marking = row.Cells["Marking"].Value?.ToString()?.Trim() ?? string.Empty;
                string length = row.Cells["Length"].Value?.ToString()?.Trim() ?? string.Empty;
                string width = row.Cells["Width"].Value?.ToString()?.Trim() ?? string.Empty;
                string tonnage = row.Cells["Tonnage"].Value?.ToString()?.Trim() ?? string.Empty;
                string gas = row.Cells["Gas"].Value?.ToString()?.Trim() ?? string.Empty;
                string engine = row.Cells["Engine"].Value?.ToString()?.Trim() ?? string.Empty;
                string fuel = row.Cells["Fuel"].Value?.ToString()?.Trim() ?? string.Empty;

                txtInternationalNumber.Text = internationalNumber;
                txtCallSign.Text = callSign;
                txtMarking.Text = marking;
                txtLength.Text = length;
                txtWidth.Text = width;
                txtTonnage.Text = tonnage;
                txtGas.Text = gas;
                txtEngine.Text = engine;
                txtFuel.Text = fuel;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cmbOwners.SelectedIndex == -1 || cmbCaptains.SelectedIndex == -1)
            {
                cmbOwners.ForeColor = Color.Red;
                cmbCaptains.ForeColor = Color.Red;
                MessageBox.Show("Please select an owner and a captain.");
                return;
            }

            ComboBoxModel.ComboBoxOwner selectedOwner = (ComboBoxModel.ComboBoxOwner)cmbOwners.SelectedItem;
            ComboBoxCaptain selectedCaptain = (ComboBoxCaptain)cmbCaptains.SelectedItem;

            int ownerId = selectedOwner.OwnerId;
            int captainId = selectedCaptain.CaptainId;

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                // Create a SQL INSERT statement with parameter placeholders
                string sql = "INSERT INTO Vessel (InternationalNumber, CallSign, Marking, Length, Width, Tonnage, Gas, Engine, Fuel, OwnerId, CaptainId) " +
                             "VALUES (@InternationalNumber, @CallSign, @Marking, @Length, @Width, @Tonnage, @Gas, @Engine, @Fuel, @OwnerId, @CaptainId)";

                // Create a SqlCommand object with the SQL statement and connection
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Set the parameter values from the text boxes
                    command.Parameters.AddWithValue("@InternationalNumber", txtInternationalNumber.Text);
                    command.Parameters.AddWithValue("@CallSign", txtCallSign.Text);
                    command.Parameters.AddWithValue("@Marking", txtMarking.Text);
                    command.Parameters.AddWithValue("@Length", decimal.Parse(txtLength.Text));
                    command.Parameters.AddWithValue("@Width", decimal.Parse(txtWidth.Text));
                    command.Parameters.AddWithValue("@Tonnage", decimal.Parse(txtTonnage.Text));
                    command.Parameters.AddWithValue("@Gas", txtGas.Text);
                    command.Parameters.AddWithValue("@Engine", txtEngine.Text);
                    command.Parameters.AddWithValue("@Fuel", txtFuel.Text);
                    command.Parameters.AddWithValue("@OwnerId", ownerId);
                    command.Parameters.AddWithValue("@CaptainId", captainId);

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                    dgvReset();
                }
            }
        }

        private void cbOwners_DropDown(object sender, EventArgs e)
        {
            cmbOwners.ForeColor = Color.Black;
            cmbCaptains.ForeColor = Color.Black;
        }
        private void cbCaptains_DropDown(object sender, EventArgs e)
        {
            cmbOwners.ForeColor = Color.Black;
            cmbCaptains.ForeColor = Color.Black;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvVessel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // Get the VesselID from the selected row
            int vesselId = (int)dgvVessel.SelectedRows[0].Cells["VesselID"].Value;

            // Confirm deletion with the user
            DialogResult result = MessageBox.Show("Are you sure you want to delete this vessel?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete the vessel from the database
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    connection.Open();

                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM [Vessel] WHERE VesselID = @VesselId", connection);
                    deleteCommand.Parameters.AddWithValue("@VesselId", vesselId);
                    deleteCommand.ExecuteNonQuery();

                    connection.Close();
                }

                // Refresh the DataGridView
                dgvReset();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvVessel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            // Get the selected row
            DataGridViewRow row = dgvVessel.SelectedRows[0];

            // Get the VesselID from the selected row
            int vesselId = (int)row.Cells["VesselID"].Value;

            // Get the new values from the text boxes
            string internationalNumber = txtInternationalNumber.Text.Trim();
            string callSign = txtCallSign.Text.Trim();
            string marking = txtMarking.Text.Trim();
            decimal length = decimal.Parse(txtLength.Text.Trim());
            decimal width = decimal.Parse(txtWidth.Text.Trim());
            decimal tonnage = decimal.Parse(txtTonnage.Text.Trim());
            string gas = txtGas.Text.Trim();
            string engine = txtEngine.Text.Trim();
            string fuel = txtFuel.Text.Trim();

            // Update the vessel in the database
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [Vessel] SET InternationalNumber = @InternationalNumber, CallSign = @CallSign, Marking = @Marking, Length = @Length, Width = @Width, Tonnage = @Tonnage, Gas = @Gas, Engine = @Engine, Fuel = @Fuel WHERE VesselID = @VesselId", connection);
                updateCommand.Parameters.AddWithValue("@InternationalNumber", internationalNumber);
                updateCommand.Parameters.AddWithValue("@CallSign", callSign);
                updateCommand.Parameters.AddWithValue("@Marking", marking);
                updateCommand.Parameters.AddWithValue("@Length", length);
                updateCommand.Parameters.AddWithValue("@Width", width);
                updateCommand.Parameters.AddWithValue("@Tonnage", tonnage);
                updateCommand.Parameters.AddWithValue("@Gas", gas);
                updateCommand.Parameters.AddWithValue("@Engine", engine);
                updateCommand.Parameters.AddWithValue("@Fuel", fuel);
                updateCommand.Parameters.AddWithValue("@VesselId", vesselId);
                updateCommand.ExecuteNonQuery();

                connection.Close();
            }

            // Refresh the DataGridView
            dgvReset();
        }
    }
}

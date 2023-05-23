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
    public partial class frmFishingPermit : Form
    {
        private static void UpdatePermitsDataGridView(DataGridView dgvPermits)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT PermitId, PermitNumber, IssueDate, ExpirationDate, Equipment, VesselId FROM [FishingPermit]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvPermits.DataSource = dt;
        }

        private static void UpdateVesselsComboBox(ComboBox cbVessels)
        {
            cbVessels.Items.Clear();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT VesselId, InternationalNumber FROM [Vessel]", con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int vesselId = reader.GetInt32(0);
                            string internationalNumber = reader.GetString(1);

                            // Add the international number to the ComboBox items and store the vessel ID as the item value
                            cbVessels.Items.Add(new ComboBoxItem(internationalNumber, vesselId));
                        }
                    }
                }
            }
        }

        public frmFishingPermit()
        {
            InitializeComponent();
            UpdatePermitsDataGridView(dgvPermit);
            UpdateVesselsComboBox(cbVessels);
        }

        private void dgvPermit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPermit.Rows[e.RowIndex];

                string permitNumber = row.Cells["PermitNumber"].Value.ToString().Trim();
                DateTime issueDate = (DateTime)row.Cells["IssueDate"].Value;
                DateTime expirationDate = (DateTime)row.Cells["ExpirationDate"].Value;
                string equipment = row.Cells["Equipment"].Value.ToString().Trim();
                string vesselId = row.Cells["VesselId"].Value.ToString().Trim();

                txtPermitNumber.Text = permitNumber;
                dtpIssueDate.Value = issueDate;
                dtpExpirationDate.Value = expirationDate;
                txtEquipment.Text = equipment;
                cbVessels.SelectedItem = cbVessels.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Value.ToString() == vesselId);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cbVessels.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vessel.");
                return;
            }

            ComboBoxItem selectedVessel = (ComboBoxItem)cbVessels.SelectedItem;

            int vesselId = (int)selectedVessel.Value;

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                // Create a SQL INSERT statement with parameter placeholders
                string sql = "INSERT INTO [FishingPermit] (PermitNumber, IssueDate, ExpirationDate, Equipment, VesselId) " +
                             "VALUES (@PermitNumber, @IssueDate, @ExpirationDate, @Equipment, @VesselId)";

                // Create a SqlCommand object with the SQL statement and connection
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Generate a unique permit number
                    string permitNumber = GeneratePermitNumber();

                    // Set the parameter values from the controls and selected vessel ID
                    command.Parameters.AddWithValue("@PermitNumber", permitNumber);
                    command.Parameters.AddWithValue("@IssueDate", dtpIssueDate.Value);
                    command.Parameters.AddWithValue("@ExpirationDate", dtpExpirationDate.Value);
                    command.Parameters.AddWithValue("@Equipment", txtEquipment.Text);
                    command.Parameters.AddWithValue("@VesselId", vesselId);

                    // Execute the SQL command
                    command.ExecuteNonQuery();

                    // Refresh the DataGridView
                    UpdatePermitsDataGridView(dgvPermit);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPermit.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            int permitId = (int)dgvPermit.SelectedRows[0].Cells["PermitId"].Value;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this fishing permit?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    connection.Open();

                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM [FishingPermit] WHERE PermitId = @PermitId", connection);
                    deleteCommand.Parameters.AddWithValue("@PermitId", permitId);
                    deleteCommand.ExecuteNonQuery();

                    connection.Close();
                }

                UpdatePermitsDataGridView(dgvPermit);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPermit.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            DataGridViewRow row = dgvPermit.SelectedRows[0];

            int permitId = (int)row.Cells["PermitId"].Value;

            ComboBoxItem selectedVessel = (ComboBoxItem)cbVessels.SelectedItem;
            int vesselId = (int)selectedVessel.Value;

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [FishingPermit] SET IssueDate = @IssueDate, ExpirationDate = @ExpirationDate, Equipment = @Equipment, VesselId = @VesselId WHERE PermitId = @PermitId", connection);
                updateCommand.Parameters.AddWithValue("@IssueDate", dtpIssueDate.Value);
                updateCommand.Parameters.AddWithValue("@ExpirationDate", dtpExpirationDate.Value);
                updateCommand.Parameters.AddWithValue("@Equipment", txtEquipment.Text);
                updateCommand.Parameters.AddWithValue("@VesselId", vesselId);
                updateCommand.Parameters.AddWithValue("@PermitId", permitId);
                updateCommand.ExecuteNonQuery();

                connection.Close();
            }

            UpdatePermitsDataGridView(dgvPermit);
        }

        private string GeneratePermitNumber()
        {
            // Generate a unique permit number here or use a specific logic
            // Return the generated permit number
            return Guid.NewGuid().ToString();
        }

        public class ComboBoxItem
        {
            public object Value { get; set; }
            public string Text { get; set; }

            public ComboBoxItem(string text, object value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}

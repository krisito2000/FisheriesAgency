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
using static FisheriesAgency.View.Admin_Panel_Buttons.frmVessel;

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

        public frmFishingPermit()
        {
            InitializeComponent();
            UpdatePermitsDataGridView(dgvPermit);

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "SELECT VesselId, InternationalNumber FROM [Vessel]";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int vesselId = reader.GetInt32(0);
                            string intNum = reader.GetString(1);

                            // Add the name to the ComboBox items and store the ID as the item value
                            cbVessels.Items.Add(new ComboBoxVessel(intNum, vesselId));
                        }
                    }
                }
            }
        }
        private void dgvReset()
        {
            UpdatePermitsDataGridView(dgvPermit);
            dgvPermit.Refresh();
        }

        private void dgvPermit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPermit.Rows[e.RowIndex];

                string permitNumber = row.Cells["PermitNumber"].Value?.ToString()?.Trim() ?? string.Empty;
                DateTime issueDate = (DateTime)row.Cells["IssueDate"].Value;
                DateTime expirationDate = (DateTime)row.Cells["ExpirationDate"].Value;
                string equipment = row.Cells["Equipment"].Value?.ToString()?.Trim() ?? string.Empty;
                string vesselId = row.Cells["VesselId"].Value?.ToString()?.Trim() ?? string.Empty;

                txtPermitNumber.Text = permitNumber;

                dtpIssueDate.Value = issueDate;
                dtpExpirationDate.Value = expirationDate;
                txtEquipment.Text = equipment;
                cbVessels.SelectedItem = cbVessels.Items.Cast<ComboBoxVessel>().FirstOrDefault(item => item.VesselId.ToString() == vesselId);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cbVessels.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vessel.");
                cbVessels.ForeColor = Color.Red;
                return;
            }

            ComboBoxVessel selectedVessel = (ComboBoxVessel)cbVessels.SelectedItem;
            int vesselId = selectedVessel.VesselId;

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                // Create a SQL INSERT statement with parameter placeholders
                string sql = "INSERT INTO FishingPermit (PermitNumber, IssueDate, ExpirationDate, Equipment, VesselId) " +
                             "VALUES (@PermitNumber, @IssueDate, @ExpirationDate, @Equipment, @VesselId)";

                // Create a SqlCommand object with the SQL statement and connection
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Set the parameter values from the form controls
                    command.Parameters.AddWithValue("@PermitNumber", txtPermitNumber.Text);
                    command.Parameters.AddWithValue("@IssueDate", dtpIssueDate.Value.Date);
                    command.Parameters.AddWithValue("@ExpirationDate", dtpExpirationDate.Value.Date);
                    command.Parameters.AddWithValue("@Equipment", txtEquipment.Text);
                    command.Parameters.AddWithValue("@VesselId", vesselId);

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                    dgvReset();
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
            string permitNumber = txtPermitNumber.Text.Trim();
            DateTime issueDate = dtpIssueDate.Value;
            DateTime expirationDate = dtpExpirationDate.Value;
            string equipment = txtEquipment.Text.Trim();

            ComboBoxVessel selectedVessel = (ComboBoxVessel)cbVessels.SelectedItem;
            int vesselId = (int)selectedVessel.VesselId;

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "UPDATE [FishingPermit] SET PermitNumber = @PermitNumber, IssueDate = @IssueDate, ExpirationDate = @ExpirationDate, Equipment = @Equipment,VesselId = @VesselId WHERE PermitId = @PermitId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@PermitNumber", permitNumber);
                    command.Parameters.AddWithValue("@IssueDate", issueDate);
                    command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                    command.Parameters.AddWithValue("@Equipment", equipment);


                    command.Parameters.AddWithValue("@VesselId", vesselId);
                    command.Parameters.AddWithValue("@PermitId", permitId);

                    command.ExecuteNonQuery();
                    dgvReset();
                }
            }
        }

        public class ComboBoxVessel
        {
            public int VesselId { get; set; }
            public string InternationalNumber { get; set; }

            public ComboBoxVessel(string internationalNumber, int vesselId)
            {
                InternationalNumber = internationalNumber;
                VesselId = vesselId;
            }

            public override string ToString()
            {
                return InternationalNumber;
            }
        }
    }
}

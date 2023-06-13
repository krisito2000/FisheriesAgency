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
    public partial class frmInspector : Form
    {
        private static void UpdateInspectorDataGridView(DataGridView dgvInspector)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT InspectorId, InspectorDate, VesselId FROM [Inspector]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvInspector.DataSource = dt;
        }

        public frmInspector()
        {
            InitializeComponent();
            UpdateInspectorDataGridView(dgvInspector);

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
                            cmbVessels.Items.Add(new ComboBoxVessel(internationalNumber, vesselId));
                        }
                    }
                }
            }
        }

        private void dgvReset()
        {
            UpdateInspectorDataGridView(dgvInspector);
            dgvInspector.Refresh();
        }

        private void dgvInspector_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInspector.Rows[e.RowIndex];

                int inspectorId = (int)row.Cells["InspectorId"].Value;
                DateTime inspectorDate = (DateTime)row.Cells["InspectorDate"].Value;
                int vesselId = (int)row.Cells["VesselId"].Value;

                dtpInspectorDate.Value = inspectorDate;

                // Select the appropriate vessel in the ComboBox based on vesselId
                foreach (ComboBoxVessel item in cmbVessels.Items)
                {
                    if (item.VesselId == vesselId)
                    {
                        cmbVessels.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cmbVessels.SelectedIndex == -1)
            {
                cmbVessels.ForeColor = Color.Red;
                MessageBox.Show("Please select a vessel.");
                return;
            }

            ComboBoxVessel selectedVessel = (ComboBoxVessel)cmbVessels.SelectedItem;

            int vesselId = (int)selectedVessel.VesselId;

            DateTime inspectorDate = dtpInspectorDate.Value;

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Inspector (InspectorDate, VesselId) VALUES (@InspectorDate, @VesselId)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@InspectorDate", inspectorDate);
                    command.Parameters.AddWithValue("@VesselId", vesselId);

                    command.ExecuteNonQuery();
                    dgvReset();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInspector.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            int inspectorId = (int)dgvInspector.SelectedRows[0].Cells["InspectorId"].Value;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this inspector?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM Inspector WHERE InspectorId = @InspectorId";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@InspectorId", inspectorId);

                        command.ExecuteNonQuery();
                        dgvReset();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvInspector.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            DataGridViewRow row = dgvInspector.SelectedRows[0];
            int inspectorId = (int)row.Cells["InspectorId"].Value;
            DateTime inspectorDate = dtpInspectorDate.Value;

            ComboBoxVessel selectedVessel = (ComboBoxVessel)cmbVessels.SelectedItem;
            int vesselId = (int)selectedVessel.VesselId;

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "UPDATE Inspector SET InspectorDate = @InspectorDate, VesselId = @VesselId WHERE InspectorId = @InspectorId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@InspectorDate", inspectorDate);
                    command.Parameters.AddWithValue("@VesselId", vesselId);
                    command.Parameters.AddWithValue("@InspectorId", inspectorId);

                    command.ExecuteNonQuery();
                    dgvReset();
                }
            }
        }

        private void cmbVessels_DropDown(object sender, EventArgs e)
        {
            cmbVessels.ForeColor = Color.Aqua;
        }
    }
}

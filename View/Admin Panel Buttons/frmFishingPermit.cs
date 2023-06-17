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
using FisheriesAgency.Model;
using FisheriesAgency.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using FisheriesAgency.Utils;

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
                            cmbVessels.Items.Add(new ComboBoxVessel(intNum, vesselId));
                        }
                    }
                }
            }
        }

        private void cmbVessels_DropDown(object sender, EventArgs e)
        {
            cmbVessels.ForeColor = Color.Aqua;
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
                cmbVessels.SelectedItem = cmbVessels.Items.Cast<ComboBoxVessel>().FirstOrDefault(item => item.VesselId.ToString() == vesselId);
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
            if (string.IsNullOrEmpty(txtPermitNumber.Text) || string.IsNullOrEmpty(txtEquipment.Text))
            {
                MessageBox.Show("Please fill all spaces");
                return;
            }

            ComboBoxVessel selectedVessel = (ComboBoxVessel)cmbVessels.SelectedItem;
            int vesselId = selectedVessel.VesselId;

            AdminPanelController.PermitsCreateController(txtPermitNumber, dtpIssueDate, dtpExpirationDate, txtEquipment, vesselId);
            UpdatePermitsDataGridView(dgvPermit);
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
                AdminPanelController.PermitsDeleteController(permitId);
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

            ComboBoxVessel selectedVessel = (ComboBoxVessel)cmbVessels.SelectedItem;
            int vesselId = (int)selectedVessel.VesselId;

            AdminPanelController.PermitsEditController(permitNumber, issueDate, expirationDate, equipment, vesselId, permitId);
            UpdatePermitsDataGridView(dgvPermit);
        }

        // Create
        private void btnCreate_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnCreate);
        }

        private void btnCreate_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnCreate);
        }

        private void btnCreate_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnCreate);
        }

        private void btnCreate_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnCreate);
        }
        // Delete
        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnDelete);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnDelete);
        }

        private void btnDelete_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnDelete);
        }

        private void btnDelete_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnDelete);
        }
        // Edit
        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnEdit);
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnEdit);
        }

        private void btnEdit_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnEdit);
        }

        private void btnEdit_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnEdit);
        }
    }
}

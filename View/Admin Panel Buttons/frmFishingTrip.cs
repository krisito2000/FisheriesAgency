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
using FisheriesAgency.Controller;
using FisheriesAgency.Utils;

namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    public partial class frmFishingTrip : Form
    {
        public frmFishingTrip()
        {
            InitializeComponent();
            AdminPanelController.UpdateTripsDataGridView(dgvTrip);
            ComboBoxController.VesselController(cmbVessels);
        }

        private void dgvTrip_CellClick(object sender, DataGridViewCellEventArgs e)
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
            ComboBoxVessel selectedVessel = (ComboBoxVessel)cmbVessels.SelectedItem;

            if (selectedVessel != null)
            {
                if (string.IsNullOrEmpty(txtCatchAmount.Text))
                {
                    MessageBox.Show("Please fill all spaces");
                    return;
                }

                int vesselId = selectedVessel.VesselId;

                string query = "INSERT INTO [FishingTrip] (TripStart, TripEnd, CatchAmount, VesselId) VALUES (@TripStart, @TripEnd, @CatchAmount, @VesselId)";

                AdminPanelController.TripCreateController(dgvTrip, query, dtpTripStart, dtpTripEnd, txtCatchAmount, vesselId);
            }
            else
            {
                cmbVessels.ForeColor = Color.Red;
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
                AdminPanelController.TripDeleteController(tripId);
                AdminPanelController.UpdateTripsDataGridView(dgvTrip);
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

            AdminPanelController.TripEditController(newTripStart, newTripEnd, newCatch, tripId);

            // Refresh the DataGridView to reflect the updated data
            AdminPanelController.UpdateTripsDataGridView(dgvTrip);
        }

        private void cbVessels_DropDown(object sender, EventArgs e)
        {
            cmbVessels.ForeColor = Color.Aqua;
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

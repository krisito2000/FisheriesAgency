using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static FisheriesAgency.View.Admin_Panel_Buttons.frmFishingPermit;
using FisheriesAgency.Model;
using FisheriesAgency.Controller;
using System.Xml.Linq;
using FisheriesAgency.Utils;

namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    public partial class frmCatch : Form
    {
        public frmCatch()
        {
            InitializeComponent();
            AdminPanelController.UpdateCatchesDataGridView(dgvCatch);
            ComboBoxController.TripController(cmbTrip);
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
                        AdminPanelController.UpdateCatchesDataGridView(dgvCatch);
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
            AdminPanelController.UpdateCatchesDataGridView(dgvCatch);
        }

        private void cmbTrip_DropDown(object sender, EventArgs e)
        {
            cmbTrip.ForeColor = Color.Aqua;
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

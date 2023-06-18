using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FisheriesAgency;
using static FisheriesAgency.View.Admin_Panel_Buttons.frmTicket;
using FisheriesAgency.Model;
using FisheriesAgency.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using FisheriesAgency.Utils;

namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    public partial class frmTicket : Form
    {
        public frmTicket()
        {
            InitializeComponent();
            AdminPanelController.UpdateTicketsDataGridView(dgvTicket);
            ComboBoxController.MemberController(cmbMember);
        }

        private void dgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTicket.Rows[e.RowIndex];

                string startDate = row.Cells["StartDate"].Value?.ToString()?.Trim() ?? string.Empty;
                string endDate = row.Cells["EndDate"].Value?.ToString()?.Trim() ?? string.Empty;
                string price = row.Cells["Price"].Value?.ToString()?.Trim() ?? string.Empty;
                bool pensioner = (bool)row.Cells["IsPensioner"].Value;
                bool disabled = (bool)row.Cells["IsDisabled"].Value;
                string telk = row.Cells["TelkDecisionNum"].Value?.ToString()?.Trim() ?? string.Empty;

                dtpStartDate.Text = startDate;
                dtpEndDate.Text = endDate;
                txtPrice.Text = price;
                cbIsPensioner.Checked = pensioner;
                cbIsDisabled.Checked = disabled;
                txtTelk.Text = telk;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cmbMember.SelectedIndex == -1)
            {
                cmbMember.ForeColor = Color.Red;
                MessageBox.Show("Please select an owner and a captain.");
                return;
            }
            if (string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtTelk.Text))
            {
                MessageBox.Show("Please fill all spaces");
                return;
            }

            // Get the selected member from the ComboBox
            ComboBoxMember selectedMember = (ComboBoxMember)cmbMember.SelectedItem;

            // Check if a valid member is selected
            if (selectedMember != null)
            {
                // Retrieve the selected member details
                int memberId = selectedMember.MemberId;

                AdminPanelController.TicketCreateController(memberId, dtpStartDate, dtpEndDate, txtPrice, cbIsPensioner, cbIsDisabled, txtTelk);

                AdminPanelController.UpdateTicketsDataGridView(dgvTicket);
            }
            else
            {
                // Invalid member selection
                MessageBox.Show("Invalid member selection!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTicket.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvTicket.SelectedRows[0];

                // Get the TicketID value from the selected row
                int ticketId = Convert.ToInt32(selectedRow.Cells["TicketID"].Value);

                AdminPanelController.TicketDeleteController(ticketId);

                // Remove the selected row from the DataGridView
                dgvTicket.Rows.Remove(selectedRow);
                AdminPanelController.UpdateTicketsDataGridView(dgvTicket);

            }
            else
            {
                // No row is selected, show an error message
                MessageBox.Show("Please select a row to delete!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvTicket.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            // Get the selected row
            DataGridViewRow row = dgvTicket.SelectedRows[0];

            // Get the ticket ID from the selected row
            int ticketId = (int)row.Cells["TicketID"].Value;

            // Get the new start date, end date, price, and other values from the respective controls
            string newStartDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string newEndDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
            string newPrice = txtPrice.Text.Trim();
            bool newIsPensioner = cbIsPensioner.Checked;
            bool newIsDisabled = cbIsDisabled.Checked;

            AdminPanelController.TicketEditController(newStartDate, newEndDate, newPrice, newIsPensioner, newIsDisabled, ticketId);

            // Refresh the DataGridView to reflect the updated data
            AdminPanelController.UpdateTicketsDataGridView(dgvTicket);
        }

        private void cmbMember_DropDown(object sender, EventArgs e)
        {
            cmbMember.ForeColor = Color.Aqua;
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

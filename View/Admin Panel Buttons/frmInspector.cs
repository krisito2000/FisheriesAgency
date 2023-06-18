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
using FisheriesAgency.Controller;
using FisheriesAgency.Model;
using FisheriesAgency.Utils;

namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    public partial class frmInspector : Form
    {
        public frmInspector()
        {
            InitializeComponent();
            AdminPanelController.UpdateInspectorDataGridView(dgvInspector);
            ComboBoxController.VesselController(cmbVessels);
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

            AdminPanelController.InspectorCreateController(inspectorDate, vesselId);

            AdminPanelController.UpdateInspectorDataGridView(dgvInspector);
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
                AdminPanelController.InspectorDeleteController(inspectorId);
                AdminPanelController.UpdateInspectorDataGridView(dgvInspector);
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

            AdminPanelController.InspectorEditController(inspectorDate, vesselId, inspectorId);

            AdminPanelController.UpdateInspectorDataGridView(dgvInspector);
        }

        private void cmbVessels_DropDown(object sender, EventArgs e)
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

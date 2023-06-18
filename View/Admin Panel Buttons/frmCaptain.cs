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
using FisheriesAgency.Utils;

namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    public partial class frmCaptain : Form
    {
        public frmCaptain()
        {
            InitializeComponent();
            AdminPanelController.UpdateCaptainsDataGridView(dgvCaptain);
        }

        private void dgvCaptain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCaptain.Rows[e.RowIndex];


                string name = row.Cells["Name"].Value?.ToString()?.Trim() ?? string.Empty;
                string address = row.Cells["Address"].Value?.ToString()?.Trim() ?? string.Empty;

                txtName.Text = name;
                txtAddress.Text = address;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please fill all spaces");
            }
            else
            {
                AdminPanelController.CaptainCreateController(txtName, txtAddress);
            }
            AdminPanelController.UpdateCaptainsDataGridView(dgvCaptain);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvCaptain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this captain?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                AdminPanelController.CaptainDeleteController(txtName, txtAddress);
                AdminPanelController.UpdateCaptainsDataGridView(dgvCaptain);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCaptain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }
            else
            {
                AdminPanelController.CaptainEditController(txtName, txtAddress, dgvCaptain);
            }
            AdminPanelController.UpdateCaptainsDataGridView(dgvCaptain);
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

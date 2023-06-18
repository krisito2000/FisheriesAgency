using FisheriesAgency.Utils;
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

namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
            AdminPanelController.UpdateUsersDataGridView(dgvUser);
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            PasswordToggle.Toggle(txtPassword, btnViewPassword);
        }
        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUser.Rows[e.RowIndex];

                if (e.RowIndex == 0)
                {
                    string columnName = row.Cells[0].Value?.ToString()?.Trim() ?? string.Empty;
                    if (columnName != "UserID")
                    {
                        MessageBox.Show("You can't change the main owner.");
                        return;
                    }
                }

                string username = row.Cells["Username"].Value?.ToString()?.Trim() ?? string.Empty;
                string password = row.Cells["Password"].Value?.ToString()?.Trim() ?? string.Empty;
                bool isAdmin = (bool)row.Cells["isAdministrator"].Value;

                txtUsername.Text = username;
                txtPassword.Text = password;
                cbAdmin.Checked = isAdmin;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool admin = cbAdmin.Checked;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all spaces");
                return;
            }
            AdminPanelController.UserCreateController(username, password, admin, dgvUser);
        }

        //Delete button is working but it does not refresh the table
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            int userId = (int)dgvUser.SelectedRows[0].Cells["UserID"].Value;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this vessel?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                AdminPanelController.UserDeleteController(userId);
                AdminPanelController.UpdateUsersDataGridView(dgvUser);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            AdminPanelController.UserEditController(txtUsername, txtPassword, cbAdmin, dgvUser);
            AdminPanelController.UpdateUsersDataGridView(dgvUser);
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

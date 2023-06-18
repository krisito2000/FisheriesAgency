using FisheriesAgency.Controller;
using FisheriesAgency.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    public partial class frmMember : Form
    {
        public frmMember()
        {
            InitializeComponent();
            AdminPanelController.UpdateMembersDataGridView(dgvMember);
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMember.Rows[e.RowIndex];


                string name = row.Cells["Name"].Value?.ToString()?.Trim() ?? string.Empty;
                string address = row.Cells["Address"].Value?.ToString()?.Trim() ?? string.Empty;

                txtName.Text = name;
                txtAddress.Text = address;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill all spaces");
            }

            AdminPanelController.MemberCreateController(name, address);
            AdminPanelController.UpdateMembersDataGridView(dgvMember);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(address))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    AdminPanelController.MemberDeleteController(name, address);
                    AdminPanelController.UpdateMembersDataGridView(dgvMember);
                }
            }
            else
            {
                MessageBox.Show("Please enter the name and address of the owner to delete.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMember.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            DataGridViewRow row = dgvMember.SelectedRows[0];
            int memberId = (int)row.Cells["MemberId"].Value;
            string newName = txtName.Text.Trim();
            string newAddress = txtAddress.Text.Trim();

            AdminPanelController.MemberEditController(newName, newAddress, memberId);
            AdminPanelController.UpdateMembersDataGridView(dgvMember);
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

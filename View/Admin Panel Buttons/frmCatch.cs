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

namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    public partial class frmCatch : Form
    {
        private static void UpdateUsersDataGridView(DataGridView dgvFisheriesAgencyDB)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT CatchId, Weight, Quantity FROM [Catch]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvFisheriesAgencyDB.DataSource = dt;
        }
        public frmCatch()
        {
            InitializeComponent();
            UpdateUsersDataGridView(dgvCatch);
        }

        private void dgvCatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCatch.Rows[e.RowIndex];


                string weight = row.Cells["Weight"].Value.ToString().Trim();
                string quantity = row.Cells["Quantity"].Value.ToString().Trim();

                txtWeight.Text = weight;
                txtQuantity.Text = quantity;
            }
        }
        //Todo: make create, edit and delete buttons to work
    }
}

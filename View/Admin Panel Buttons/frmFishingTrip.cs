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
    public partial class frmFishingTrip : Form
    {
        private static void UpdateUsersDataGridView(DataGridView dgvFisheriesAgencyDB)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TripId, TripStart, TripEnd, CatchAmount FROM [FishingTrip]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvFisheriesAgencyDB.DataSource = dt;
        }
        public frmFishingTrip()
        {
            InitializeComponent();
            UpdateUsersDataGridView(dgvTrip);
        }

        private void dgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTrip.Rows[e.RowIndex];


            string tripStart = row.Cells["TripStart"].Value.ToString().Trim();
            string tripEnd = row.Cells["TripEnd"].Value.ToString().Trim();
            string catchAmount = row.Cells["CatchAmount"].Value.ToString().Trim();

            dtpTripStart.Text = tripStart;
            dtpTripEnd.Text = tripEnd;
            txtCatchAmount.Text = catchAmount;
        }
        //Todo: make create, edit and delete buttons to work
    }
}

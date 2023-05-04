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

namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    public partial class frmTicket : Form
    {
        private static void UpdateUsersDataGridView(DataGridView dgvFisheriesAgencyDB)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TicketID, StartDate, EndDate, Price, IsPensioner, IsDisabled, TelkDecisionNum FROM [Ticket]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvFisheriesAgencyDB.DataSource = dt;
        }
        public frmTicket()
        {
            InitializeComponent();
            UpdateUsersDataGridView(dgvTicket);
        }

        private void dgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTicket.Rows[e.RowIndex];


                string startDate = row.Cells["StartDate"].Value.ToString().Trim();
                string endDate = row.Cells["EndDate"].Value.ToString().Trim();
                string price = row.Cells["Price"].Value.ToString().Trim();
                string telk = row.Cells["TelkDecisionNum"].Value.ToString().Trim();

                dtpStartDate.Text = startDate;
                dtpEndDate.Text = endDate;
                txtPrice.Text = price;
                bool isPencioner = (bool)row.Cells["IsPencioner"].Value;
                bool isDisabled = (bool)row.Cells["IsDisabled"].Value;
                txtTalkDecisionNum.Text = telk;

            }
        }
        //Todo: make create, edit and delete buttons to work
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FisheriesAgency.Controller;
using FisheriesAgency.Model;
using FisheriesAgency.Utils;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.ComponentModel.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FisheriesAgency.View
{
    public partial class frmAdminsPanel : Form
    {
        private static void UpdateUsersDataGridView(DataGridView dgvFisheriesAgencyDB)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT UserID, Username, Password, isAdministrator FROM [User]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvFisheriesAgencyDB.DataSource = dt;
        }
        public frmAdminsPanel()
        {
            InitializeComponent();
            UpdateUsersDataGridView(dgvFisheriesAgencyDB);
        }
        private void dgvReset()
        {
            UpdateUsersDataGridView(dgvFisheriesAgencyDB);
            dgvFisheriesAgencyDB.Refresh();
        }


        private void btnGetPermits_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMonths.Text, out int months))
            {
                DateTime expirationDate = DateTime.Today.AddMonths(months);
                string query = $"SELECT PermitNumber, IssueDate, ExpirationDate, Equipment, VesselId FROM FishingPermit WHERE ExpirationDate <= '{expirationDate.ToString("yyyy-MM-dd")}'";

                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable permitsTable = new DataTable();
                            adapter.Fill(permitsTable);
                            dgvFisheriesAgencyDB.DataSource = permitsTable;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number of months.");
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmUser frmUser = new Admin_Panel_Buttons.frmUser();
            frmUser.ShowDialog();
        }

        private void btnFishingPermits_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT PermitNumber, IssueDate, ExpirationDate, Equipment, VesselId FROM [FishingPermit]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvFisheriesAgencyDB.DataSource = dt;
            dgvFisheriesAgencyDB.Refresh();
        }

        private void btnVessels_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT VesselId, InternationalNumber, CallSign, Marking, Length, Width, Tonnage, Gas, Engine, Fuel FROM [Vessel]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvFisheriesAgencyDB.DataSource = dt;
            dgvFisheriesAgencyDB.Refresh();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TicketId, MemberId, StartDate, EndDate, Price, IsPensioner, IsDisabled, TelkDecisionNum FROM [Ticket]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvFisheriesAgencyDB.DataSource = dt;
            dgvFisheriesAgencyDB.Refresh();
        }

        private void btnBestCatchForTheYear_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT m.Name AS [Name], SUM(c.Weight) AS [Total Catch Weight (kg)]
                             FROM Catch c
                             INNER JOIN FishingTrip t ON c.FishingTripId = t.TripId
                             INNER JOIN FishingPermit p ON t.VesselId = p.VesselId
                             INNER JOIN Member m ON p.PermitNumber = m.Name
                             WHERE t.TripEnd >= DATEADD(year, -1, GETDATE())
                             GROUP BY m.Name
                             ORDER BY [Total Catch Weight (kg)] DESC";

                    SqlCommand command = new SqlCommand(query, connection);
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    dgvFisheriesAgencyDB.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving leaderboard: " + ex.Message);
            }
        }
    }
}

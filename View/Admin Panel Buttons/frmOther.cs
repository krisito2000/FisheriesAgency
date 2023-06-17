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

namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    public partial class frmOther : Form
    {
        public frmOther()
        {
            InitializeComponent();
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
                            dgvOther.DataSource = permitsTable;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number of months.");
            }
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

                    dgvOther.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving leaderboard: " + ex.Message);
            }
        }
        //Get Permits
        private void btnGetPermits_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnGetPermits);
        }

        private void btnGetPermits_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnGetPermits);
        }
        private void btnGetPermits_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnGetPermits);
        }
        private void btnGetPermits_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnGetPermits);
        }

        //Years Catch
        private void btnBestCatchForTheYear_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnBestCatchForTheYear);
        }

        private void btnBestCatchForTheYear_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnBestCatchForTheYear);
        }

        private void btnBestCatchForTheYear_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnBestCatchForTheYear);
        }

        private void btnBestCatchForTheYear_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnBestCatchForTheYear);
        }
    }
}

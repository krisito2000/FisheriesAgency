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
using FisheriesAgency.View.Admin_Panel_Buttons;

namespace FisheriesAgency.View
{

    public partial class frmAdminsPanel : Form
    {
        private static List<Form> openForms = new List<Form>();
        public frmAdminsPanel()
        {
            InitializeComponent();
        }


        private void btnGetPermits_Click(object sender, EventArgs e)
        {
            //if (int.TryParse(txtMonths.Text, out int months))
            //{
            //    DateTime expirationDate = DateTime.Today.AddMonths(months);
            //    string query = $"SELECT PermitNumber, IssueDate, ExpirationDate, Equipment, VesselId FROM FishingPermit WHERE ExpirationDate <= '{expirationDate.ToString("yyyy-MM-dd")}'";

            //    using (SqlConnection connection = new SqlConnection(Program.connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand(query, connection))
            //        {
            //            connection.Open();
            //            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            //            {
            //                DataTable permitsTable = new DataTable();
            //                adapter.Fill(permitsTable);
            //                dgvFisheriesAgencyDB.DataSource = permitsTable;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please enter a valid number of months.");
            //}
        }
        private void btnBestCatchForTheYear_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(Program.connectionString))
            //    {
            //        connection.Open();
            //        string query = @"SELECT m.Name AS [Name], SUM(c.Weight) AS [Total Catch Weight (kg)]
            //                 FROM Catch c
            //                 INNER JOIN FishingTrip t ON c.FishingTripId = t.TripId
            //                 INNER JOIN FishingPermit p ON t.VesselId = p.VesselId
            //                 INNER JOIN Member m ON p.PermitNumber = m.Name
            //                 WHERE t.TripEnd >= DATEADD(year, -1, GETDATE())
            //                 GROUP BY m.Name
            //                 ORDER BY [Total Catch Weight (kg)] DESC";

            //        SqlCommand command = new SqlCommand(query, connection);
            //        DataTable table = new DataTable();
            //        SqlDataAdapter adapter = new SqlDataAdapter(command);
            //        adapter.Fill(table);
            //        dgvFisheriesAgencyDB.DataSource = table;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error retrieving leaderboard: " + ex.Message);
            //}
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmUser frmUser = new Admin_Panel_Buttons.frmUser();
            frmUser.Show();
            openForms.Add(frmUser);
        }
        private void btnVessels_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmVessel frmVessel = new Admin_Panel_Buttons.frmVessel();
            frmVessel.Show();
            openForms.Add(frmVessel);
        }

        private void btnFishingPermits_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmFishingPermit frmPermits = new Admin_Panel_Buttons.frmFishingPermit();
            frmPermits.Show();
            openForms.Add(frmPermits);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmTicket frmTicket = new Admin_Panel_Buttons.frmTicket();
            frmTicket.Show();
            openForms.Add(frmTicket);
        }

        private void btnCaptains_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmCaptain frmCaptain = new Admin_Panel_Buttons.frmCaptain();
            frmCaptain.Show();
            openForms.Add(frmCaptain);
        }

        private void btnCatches_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmCatch frmCatch = new Admin_Panel_Buttons.frmCatch();
            frmCatch.Show();
            openForms.Add(frmCatch);
        }

        private void btnTrips_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmFishingTrip frmFishingTrip = new Admin_Panel_Buttons.frmFishingTrip();
            frmFishingTrip.Show();
            openForms.Add(frmFishingTrip);
        }

        private void btnInspector_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmInspector frmInspector = new Admin_Panel_Buttons.frmInspector();
            frmInspector.Show();
            openForms.Add(frmInspector);
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmMember frmMember = new Admin_Panel_Buttons.frmMember();
            frmMember.Show();
            openForms.Add(frmMember);
        }

        private void btnOwners_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmOwner frmOwner = new Admin_Panel_Buttons.frmOwner();
            frmOwner.Show();
            openForms.Add(frmOwner);
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmOther frmOther = new Admin_Panel_Buttons.frmOther();
            frmOther.Show();
            openForms.Add(frmOther);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (logout == DialogResult.Yes) 
            {
                foreach (Form form in openForms)
                {
                    if (form != this)
                    {
                        form.Close();
                    }
                }
                this.Hide();
            }
        }
    }
}

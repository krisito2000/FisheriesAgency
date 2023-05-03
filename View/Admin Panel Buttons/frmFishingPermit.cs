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
    public partial class frmFishingPermit : Form
    {
        private static void UpdateUsersDataGridView(DataGridView dgvFisheriesAgencyDB)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT PermitNumber, IssueDate, Equipment FROM [FishingPermit]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvFisheriesAgencyDB.DataSource = dt;
        }
        public frmFishingPermit()
        {
            InitializeComponent();
            UpdateUsersDataGridView(dgvFishingPermit);
        }

        private void dgvFishingPermit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Todo: make when you click cell it will replace everything in txt and dtp
        }
        //Todo: make create, edit and delete buttons to work
    }
}

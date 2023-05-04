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
    public partial class frmInspector : Form
    {
        private static void UpdateUsersDataGridView(DataGridView dgvFisheriesAgencyDB)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT InspectorId, InspectorDate FROM [Inspector]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvFisheriesAgencyDB.DataSource = dt;
        }
        public frmInspector()
        {
            InitializeComponent();
            UpdateUsersDataGridView(dgvInspector);
        }

        private void dgvInspector_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInspector.Rows[e.RowIndex];


                string inspectorDate = row.Cells["InspectorDate"].Value.ToString().Trim();

                dtpInspectorDate.Text = inspectorDate;
            }
        }
        //Todo: make create, edit and delete buttons to work
    }
}

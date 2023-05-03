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
    public partial class frmVessel : Form
    {
        private static void UpdateUsersDataGridView(DataGridView dgvFisheriesAgencyDB)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT VesselID, InternationalNumber, CallSign, Marking, Length, Width, Tonnage, Gas, Engine, Fuel FROM [Vessel]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvFisheriesAgencyDB.DataSource = dt;
        }
        public frmVessel()
        {
            InitializeComponent();
            UpdateUsersDataGridView(dgvVessel);
        }
        private void dgvReset()
        {
            UpdateUsersDataGridView(dgvVessel);
            dgvVessel.Refresh();
        }

        private void dgvVessel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVessel.Rows[e.RowIndex];


                string internationalNumber = row.Cells["InternationalNumber"].Value.ToString().Trim();
                string callSign = row.Cells["CallSign"].Value.ToString().Trim();
                string marking = row.Cells["Marking"].Value.ToString().Trim();
                string length = row.Cells["Length"].Value.ToString().Trim();
                string width = row.Cells["Width"].Value.ToString().Trim();
                string tonnage = row.Cells["Tonnage"].Value.ToString().Trim();
                string gas = row.Cells["Gas"].Value.ToString().Trim();
                string engine = row.Cells["Engine"].Value.ToString().Trim();
                string fuel = row.Cells["Fuel"].Value.ToString().Trim();

                txtInternationalNumber.Text = internationalNumber;
                txtCallSign.Text = callSign;
                txtMarking.Text = marking;
                txtLength.Text = length;
                txtWidth.Text = width;
                txtTonnage.Text = tonnage;
                txtGas.Text = gas;
                txtEngine.Text = engine;
                txtFuel.Text = fuel;
            }
        }
        // TODO: Write code for create, delete and edit button
    }
}

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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //using (SqlConnection connection = new SqlConnection(Program.connectionString))
            //{
            //    connection.Open();

            //    // Create a SQL INSERT statement with parameter placeholders
            //    string sql = "INSERT INTO Vessel (InternationalNumber, CallSign, Marking, Length, Width, Tonnage, Gas, Engine, Fuel, OwnerId, CaptainId) " +
            //                 "VALUES (@InternationalNumber, @CallSign, @Marking, @Length, @Width, @Tonnage, @Gas, @Engine, @Fuel, @OwnerId, @CaptainId)";

            //    // Create a SqlCommand object with the SQL statement and connection
            //    using (SqlCommand command = new SqlCommand(sql, connection))
            //    {
            //        // Set the parameter values from the text boxes
            //        command.Parameters.AddWithValue("@InternationalNumber", txtInternationalNumber.Text);
            //        command.Parameters.AddWithValue("@CallSign", txtCallSign.Text);
            //        command.Parameters.AddWithValue("@Marking", txtMarking.Text);
            //        command.Parameters.AddWithValue("@Length", decimal.Parse(txtLength.Text));
            //        command.Parameters.AddWithValue("@Width", decimal.Parse(txtWidth.Text));
            //        command.Parameters.AddWithValue("@Tonnage", decimal.Parse(txtTonnage.Text));
            //        command.Parameters.AddWithValue("@Gas", txtGas.Text);
            //        command.Parameters.AddWithValue("@Engine", txtEngine.Text);
            //        command.Parameters.AddWithValue("@Fuel", txtFuel.Text);
            //        command.Parameters.AddWithValue("@OwnerId", int.Parse(txtOwnerId.Text));
            //        command.Parameters.AddWithValue("@CaptainId", int.Parse(txtCaptainId.Text));

            //        // Execute the SQL command
            //        command.ExecuteNonQuery();
            //    }
            //}
        }
    }
}

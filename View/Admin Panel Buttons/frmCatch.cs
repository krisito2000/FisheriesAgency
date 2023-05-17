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
        private void dgvReset()
        {
            UpdateUsersDataGridView(dgvCatch);
            dgvCatch.Refresh();
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //string weight = txtWeight.Text;
            //string quantity = txtQuantity.Text;
            //if (string.IsNullOrEmpty(weight) || string.IsNullOrEmpty(quantity))
            //{
            //    MessageBox.Show("Please fill all spaces");
            //}

            //using (SqlConnection connection = new SqlConnection(Program.connectionString))
            //{
            //    connection.Open();

            //    // Create a SQL INSERT statement with parameter placeholders
            //    string sql = "INSERT INTO Catch (Weight, Quantity) VALUES (@Weight, @Quantity)";

            //    // Create a SqlCommand object with the SQL statement and connection
            //    using (SqlCommand command = new SqlCommand(sql, connection))
            //    {
            //        // Set the parameter values from the text boxes
            //        command.Parameters.AddWithValue("@Weight", txtWeight.Text);
            //        command.Parameters.AddWithValue("@Quantity", txtQuantity.Text);

            //        // Execute the SQL command
            //        command.ExecuteNonQuery();
            //    }
            //    dgvReset();
            //}
        }
    }
}

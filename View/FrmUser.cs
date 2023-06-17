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

namespace FisheriesAgency.View
{
    public partial class frmUser : Form
    {
        public int UserID { get; set; }
        public frmUser()
        {
            InitializeComponent();
            dgvInformation.DataSource = GetTicketsByUserID(UserID);

        }
        private DataTable GetTicketsByUserID(int userID)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM [Ticket] WHERE MemberId = @userID", connection);
                command.Parameters.AddWithValue("@userID", userID);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (logout == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

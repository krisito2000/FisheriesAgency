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

namespace FisheriesAgency.View
{
    public partial class frmAdminsPanel : Form
    {
        public frmAdminsPanel()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Username, Password, isAdministrator FROM [User]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvFisheriesAgencyDB.DataSource = dt;
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                string selectSql = "SELECT COUNT(*) FROM [User] WHERE Username = @username";
                string insertSql = "INSERT INTO [User] (Username, Password) VALUES (@username, @password)";

                if (username == string.Empty && password == string.Empty)
                {
                    MessageBox.Show("Please enter your username and password");
                }
                else if (username == string.Empty)
                {
                    MessageBox.Show("Please enter your username");
                }
                else if (password == string.Empty)
                {
                    MessageBox.Show("Please enter your password");
                }
                else
                {
                    // Need Model
                }
            }
        }
    }
}

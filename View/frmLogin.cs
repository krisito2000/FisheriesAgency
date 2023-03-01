using System.Data.SqlClient;
using FisheriesAgency.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FisheriesAgency
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();
        }

        //Making password visible

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

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
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand("SELECT isAdministrator FROM [User] WHERE Username = @username AND Password = @password", connection);

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();
                    object isAdminObj = command.ExecuteScalar();
                    connection.Close();

                    if (isAdminObj != null && isAdminObj != DBNull.Value)
                    {
                        bool isAdmin = (bool)isAdminObj;
                        if (isAdmin)
                        {
                            this.Hide();
                            frmAdminsPanel frmAdminsPanel = new frmAdminsPanel();
                            frmAdminsPanel.Show();
                            MessageBox.Show("Login successful as Administrator!");
                        }
                        else
                        {
                            MessageBox.Show("Login successful as User!");
                            //this.Hide();
                            //frmUser frmUser = new frmUser();
                            //frmUser.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
                }
            }
        }
    }
}
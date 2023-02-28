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
                SqlConnection connection = new SqlConnection(Program.connectionString);
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE Username = @username AND Password = @password", connection);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                int result = (int)command.ExecuteScalar();
                connection.Close();

                if (result > 0)
                {
                    this.Hide();
                    frmAdminsPanel frmAdminsPanel = new frmAdminsPanel();
                    frmAdminsPanel.Show();
                    MessageBox.Show("Login successful!");
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
        }
    }
}
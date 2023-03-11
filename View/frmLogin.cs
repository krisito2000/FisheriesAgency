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
                            MessageBox.Show($"Login successful as {username}");
                        }
                        else
                        {
                            this.Hide();
                            frmUser frmUser = new frmUser();
                            frmUser.Show();
                            MessageBox.Show($"Login successful as {username}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
                }
            }
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

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black;
            btnLogin.BackColor = Color.Aqua;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Aqua;
            btnLogin.BackColor = Color.DimGray;
        }

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.ForeColor = Color.Black;
            btnRegister.BackColor = Color.Aqua;
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.ForeColor = Color.Aqua;
            btnRegister.BackColor = Color.DimGray;
        }
        private void btnLogin_Enter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black;
            btnLogin.BackColor = Color.Aqua;
        }

        private void btnLogin_Leave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Aqua;
            btnLogin.BackColor = Color.DimGray;
        }
        private void btnRegister_Enter(object sender, EventArgs e)
        {
            btnRegister.ForeColor = Color.Black;
            btnRegister.BackColor = Color.Aqua;
        }

        private void btnRegister_Leave(object sender, EventArgs e)
        {
            btnRegister.ForeColor = Color.Aqua;
            btnRegister.BackColor = Color.DimGray;
        }
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                btnRegister.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txtPassword.Focus();
            }
            else if (e.KeyCode == Keys.Enter) 
            { 
                if (txtPassword.Text == string.Empty)
                {
                    txtPassword.Focus();
                }
                else if (txtUsername.Text == string.Empty)
                {
                    txtUsername.Focus();
                }
                else
                {
                    btnLogin.Focus();
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtUsername.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                btnLogin.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (txtUsername.Text == string.Empty)
                {
                    txtUsername.Focus();
                }
                if (txtPassword.Text == string.Empty)
                {
                    txtPassword.Focus();
                }
                else
                {
                    btnLogin.Focus();
                }
            }
        }

        private void btnViewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtUsername.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txtPassword.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                btnLogin.Focus();
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtPassword.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                btnViewPassword.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                btnRegister.Focus();
            }
        }

        private void btnRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                btnLogin.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txtUsername.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
using System.Data.SqlClient;
using FisheriesAgency.Properties;
using FisheriesAgency.Utils;
using FisheriesAgency.View;
using FisheriesAgency.Controller;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FisheriesAgency
{
    public partial class frmLogin : Form
    {
        public int UserID { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == string.Empty && password == string.Empty)
            {
                txtUsername.Focus();
                MessageBox.Show("Please enter your username and password");
            }
            else if (username == string.Empty)
            {
                txtUsername.Focus();
                MessageBox.Show("Please enter your username");
            }
            else if (password == string.Empty)
            {
                txtPassword.Focus();
                MessageBox.Show("Please enter your password");
            }
            else
            {
                LoginController.UserLoginController(this, username, password, txtPassword);
            }
        }


        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            PasswordToggle.Toggle(txtPassword, btnViewPassword);
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnLogin);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnLogin);
        }

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnRegister);
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnRegister);
        }
        private void btnLogin_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnLogin);
        }

        private void btnLogin_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnLogin);
        }
        private void btnRegister_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnRegister);
        }

        private void btnRegister_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnRegister);
        }
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
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
                    LoginController.UserLoginController(this, username, password, txtPassword);
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
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
                    LoginController.UserLoginController(this, username, password, txtPassword);
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
    }

}
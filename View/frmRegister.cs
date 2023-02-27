using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FisheriesAgency.Model;
using FisheriesAgency.Controller;

namespace FisheriesAgency.View
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();      
            frmLogin.Show();
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (username == string.Empty && password == string.Empty && confirmPassword == string.Empty)
            {
                MessageBox.Show("Please enter your username, password and confirm password");
            }
            else if (username == string.Empty && password == string.Empty)
            {
                MessageBox.Show("Please enter your username and password");
            }
            else if (username == string.Empty && confirmPassword == string.Empty)
            {
                MessageBox.Show("Please enter your username and confirm password");
            }
            else if (username == string.Empty)
            {
                MessageBox.Show("Please enter your username");
            }
            else if (password == string.Empty)
            {
                MessageBox.Show("Please enter your password");
            }
            else if (confirmPassword == string.Empty)
            {
                MessageBox.Show("Please enter your confirm password");
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Your password and confirm password must be the same");
            }

            //User user = new User();
            //user.Username = username;
            //user.Password = password;
        }
    }
}

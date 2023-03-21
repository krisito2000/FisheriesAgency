using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisheriesAgency.Utils
{
    internal static class PasswordToggle
    {
        public static void Toggle(TextBox txtPassword, Button btnViewPassword)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnViewPassword.BackColor = Color.Aqua;
            }
            else if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                btnViewPassword.BackColor = Color.DimGray;
            }
        }
        public static void ToggleRegister(TextBox txtPassword, TextBox txtConfirmPassword, Button btnViewPassword)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
                btnViewPassword.BackColor = Color.Aqua;
            }
            else if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
                btnViewPassword.BackColor = Color.DimGray;
            }
        }
    }
}

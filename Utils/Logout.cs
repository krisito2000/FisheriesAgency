using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisheriesAgency.Utils
{
    internal static class Logout
    {
        public static void LogoutHelper(Form form)
        {
            frmLogin frmLogin = new frmLogin();
            form.Hide();
            frmLogin.ShowDialog();
        }
    }
}

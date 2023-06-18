using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FisheriesAgency.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FisheriesAgency.Controller
{
    public class LoginController
    {
        public static int GetUserIDController(string username)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT UserID FROM [User] WHERE Username = @username", connection);
                command.Parameters.AddWithValue("@username", username);

                connection.Open();
                object userIDObj = command.ExecuteScalar();
                connection.Close();

                if (userIDObj != null && userIDObj != DBNull.Value)
                {
                    return (int)userIDObj;
                }

                return -1; // Return -1 if the user ID is not found
            }
        }
        public static void UserLoginController(Form thisForm, string username, string password, TextBox txtPassword)
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
                        txtPassword.Text = null;
                        thisForm.Hide();
                        frmAdminsPanel frmAdminsPanel = new frmAdminsPanel();
                        frmAdminsPanel.ShowDialog();
                    }
                    else
                    {
                        int userID = GetUserIDController(username);
                        txtPassword.Text = null;
                        thisForm.Hide();
                        frmUser frmUser = new frmUser();
                        frmUser.UserID = userID; // Pass the user ID to the frmUser form
                        frmUser.ShowDialog();
                    }
                    thisForm.Show();
                }
                else
                {
                    txtPassword.Text = null;
                    txtPassword.Focus();
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
        }
    }
}

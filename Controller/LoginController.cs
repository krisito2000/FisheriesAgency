using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

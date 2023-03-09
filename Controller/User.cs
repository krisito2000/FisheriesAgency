using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FisheriesAgency.Controller
{
    internal class User
    {
        static string GetUser(string username)
        {
            //string connectionString = DatabaseHelper.GetLocalDbConnectionString("FisheriesAgencyDB");
            string password = "";
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();
                string sqlquery = "SELECT * FROM Users WHERE username = @UName";
                SqlCommand command = new SqlCommand(sqlquery, con);

                command.Parameters.AddWithValue("@UName", username);
                SqlDataReader sReader = command.ExecuteReader();

                while (sReader.Read())
                {
                    username = sReader["username"].ToString();
                    password = sReader["password"].ToString();
                }
                con.Close();
            }
            return password;
        }
    }
}

using FisheriesAgency.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisheriesAgency.Controller
{
    public class ComboBoxController
    {
        public static void VesselController(ComboBox cbVessels)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "SELECT VesselId, InternationalNumber FROM Vessel";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int vesselId = reader.GetInt32(0);
                            string internationalNumber = reader.GetString(1);

                            // Add the vessel to the ComboBox items and store the ID as the item value
                            cbVessels.Items.Add(new ComboBoxVessel(internationalNumber, vesselId));
                        }
                    }
                }
            }
        }
        public static void OwnerController(ComboBox cmbOwners)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "SELECT OwnerId, Name FROM Owner";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ownerId = reader.GetInt32(0);
                            string name = reader.GetString(1);

                            // Add the name to the ComboBox items and store the ID as the item value
                            cmbOwners.Items.Add(new ComboBoxModel.ComboBoxOwner(name, ownerId));
                        }
                    }
                }
            }
        }
        public static void CaptainController(ComboBox cmbCaptains)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "SELECT CaptainId, Name FROM Captain";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int captainId = reader.GetInt32(0);
                            string name = reader.GetString(1);


                            // Add the name to the ComboBox items and store the ID as the item value
                            cmbCaptains.Items.Add(new ComboBoxCaptain(name, captainId));
                        }
                    }
                }
            }
        }
        public static void MemberController(ComboBox cmbMember) 
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "SELECT MemberId, Name FROM Member";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int memberId = reader.GetInt32(0);
                            string name = reader.GetString(1);

                            // Create a new Member object
                            ComboBoxMember member = new ComboBoxMember(memberId, name);

                            // Add the member to the combo box
                            cmbMember.Items.Add(member);
                        }
                    }
                }
            }
        }
        public static void TripController(ComboBox cmbTrip)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "SELECT TripId, VesselId FROM [FishingTrip]";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int tripId = reader.GetInt32(0);
                            int vesselId = reader.GetInt32(1);

                            // Create a new trip object
                            ComboBoxTrip trip = new ComboBoxTrip(tripId, vesselId);

                            // Add the trip to the combo box
                            cmbTrip.Items.Add(trip);
                        }
                    }
                }
            }
        }
    }
}

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace FisheriesAgency.Controller
{
    public class AdminPanelController
    {
        //
        // User form
        //
        public static void UserDeleteController(int userId)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("DELETE FROM [User] WHERE UserID = @UserId", connection);
                command.Parameters.AddWithValue("@UserId", userId);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static void UserEditController(TextBox txtUsername, TextBox txtPassword, CheckBox cbAdmin, DataGridView dgvUser) 
        {
            // Get the selected row
            DataGridViewRow row = dgvUser.SelectedRows[0];

            // Get the user ID from the selected row
            int userId = (int)row.Cells["UserID"].Value;

            // Get the new username and password from the textboxes
            string newUsername = txtUsername.Text.Trim();
            string newPassword = txtPassword.Text.Trim();
            bool newAdmin = cbAdmin.Checked;

            // Check if the new username already exists in the database
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE Username = @Username AND UserID <> @UserId", connection);
                checkCommand.Parameters.AddWithValue("@Username", newUsername);
                checkCommand.Parameters.AddWithValue("@UserId", userId);
            }

            // Update the user in the local database
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [User] SET Username = @Username, Password = @Password, isAdministrator = @newAdmin WHERE UserID = @UserId", connection);
                updateCommand.Parameters.AddWithValue("@Username", newUsername);
                updateCommand.Parameters.AddWithValue("@Password", newPassword);
                updateCommand.Parameters.AddWithValue("@newAdmin", newAdmin);
                updateCommand.Parameters.AddWithValue("@UserId", userId);
                updateCommand.ExecuteNonQuery();

                connection.Close();
            }
        }
        //
        // Vessel form
        //
        public static void VesselCreateController(TextBox txtInternationalNumber, TextBox txtCallSign, TextBox txtMarking, TextBox txtLength, TextBox txtWidth, TextBox txtTonnage, TextBox txtGas, TextBox txtEngine, TextBox txtFuel, int ownerId, int captainId)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                // Create a SQL INSERT statement with parameter placeholders
                string sql = "INSERT INTO Vessel (InternationalNumber, CallSign, Marking, Length, Width, Tonnage, Gas, Engine, Fuel, OwnerId, CaptainId) " +
                             "VALUES (@InternationalNumber, @CallSign, @Marking, @Length, @Width, @Tonnage, @Gas, @Engine, @Fuel, @OwnerId, @CaptainId)";

                // Create a SqlCommand object with the SQL statement and connection
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Set the parameter values from the text boxes
                    command.Parameters.AddWithValue("@InternationalNumber", txtInternationalNumber.Text);
                    command.Parameters.AddWithValue("@CallSign", txtCallSign.Text);
                    command.Parameters.AddWithValue("@Marking", txtMarking.Text);
                    command.Parameters.AddWithValue("@Length", decimal.Parse(txtLength.Text));
                    command.Parameters.AddWithValue("@Width", decimal.Parse(txtWidth.Text));
                    command.Parameters.AddWithValue("@Tonnage", decimal.Parse(txtTonnage.Text));
                    command.Parameters.AddWithValue("@Gas", txtGas.Text);
                    command.Parameters.AddWithValue("@Engine", txtEngine.Text);
                    command.Parameters.AddWithValue("@Fuel", txtFuel.Text);
                    command.Parameters.AddWithValue("@OwnerId", ownerId);
                    command.Parameters.AddWithValue("@CaptainId", captainId);

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void VesselDeleteController(int vesselId)
        {
            // Delete the vessel from the database
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand deleteCommand = new SqlCommand("DELETE FROM [Vessel] WHERE VesselID = @VesselId", connection);
                deleteCommand.Parameters.AddWithValue("@VesselId", vesselId);
                deleteCommand.ExecuteNonQuery();

                connection.Close();
            }
        }
        public static void VesselEditController(string internationalNumber, string callSign, string marking, decimal length, decimal width, decimal tonnage, string gas, string engine, string fuel, int vesselId)
        {
            // Update the vessel in the database
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [Vessel] SET InternationalNumber = @InternationalNumber, CallSign = @CallSign, Marking = @Marking, Length = @Length, Width = @Width, Tonnage = @Tonnage, Gas = @Gas, Engine = @Engine, Fuel = @Fuel WHERE VesselID = @VesselId", connection);
                updateCommand.Parameters.AddWithValue("@InternationalNumber", internationalNumber);
                updateCommand.Parameters.AddWithValue("@CallSign", callSign);
                updateCommand.Parameters.AddWithValue("@Marking", marking);
                updateCommand.Parameters.AddWithValue("@Length", length);
                updateCommand.Parameters.AddWithValue("@Width", width);
                updateCommand.Parameters.AddWithValue("@Tonnage", tonnage);
                updateCommand.Parameters.AddWithValue("@Gas", gas);
                updateCommand.Parameters.AddWithValue("@Engine", engine);
                updateCommand.Parameters.AddWithValue("@Fuel", fuel);
                updateCommand.Parameters.AddWithValue("@VesselId", vesselId);
                updateCommand.ExecuteNonQuery();

                connection.Close();
            }
        }
        //
        // Permits form
        //
        public static void PermitsCreateController(TextBox txtPermitNumber, DateTimePicker dtpIssueDate, DateTimePicker dtpExpirationDate, TextBox txtEquipment, int vesselId)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                // Create a SQL INSERT statement with parameter placeholders
                string sql = "INSERT INTO FishingPermit (PermitNumber, IssueDate, ExpirationDate, Equipment, VesselId) " +
                             "VALUES (@PermitNumber, @IssueDate, @ExpirationDate, @Equipment, @VesselId)";

                // Create a SqlCommand object with the SQL statement and connection
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Set the parameter values from the form controls
                    command.Parameters.AddWithValue("@PermitNumber", txtPermitNumber.Text);
                    command.Parameters.AddWithValue("@IssueDate", dtpIssueDate.Value.Date);
                    command.Parameters.AddWithValue("@ExpirationDate", dtpExpirationDate.Value.Date);
                    command.Parameters.AddWithValue("@Equipment", txtEquipment.Text);
                    command.Parameters.AddWithValue("@VesselId", vesselId);

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void PermitsDeleteController(int permitId)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand deleteCommand = new SqlCommand("DELETE FROM [FishingPermit] WHERE PermitId = @PermitId", connection);
                deleteCommand.Parameters.AddWithValue("@PermitId", permitId);
                deleteCommand.ExecuteNonQuery();

                connection.Close();
            }
        }
        public static void PermitsEditController(string permitNumber, DateTime issueDate, DateTime expirationDate, string equipment, int vesselId, int permitId)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "UPDATE [FishingPermit] SET PermitNumber = @PermitNumber, IssueDate = @IssueDate, ExpirationDate = @ExpirationDate, Equipment = @Equipment,VesselId = @VesselId WHERE PermitId = @PermitId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@PermitNumber", permitNumber);
                    command.Parameters.AddWithValue("@IssueDate", issueDate);
                    command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                    command.Parameters.AddWithValue("@Equipment", equipment);


                    command.Parameters.AddWithValue("@VesselId", vesselId);
                    command.Parameters.AddWithValue("@PermitId", permitId);

                    command.ExecuteNonQuery();
                }
            }
        }
        //
        // Ticket form
        //
        public static void TicketCreateController(int memberId, DateTimePicker dtpStartDate, DateTimePicker dtpEndDate, TextBox txtPrice, CheckBox cbIsPensioner, CheckBox cbIsDisabled, TextBox txtTelk)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Ticket (MemberId, StartDate, EndDate, Price, IsPensioner, IsDisabled, TelkDecisionNum) " +
                             "VALUES (@MemberId, @StartDate, @EndDate, @Price, @IsPensioner, @IsDisabled, @TelkDecisionNum)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MemberId", memberId);
                    command.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                    command.Parameters.AddWithValue("@EndDate", dtpEndDate.Value);
                    command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                    command.Parameters.AddWithValue("@IsPensioner", cbIsPensioner.Checked);
                    command.Parameters.AddWithValue("@IsDisabled", cbIsDisabled.Checked);
                    command.Parameters.AddWithValue("@TelkDecisionNum", txtTelk.Text);

                    command.ExecuteNonQuery();
                }
            }
        }
        public static void TicketDeleteController(int ticketId)
        {
            // Execute a SQL DELETE statement to remove the record from the database
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM Ticket WHERE TicketID = @TicketID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TicketID", ticketId);

                    command.ExecuteNonQuery();
                }
            }
        }
        public static void TicketEditController(string newStartDate, string newEndDate, string newPrice, bool newIsPensioner, bool newIsDisabled, int ticketId)
        {
            // Update the ticket in the database
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE Ticket SET StartDate = @StartDate, EndDate = @EndDate, Price = @Price, IsPensioner = @IsPensioner, IsDisabled = @IsDisabled WHERE TicketID = @TicketId", connection);
                updateCommand.Parameters.AddWithValue("@StartDate", newStartDate);
                updateCommand.Parameters.AddWithValue("@EndDate", newEndDate);
                updateCommand.Parameters.AddWithValue("@Price", newPrice);
                updateCommand.Parameters.AddWithValue("@IsPensioner", newIsPensioner);
                updateCommand.Parameters.AddWithValue("@IsDisabled", newIsDisabled);
                updateCommand.Parameters.AddWithValue("@TicketId", ticketId);
                // Add parameters for other relevant columns if needed

                updateCommand.ExecuteNonQuery();

                connection.Close();
            }
        }
        //
        // Captain form
        //
        public static void CaptainCreateController(TextBox txtName, TextBox txtAddress)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                // Check if the name already exists in the database
                string checkSql = "SELECT COUNT(*) FROM Captain WHERE Name = @Name";
                using (SqlCommand checkCommand = new SqlCommand(checkSql, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Name", txtName.Text);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Name already exists");
                        return;
                    }
                }
                // Create a SQL INSERT statement with parameter placeholders
                string sql = "INSERT INTO Captain (Name, Address) VALUES (@Name, @Address)";

                // Create a SqlCommand object with the SQL statement and connection
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Set the parameter values from the text boxes
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@Address", txtAddress.Text);

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void CaptainDeleteController(TextBox txtName, TextBox txtAddress)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM Captain WHERE Name = @Name AND Address = @Address";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    command.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Clear the text boxes
                        txtName.Text = string.Empty;
                        txtAddress.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Captain not found or deletion failed.");
                        return;
                    }
                }
            }
        }
        public static void CaptainEditController(TextBox txtName, TextBox txtAddress, DataGridView dgvCaptain)
        {
            DataGridViewRow row = dgvCaptain.SelectedRows[0];
            int captainId = (int)row.Cells["CaptainId"].Value;
            string newName = txtName.Text.Trim();
            string newAddress = txtAddress.Text.Trim();

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [Captain] WHERE Name = @Name AND Address <> @Address AND CaptainId <> @CaptainId", connection);
                checkCommand.Parameters.AddWithValue("@Name", newName);
                checkCommand.Parameters.AddWithValue("@Address", newAddress);
                checkCommand.Parameters.AddWithValue("@CaptainId", captainId);


                using (SqlConnection conn = new SqlConnection(Program.connectionString))
                {
                    conn.Open();

                    SqlCommand updateCommand = new SqlCommand("UPDATE [Captain] SET Name = @Name, Address = @Address WHERE CaptainId = @CaptainId", conn);
                    updateCommand.Parameters.AddWithValue("@Name", newName);
                    updateCommand.Parameters.AddWithValue("@Address", newAddress);
                    updateCommand.Parameters.AddWithValue("@CaptainId", captainId);
                    updateCommand.ExecuteNonQuery();

                    conn.Close();
                }
                connection.Close();
            }
        }
        //
        // Catch form
        //
        public static void CatchCreateController(string weight, string quantity, int tripId)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                // Create a SQL INSERT statement with parameter placeholders
                string sql = "INSERT INTO Catch (FishingTripId, Weight, Quantity) VALUES (@TripId, @Weight, @Quantity)";

                // Create a SqlCommand object with the SQL statement and connection
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Set the parameter values from the text boxes
                    command.Parameters.AddWithValue("@Weight", weight);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@TripId", tripId);

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void CatchDeleteController(int catchId)
        {
            // Execute a SQL DELETE statement to remove the record from the database
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM [Catch] WHERE CatchId = @CatchId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@CatchId", catchId);

                    command.ExecuteNonQuery();
                }
            }
        }
        public static void CatchEditController(int tripId, string weight, string quantity, int catchId)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "UPDATE [Catch] SET FishingTripId = @TripId, Weight = @Weight, Quantity = @Quantity WHERE CatchId = @CatchId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TripId", tripId);
                    command.Parameters.AddWithValue("@Weight", weight);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@CatchId", catchId);

                    command.ExecuteNonQuery();
                }
            }
        }
        //
        // Trip form
        //
        public static void TripDeleteController(int tripId)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand deleteCommand = new SqlCommand("DELETE FROM [FishingTrip] WHERE TripId = @TripId", connection);
                deleteCommand.Parameters.AddWithValue("@TripId", tripId);
                deleteCommand.ExecuteNonQuery();

                connection.Close();
            }
        }
        public static void TripEditController(string newTripStart, string newTripEnd, string newCatch, int tripId)
        {
            // Update the ticket in the database
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [FishingTrip] SET TripStart = @TripStart, TripEnd = @TripEnd, CatchAmount = @CatchAmount WHERE TripID = @TripId", connection);
                updateCommand.Parameters.AddWithValue("@TripStart", newTripStart);
                updateCommand.Parameters.AddWithValue("@TripEnd", newTripEnd);
                updateCommand.Parameters.AddWithValue("@CatchAmount", newCatch);
                updateCommand.Parameters.AddWithValue("@TripId", tripId);
                // Add parameters for other relevant columns if needed

                updateCommand.ExecuteNonQuery();

                connection.Close();
            }
        }
        //
        // Inspector form
        //
        public static void InspectorCreateController(DateTime inspectorDate, int vesselId)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Inspector (InspectorDate, VesselId) VALUES (@InspectorDate, @VesselId)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@InspectorDate", inspectorDate);
                    command.Parameters.AddWithValue("@VesselId", vesselId);

                    command.ExecuteNonQuery();
                }
            }
        }
        public static void InspectorDeleteController(int inspectorId)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM Inspector WHERE InspectorId = @InspectorId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@InspectorId", inspectorId);

                    command.ExecuteNonQuery();

                }
            }
        }
        public static void InspectorEditController(DateTime inspectorDate, int vesselId, int inspectorId)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "UPDATE Inspector SET InspectorDate = @InspectorDate, VesselId = @VesselId WHERE InspectorId = @InspectorId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@InspectorDate", inspectorDate);
                    command.Parameters.AddWithValue("@VesselId", vesselId);
                    command.Parameters.AddWithValue("@InspectorId", inspectorId);

                    command.ExecuteNonQuery();

                }
            }
        }
        //
        // Member form
        //
        public static void MemberCreateController(string name, string address)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                // Check if the name already exists in the database
                string checkSql = "SELECT COUNT(*) FROM Member WHERE Name = @Name";
                using (SqlCommand checkCommand = new SqlCommand(checkSql, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Name", name);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Name already exists");
                        return;
                    }
                    // Create a SQL INSERT statement with parameter placeholders
                    string sql = "INSERT INTO Member (name, address) VALUES (@Name, @Address)";

                    // Create a SqlCommand object with the SQL statement and connection
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Set the parameter values from the text boxes
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Address", address);

                        // Execute the SQL command
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        public static void MemberDeleteController(string name, string address)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM Member WHERE Name = @Name AND Address = @Address";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Address", address);


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Clear the text boxes
                        name = string.Empty;
                        address = string.Empty;

                    }
                    else
                    {
                        MessageBox.Show("Owner not found or deletion failed.");
                    }
                }
            }
        }
        public static void MemberEditController(string newName, string newAddress, int memberId)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [Member] WHERE Name = @Name AND Address <> @Address", connection);
                checkCommand.Parameters.AddWithValue("@Name", newName);
                checkCommand.Parameters.AddWithValue("@Address", newAddress);
                checkCommand.Parameters.AddWithValue("@MemberId", memberId);
            }

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [Member] SET Name = @Name, Address = @Address WHERE MemberId = @MemberId", connection);
                updateCommand.Parameters.AddWithValue("@Name", newName);
                updateCommand.Parameters.AddWithValue("@Address", newAddress);
                updateCommand.Parameters.AddWithValue("@MemberId", memberId);
                updateCommand.ExecuteNonQuery();

                connection.Close();
            }
        }
        //
        // Owner form
        //
        public static void OwnerCreateController(string name, string address)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                // Check if the name already exists in the database
                string checkSql = "SELECT COUNT(*) FROM [Owner] WHERE name = @Name";
                using (SqlCommand checkCommand = new SqlCommand(checkSql, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Name", name);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Name already exists");
                        return;
                    }
                }

                // Create a SQL INSERT statement with parameter placeholders
                string sql = "INSERT INTO Owner (name, address) VALUES (@Name, @Address)";

                // Create a SqlCommand object with the SQL statement and connection
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Set the parameter values from the text boxes
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Address", address);

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }

            }
        }
        public static void OwnerDeleteController(string name, string address)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    connection.Open();

                    string sql = "DELETE FROM Owner WHERE name = @Name AND address = @Address";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Address", address);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Clear the text boxes
                            name = string.Empty;
                            address = string.Empty;

                        }
                        else
                        {
                            MessageBox.Show("Owner not found or deletion failed.");
                        }
                    }
                }
            }
        }
        public static void OwnerEditController(string newName, string newAddress, int ownerId)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [Owner] WHERE name = @name AND address <> @address", connection);
                checkCommand.Parameters.AddWithValue("@name", newName);
                checkCommand.Parameters.AddWithValue("@address", newAddress);
                checkCommand.Parameters.AddWithValue("@OwnerId", ownerId);
            }

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [Owner] SET name = @name, address = @address WHERE OwnerID = @OwnerId", connection);
                updateCommand.Parameters.AddWithValue("@name", newName);
                updateCommand.Parameters.AddWithValue("@address", newAddress);
                updateCommand.Parameters.AddWithValue("@OwnerId", ownerId);
                updateCommand.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ApexCareApp.Control
{
    public class DataHandler
    {
        private readonly string connectionString = "Data Source=GERHARD-PC\\SQLEXPRESS;Initial Catalog=ApexCareDB;Integrated Security=True";

        public DataHandler()
        {
            
        }
        public DataTable GetClientData()
        {
            DataTable dataTable = new DataTable();

            string query = @"
                SELECT 
                    c.ClientName, 
                    c.ContactNumber, 
                    c.ContactPerson, 
                    sc.ContractLevel, 
                    sc.City, 
                    ISNULL(AVG(cf.SatisfactionRating), 0) AS AverageFeedbackScore
                FROM 
                    Client c
                JOIN 
                    ServiceContract sc ON c.ClientID = sc.ClientID
                JOIN 
                    ServiceRequest sr ON sc.ContractID = sr.ContractID
                LEFT JOIN 
                    CustomerFeedback cf ON sr.RequestID = cf.ServiceRequestID
                GROUP BY 
                    c.ClientName, 
                    c.ContactNumber, 
                    c.ContactPerson, 
                    sc.ContractLevel, 
                    sc.City;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.Fill(dataTable);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}");
            }
            return dataTable;
        }

        public DataTable GetTechnicianData()
        {
            DataTable dataTable = new DataTable();

            string query = @"
             SELECT 
                t.Name AS TechnicianName, 
                t.Type AS TechnicianType, 
                t.PhoneNum, 
                t.City, 
                ISNULL(AVG(cf.SatisfactionRating), 0) AS AverageFeedbackScore
             FROM 
                Technician t
             LEFT JOIN 
                ServiceRequest sr ON t.TechnicianID = sr.TechnicianID
             LEFT JOIN 
                CustomerFeedback cf ON sr.RequestID = cf.ServiceRequestID
             GROUP BY 
                t.Name, 
                t.Type, 
                t.PhoneNum, 
                t.City;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving technician data: {ex.Message}");
            }

            return dataTable;
        }

        public DataRow GetTechnicianByID(int technicianID)
        {
            DataTable dataTable = new DataTable();
            string query = @"
             SELECT 
                Name, 
                PhoneNum, 
                Suburb, 
                City, 
                Province, 
                Type
             FROM 
                Technician
             WHERE 
                TechnicianID = @TechnicianID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TechnicianID", technicianID);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving technician data: {ex.Message}");
            }

            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0];
            }
            return null;
        }

        public DataTable GetTechnicianSpecializations(int technicianID)
        {
            DataTable dataTable = new DataTable();

            string query = @"
         SELECT 
            EquipmentSpecialty
         FROM 
            TechnicianEquipment
         WHERE 
            TechnicianID = @TechnicianID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TechnicianID", technicianID);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving technician specializations: {ex.Message}");
            }

            return dataTable;
        }
        public DataTable GetTechnicianRequests(int technicianID)
        {
            DataTable dataTable = new DataTable();

            string query = @"
         SELECT 
            sr.RequestID, 
            sc.City, 
            sr.RequestIssue, 
            LastUpdate.LatestUpdate AS LatestUpdate, 
            sr.Completed
         FROM 
            ServiceRequest sr
         JOIN 
            ServiceContract sc ON sr.ContractID = sc.ContractID
         OUTER APPLY 
         (
            SELECT TOP 1 [value] AS LatestUpdate 
            FROM OPENJSON(sr.Updates) 
            ORDER BY [key] DESC
         ) LastUpdate
         WHERE 
            sr.TechnicianID = @TechnicianID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TechnicianID", technicianID);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving technician requests: {ex.Message}");
            }

            return dataTable;
        }

        public void UpdateRequest(int requestID, string newUpdateMessage, bool isCompleted)
        {
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

            string formattedUpdate = $"{{\"{currentDate}\": \"{newUpdateMessage}\"}}";

            string query = @"
         UPDATE ServiceRequest
         SET Updates = JSON_MODIFY(Updates, 'append $', @formattedUpdate),
            Completed = @isCompleted
         WHERE RequestID = @RequestID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RequestID", requestID);
                        command.Parameters.AddWithValue("@formattedUpdate", formattedUpdate);
                        command.Parameters.AddWithValue("@isCompleted", isCompleted ? 1 : 0);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating the request: {ex.Message}");
            }
        }

        public DataRow GetClientByID(int clientID)
        {
            DataTable dataTable = new DataTable();
            string query = @"
         SELECT 
            ClientName, 
            ContactPerson, 
            EmailAddress, 
            ContactNumber
         FROM 
            Client
         WHERE 
            ClientID = @ClientID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClientID", clientID);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving client data: {ex.Message}");
            }

            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0];
            }
            return null;
        }

        public DataTable GetClientContracts(int clientID)
        {
            DataTable dataTable = new DataTable();
            string query = @"
         SELECT 
            sc.ContractLevel, 
            sc.City, 
            sc.ContractStart, 
            sc.ContractEnd, 
            sc.Equipment
         FROM 
            ServiceContract sc
         WHERE 
            sc.ClientID = @ClientID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClientID", clientID);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving client contracts: {ex.Message}");
            }

            return dataTable;
        }

        public DataTable GetClientServiceRequests(int clientID)
        {
            DataTable dataTable = new DataTable();
            string query = @"
         SELECT 
            sr.RequestID, 
            sc.City, 
            sr.RequestIssue, 
            LatestUpdate.LatestUpdate AS LatestUpdate, 
            sr.Completed,
            t.Name AS TechnicianName
         FROM 
             ServiceRequest sr
         JOIN 
            ServiceContract sc ON sr.ContractID = sc.ContractID
         JOIN 
            Technician t ON sr.TechnicianID = t.TechnicianID
         OUTER APPLY 
         (
         SELECT TOP 1 value AS LatestUpdate
         FROM OPENJSON(sr.Updates) 
         ORDER BY [key] DESC
         ) LatestUpdate
         WHERE 
            sc.ClientID = @ClientID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClientID", clientID);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving service requests: {ex.Message}");
            }

            return dataTable;
        }

        public void SubmitFeedback(int requestID, int satisfactionRating, string feedbackMessage, bool requiresFollowUp)
        {
            string query = @"
            INSERT INTO CustomerFeedback (ServiceRequestID, FeedbackText, SatisfactionRating, RequiresFollowUp)
            VALUES (@ServiceRequestID, @FeedbackText, @SatisfactionRating, @RequiresFollowUp)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ServiceRequestID", requestID);
                        command.Parameters.AddWithValue("@FeedbackText", feedbackMessage);
                        command.Parameters.AddWithValue("@SatisfactionRating", satisfactionRating);
                        command.Parameters.AddWithValue("@RequiresFollowUp", requiresFollowUp);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error submitting feedback: {ex.Message}");
            }
        }
    }
}


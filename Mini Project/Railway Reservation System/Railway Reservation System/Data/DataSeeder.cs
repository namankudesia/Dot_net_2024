using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Railway_Reservation_System.Data
{
    public static class DataSeeder
    {
        public static void SeedData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Train_Reservation"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SeedTrains(conn);
                SeedUsers(conn);
            }
        }
        private static void SeedTrains(SqlConnection conn)
        {
            string query = "IF NOT EXISTS (SELECT * FROM Trains) BEGIN " +
                           "INSERT INTO Trains VALUES (12179, 'InterCity SF Express', 'Lucknow Junction', 'Agra Fort', 145, 'SL', 'Active', 780), " +
                           "(12583, 'AC Double Decker Express', 'Lucknow Junction', 'Anand Vihar Terminal', 560, 'CC', 'Inactive', 120), " +
                           "(22426, 'Vande Bharat Express', 'Anand Vihar Terminal JN', 'Ayodhya Cantt.', 1450, '2AC', 'Active', 30), " +
                           "(82501, 'IRCTC Tejas Express', 'Lucknow Junction', 'New Delhi', 2500, '1AC', 'Active', 15) END";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        private static void SeedUsers(SqlConnection conn)
        {
            string query = "IF NOT EXISTS (SELECT * FROM Users) BEGIN " +
                           "INSERT INTO Users (User_Name, Password, Role) VALUES ('admin', 'admin123', 'admin'), ('user', 'user123', 'user') END";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
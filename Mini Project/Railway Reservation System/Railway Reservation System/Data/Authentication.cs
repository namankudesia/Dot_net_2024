using System;
using System.Data.SqlClient;
using System.Configuration;
using Railway_Reservation_System.Models;

namespace Railway_Reservation_System.Data
{
    public static class Authentication
    {
        public static Users Login(string username, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Train_Reservation"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT User_ID, User_Name, Password, Role FROM Users WHERE User_Name = @username AND Password = @password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Users
                            {
                                User_ID = (int)reader["User_ID"],
                                User_Name = reader["User_Name"].ToString(),
                                Password = reader["Password"].ToString(),
                                role = reader["Role"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
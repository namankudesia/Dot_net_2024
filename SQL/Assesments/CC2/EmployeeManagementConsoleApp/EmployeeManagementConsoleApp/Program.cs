using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=ICS-LT-C54R4D3\SQLEXPRESS;database=Employee_Management;Integrated Security=true;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("add_Employee", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Empname", "Naman Kudesia");
                command.Parameters.AddWithValue("@Empsal", 100000.00);
                command.Parameters.AddWithValue("@Emptype", "P");
                int empno = (int)command.ExecuteScalar();
                Console.WriteLine($"Employee added with Empno: {empno}");
                Console.ReadKey();
                connection.Close();
            }
        }
    }
}

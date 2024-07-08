using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignments6_Fifth_Week_

{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public decimal EmpSalary { get; set; }
        public Employee(int empId, string empName, string empCity, decimal empSalary)
        {
            EmpId = empId;
            EmpName = empName;
            EmpCity = empCity;
            EmpSalary = empSalary;
        }
    }
    public class Class2
    {
        public static void Main()
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter number of employees: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfEmployees))
            {
                for (int i = 0; i < numberOfEmployees; i++)
                {
                    Console.WriteLine($"\nEnter details for Employee {i + 1}:");
                    Console.Write("EmpId: ");
                    int empId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("EmpName: ");
                    string empName = Console.ReadLine();

                    Console.Write("EmpCity: ");
                    string empCity = Console.ReadLine();

                    Console.Write("EmpSalary: ");
                    decimal empSalary = Convert.ToDecimal(Console.ReadLine());

                    employees.Add(new Employee(empId, empName, empCity, empSalary));
                }
                Console.WriteLine("\nEmployee data entered successfully.\n");
                while (true)
                {
                    Console.WriteLine("1. Display all employees");
                    Console.WriteLine("2. Display employees with salary greater than 45000");
                    Console.WriteLine("3. Display employees from Bangalore");
                    Console.WriteLine("4. Display employees sorted by name (ascending)");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice (1-5): ");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("\nDisplaying all employees:");
                            DisplayAllEmployees(employees);
                            break;

                        case "2":
                            Console.WriteLine("\nDisplaying employees with salary greater than 45000:");
                            DisplayEmployeesWithSalaryGreaterThan(employees, 45000);
                            break;

                        case "3":
                            Console.WriteLine("\nDisplaying employees from Bangalore:");
                            DisplayEmployeesFromCity(employees, "Bangalore");
                            break;

                        case "4":
                            Console.WriteLine("\nDisplaying employees sorted by name (ascending):");
                            DisplayEmployeesSortedByNameAscending(employees);
                            break;

                        case "5":
                            Console.WriteLine("\nExiting program.");
                            return;

                        default:
                            Console.WriteLine("\nInvalid choice. Please enter a number from 1 to 5.");
                            break;
                    }

                    Console.WriteLine(); 
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        private static void DisplayAllEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"EmpId: {employee.EmpId}, EmpName: {employee.EmpName}, EmpCity: {employee.EmpCity}, EmpSalary: {employee.EmpSalary}");
            }
        }
        private static void DisplayEmployeesWithSalaryGreaterThan(List<Employee> employees, decimal salaryThreshold)
        {
            var filteredEmployees = employees.Where(e => e.EmpSalary > salaryThreshold);
            foreach (var employee in filteredEmployees)
            {
                Console.WriteLine($"EmpId: {employee.EmpId}, EmpName: {employee.EmpName}, EmpCity: {employee.EmpCity}, EmpSalary: {employee.EmpSalary}");
            }
        }
        private static void DisplayEmployeesFromCity(List<Employee> employees, string city)
        {
            var filteredEmployees = employees.Where(e => e.EmpCity.Equals(city, StringComparison.OrdinalIgnoreCase));
            foreach (var employee in filteredEmployees)
            {
                Console.WriteLine($"EmpId: {employee.EmpId}, EmpName: {employee.EmpName}, EmpCity: {employee.EmpCity}, EmpSalary: {employee.EmpSalary}");
            }
        }
        private static void DisplayEmployeesSortedByNameAscending(List<Employee> employees)
        {
            var sortedEmployees = employees.OrderBy(e => e.EmpName);
            foreach (var employee in sortedEmployees)
            {
                Console.WriteLine($"EmpId: {employee.EmpId}, EmpName: {employee.EmpName}, EmpCity: {employee.EmpCity}, EmpSalary: {employee.EmpSalary}");
            }
        }
    }
}

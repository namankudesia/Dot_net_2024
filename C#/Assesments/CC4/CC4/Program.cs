using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CC4
{
    class Program
    {
        static void Main(string[] args)
        {  
            //Program 1 
            string filePath = "Randomtextfile.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("This file is created by Naman Kudesia for the first Program.");
                    writer.WriteLine("If you want to append more text then you can do it.");
                }
                Console.WriteLine("Text appended to the file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            Console.WriteLine("--------End of Program 1------------");
            Console.WriteLine("");
            //Program 2 Main Funtion
            Calculator calculator = new Calculator();
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultAdd = calculator.PerformOperation(calculator.Add, num1, num2);
            int resultSubtract = calculator.PerformOperation(calculator.Subtract, num1, num2);
            int resultMultiply = calculator.PerformOperation(calculator.Multiply, num1, num2);
            Console.WriteLine($"Result of Addition: {resultAdd}");
            Console.WriteLine($"Result of Subtraction: {resultSubtract}");
            Console.WriteLine($"Result of Multiplication: {resultMultiply}");
            Console.WriteLine("--------End of Program 2------------");
            Console.WriteLine("");
            //Program 3 Main Funtion
            EmployeeManager employeeManager = new EmployeeManager();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("a. Display detail of all the employees");
                Console.WriteLine("b. Display details of all the employees whose location is not Mumbai");
                Console.WriteLine("c. Display details of all the employees whose title is 'AsstManager'");
                Console.WriteLine("d. Display details of all the employees whose Last Name starts with 'S'");
                Console.WriteLine("e. Exit");

                Console.Write("Enter your choice (a/b/c/d/e): ");
                string choice = Console.ReadLine()?.ToLower();

                switch (choice)
                {
                    case "a":
                        employeeManager.DisplayAllEmployees();
                        break;
                    case "b":
                        employeeManager.DisplayEmployeesNotInMumbai();
                        break;
                    case "c":
                        employeeManager.DisplayAsstManagers();
                        break;
                    case "d":
                        employeeManager.DisplayEmployeesWithLastNameStartingWithS();
                        break;
                    case "e":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }
    //Program 2
    delegate int CalculatorOperation(int x, int y);
    class Calculator
    {
        public int Add(int x, int y) => x + y;
        public int Subtract(int x, int y) => x - y;
        public int Multiply(int x, int y) => x * y;

        public int PerformOperation(CalculatorOperation operation, int x, int y) => operation(x, y);
    }
    //Program 3
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }
    public class EmployeeManager
    {
        private List<Employee> empList;
        public EmployeeManager()
        {
            empList = new List<Employee>();
            InitializeEmployees();
        }
        private void InitializeEmployees()
        {
            empList.Add(new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" });
            empList.Add(new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" });
            empList.Add(new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" });
            empList.Add(new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" });
            empList.Add(new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" });
            empList.Add(new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" });
            empList.Add(new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" });
            empList.Add(new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" });
            empList.Add(new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" });
            empList.Add(new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" });
        }
        public void DisplayAllEmployees()
        {
            var allEmployees = empList.Select(e => new { e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB, e.DOJ, e.City });

            Console.WriteLine("Details of all employees:");
            foreach (var emp in allEmployees)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB:d}, DOJ: {emp.DOJ:d}, City: {emp.City}");
            }
        }
        public void DisplayEmployeesNotInMumbai()
        {
            var employeesNotInMumbai = empList.Where(e => e.City != "Mumbai")
                                              .Select(e => new { e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB, e.DOJ, e.City });

            Console.WriteLine("Details of employees not in Mumbai:");
            foreach (var emp in employeesNotInMumbai)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB:d}, DOJ: {emp.DOJ:d}, City: {emp.City}");
            }
        }
        public void DisplayAsstManagers()
        {
            var asstManagers = empList.Where(e => e.Title == "AsstManager")
                                      .Select(e => new { e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB, e.DOJ, e.City });

            Console.WriteLine("Details of employees with title AsstManager:");
            foreach (var emp in asstManagers)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB:d}, DOJ: {emp.DOJ:d}, City: {emp.City}");
            }
        }
        public void DisplayEmployeesWithLastNameStartingWithS()
        {
            var employeesWithLastNameS = empList.Where(e => e.LastName.StartsWith("S"))
                                                .Select(e => new { e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB, e.DOJ, e.City });
            Console.WriteLine("Details of employees with last name starting with S:");
            foreach (var emp in employeesWithLastNameS)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB:d}, DOJ: {emp.DOJ:d}, City: {emp.City}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment1_Naman_LNIQ
{
    //1. Create a console application and add class named Employee with following field.
    internal class Employee
    {
        public int Employee_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Creating List to store employee records  
            List<Employee> empList = new List<Employee>
            {

            new Employee { Employee_ID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984,11,16), DOJ = new DateTime(2011,6,8 ), City = "Mumbai" },
            new Employee { Employee_ID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984,8,20), DOJ = new DateTime(2012,7,7), City = "Mumbai" },
            new Employee { Employee_ID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987,11,14), DOJ = new DateTime(2015,4,12), City = "Pune" },
            new Employee { Employee_ID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990,6,3), DOJ = new DateTime(2016,2,2), City = "Pune" },
            new Employee { Employee_ID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991,3,8), DOJ = new DateTime(2016, 2,2), City = "Mumbai" },
            new Employee { Employee_ID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989,11,7), DOJ = new DateTime(2014,8,8), City = "Chennai" },
            new Employee { Employee_ID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989,12,2), DOJ = new DateTime(2015,6,1), City = "Mumbai" },
            new Employee { Employee_ID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993,11,11), DOJ = new DateTime(2014,11,6), City = "Chennai" },
            new Employee { Employee_ID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992,8,12), DOJ = new DateTime(2014,12,3), City = "Chennai" },
            new Employee { Employee_ID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991,4,12), DOJ = new DateTime(2016,1,2), City = "Pune" }
            };

            //Displaying the employeeList
            foreach (var e in empList)
            {
                Console.WriteLine($"Employee ID: {e.Employee_ID},Employee Name: {e.FirstName} {e.LastName}, Title: {e.Title},  DOB: {e.DOB}, DOJ: {e.DOJ}, City: {e.City}");
                Console.WriteLine();
            }
            //1. Display a list of all the employee who have joined before 1/1/2015
            var EmpJoinBefore2015 = empList.Where(emp => emp.DOJ < new DateTime(2015, 1, 1));
            Console.WriteLine("Employees who have joined before 1/1/2015:");
            foreach (var ep in EmpJoinBefore2015)
            {
                Console.WriteLine($"Emp_Id: {ep.Employee_ID}, EmployeeName: {ep.FirstName} {ep.LastName}");
            }
            Console.WriteLine();
            //2. Display a list of all the employee whose date of birth is after 1/1/1990
            var DOBAfter1990 = empList.Where(emp => emp.DOB > new DateTime(1990, 1, 1));
            Console.WriteLine("Employees whose date of birth is after 1/1/1990:");
            foreach (var ep in DOBAfter1990)
            {
                Console.WriteLine($"Emp_Id: {ep.Employee_ID}, EmployeeName: {ep.FirstName} {ep.LastName}");
            }
            Console.WriteLine();
            //3. Display a list of all the employee whose designation is Consultant and Associate
            var Cons_And_Assoc = empList.Where(emp => emp.Title == "Consultant" || emp.Title == "Associate");
            Console.WriteLine("Employees whose Designation is Consultant and Associate:");
            foreach (var ep in Cons_And_Assoc)
            {
                Console.WriteLine($"Emp_Id: {ep.Employee_ID}, EmployeeName: {ep.FirstName} {ep.LastName}, Designation: { ep.Title}");
            }
            Console.WriteLine();
            //4. Display total number of employees
            var Total_Employees = empList.Count();
            Console.WriteLine("Total Number of Employees: " + Total_Employees);
            Console.WriteLine();
            //5. Display total number of employees belonging to “Chennai”
            var Chennai_Employees = empList.Where(emp => emp.City == "Chennai");
            int Total_Emp = Chennai_Employees.Count();
            Console.WriteLine("Employees who belongs to chennai: " + Total_Emp);
            Console.WriteLine();
            //6. Display highest employee id from the list
            var HighestEmployeeID = empList.Max(emp => emp.Employee_ID);
            Console.WriteLine("Heighest Employee ID from the list: " + HighestEmployeeID);
            Console.WriteLine();
            //7. Display total number of employee who have joined after 1/1/2015
            var EmpJoinAfter2015 = empList.Where(emp => emp.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine("Employee who have joined after 1/1/2015: ");
            foreach (var ep in EmpJoinAfter2015)
            {
                Console.WriteLine($"Emp_Id: {ep.Employee_ID}, EmployeeName: {ep.FirstName} {ep.LastName} , DOJ: {ep.DOJ}");
            }
            Console.WriteLine();
            //8. Display total number of employee whose designation is not “Associate”
            var NotAssociate = empList.Where(emp => emp.Title != "Associate");
            int Total_Non_Ass = NotAssociate.Count();
            Console.WriteLine("Employee whose designation is not Associate:" + Total_Non_Ass);
            Console.WriteLine();
            //9. Display total number of employee based on City
            var Total_Emp_CityBased = empList.GroupBy(emp => emp.City).Select(G_city => new { City = G_city.Key, Emp_Cnt = G_city.Count() });
            Console.Write("Total Number of Employees based on City: ");
            Console.WriteLine();
            foreach (var ep in Total_Emp_CityBased)
            {
                Console.WriteLine($"Number of Employees in {ep.City} are :- {ep.Emp_Cnt}");
            }
            Console.WriteLine();
            //10. Display total number of employee based on city and title
            var Total_Emp_Num = empList.GroupBy(emp => new { emp.City, emp.Title }).Select(City_title => new { City = City_title.Key.City, Title = City_title.Key.Title, Emp_count = City_title.Count() });
            Console.Write("Total Number of Employees based on city and title: ");
            foreach (var ep in Total_Emp_Num)
            {
                Console.WriteLine(ep.City + "----" + ep.Title + " (" + ep.Emp_count + ")");
            }
            Console.WriteLine();
            //11. Display total number of employee who is youngest in the list
            var Youngest_Emp = empList.Min(emp => (DateTime.Today - emp.DOB).TotalDays);
            var Y_Employee = empList.Where(emp => (DateTime.Today - emp.DOB).TotalDays == Youngest_Emp);
            foreach (var ep in Y_Employee)
            {
                Console.WriteLine($" Name of Employee who is youngest in the list :{ep.FirstName} {ep.LastName}");
                Console.WriteLine($" Number of Youngest employees is : {Y_Employee.Count()}");
            }
            Console.ReadLine();

        }
    }

}

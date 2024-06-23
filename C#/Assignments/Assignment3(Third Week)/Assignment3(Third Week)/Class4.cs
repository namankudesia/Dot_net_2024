using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Third_Week_
{
    public class Customer
    {
        private int CustomerId;
        private string Name;
        private int Age;
        private string Phone;
        private string City;
        public Customer()
        {
            CustomerId = 0;
            Name = "Unknown";
            Age = 0;
            Phone = "Unknown";
            City = "Unknown";
        }
        public Customer(int customerId, string name, int age, string phone, string city)
        {
            CustomerId = customerId;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;
        }
        public void DisplayCustomer()
        {
            Console.WriteLine("\nCustomer Details:");
            Console.WriteLine($"Customer ID: {CustomerId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"City: {City}");
        }
        ~Customer()
        {
            Console.WriteLine($"Customer {Name} with ID {CustomerId} is being deleted.");
        }
    }
}

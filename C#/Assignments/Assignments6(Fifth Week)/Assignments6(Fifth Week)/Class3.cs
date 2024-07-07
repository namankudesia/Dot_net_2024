using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments6_Fifth_Week_

    {
        public class ConcessionCalculator
        {
            public string CalculateConcession(int age)
            {
                const decimal TotalFare = 500; 
                if (age <= 5)
                {
                    return "Little Champs - Free Ticket";
                }
                else if (age > 60)
                {
                    decimal concessionAmount = TotalFare * 0.3m; 
                    decimal discountedFare = TotalFare - concessionAmount;
                    return $"Senior Citizen - Fare after 30% concession: {discountedFare:C}";
                }
                else
                {
                    return $"Ticket Booked - Fare: {TotalFare:C}";
                }
            }
        }

        public class Class3
        {
            private const decimal TotalFare = 500; 
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Concession Calculator!");
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your age: ");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    ConcessionCalculator calculator = new ConcessionCalculator();
                    string result = calculator.CalculateConcession(age);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Invalid age input. Please enter a valid number.");
                }
                Console.WriteLine("\nThank you for using Concession Calculator!");
            Console.Read();
            }
        }
    }



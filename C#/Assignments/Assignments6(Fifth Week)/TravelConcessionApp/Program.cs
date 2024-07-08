using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelConcessionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Invalid age entered.");
                return;
            }

            // Create an instance of TravelTicket
            var ticket = new TravelConcessionLibrary.TravelTicket
            {
                Name = name,
                Age = age
            };

            // Calculate and display the concession
            string concessionMessage = ticket.CalculateConcession();
            Console.WriteLine(concessionMessage);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments6_Fifth_Week_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadNumbersFromUser();            
            var filteredNumbers = numbers.Where(num => num * num > 20);
            foreach (var num in filteredNumbers)
            {
                Console.WriteLine($"{num} - {num * num}");
            }
            Console.Read();
        }
        private static List<int> ReadNumbersFromUser()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter numbers (one per line, enter 'done' to finish):");
            string input;
            while ((input = Console.ReadLine()) != "done")
            {
                if (int.TryParse(input, out int num))
                {
                    numbers.Add(num);
                }
                else
                {
                    Console.WriteLine($"Invalid input: '{input}'. Please enter a valid integer.");
                }
            }
            return numbers;
        }
    }
}


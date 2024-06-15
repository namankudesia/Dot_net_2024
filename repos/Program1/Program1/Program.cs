using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for name
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            // Prompt user for age and validate input
            int age;
            bool isValidAge = false;
            while (!isValidAge)
            {
                Console.WriteLine("Please enter your age:");
                string ageInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(ageInput))
                {
                    Console.WriteLine("Age cannot be empty. Please try again.");
                }
                else if (!int.TryParse(ageInput, out age))
                {
                    Console.WriteLine("Invalid age format. Please enter a valid number.");
                }
                else
                {
                    isValidAge = true;
                }
            }

            // Display the collected information
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

            Console.ReadLine(); // Keep console window open until Enter is pressed
        }
    }
}

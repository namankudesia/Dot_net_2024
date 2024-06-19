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

            // Prompt user for age
            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());

            // Display the collected information
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

            Console.ReadLine(); // Keep console window open until Enter is pressed
        }
    }
}

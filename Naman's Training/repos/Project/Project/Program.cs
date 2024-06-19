using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.ReadLine(); 
        }
    }
}

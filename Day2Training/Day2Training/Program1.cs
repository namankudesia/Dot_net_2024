using System;

class Program
{
    static void Number()
    {
        Console.WriteLine("Enter the first integer:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second integer:");
        int num2 = int.Parse(Console.ReadLine());
        if (num1 == num2)
        {
            Console.WriteLine("The two integers are equal.");
        }
        else
        {
            Console.WriteLine("The two integers are not equal.");
        }
        Console.ReadLine();
    }
}


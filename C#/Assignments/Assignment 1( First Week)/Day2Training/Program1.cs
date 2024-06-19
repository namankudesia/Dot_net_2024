using System;

class Program
{
 public static void Main()
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

        Program2.checkPositive();
        Program3.Number();
        Program4.swap();
        Program5.Row();
    }
}


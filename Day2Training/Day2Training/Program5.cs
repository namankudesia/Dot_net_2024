using System;

class Program5
{
    public static void Row()
    {
        Console.WriteLine("Enter a digit:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0} {0} {0} {0}", number);
        Console.WriteLine("{0}{0}{0}{0}", number);
        Console.WriteLine("{0} {0} {0} {0}", number);
        Console.WriteLine("{0}{0}{0}{0}", number);
        Console.ReadLine();
    }
}

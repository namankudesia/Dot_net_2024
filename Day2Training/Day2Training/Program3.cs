using System;

class Program3
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        double num2 = double.Parse(Console.ReadLine());
        double addition = num1 + num2;
        double subtraction = num1 - num2;
        double multiplication = num1 * num2;
        Console.WriteLine($"Addition result: {num1} + {num2} = {addition}");
        Console.WriteLine($"Subtraction result: {num1} - {num2} = {subtraction}");
        Console.WriteLine($"Multiplication result: {num1} * {num2} = {multiplication}");
        Console.WriteLine($"Division result: {num1} / {num2} = {division}");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Second_Week_
{
    class Class3
    {
        public static void PMarks()
        {
            int[] marks = new int[10];

            Console.WriteLine("Enter ten marks:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            double average = (double)total / marks.Length;

            int min = marks[0];
            int max = marks[0];
            foreach (int mark in marks)
            {
                if (mark < min)
                    min = mark;
                if (mark > max)
                    max = mark;
            }

            Console.WriteLine($"Total marks: {total}");
            Console.WriteLine($"Average marks: {average:F2}");

            Console.WriteLine($"Minimum marks: {min}");
            Console.WriteLine($"Maximum marks: {max}");

            Array.Sort(marks);
            Console.WriteLine("Marks in ascending order:");
            foreach (int mark in marks)
            {
                Console.Write($"{mark} ");
            }
            Console.WriteLine();

            Array.Reverse(marks);
            Console.WriteLine("Marks in descending order:");
            foreach (int mark in marks)
            {
                Console.Write($"{mark} ");
            }
            Console.WriteLine();
        }
    }
}

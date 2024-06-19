using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Second_Week_
{
    class Class4
    {
        public void CopyArray(int[] source, int[] destination)
        {
            if (source.Length != destination.Length)
            {
                throw new ArgumentException("Arrays must have the same length.");
            }
            for (int i = 0; i < source.Length; i++)
            {
                destination[i] = source[i];
            }
        }
        public static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}

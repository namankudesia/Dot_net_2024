using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Second_Week_
{
    class Class2
    {
        public void ProcessArray()
        {
            int[] array = { 3, 6, 9, 2, 4, 1, 8, 7, 5 };
            double average = CalculateAverage(array);
            Console.WriteLine("Average value of array elements: " + average);
            int min = FindMinimum(array);
            int max = FindMaximum(array);
            Console.WriteLine("Minimum value in the array: " + min);
            Console.WriteLine("Maximum value in the array: " + max);
        }

        private double CalculateAverage(int[] array)
        {
            if (array.Length == 0)
                return 0;

            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return (double)sum / array.Length;
        }

        private int FindMinimum(int[] array)
        {
            if (array.Length == 0)
                throw new ArgumentException("Array must not be empty");

            int min = array[0];
            foreach (int num in array)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }

        private int FindMaximum(int[] array)
        {
            if (array.Length == 0)
                throw new ArgumentException("Array must not be empty");

            int max = array[0];
            foreach (int num in array)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

    }
}

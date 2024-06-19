using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Second_Week_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = SumSpecial(num1, num2);
            Console.WriteLine("Result: " + result);


            Console.WriteLine("\nEnter a day number (1-7):");
            int dn = Convert.ToInt32(Console.ReadLine());

            string dayName = Class1.DaysofWeek(dn);
             if (dayName != null)
        {
            Console.WriteLine("Day Name: " + dayName);
        }
        else
        {
            Console.WriteLine("Invalid day number entered.");
        }


            Class2 arr = new Class2();


            Class3 marksp = new Class3();

            Class3.PMarks();


            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = new int[sourceArray.Length];

     
            Class4 arrayCopier = new Class4();

      
            arrayCopier.CopyArray(sourceArray, destinationArray);

   
            Console.WriteLine("Source Array:");
            Class4.PrintArray(sourceArray);

            Console.WriteLine("Destination Array (copied from Source Array):");
            Class4.PrintArray(destinationArray);



            Console.Write("Enter a word: ");
            string inputWord = Console.ReadLine();
            Class5 wordLengthCalculator = new Class5 ();
            int lengthOfWord = wordLengthCalculator.WordLength(inputWord);

            Console.WriteLine($"Length of the word '{inputWord}' is: {lengthOfWord}");


            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            string reversedWord = Class6.ReverseWord(word);
            Console.WriteLine("Reversed word: " + reversedWord);




            Console.Write("Enter the first word: ");
            string word1 = Console.ReadLine();

            Console.Write("Enter the second word: ");
            string word2 = Console.ReadLine();
            bool areSame = Class7.WordsSame(word1, word2);

            if (areSame)
            {
                Console.WriteLine("The words are the same.");
            }
            else
            {
                Console.WriteLine("The words are different.");
            }


            Console.ReadLine();
        }

        static int SumSpecial(int a, int b)
        {
            int sum = a + b;

            if (a == b)
            {
                return 3 * sum;
            }
            else
            {
                return sum;
            }
        }
    }
}

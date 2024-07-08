using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments6_Fifth_Week_
{

    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Enter a list of words separated by commas:");
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var filteredWords = words.Where(word => word.StartsWith("a", StringComparison.OrdinalIgnoreCase)
                                                 && word.EndsWith("m", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("\nWords starting with 'a' and ending with 'm':");
            foreach (var word in filteredWords)
            {
                Console.WriteLine(word);
            }
            Console.Read();
        }
    }
}
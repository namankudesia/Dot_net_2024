using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveChar("Python", 1));
            Console.WriteLine(RemoveChar("Python", 0));
            Console.WriteLine(RemoveChar("Python", 4));
           
            
            Console.WriteLine(Class1.ExFAL("abcd"));
            Console.WriteLine(Class1.ExFAL("a"));
            Console.WriteLine(Class1.ExFAL("xy"));


            int r1 = Class2.FindLargest(1, 2, 3);
            Console.WriteLine(r1);
            int r2 = Class2.FindLargest(1, 3, 2);
            Console.WriteLine(r2);
            int r3 = Class2.FindLargest(1, 1, 1);
            Console.WriteLine(r3);
            int r4 = Class2.FindLargest(1, 2, 2);
            Console.WriteLine(r4);


            Console.Write(" Enter the number: ");
            int inpno = Convert.ToInt32(Console.ReadLine());
            Class3.MTable(inpno);

            Console.ReadLine();

        }
       
        static string RemoveChar(string str, int index)
        {
            if(index<0 || index >= str.Length)
            {
                return str;
            }
            else
            {
                return str.Remove(index, 1);
                
            }
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Training
{
    class Class1
    {
        enum cities { Agra = 3, Lucknow = 1, Kanpur = 2, Delhi = 4, }
        public static void Main()
        {

            foreach (int x in Enum.GetValues(typeof(cities)))
            {
                if (x == 1)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + " " + "Is famous for Chicken Kadai and Kebab");
                else if (x == 2)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + " " + "Is famous for Textile and River Ganga");
                else if (x == 3)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + " " + "Is famous for Petha");
            }

            foreach (var v in Enum.GetNames(typeof(cities)))
            {
                Console.WriteLine(v);
                Console.ReadLine();
            }
        }
    }
}
    


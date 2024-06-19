using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC1
{
    class Class3
    {
        public static void MTable(int n)
        {
            for(int i=0; i<=10; i++)
            {
                int r = n * i;
                Console.WriteLine($"{n} * {i} = {r}");
            }
                }
    }
}

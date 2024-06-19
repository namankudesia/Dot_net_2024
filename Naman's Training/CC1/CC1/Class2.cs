using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC1
{
    class Class2
    {
        public static int FindLargest(int n1, int n2, int n3)
        {
            int largest = n1;
            if (n2 > largest)
            {
                largest = n2;
            }
            if(n3> largest)
            {
                largest = n3;

            }
            return largest;
    }
    }
}

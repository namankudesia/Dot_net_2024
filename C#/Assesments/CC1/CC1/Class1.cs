using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC1
{
   public class Class1
    {
        public static string ExFAL (string str)
        {
            if (str.Length<=1)
            {
                return str;
            }
            else
            {
                char FChar = str[0];
                char LChar = str[str.Length - 1];
                char[] charArray = str.ToCharArray();
                charArray[0] = LChar;
                charArray[str.Length - 1] = FChar;
                return new string(charArray);
            }
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.LongestString
{
    class LongestString
    {
        static void Main()
        {
            string[] strings = new string[] { "ghjsdfk", "jsdkfj", "yweiutrotuip", "jfdl", "jdflg" };
            var longestString =
                (from word in strings
                 select word).Max();
            Console.WriteLine("The longest string is {0}", longestString);
        }
    }
}

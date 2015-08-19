using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RefactorTheLoop
{
    class Loops
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);
                if (i % 10 == 0 && array[i] == expectedValue)
                {
                    Console.WriteLine("Value Found");
                    break;
                }
            }
            // More code here
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._64BitArray
{
    class BitArrayMain
    {
        static void Main()
        {
            BitArray64 number = new BitArray64();

            number[63] = 1;
            number[8] = 1;
            number[34] = 1;
            number[45] = 1;

            Console.WriteLine(number);
        }
    }
}

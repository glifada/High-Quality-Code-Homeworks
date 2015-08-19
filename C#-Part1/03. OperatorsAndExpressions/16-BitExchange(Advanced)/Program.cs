using System;

class ExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Please, enter 32-bit unsigned integer:");
        ulong number = UInt64.Parse(Console.ReadLine());
        if ((number > 0) && (number < 4294967295))
        {
            Console.WriteLine("Please, enter first position:");
            byte pos1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Please, enter second position:");
            byte pos2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Please, enter the number of bits to change:");
            byte numbit = Convert.ToByte(Console.ReadLine());
            string binNum = Convert.ToString((uint)number, 2).PadLeft(32, '0');
            Console.WriteLine("The entered binary number is {0}.", binNum);
            if ((pos1 + numbit - 1) < 32)
            {
                if ((pos1 + numbit - 1) < (pos2) || (pos2 + numbit - 1) < (pos1))
                {
                    uint mask = (uint)(1 << numbit);
                    mask = mask - 1;
                    uint mask1 = mask << pos1;
                    uint nAndMask1 = (uint)number & mask1;
                    uint bit1 = nAndMask1 >> pos1;
                    uint mask2 = (mask << pos2);
                    uint nAndMask2 = (uint)number & mask2;
                    uint bit2 = nAndMask2 >> pos2;
                    uint invertMask1 = ~mask1;
                    number = number & invertMask1;
                    uint invertMask2 = ~mask2;
                    number = number & invertMask2;
                    bit1 = bit1 << pos2;
                    number = number | bit1;
                    bit2 = bit2 << pos1;
                    number = number | bit2;
                    binNum = Convert.ToString((uint)number, 2).PadLeft(32, '0');
                    Console.WriteLine("The exchanged binary number is {0} and its integer expression is {1}.", binNum, number);
                }
                else
                {
                    Console.WriteLine("The bits can't be exchanged. There is overlapping!!!");
                }
            }
            else
            {
                Console.WriteLine("The bits can't be exchanged. Out of range!!!");
            }
        }
        else
        {
            Console.WriteLine("The entered number is not 32-bit.");
        }
    }
}

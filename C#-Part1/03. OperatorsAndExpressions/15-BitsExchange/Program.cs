using System;

class ExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Please, enter 32-bit unsigned integer:");
        uint number = UInt32.Parse(Console.ReadLine());
        string binNum = Convert.ToString(number, 2).PadLeft(32, '0');
        Console.WriteLine("The entered binary number is {0}.", binNum);
        byte pos1=3;
        byte pos2 = 24;
        uint mask = (uint)(1 << 3);
        mask = mask - 1;
        uint mask1 = mask << pos1;
        uint nAndMask1 = number & mask1;
        uint bit1 = nAndMask1 >> pos1;
        uint mask2 = (mask << pos2);
        uint nAndMask2 = number & mask2;
        uint bit2 = nAndMask2 >> pos2;
        uint invertMask1 = ~mask1;
        number = number & invertMask1;
        uint invertMask2 = ~mask2;
        number = number & invertMask2;
        bit1 = bit1 << pos2;
        number = number | bit1;
        bit2 = bit2 << pos1;
        number = number | bit2;
        binNum = Convert.ToString(number, 2).PadLeft(32, '0');
        Console.WriteLine("The exchanged binary number is {0} and its integer expression is {1}.", binNum, number);
    }
}

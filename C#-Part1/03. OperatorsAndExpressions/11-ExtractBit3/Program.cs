using System;

class ExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Please, enter an unsigned integer:");
        uint number = UInt32.Parse(Console.ReadLine());
        string binNum = Convert.ToString(number, 2).PadLeft(32, '0');
        uint mask = 1 << 3;
        uint nAndMask = number & mask;
        uint bit = nAndMask >> 3;
        Console.WriteLine("The entered binary number is {0} and its third bit is {1}.", binNum, bit);
    }
}

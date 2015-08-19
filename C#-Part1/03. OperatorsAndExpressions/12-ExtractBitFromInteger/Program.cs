using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Please, enter an integer number:");
        int number = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter the position of the bit you want to extract:");
        byte pos = Convert.ToByte(Console.ReadLine());
        string binNum = Convert.ToString(number, 2).PadLeft(32, '0');
        int mask = 1 << pos;
        int nAndMask = number & mask;
        int bit = nAndMask >> pos;
        Console.WriteLine("The entered binary number is {0} and its bit at position {1} is {2}.", binNum, pos, bit);
    }
}

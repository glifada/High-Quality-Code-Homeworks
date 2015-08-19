using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Please, enter an integer number:");
        int number = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter the position of the bit you want to change:");
        byte pos = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Please, enter 0 or 1 for value ot the bit you want to change:");
        byte value = Convert.ToByte(Console.ReadLine());
        string binNum = Convert.ToString(number, 2).PadLeft(32, '0');
        Console.WriteLine("The entered binary number is {0}.", binNum);
        if (value == 1 || value ==0)
        {
            if (value ==1)
            {
                int mask = 1 << pos;
                int result = number | mask;
                string binRes = Convert.ToString(result, 2).PadLeft(32, '0');
                Console.WriteLine("The changeed binary number is {0} and its integer expression is {1}.", binRes, result);
            }
            else
            {
                int mask = ~(1 << pos);
                int result = number & mask;
                string binRes = Convert.ToString(result, 2).PadLeft(32, '0');
                Console.WriteLine("The changeed binary number is {0} and its integer expresion is {1}.", binRes, result);
            }
        }
        else
        {
            Console.WriteLine("The value of the bit must be 0 or 1. Please, start the program again.");
        }
    }
}

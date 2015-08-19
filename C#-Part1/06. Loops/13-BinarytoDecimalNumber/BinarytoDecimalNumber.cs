using System;

class BinarytoDecimalNumber
{
    static void Main()
    {
        Console.Write("Please enter a binary integer number: ");
        string binNum = Console.ReadLine();
        long decNum = 0;
        long power = 1;
        for (int i = binNum.Length - 1; i >= 0; i--)
        {
            if (binNum[i]-48 == 1)
            {
                decNum += power;
            }
            power *= 2;
        }
        Console.WriteLine("The decimal number is {0}.", decNum);
    }
}

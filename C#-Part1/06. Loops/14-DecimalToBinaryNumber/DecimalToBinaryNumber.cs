using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        long n = long.Parse(Console.ReadLine());
        long remainder = 0;
        string binNum = "";

        if (n == 0)
        {
            binNum = "\00";
        }
        while (n > 0)
        {
            remainder = n % 2;
            binNum += remainder;
            n /= 2;
        }
        Console.WriteLine(binNum);
    }
}

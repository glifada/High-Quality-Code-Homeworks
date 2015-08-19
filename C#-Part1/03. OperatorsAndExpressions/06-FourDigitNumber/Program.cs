using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Please enter four-digit number for check:");
        short number = (short)Int16.Parse(Console.ReadLine());
        while ((number < 1000) || (number > 9999))
        {
            Console.WriteLine("The entered number {0} is not four-digit number.", number);
            Console.WriteLine("Please enter another four-digit number for check:");
            number = (short)Int16.Parse(Console.ReadLine());
        }
        byte fourthDigit = (byte)(number % 10);
        number = (short)(number / 10);
        byte thirdDigit = (byte)(number % 10);
        number = (short)(number / 10);
        byte secondDigit = (byte)(number % 10);
        byte firstDigit = (byte)(number / 10);
        Console.WriteLine("The digits of entered number are: {0}, {1}, {2} and {3}.", firstDigit, secondDigit, thirdDigit, fourthDigit);
        byte sum = (byte)(firstDigit + secondDigit + thirdDigit + fourthDigit);
        Console.WriteLine("The sum of the digits is {0}.", sum);
        Console.WriteLine("The number in reversed order is {3}{2}{1}{0}.", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("The number with last digit in first positions is {3}{0}{1}{2}.", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("The number with exchanged second and third digits is {0}{2}{1}{3}.", firstDigit, secondDigit, thirdDigit, fourthDigit);
    }
}

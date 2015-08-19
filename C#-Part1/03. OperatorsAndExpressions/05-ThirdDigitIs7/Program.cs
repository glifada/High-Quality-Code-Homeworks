using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Please enter a number for check:");
        int number = Int32.Parse(Console.ReadLine());
        if ((number < 100) && (number > -100))
        {
            Console.WriteLine("The entered number {0} has less than 3 digits.", number);
        }
        else
        {
            int numDiv100 = number / 100;
            int digit = numDiv100 % 10;
            if (Math.Abs(digit) == 7)
            {
                Console.WriteLine("The entered number {0} has third digit 7.", number);
            }
            else
            {
                Console.WriteLine("The entered number {0} hasn't third digit 7.", number);
            }
        }
    }
}

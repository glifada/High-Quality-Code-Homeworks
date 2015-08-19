using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Please enter a number for check:");
        int number = Int32.Parse(Console.ReadLine());
        if (Math.Abs(number % 2) == 1)
        {
            Console.WriteLine("The input number {0} is odd.", number);
        }
        else 
        {
            Console.WriteLine("The input number {0} is even.", number);
        }
    }
}

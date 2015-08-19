using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Please enter a positive number:");
        int number = Int32.Parse(Console.ReadLine());
        if (number > 0)
        {
            if (((number == 2) || (number == 3) || (number == 5) || (number == 7)) ||
                ((number != 1) &&(number %2 != 0) && (number % 3 != 0) && (number % 5 != 0) && (number % 7 != 0)))
            {
                Console.WriteLine("The entered number {0} is prime.", number);
            }
            else
            {
                Console.WriteLine("The entered number {0} is not prime.", number);
            }
        }
        else
        {
            Console.WriteLine("The entered number {0} is not positive.", number);
        }

    }
}

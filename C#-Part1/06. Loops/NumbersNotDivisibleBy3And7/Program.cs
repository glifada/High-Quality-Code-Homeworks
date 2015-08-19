using System;

class NumbersFrom1toN
{
    static void Main()
    {
        Console.Write("Plese, enter a positive integer number: ");
        int number = Int16.Parse(Console.ReadLine());
        while (number <= 0)
        {
            Console.WriteLine("Incorrect number!");
            Console.WriteLine("Plese, enter a new positive integer number: ");
            number = Int16.Parse(Console.ReadLine());
        }
        for (int i = 1; i <= number; i++)
        {
            if ((i % 3 != 0) && (i % 7 != 0))
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}

using System;

class NumbersFrom1toN
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        int num = Int32.Parse(Console.ReadLine());
        if (num > 0)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            for (int i = num; i <= 1; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

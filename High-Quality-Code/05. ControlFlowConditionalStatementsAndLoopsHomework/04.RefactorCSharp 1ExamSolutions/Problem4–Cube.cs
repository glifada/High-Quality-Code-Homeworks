using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char topFill = '/';
        char sideFill = 'X';
        char side = ':';

        for (int i = 1; i <= 2 * n - 1; i++)
        {
            if (i == 1 || i == 2 * n - 1)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < n; j++)
                {
                    Console.Write(side);
                }
                Console.WriteLine();
            }
            else if (1 < i && i < n)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(side);
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write(topFill);
                }
                Console.Write(side);
                for (int j = 0; j < i - 2; j++)
                {
                    Console.Write(sideFill);
                }
                Console.Write(side);
                Console.WriteLine();
            }
            else if (i == n)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(side);
                }
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write(sideFill);
                }
                Console.Write(side);
                Console.WriteLine();
            }
            else if (n < i && i < 2 * n - 1)
            {
                Console.Write(side);
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(side);
                for (int j = 0; j < 2 * (n - 1) - i; j++)
                {
                    Console.Write(sideFill);
                }
                Console.Write(side);
                Console.WriteLine();
            }
        }
    }
}

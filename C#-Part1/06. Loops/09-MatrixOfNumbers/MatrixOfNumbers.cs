using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Please enter a positive integer number n (1<=n<=20): ");
        int n = int.Parse(Console.ReadLine());

        while ((n < 1) || (n > 20))
        {
            Console.Write("Please enter a correct number! ");
            Console.Write("Please enter a positive integer number n (1<=n<=20): ");
            n = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
            for (int j = i+1; j < n+i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Please enter number n (0<=n<=100): ");
        int n = int.Parse(Console.ReadLine());
        BigInteger nFac = 1;
        BigInteger n2Fac = 1;
        BigInteger n1Fac = 1;

        while ((n < 0) || (n > 100))
        {
            Console.WriteLine("Please enter correct number!");
            Console.Write("Please enter number n (0<=n<=100): ");
            n = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i <= n; i++)
        {
            nFac *= i;
        }
        for (int j = 1; j <= 2 * n; j++)
        {
            n2Fac *= j;
        }
        for (int l = 1; l <= n + 1; l++)
        {
            n1Fac *= l;
        }
        
        BigInteger catNum = n2Fac / (n1Fac * nFac);
        Console.WriteLine("The {0}th Catalan number is: {1}", n, catNum);
    }
}

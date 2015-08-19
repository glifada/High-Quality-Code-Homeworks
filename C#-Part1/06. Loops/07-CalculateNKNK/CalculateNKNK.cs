using System;
using System.Numerics;

class CalculateNKNK
{
    static void Main()
    {
        Console.Write("Plese enter an integer number in [1..100] n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Plese enter an integer number in [1..{0}] k: ", n);
        int k = int.Parse(Console.ReadLine());
        BigInteger nFac = 1;
        BigInteger kFac = 1;
        BigInteger nkFac = 1;
        BigInteger result = 1;
        for (int i = 1, j = 1; i <= n; i++, j++)
        {
            nFac *= i;
            if (j <= k)
            {
                kFac *= j;
            }
        }
        for (int l = 1; l <= (n - k); l++)
        {
            nkFac *= l;
        }
        result = nFac / (kFac * nkFac);
        Console.WriteLine("The result of n!/(k!(n-k)! is: {0}!/({1}!({0}-{1})! = {2}", n, k, result);
    }
}
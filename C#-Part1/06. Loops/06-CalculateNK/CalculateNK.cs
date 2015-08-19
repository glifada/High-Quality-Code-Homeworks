using System;

class CalculateNK
{
    static void Main()
    {
        Console.Write("Plese enter an integer number in [1..100] n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Plese enter an integer number in [1..{0}] k: ", n);
        int k = int.Parse(Console.ReadLine());
        int nFac = 1;
        int kFac = 1;
        double result = 1;
        for (int i = 1, j = 1; i <= n; i++, j++)
        {
            nFac *= i;
            if (j <= k)
            {
                kFac *= j;
            }
        }
        result = nFac / kFac;
        Console.WriteLine("The result of n!/k! is: {0}!/{1}! = {2}", n, k, result);
    }
}

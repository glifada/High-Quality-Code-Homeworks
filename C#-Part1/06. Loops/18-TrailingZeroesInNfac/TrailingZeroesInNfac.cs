using System;
using System.Numerics;

class TrailingZeroesInNfac
{
    static void Main()
    {
        Console.Write("Please enter an integer number n = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        string facStr = factorial.ToString();
        int counter = 0;
        for (int i = facStr.Length - 1; i >= 0; i--)
        {
            while (true)
            {
                if (facStr[i] == '0')
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine("The {0}! has {1} trailing zeros!", n, counter);
                    return;
                }
                break;
            }
        }


    }
}

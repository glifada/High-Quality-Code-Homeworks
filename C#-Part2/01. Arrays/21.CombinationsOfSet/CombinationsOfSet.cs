using System;
using System.Linq;

class CombinationsOfSet
{
    static int[] refStore;

    public static void combinations(int n, int k, int ind, int newStart)
    {
        if (k <= ind)
        {
            string combination = "{";

            for (int i = 0; i < k; i++)
            {
                combination += refStore[i] + ",";
            }

            Console.WriteLine(combination.TrimEnd(',') + "}");

        }
        else
        { 
            for (int i = newStart; i <= n; i++)
            {
                refStore[ind] = i;
                combinations(n, k, ind + 1, i + 1);
            }
        }
    }


    static void Main()
    {
        Console.WriteLine("Please enter the number n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number k = ");
        int k = int.Parse(Console.ReadLine());

        refStore = Enumerable.Range(1, n).ToArray();
        combinations(n, k, 0, 1);
    }
}

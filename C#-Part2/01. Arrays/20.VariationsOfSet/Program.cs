using System;
using System.Linq;

class PermutationOfSet
{
    static int[] refStore;

    public static void Variation(int n, int k, int ind)
    {
        if (k <= ind)
        {
            string Variation = "{";

            for (int i = 0; i < k; i++)
            {
                Variation += refStore[i] + ",";
            }

            Console.WriteLine(Variation.TrimEnd(',') + "}");

        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                refStore[ind] = i;
                Variation(n, k, ind + 1);
            }
        }
    }
    static void Main()
    {
        Console.Write("Please enter the number n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number k = ");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i + 1;
        }

        refStore = Enumerable.Range(1, n).ToArray();
        Variation(n, k, 0);
    }
}

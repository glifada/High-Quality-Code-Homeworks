using System;

class PermutationOfSet
{
    static void Main()
    {
        Console.Write("Please enter the number n = ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i + 1;
        }

        Permutation(arr, 0, arr.Length - 1);
    }

    private static void Permutation(int[] arr, int k, int n)
    {
        if (k == n)
        {
            Print(arr);
        }
        else
        {
            for (int i = k; i <= n; i++)
            {
                SwapElements(arr, k, i);
                Permutation(arr, k + 1, n);
                SwapElements(arr, k, i);
            }
        }

    }
    private static void SwapElements(int[] arr, int k, int i)
    {
        int t = arr[k];
        arr[k] = arr[i];
        arr[i] = t;
    }
    private static void Print(int[] arr)
    {
        Console.Write("{");
        for (int i = 0; i < arr.Length; i++)
        {
            if (i < arr.Length - 1)
            {
                Console.Write(arr[i] + ", ");
            }
            else Console.Write(arr[i]);
        }
        Console.WriteLine("}");
    }
}

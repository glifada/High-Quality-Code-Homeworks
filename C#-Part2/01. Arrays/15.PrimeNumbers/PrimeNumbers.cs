using System;

class PrimeNumbers
{
    static void Main()
    {
        long n = 10000000;
        bool[] arr = new bool[n];
        for (int i = 2; i < n; i++)
        {
            arr[i] = true;
        }
         
        for (int i = 2; i < n; i++)
        {
            if (arr[i])
            {
                for (long j = 2; (j * i) < n; j++)
                {
                    arr[j * i] = false;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (arr[i])
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}

using System;

class SubsetKwithSumS
{
    static void Main()
    {
        Console.Write("Please enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the length of the subset: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Please enter the sum to find: ");
        int s = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Please enter the elements of the array: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        bool isEqual = false;

        for (int i = 0; i < (2 << n) - 1 && !isEqual; i++)
        {
            int sum = 0;
            string subset = "";
            int counter = 0;

            for (int j = 0; j < n && !isEqual; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    sum += arr[j];
                    subset += arr[j] + " ";
                    counter++;
                }

                if (sum == s && counter == k)
                {
                    Console.WriteLine(subset);
                    isEqual = true;
                }
            }
        }
        if (!isEqual)
        {
            Console.WriteLine("There is no such subset!");
        }
    }
}

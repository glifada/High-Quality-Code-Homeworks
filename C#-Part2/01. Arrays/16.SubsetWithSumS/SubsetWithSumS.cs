using System;

class SubsetWithSumS
{
    static void Main()
    {
        Console.Write("Please enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        Console.WriteLine("Please enter the elements of the array: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        Console.Write("Please enter the sum to find: ");
        int givenSum = int.Parse(Console.ReadLine());
        bool isEqual = false;

        for (int i = 0; i < (2 << length) - 1 && !isEqual; i++)
        {
            int sum = 0;

            for (int j = 0; j < length && !isEqual; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    sum += arr[j];
                }

                if (sum == givenSum)
                {
                    Console.WriteLine("Yes");
                    isEqual = true;
                }

            }
        }
    }
}

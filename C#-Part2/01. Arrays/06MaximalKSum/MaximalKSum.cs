using System;

class MaximalKSum
{
    static void Main()
    {
        Console.Write("Please enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.Write("Please enter how many element do you want to sum: ");
        int k = int.Parse(Console.ReadLine());
        int maxSum = 0;
        Console.WriteLine("Please enter the elements of the array: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr1[{0}] = ", i);
            arr[i] = Char.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        Array.Sort(arr);
        for (int i = n-k; i < n; i++)
        {
            maxSum += arr[i] - '0';
        }
        Console.WriteLine("The maximal sum of {0} elements is: {1}", k, maxSum);
    }
}

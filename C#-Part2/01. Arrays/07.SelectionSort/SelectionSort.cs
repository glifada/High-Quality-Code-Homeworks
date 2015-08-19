using System;
using System.Collections.Generic;
using System.Linq;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Please enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        Console.WriteLine("Please enter the elements of the array:");
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        List<int> RemovedMin = arr.ToList<int>();
        int[] sortArr = new int[length];
        for (int i = 0; i < length; i++)
        {
            int min = RemovedMin.Min();
            RemovedMin.Remove(min);
            sortArr[i] = min;
        }
        for (int i = 0; i < length; i++)
        {
            Console.Write(sortArr[i] + " ");
        }
        Console.WriteLine();
    }
}

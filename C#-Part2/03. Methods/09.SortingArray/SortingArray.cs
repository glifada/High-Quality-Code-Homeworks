using System;
using System.Linq;
using System.Collections.Generic;

class SortingArray
{
    static void Main()
    {
        Console.WriteLine("Please enter the elements ot the array, separated by space:");
        string[] arrStr = Console.ReadLine().Split(' ');
        List<int> numbers = arrStr.Select(int.Parse).ToList();
        SortArray(numbers);
    }

    static int GetMax (List<int> numbers)
    {
        int max = int.MinValue;
        foreach (int element in numbers)
        {
            if (max < element)
            {
                max = element;
            }
        }
        return max;
    }

    static void SortArray(List<int> numbers)
    {
        int max = int.MinValue;
        int n = numbers.Count;
        List<int> descendingArray = new List<int>();
        List<int> ascendingArray = new List<int>();
        for (int i = 0; i < n ; i++)
	    {
            max = GetMax(numbers);
            descendingArray.Add(max);
            numbers.Remove(max);
	    }
        ascendingArray = descendingArray.ToList();
        ascendingArray.Reverse();
        Console.WriteLine("Sorted array in ascending order is: {0}", string.Join(", ", ascendingArray));
        Console.WriteLine("Sorted array in descending order is: {0}", string.Join(", ", descendingArray));
    }

}

using System;

class QuickSort
{
    static void Main()
    {
        Console.Write("Please enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        string[] unsorted = new string[length];
        Console.WriteLine("Please enter the elements of the string array: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            unsorted[i] = Console.ReadLine();
        }

        // Print the unsorted array
        Console.Write("Unsorted array is: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write(unsorted[i] + " ");
        }
        Console.WriteLine();

        // Sort the array
        Quicksort(unsorted, 0, length - 1);

        // Print the sorted array
        Console.Write("Sorted array is: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write(unsorted[i] + " ");
        }
        Console.WriteLine();
    }

    public static void Quicksort(IComparable[] elements, int left, int right)
    {
        int i = left, j = right;
        IComparable pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                // Swap
                IComparable tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;

                i++;
                j--;
            }
        }

        // Recursive calls
        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }
}

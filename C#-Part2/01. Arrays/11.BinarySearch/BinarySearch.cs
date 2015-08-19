using System;

class BinarySearch
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
        }

        Array.Sort(arr);
        Console.Write("The sorted array is: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        Console.Write("Please enter the number you want to find: ");
        int number = int.Parse(Console.ReadLine());
      
        int low = 0, high = arr.Length - 1, midpoint = 0;
        int index = -1;
        
 
        while (low <= high)
        {
            midpoint = (low + high) / 2;
            if (number == arr[midpoint])
            {                    
                index = midpoint;
                midpoint++;
                break;
            }
            else if (number < arr[midpoint])
                high = midpoint - 1;
            else
                low = midpoint + 1;
        }

        if (index == -1)
        {
            Console.WriteLine("There is no such element in the array!");
        }
        else
        {
            Console.WriteLine("The number {0} has index {1} in the array!", number, index);
        }
    }
}

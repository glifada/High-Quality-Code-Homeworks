using System;

class CompareArrays
{
    static void Main()
    {
        Console.Write("Please enter the length of the arrays: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr1 = new int[length];
        Console.WriteLine("Please enter the first integer array: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr1[{0}] = ", i);
            arr1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        Console.WriteLine("Please enter the second integer array: ");
        int[] arr2 = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr2[{0}] = ", i);
            arr2[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        bool isEqual = true;
        for (int i = 0; i < length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                isEqual = false;
                break;
            }
        }
        if (isEqual)
        {
            Console.WriteLine("The arrays are equal.");
        }
        else
        {
            Console.WriteLine("The arrays are not equal.");
        }
    }
}

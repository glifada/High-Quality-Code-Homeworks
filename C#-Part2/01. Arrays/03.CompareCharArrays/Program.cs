using System;

class CompareArrays
{
    static void Main()
    {
        Console.Write("Please enter the length of the arrays: ");
        int length = int.Parse(Console.ReadLine());
        char[] arr1 = new char[length];
        Console.WriteLine("Please enter the first char array: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr1[{0}] = ", i);
            arr1[i] = Char.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        Console.WriteLine("Please enter the second cahr array: ");
        char[] arr2 = new char[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr2[{0}] = ", i);
            arr2[i] = Char.Parse(Console.ReadLine());
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
            Console.WriteLine("The arrays are lexicographically equal.");
        }
        else
        {
            Console.WriteLine("The arrays are lexicographically not equal.");
        }
    }
}

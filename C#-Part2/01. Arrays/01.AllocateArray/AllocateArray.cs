using System;

class AllocateArray
{
    static void Main()
    {
        int[] arr = new int[20];
        Console.Write("The allocated array is: {");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i * 5;
            if (i < arr.Length - 1)
            {
                Console.Write("{0}, ", arr[i]);
            }
            else
            {
                Console.Write("{0}", arr[i]);
            }
        }
        Console.WriteLine("}");
    }
}
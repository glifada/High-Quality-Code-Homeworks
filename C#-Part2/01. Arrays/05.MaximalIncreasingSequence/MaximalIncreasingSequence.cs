using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Please enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        int currentSeq = 1;
        int maxSeq = 0;
        string sequence = "";
        string increasingSeq = "";
        Console.WriteLine("Please enter the elements of the array: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr1[{0}] = ", i);
            arr[i] = Char.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        for (int i = 0; i < length - 1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                currentSeq ++;
                sequence += arr[i] - '0' + ", ";
            }
            else
            {
                if (maxSeq < currentSeq)
                {
                    maxSeq = currentSeq;
                    sequence += arr[i] - '0';
                    increasingSeq = sequence;
                }
                sequence = "";
                currentSeq = 1;
            }
        }
        Console.WriteLine("The maximal sequence of increasing elements is: {0}", increasingSeq);
    }
}

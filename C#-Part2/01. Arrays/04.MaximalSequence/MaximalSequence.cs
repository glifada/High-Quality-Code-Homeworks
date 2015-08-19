using System;

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Please enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        int currentSeq = 1;
        int maxSeq = 0;
        int sequence = 0;
        Console.WriteLine("Please enter the elements of the array: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr1[{0}] = ", i);
            arr[i] = Char.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        for (int i = 0; i < length - 1; i++)
        {
            if (arr[i] == arr[i+1])
            {
                currentSeq += 1;
                sequence = arr[i] - '0';
            }
            else
            {
                if (maxSeq < currentSeq)
                {
                    maxSeq = currentSeq;
                }
                currentSeq = 1;
            }
        }
        Console.Write("The maximal sequence of equal elements is: ");
        for (int i = 0; i < maxSeq; i++)
        {
            if (i < maxSeq - 1)
            {
                Console.Write("{0}, ", sequence);
            }
            else
            {
                Console.Write("{0}", sequence);
                Console.WriteLine();
            }
        }
    }
}

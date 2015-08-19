using System;

class MaximalSum
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
        int sum = 0;
        int maxSum = int.MinValue;
        int startSeq = 0;
        int endSeq = 0;
        int temp = 0;
        for (int i = 0; i < length; i++)
        {
            sum += arr[i];
            if (maxSum < sum)
            {
                maxSum = sum;
                endSeq = i;
                startSeq = temp;
            }
            if (sum <= 0)
            {
                sum = 0;
                temp = i + 1;
            }
        }
        Console.Write("The sequence of maximal sum is: ");
        for (int i = startSeq; i <= endSeq; i++)
        {
            if (i < endSeq)
            {
                Console.Write(arr[i] + ", ");
            }
            else
            {
                Console.Write(arr[i] );
            }
        }
        Console.WriteLine();
    }
}

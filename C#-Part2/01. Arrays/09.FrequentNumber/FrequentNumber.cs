using System;

class FrequentNumber
{
    static void Main()
    {
        Console.Write("Please enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        int number;
        int counter = 0;
        int mostFreq = 0;
        int freqNum = 0;
        Console.WriteLine("Please enter the elements of the array: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < length; i++)
        {
            number = arr[i];
            for (int j = 0; j < length; j++)
            {
                if (number == arr[j])
                {
                    counter++;
                }
            }
            if (mostFreq < counter)
            {
                mostFreq = counter;
                freqNum = number;
            }
            counter = 0;
        }
        Console.WriteLine("The most frequent number is: {0} ({1} times)", freqNum, mostFreq);
    }
}

using System;

class RemoveElementsFromArray
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
        }

        int[] store = new int[length];
        int[] sequence = store;
        int maxLength = 0;

        for (int i = 0, currentLength = 0; i < (2 << length) - 1; i++)
        {
            bool increasing = true;

            for (int j = 0, storeIndex = 0; j < length; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    store[storeIndex++] = arr[j];
                    if (storeIndex > 1)
                    {

                        if (store[storeIndex - 2] > store[storeIndex - 1])
                        {
                            increasing = false;
                        }
                    }
                    currentLength++;
                }
            }
            if (increasing && currentLength > maxLength)
            {
                maxLength = currentLength;
                sequence = store;
                store = new int[length];

            }
            currentLength = 0;
        }

        for (int i = 0; i < maxLength; i++)
        {
            if (i < maxLength - 1)
            {
                Console.Write(sequence[i] + ",");
            }
            else Console.WriteLine(sequence[i]);
        }
    }
}

using System;

class FindSunInArray
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
        Console.Write("Please enter the sum to find: ");
        int givenSum = int.Parse(Console.ReadLine());
        bool isEqual = false;

        while (!isEqual)
        {
            for (int i = 0; i < length; i++)
            {
                int sum = arr[i];
                string sequence = Convert.ToString(arr[i]);
                for (int j = i + 1; j < length; j++)
                {
                    sum += arr[j];
                    sequence += ", " + arr[j];
                    if (sum >= givenSum)
                    {
                        break;
                    }
                }
                if (sum == givenSum)
                {
                    Console.WriteLine(sequence);
                    isEqual = true;
                    break;
                }
            }
            if (!isEqual)
            {
                Console.WriteLine("There is no such sum!");
                isEqual = true;
                break;
            }
        }
    }
}

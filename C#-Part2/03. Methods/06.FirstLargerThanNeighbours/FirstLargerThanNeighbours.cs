using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Please enter the integer elements of the array, separated by space:");
        string[] numString = Console.ReadLine().Split(' ');
        int[] numbers = numString.Select(int.Parse).ToArray();
        int index = CheckNeighbours(numbers);
        Console.Write("The index of the first element in array that is larger than its neighbours is: {0}", index);
    }

    static int CheckNeighbours(int[] numbers)
    {
        int index = -1;
        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if (numbers[i - 1] < numbers[i] && numbers[i] > numbers[i + 1])
            {
                return index = i;
            }
        }
        return index;
    }
}

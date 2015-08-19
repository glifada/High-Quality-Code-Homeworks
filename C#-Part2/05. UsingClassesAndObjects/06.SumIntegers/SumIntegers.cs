using System;
using System.Linq;

class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("Please enter a sequence of positive integer numbers, separated by spaces:");
        string[] numbersStr = Console.ReadLine().Split(' ');
        int[] numbers = numbersStr.Select(int.Parse).ToArray();
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine("The sum of numbers {0} is {1}", string.Join(", ", numbers), sum);
    }
}

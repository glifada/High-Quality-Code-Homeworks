using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        Console.WriteLine("Please enter the array of numbers, separated by space:");
        string[] numbersString = Console.ReadLine().Split(' ');
        int[] numbers = numbersString.Select(int.Parse).ToArray();
        Console.Write("Please enter the number, you want to count: ");
        int number = int.Parse(Console.ReadLine());
        NumberCount(numbers, number);
    }

    static void NumberCount (int[] numbers, int number)
    {
        int counter = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (number == numbers[i])
            {
                counter++;
            }
        }
        Console.WriteLine("The number {0} appears {1} times in the array {2}", number, counter, string.Join(", ", numbers));
        counter = 0;
    }
}
using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Please enter the integer elements of the array, separated by space:");
        string[] numString = Console.ReadLine().Split(' ');
        int[] numbers = numString.Select(int.Parse).ToArray();
        Console.Write("Please enter the position of the element you want to check: ");
        int position = int.Parse(Console.ReadLine());
        CheckNeighbours(numbers, position);
    }

    static void CheckNeighbours (int[] numbers, int position)
    {
        if (position == 1 || position == numbers.Length)
        {
            Console.WriteLine("The element {0} at position {1} hasn't two neighbours!", numbers[position - 1], position);
        }
        else if (numbers[position - 2] < numbers[position - 1] && numbers[position - 1] > numbers[position])
        {
            Console.WriteLine("The element {0} at position {1} is larger than its two neighbours: {2} and {3}!", numbers[position - 1], position, numbers[position - 2], numbers[position]);
        }
        else
        {
            Console.WriteLine("The element {0} at position {1} isn't larger than its two neighbours: {2} and {3}!", numbers[position - 1], position, numbers[position - 2], numbers[position]);
        }
    }
}

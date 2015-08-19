using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Please enter a length of a string: ");
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int[length];
        Console.Write("Please enter a string of integers, separated by spase: ");
        string[] text = Console.ReadLine().Split(' ');
        Console.Write("Please enter a number K: ");
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(text[i]);
        }

        Array.Sort(numbers);
        int index = Array.BinarySearch(numbers, k);

        if (index < 0)
        {
            index = Math.Abs(index) - 2;
        }
        Console.WriteLine("The largest number in the array which is <= to {0} is {1}", k, numbers[index]);
    }
}
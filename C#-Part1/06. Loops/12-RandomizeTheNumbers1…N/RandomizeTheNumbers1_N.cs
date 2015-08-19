using System;

class RandomizeTheNumbers1_N
{
    static void Main()
    {
        Console.Write("Please enter how many numbers you want to print: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int [n];
        System.Random random = new System.Random();

        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }

        for (int i = 0; i < n; i++)
        {
            int j = random.Next(i, numbers.Length);
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}
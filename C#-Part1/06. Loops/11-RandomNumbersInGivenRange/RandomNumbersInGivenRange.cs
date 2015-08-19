using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Please enter how many random nubmers you want to print: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please enter min value: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Please enter max value: ");
        int max = int.Parse(Console.ReadLine());
        Random ranNum = new Random();

        while (min > max)
        {
            Console.WriteLine("Please enter max value greater than min value!");
            Console.Write("max = ");
            max = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i <= number; i++)
        {
            Console.Write(ranNum.Next(min, max) + " ");
        }
        Console.WriteLine();
    }
}

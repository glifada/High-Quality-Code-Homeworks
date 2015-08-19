using System;

class MinMaxSumAndAveragOfNNumbers
{
    static void Main()
    {
        Console.Write("Plese, enter how much numbers do you want to enter: ");
        uint numbers = uint.Parse(Console.ReadLine());
        Console.WriteLine("Plese, enter {0} integer numbers: ", numbers);
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        double average = 0;
        for (int i = 1; i <= numbers; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
            if (min > number)
            {
                min = number;
            }
            if (max < number)
            {
                max = number;
            }
        }
        average = (double)sum / numbers;
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:0.00}", average);
    }
}

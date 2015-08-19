using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("The minimum is: {0}", GetMinimum(2, 5, 7, 32, 6, 7, 93));
        Console.WriteLine("The maximum is: {0}", GetMaximum(2, 5, 7, 32, 6, 7, 93));
        Console.WriteLine("The average is: {0:F2}", CalculateAverage(2, 5, 7, 32, 6, 7, 93));
        Console.WriteLine("The sum is: {0}", CalculateSum(2, 5, 7, 32, 6, 7, 93));
        Console.WriteLine("The product is: {0}", CalculateProduct(2, 5, 7, 32, 6, 7, 93));
    }

    static int GetMinimum(params int[] numbers)
    {
        int min = int.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (min > numbers[i])
            {
                min = numbers[i];
            }
        }
        return min;
    }

    static int GetMaximum(params int[] numbers)
    {
        int max = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }
        }
        return max;
    }

    static decimal CalculateAverage(params int[] numbers)
    {
        decimal average = (decimal)CalculateSum(numbers) / numbers.Length;
        return average;
    }

    static int CalculateSum(params int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    static BigInteger CalculateProduct(params int[] numbers)
    {
        BigInteger product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("The minimum is: {0}", GetMinimum(2.3, 5.1, 7.0, 32.4, 6.8, 7.9, 93.7));
        Console.WriteLine("The maximum is: {0}", GetMaximum(2.3, 5.1, 7.0, 32.4, 6.8, 7.9, 93.7));
        Console.WriteLine("The average is: {0:F3}", CalculateAverage(2.3, 5.1, 7.0, 32.4, 6.8, 7.9, 93.7));
        Console.WriteLine("The sum is: {0}", CalculateSum(2.3, 5.1, 7.0, 32.4, 6.8, 7.9, 93.7));
        Console.WriteLine("The product is: {0:F3}", CalculateProduct(2.3, 5.1, 7.0, 32.4, 6.8, 7.9, 93.7));
    }


    static T GetMinimum<T>(params T[] numbers) where T : IComparable
    {
        T min = numbers[1];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i].CompareTo(min) < 0)
            {
                min = numbers[i];
            }
        }
        return min;
    }

    static T GetMaximum<T>(params T[] numbers) where T : IComparable
    {
        T max = numbers[1];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i].CompareTo(max) > 0)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    static T CalculateAverage<T>(params T[] numbers) where T : IComparable
    {
        T average = CalculateSum(numbers) / (dynamic)numbers.Length;
        return average;
    }

    static T CalculateSum<T>(params T[] numbers) where T : IComparable
    {
        T sum = default(T);
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += (dynamic)numbers[i];
        }
        return sum;
    }

    static T CalculateProduct<T>(params T[] numbers) where T : IComparable
    {
        dynamic product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= (dynamic)numbers[i];
        }
        return product;
    }
}
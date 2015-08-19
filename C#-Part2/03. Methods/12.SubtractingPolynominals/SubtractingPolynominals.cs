using System;
using System.Linq;
using System.Collections.Generic;

class SubtractingPolynominals
{
    static void Main()
    {
        Console.WriteLine("Please enter the coefficients ot two polynominals, represented as array and separated by space:");
        Console.Write("Polynominal 1: ");
        string[] poly1Str = Console.ReadLine().Split(' ');
        int[] polynominal1 = poly1Str.Select(int.Parse).ToArray();
        Console.Write("Polynominal 2: ");
        string[] poly2Str = Console.ReadLine().Split(' ');
        int[] polynominal2 = poly2Str.Select(int.Parse).ToArray();
        int[] subtract = SubtractCoeficients(polynominal1, polynominal2);
        Console.WriteLine("The result of subtraction is: {0}", PrintResult(subtract));
        int[] multiplication = MultiplicationCoeficients(polynominal1, polynominal2);
        Console.WriteLine("The result of multiplication is: {0}", PrintResult(multiplication));
    }

    static int[] SubtractCoeficients(int[] number1Arr, int[] number2Arr)
    {
        Array.Reverse(number1Arr);
        Array.Reverse(number2Arr);
        int length = 0;
        if (number1Arr.Length > number2Arr.Length)
        {
            length = number1Arr.Length;
            List<int> temp = number2Arr.ToList();
            for (int i = 0; i < length - number2Arr.Length; i++)
            {
                temp.Add(0);
            }
            number2Arr = new int[length];
            number2Arr = temp.ToArray();
        }
        else
        {
            length = number2Arr.Length;
            List<int> temp = number1Arr.ToList();
            for (int i = 0; i < length - number1Arr.Length; i++)
            {
                temp.Add(0);
            }
            number1Arr = new int[length];
            number1Arr = temp.ToArray();
        }

        int[] subArr = new int[length];
        for (int i = 0; i < length; i++)
        {
            subArr[i] = number1Arr[i] - number2Arr[i];
        }
        Array.Reverse(subArr);
        return subArr;
    }

    static int[] MultiplicationCoeficients(int[] number1Arr, int[] number2Arr)
    {
        Array.Reverse(number1Arr);
        Array.Reverse(number2Arr);
        if (number1Arr.Length > number2Arr.Length)
        {
            List<int> temp = number2Arr.ToList();
            for (int i = 0; i < number1Arr.Length - number2Arr.Length; i++)
            {
                temp.Add(0);
            }
            number2Arr = new int[number1Arr.Length];
            number2Arr = temp.ToArray();
        }
        else
        {
            List<int> temp = number1Arr.ToList();
            for (int i = 0; i < number2Arr.Length - number1Arr.Length; i++)
            {
                temp.Add(0);
            }
            number1Arr = new int[number2Arr.Length];
            number1Arr = temp.ToArray();
        }

        int length = number1Arr.Length + number2Arr.Length - 1;
        int[] productArr = new int[length];
        for (int i = 0; i < number1Arr.Length; i++)
        {
            for (int j = 0; j < number2Arr.Length; j++)
            {
                productArr[i + j] += number1Arr[i] * number2Arr[j];
            }
        }
        return productArr;
    }

    static string PrintResult (int[] resultArr)
    {
        string result = string.Empty;
        int rate = 0;
        for (int i = 0; i < resultArr.Length; i++)
        {
            rate = resultArr.Length - 1 - i;
            if (rate == resultArr.Length - 1)
            {
                if (resultArr[i] < 0)
                {
                    result += " - " + Math.Abs(resultArr[i]) + " x" + "^" + rate;
                }
                else if (resultArr[i] == 0)
                {
                    continue;
                }
                else
                {
                    result += resultArr[i] + " x" + "^" + rate;
                }
            }
            else if (rate > 1)
            {
                if (resultArr[i] < 0)
                {
                    result += " - " + Math.Abs(resultArr[i]) + " x" + "^" + rate;
                }
                else if (resultArr[i] == 0)
                {
                    continue;
                }
                else
                {
                    result += " + " + resultArr[i] + " x" + "^" + rate;
                }
            }
            else if (rate == 1)
            {
                if (resultArr[i] < 0)
                {
                    result += " - " + Math.Abs(resultArr[i]) + " x";
                }
                else if (resultArr[i] == 0)
                {
                    continue;
                }
                else
                {
                    result += " + " + resultArr[i] + " x";
                }
            }
            else
            {
                if (resultArr[i] < 0)
                {
                    result += " - " + Math.Abs(resultArr[i]);
                }
                else if (resultArr[i] == 0)
                {
                    continue;
                }
                else
                {
                    result += " + " + resultArr[i];
                }
            }
        }
        return result;
    }
}
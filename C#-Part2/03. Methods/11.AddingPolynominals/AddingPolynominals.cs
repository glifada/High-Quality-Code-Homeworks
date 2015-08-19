using System;
using System.Linq;
using System.Collections.Generic;

class AddingPolynominals
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
        AddCoeficients(polynominal1, polynominal2);
    }

    static void AddCoeficients(int[] number1Arr, int[] number2Arr)
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

        int[] sumArr = new int[length];
        for (int i = 0; i < length; i++)
        {
            sumArr[i] = number1Arr[i] + number2Arr[i];
        }
        Array.Reverse(sumArr);

        string result = string.Empty;
        int rate = 0;
        for (int i = 0; i < sumArr.Length; i++)
        {
            rate = sumArr.Length - 1 - i;
            if (rate == sumArr.Length - 1)
            {
                if (sumArr[i] < 0)
                {
                    result += " " + sumArr[i] + " x" + "^" + rate;
                }
                else if (sumArr[i] == 0)
                {
                    continue;
                }
                else
                {
                    result += sumArr[i] + " x" + "^" + rate;
                }
            }
            else if (rate > 1)
            {
                if (sumArr[i] < 0)
                {
                    result += " " + sumArr[i] + " x" + "^" + rate;
                }
                else if (sumArr[i] == 0)
                {
                    continue;
                }
                else
                {
                    result += " + " + sumArr[i] + " x" + "^" + rate;
                }
            }
            else if (rate == 1)
            {
                if (sumArr[i] < 0)
                {
                    result += " " + sumArr[i] + " x";
                }
                else if (sumArr[i] == 0)
                {
                    continue;
                }
                else
                {
                    result += " + " + sumArr[i] + " x";
                }
            }
            else
            {
                if (sumArr[i] < 0)
                {
                    result += sumArr[i];
                }
                else if (sumArr[i] == 0)
                {
                    continue;
                }
                else
                {
                    result += " + " + sumArr[i];
                }
            }  
        }
        Console.WriteLine("The result is: {0}", result);
    }
}
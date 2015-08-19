using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

class NumbersAsArray
{
    static void Main()
    {
        Console.WriteLine("Please enter two positive integer numbers:");
        Console.Write("Number 1: ");
        BigInteger number1 = BigInteger.Parse(Console.ReadLine());
        Console.Write("Number 2: ");
        BigInteger number2 = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine(string.Join(", ", IntToArray(number1)));
        Console.WriteLine(string.Join(", ", IntToArray(number2)));
        Console.WriteLine("The sum is: {0}", string.Join("", AddNumbers(number1, number2)));

    }

    static int[] IntToArray(BigInteger number)
    {
        string numStr = Convert.ToString(number);
        int[] digits = new int[numStr.Length];
        int i = numStr.Length-1;
        foreach (char digit in numStr)
        {
            digits[i] = digit - '0';
            i--;
        }
        return digits;
    }

    static List<int> AddNumbers(BigInteger number1, BigInteger number2)
    {
        int[] number1Arr = IntToArray(number1);
        int[] number2Arr = IntToArray(number2);
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

        int[] sumArr = new int [length + 1];
        for (int i = 0; i < length; i++)
        {
            sumArr[i] += number1Arr[i] + number2Arr[i];
            if (sumArr[i] >= 10)
            {
                sumArr[i] = sumArr[i] % 10;
                sumArr[i + 1]++;
            }
        }
        List<int> sumList = sumArr.ToList();
        if (sumList[length] == 0)
        {
            sumList.RemoveAt(length);
        }
        sumList.Reverse();
        return sumList;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

class OneSystemToAnother
{
    static void Main()
    {
        Console.Write("Please enter the numeral system base to convert from: ");
        int baseFrom = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number you want to convert: ");
        string inputNumberStr = Console.ReadLine();
        Console.Write("Please enter the numeral system base to convert to: ");
        int baseTo = int.Parse(Console.ReadLine());
        while (baseFrom < 2 || baseTo > 16)
        {
            Console.WriteLine("The first numeral system base must be >= 2 and second numeral system base must be <= 16.");
            Console.WriteLine("Please enter new values for bases:");
            Console.Write("Please enter the numeral system base to convert from: ");
            baseFrom = int.Parse(Console.ReadLine());
            Console.Write("Please enter the numeral system base to convert to: ");
            baseTo = int.Parse(Console.ReadLine());
        }
        char[] inputNumberArr = inputNumberStr.ToCharArray();
        int decimalNumber = ConvertToDecimal(inputNumberArr, baseFrom);
        Console.WriteLine("Converted number is: {0}", ConvertFromDecimal(decimalNumber, baseTo));
    }

    static int ConvertToDecimal(char[] inputNumberArr, int baseFrom)
    {
        int decimalNumber = 0;
        int remainder = 0;

        for (int i = inputNumberArr.Length - 1; i >= 0; i--)
        {
            switch (inputNumberArr[i])
            {
                case 'A': remainder = 10; break;
                case 'B': remainder = 11; break;
                case 'C': remainder = 12; break;
                case 'D': remainder = 13; break;
                case 'E': remainder = 14; break;
                case 'F': remainder = 15; break;
                default: remainder = inputNumberArr[i] - '0'; break;
            }
            decimalNumber += remainder * (int)Math.Pow(baseFrom, inputNumberArr.Length - 1 - i);
        }
        return decimalNumber;
    }

    static string ConvertFromDecimal(int decimalNumber, int baseTo)
    {
        int devided = decimalNumber;
        int remainder = 0;
        string reversedNum = string.Empty;
        char symbol;
        while (devided > 0)
        {
            remainder = devided % baseTo;
            switch (remainder)
            {
                case 10: symbol = 'A'; break;
                case 11: symbol = 'B'; break;
                case 12: symbol = 'C'; break;
                case 13: symbol = 'D'; break;
                case 14: symbol = 'E'; break;
                case 15: symbol = 'F'; break;
                default: symbol = Convert.ToChar(remainder + 48); break;
            }
            reversedNum += symbol;
            devided /= baseTo;
        }
        char[] arr = reversedNum.ToCharArray();
        Array.Reverse(arr);
        string convertedNum = string.Join("", arr);
        return convertedNum;
    }
}

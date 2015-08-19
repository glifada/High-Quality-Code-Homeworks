using System;
using System.Linq;
using System.Collections.Generic;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Please enter the hexadecimal number you want to convert: ");
        string hexNumberStr = Console.ReadLine();
        char[] hexNumberArr = hexNumberStr.ToCharArray();
        int decimalNumber = 0;
        int remainder = 0;
        if (hexNumberArr[0] == '0' && hexNumberArr[1] == 'x')
        {
            List<char> hexNumberList = hexNumberArr.ToList();
            hexNumberList.RemoveAt(0);
            hexNumberList.RemoveAt(0);
            hexNumberArr = hexNumberList.ToArray();
        }
        for (int i = 0; i < hexNumberArr.Length; i++)
        {
            switch (hexNumberArr[i])
            {
                case 'A': remainder = 10; break;
                case 'B': remainder = 11; break;
                case 'C': remainder = 12; break;
                case 'D': remainder = 13; break;
                case 'E': remainder = 14; break;
                case 'F': remainder = 15; break;
                default: remainder = hexNumberArr[i] - '0'; break;
            }
            decimalNumber += remainder * (int)Math.Pow(16, hexNumberArr.Length - 1 - i);
        }
        Console.WriteLine("The decimal representation of hexadecimal number {0} is {1}", hexNumberStr, decimalNumber);
    }
}

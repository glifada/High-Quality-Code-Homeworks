using System;
using System.Collections.Generic;
using System.Linq;

class BinaryShort
{
    static void Main()
    {
        Console.Write("Please enter the short number you want to convert: ");
        short shortNumber = short.Parse(Console.ReadLine());
        string binaryNum = string.Empty;
        if (shortNumber < 0)
        {
            binaryNum = ConvertNegativeNumber(shortNumber);
        }
        else
        {
            binaryNum = ConvertPositiveNumber(shortNumber);
        }
        Console.WriteLine("The binary representation of short number {0} is {1}", shortNumber, binaryNum);
    }

    static string ConvertPositiveNumber(short shortNumber)
    {
        short devided = shortNumber;
        short remainder = 0;
        string reversedBinNum = string.Empty;
        while (devided > 0)
        {
            remainder = (short)(devided % 2);
            reversedBinNum += remainder;
            devided /= 2;
        }
        char[] binaryArr = reversedBinNum.ToCharArray();
        Array.Reverse(binaryArr);
        string binaryNum = string.Join("", binaryArr).PadLeft(16, '0');
        return binaryNum;
    }

    static string ConvertNegativeNumber(short shortNumber)
    {
        short devided = (short)(Math.Abs(shortNumber) - 1);
        short remainder = 0;
        string reversedBinNum = string.Empty;
        while (devided > 0)
        {
            remainder = (short)(devided % 2);
            reversedBinNum += remainder;
            devided /= 2;
        }
        char[] binaryArr = reversedBinNum.ToCharArray();
        Array.Reverse(binaryArr);
        string binaryNum = string.Join("", binaryArr).PadLeft(16, '0');
        binaryArr = binaryNum.ToCharArray();
        for (int i = 0; i < binaryArr.Length; i++)
        {
            if (binaryArr[i] == '0')
            {
                binaryArr[i] = '1';
            }
            else
            {
                binaryArr[i] = '0';
            }
        }
        return string.Join("", binaryArr);
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Please enter the hexadecimal number you want to convert: ");
        string hexNumberStr = Console.ReadLine();
        char[] hexNumberArr = hexNumberStr.ToCharArray();
        string binaryNumber = string.Empty;
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
                case '0': binaryNumber += "0000"; break;
                case '1': binaryNumber += "0001"; break;
                case '2': binaryNumber += "0010"; break;
                case '3': binaryNumber += "0011"; break;
                case '4': binaryNumber += "0100"; break;
                case '5': binaryNumber += "0101"; break;
                case '6': binaryNumber += "0110"; break;
                case '7': binaryNumber += "0111"; break;
                case '8': binaryNumber += "1000"; break;
                case '9': binaryNumber += "1001"; break;
                case 'A': binaryNumber += "1010"; break;
                case 'B': binaryNumber += "1011"; break;
                case 'C': binaryNumber += "1100"; break;
                case 'D': binaryNumber += "1101"; break;
                case 'E': binaryNumber += "1110"; break;
                case 'F': binaryNumber += "1111"; break;
            }
        }
        Console.WriteLine("The binary representation of hexadecimal number {0} is {1}", hexNumberStr, binaryNumber);
    }
}

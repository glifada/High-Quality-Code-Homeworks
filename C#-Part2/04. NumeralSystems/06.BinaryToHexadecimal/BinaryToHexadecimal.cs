using System;
using System.Collections.Generic;
using System.Linq;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Please enter the binary number you want to convert: ");
        string binaryNumber = Console.ReadLine();
        int length = 0;
        if (binaryNumber.Length % 4 != 0)
        {
            length = (binaryNumber.Length / 4 + 1) * 4;
        }
        else
        {
            length = binaryNumber.Length;
        }
        string binaryNumberStr = binaryNumber.PadLeft(length, '0');
        string hexadecimalNumber = "0x";
        for (int i = 0; i < binaryNumberStr.Length - 3; i += 4)
        {
            switch (binaryNumberStr.Substring(i, 4))
            {
                case "0000": hexadecimalNumber += "0"; break;
                case "0001": hexadecimalNumber += "1"; break;
                case "0010": hexadecimalNumber += "2"; break;
                case "0011": hexadecimalNumber += "3"; break;
                case "0100": hexadecimalNumber += "4"; break;
                case "0101": hexadecimalNumber += "5"; break;
                case "0110": hexadecimalNumber += "6"; break;
                case "0111": hexadecimalNumber += "7"; break;
                case "1000": hexadecimalNumber += "8"; break;
                case "1001": hexadecimalNumber += "9"; break;
                case "1010": hexadecimalNumber += "A"; break;
                case "1011": hexadecimalNumber += "B"; break;
                case "1100": hexadecimalNumber += "C"; break;
                case "1101": hexadecimalNumber += "D"; break;
                case "1110": hexadecimalNumber += "E"; break;
                case "1111": hexadecimalNumber += "F"; break;
            }
        }
        Console.WriteLine("The hexadecimal representation of binary number {0} is {1}", binaryNumber, hexadecimalNumber);
    }
}

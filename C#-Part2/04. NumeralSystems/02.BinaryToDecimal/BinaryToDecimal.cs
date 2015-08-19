using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Please enter the binary number you want to convert: ");
        string binaryNumberStr = Console.ReadLine();
        char[] binaryNumberArr = binaryNumberStr.ToCharArray();
        int decimalNumber = 0;
        for (int i = 0; i < binaryNumberArr.Length; i++)
        {
            decimalNumber += (binaryNumberArr[binaryNumberArr.Length - 1 - i] - '0') * (int)Math.Pow(2, i);
        }
        Console.WriteLine("The decimal representation of binary number {0} is {1}", binaryNumberStr, decimalNumber);
    }
}

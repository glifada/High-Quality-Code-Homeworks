using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Please enter the decimal number you want to convert: ");
        int number = int.Parse(Console.ReadLine());
        int devided = number;
        int remainder = 0;
        string reversedBinNum = string.Empty;
        while (devided > 0)
        {
            remainder = devided % 2;
            reversedBinNum += remainder;
            devided /= 2;
        }
        char[] arr = reversedBinNum.ToCharArray();
        Array.Reverse(arr);
        string binNum = string.Join("", arr);
        Console.WriteLine("The binary representation of decimal number {0} is {1}", number, binNum);
    }
}
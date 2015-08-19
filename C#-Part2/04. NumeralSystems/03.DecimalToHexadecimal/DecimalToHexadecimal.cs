using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Please enter the decimal number you want to convert: ");
        int number = int.Parse(Console.ReadLine());
        int devided = number;
        int remainder = 0;
        string reversedHexNum = string.Empty;
        char symbol;
        while (devided > 0)
        {
            remainder = devided % 16;
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
            reversedHexNum += symbol;
            devided /= 16;
        }
        reversedHexNum += "x0";
        char[] arr = reversedHexNum.ToCharArray();
        Array.Reverse(arr);
        string hexNum = string.Join("", arr);
        Console.WriteLine("The hexadecimal representation of decimal number {0} is {1}", number, hexNum);
    }
}
using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Please enter a hexadecimal integer number: ");
        string hex = Console.ReadLine();
        long decNum = 0;
        long power = 1;
        int symbol;

        for (int i = hex.Length - 1; i >= 0; i--)
        {
            switch (hex[i])
            {
                case 'A':
                    symbol = 10;
                    break;
                case 'B':
                    symbol = 11;
                    break;
                case 'C':
                    symbol = 12;
                    break;
                case 'D':
                    symbol = 13;
                    break;
                case 'E':
                    symbol = 14;
                    break;
                case 'F':
                    symbol = 15;
                    break;
                default: symbol = hex[i] - 48;
                    break;
            }
            decNum += symbol * power;
            power *= 16;
        }
        Console.WriteLine("The decimal number is {0}.", decNum);
    }
}

using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        long n = long.Parse(Console.ReadLine());
        long remainder = 0;
        string hexNum = "";
        string symbol = "";

        if (n == 0)
        {
            hexNum = "\00";
        }

        while (n > 0)
        {
            remainder = n % 16;
            switch (remainder)
	        {
                case 10:
                    symbol = "A";
                    break;
                case 11:
                    symbol = "B";
                    break;
                case 12:
                    symbol = "C";
                    break;
                case 13:
                    symbol = "D";
                    break;
                case 14:
                    symbol = "E";
                    break;
                case 15:
                    symbol = "F";
                    break;
		        default:
                    symbol = remainder.ToString();
                    break;
	        }
            hexNum = symbol + hexNum;
            n /= 16;
        }
        Console.WriteLine("The hexadecimal number is {0}.", hexNum);
    }
}
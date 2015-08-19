using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Please enter a decimal number you want to reverse: ");
        string number = Console.ReadLine();
        decimal reversedNum = ReverseDigits(number);
        Console.WriteLine(reversedNum);
    }

    static decimal ReverseDigits (string number)
    {
        string reversedStr = string.Empty;
        foreach (char digit in number)
        {
            reversedStr = digit + reversedStr;
        }
        return decimal.Parse(reversedStr);
    }
}

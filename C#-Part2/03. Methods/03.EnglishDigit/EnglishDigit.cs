using System;

class EnglishDigit
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        int number = int.Parse(Console.ReadLine());
        string digitWord = GetDigit(number);
        Console.WriteLine("The last digit of number {0} is {1}.", number, digitWord);
    }
    static string GetDigit (int number)
    {
        int digit = number % 10;
        string digitWord = string.Empty;
        switch (digit)
        {
            case 0: digitWord = "zero"; break;
            case 1: digitWord = "one"; break;
            case 2: digitWord = "two"; break;
            case 3: digitWord = "three"; break;
            case 4: digitWord = "four"; break;
            case 5: digitWord = "five"; break;
            case 6: digitWord = "six"; break;
            case 7: digitWord = "seven"; break;
            case 8: digitWord = "eight"; break;
            case 9: digitWord = "nine"; break;
        }
        return digitWord;
    }
}

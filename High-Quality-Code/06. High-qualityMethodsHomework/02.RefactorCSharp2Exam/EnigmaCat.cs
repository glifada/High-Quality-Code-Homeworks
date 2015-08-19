using System;
using System.Linq;
using System.Collections.Generic;

class EnigmaCat
{
    static void Main()
    {
        Console.WriteLine(ConvertTextSeventeenToTwentySixNumeralSystem("miao miao miao"));
        Console.WriteLine(ConvertTextSeventeenToTwentySixNumeralSystem("cikfbd clnej hmn"));
    }

    static string ConvertTextSeventeenToTwentySixNumeralSystem(string text)
    {
        if (text == string.Empty)
        {
            throw new ArgumentNullException("The text is empty string!");
        }

        string[] inputWords = text.Split(' ');
        string[] outputWords = new string[inputWords.Length];
        for (int i = 0; i < inputWords.Length; i++)
        {
            outputWords[i] = (ConvertDecimalToTwentySix(ConvertSeventeenToDecimal(inputWords[i])));
        }
        string convertedText = string.Join(" ", outputWords);
        return convertedText;
    }

    static ulong ConvertSeventeenToDecimal(string inputWord)
    {
        ulong decimalNumber = 0;
        ulong remainder = 0;
        for (int i = 0; i < inputWord.Length; i++)
        {
            remainder = (ulong)(inputWord[i] - 'a');
            decimalNumber += remainder * (ulong)Math.Pow(17, inputWord.Length - 1 - i);
        }
        return decimalNumber;
    }

    static string ConvertDecimalToTwentySix(ulong decimalNumber)
    {
        ulong devided = decimalNumber;
        ulong remainder = 0;
        string reversedNum = string.Empty;
        char symbol;
        while (devided > 0)
        {
            remainder = devided % 26;
            symbol = Convert.ToChar(remainder + 97);
            reversedNum += symbol;
            devided /= 26;
        }
        char[] arr = reversedNum.ToCharArray();
        Array.Reverse(arr);
        string convertedText = string.Join(string.Empty, arr);
        return convertedText;
    }
}
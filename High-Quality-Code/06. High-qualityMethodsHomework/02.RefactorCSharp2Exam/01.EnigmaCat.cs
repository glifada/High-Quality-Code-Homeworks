using System;
using System.Linq;
using System.Collections.Generic;

class EnigmaCat
{
    static void Main()
    {
        string[] inputWords = Console.ReadLine().Split(' ');
        if (inputWords == null || inputWords.Length == 0)
        {
            throw new ArgumentNullException("Empty input string");
        }

        string[] outputWords = new string[inputWords.Length];
        for (int i = 0; i < inputWords.Length; i++)
        {
            outputWords[i] = (ConvertFromDecimal(ConvertToDecimal(inputWords[i])));
        }
        Console.WriteLine(string.Join(" ", outputWords));
    }

    static ulong ConvertToDecimal(string inputWord)
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

    static string ConvertFromDecimal(ulong decimalNumber)
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
        string convertedNum = string.Join(string.Empty, arr);
        return convertedNum;
    }
}
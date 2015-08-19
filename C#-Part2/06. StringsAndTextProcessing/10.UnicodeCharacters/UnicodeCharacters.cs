using System;
using System.Linq;
using System.Globalization;

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Please enter the string yoy want to convert: ");
        string text = Console.ReadLine();
        string code = string.Empty;
        string unicodeText = string.Empty;
        foreach (char symbol in text)
        {
            code = string.Format("\\u" + ((int)(symbol)).ToString("X4"));
            unicodeText += code;
        }
        Console.WriteLine("The Unicode representation is {0}", unicodeText);
    }
}

using System;
using System.IO;
using System.Text.RegularExpressions;

class PrefixTest
{
    static void Main()
    {
        string newText = string.Empty;
        using (StreamReader reader = new StreamReader ("text.txt"))
        {
            string text = reader.ReadToEnd();
            newText = Regex.Replace(text, " test(?:[a-zA-Z0-9_]{0,})? ", " ");
        }
        using (StreamWriter writer = new StreamWriter ("text.txt"))
        {
            writer.WriteLine(newText);
        }
    }
}
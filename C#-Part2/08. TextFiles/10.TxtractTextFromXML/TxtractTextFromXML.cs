using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.IO;

class TxtractTextFromXML
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader ("textXML.xml"))
        {
            string text = reader.ReadToEnd();
            string newText = Regex.Replace(text, @"<.*?>", " ");
            newText = Regex.Replace(newText, @"[ ]{2,}", " ");
            Console.WriteLine(newText.Trim());
        }
    }
}

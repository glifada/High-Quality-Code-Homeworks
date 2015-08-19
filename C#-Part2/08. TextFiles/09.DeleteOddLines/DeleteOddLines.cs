using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        string newText = string.Empty;
        using (StreamReader reader = new StreamReader ("text.txt"))
        {
            string text = reader.ReadLine();
            int line = 1;
            while (text != null)
            {
                if (line % 2 == 1)
                {
                    text = string.Empty;
                }
                else
                {
                    newText += text + "\r\n";
                }
                text = reader.ReadLine();
                line++;
            }
        }
        using (StreamWriter writer = new StreamWriter("text.txt"))
        {
            writer.WriteLine(newText);
        }
    }
}

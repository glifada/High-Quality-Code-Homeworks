using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("text.txt"))
        {
            int line = 0;
            string textLine = reader.ReadLine();
            while (textLine != null)
            {
                line++;
                if (line % 2 == 1)
                {
                    Console.WriteLine("Line {0}: {1}", line, textLine);
                }
                textLine = reader.ReadLine();
            }
        }
    }
}
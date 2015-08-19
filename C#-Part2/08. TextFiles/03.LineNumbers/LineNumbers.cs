using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("text.txt"))
        {
            int line = 0;
            string textLine = reader.ReadLine();
            using (StreamWriter writer = new StreamWriter("fullText.txt"))
            {
                while (textLine != null)
                {
                    line++;
                    writer.WriteLine("Line {0}: {1}", line, textLine);
                    textLine = reader.ReadLine();
                }
            }
        }
    }
}

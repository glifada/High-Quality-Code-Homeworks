using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

class ReplaceWholeWord
{
    static void Main()
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        using (StreamReader reader = new StreamReader("start.txt"))
        {
            string startText = reader.ReadToEnd();
            string finishText = startText.Replace(" start ", " finish ")
                                         .Replace(" start.", " finish.")
                                         .Replace(" start,", " finish,")
                                         .Replace("Start ", "Finish ");

            using (StreamWriter writer = new StreamWriter("finish.txt"))
            {
                writer.WriteLine(finishText);
            }
        }
        Console.WriteLine(sw.Elapsed);
    }
}

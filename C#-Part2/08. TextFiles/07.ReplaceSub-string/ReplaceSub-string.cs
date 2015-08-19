using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

    class ReplaceSub_string
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader ("start.txt"))
            {
                string startText = reader.ReadToEnd();
                string finishText = startText.Replace("start", "finish");

                using (StreamWriter writer = new StreamWriter("finish.txt"))
                {
                    writer.WriteLine(finishText);
                }
            }
        }
    }

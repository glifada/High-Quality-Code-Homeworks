using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class CompareTextFiles
{
    static void Main()
    {
        using (StreamReader firstReader = new StreamReader ("text1.txt"))
        {
            
            using (StreamReader secondReader = new StreamReader ("text2.txt"))
            {
                string firstText = firstReader.ReadLine();
                string secondText = secondReader.ReadLine();
                int line = 0;
                List<int> sameLines = new List<int>();
                List<int> differentLines = new List<int>();
                while (firstText != null && secondText != null)
                {
                    line++;
                    if (firstText == secondText)
                    {
                        sameLines.Add(line);
                    }
                    else
                    {
                        differentLines.Add(line);
                    }
                    firstText = firstReader.ReadLine();
                    secondText = secondReader.ReadLine(); 
                }
                Console.WriteLine("Same lines are: {0}", string.Join(", ", sameLines));
                Console.WriteLine("Different lines are: {0}", string.Join(", ", differentLines));
            }
        }
    }
}

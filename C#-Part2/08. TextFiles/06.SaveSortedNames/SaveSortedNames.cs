using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class SaveSortedNames
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader ("names.txt"))
        {
            string text = reader.ReadLine();
            List<string> names = new List<string>();
            while (text != null)
            {
                names.Add(text);
                text = reader.ReadLine();
            }
            names.Sort();
            using (StreamWriter writer = new StreamWriter("sorted names.txt"))
            {
                writer.WriteLine(string.Join("\r\n", names));
            }
        }
    }
}

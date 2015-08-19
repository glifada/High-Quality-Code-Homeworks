using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        string firstText = string.Empty;
        string secondText = string.Empty;
        using (StreamReader firstReader = new StreamReader("text1.txt"))
        {
            firstText = firstReader.ReadToEnd();
        }
        using (StreamReader secondReader = new StreamReader("text2.txt"))
        {
            secondText = secondReader.ReadToEnd();
        }
        string text = firstText + "\n\r" + "\n\r" + "\n\r" + secondText;
        using (StreamWriter fulLText = new StreamWriter("fullText.txt", false))
        {
            fulLText.Write(text);
        }
    }
}

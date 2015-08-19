using System;

class QuotesInStrings
{
    static void Main()
    {
        string sentence1 = "The use of quotations causes difficulties.";
        Console.WriteLine("This is the sentence without quotations: {0}", sentence1);
        string sentence2 = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine("This is the sentence with quotations: {0}", sentence2);
    }
}

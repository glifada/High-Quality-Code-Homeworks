using System;

class Sub_stringInText
{
    static void Main()
    {
        Console.Write("Please enter a text: ");
        string text = Console.ReadLine();
        Console.Write("Please enter a substring you want to find: ");
        string substring = Console.ReadLine();
        text = text.ToLower();
        int index = -1;
        int counter = 0;
        while (true)
        {
            index = text.IndexOf(substring, index + 1);
            if (index == -1)
            {
                break;
            }
            counter++;
        }
        Console.WriteLine("The substring \"{0}\" is contained {1} times in the text.", substring, counter);
    }
}

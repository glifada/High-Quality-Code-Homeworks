using System;

class ReverseAString
{
    static void Main()
    {
        Console.Write("Please enter a string: ");
        string str = Console.ReadLine();
        string reversedStr = string.Empty;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversedStr += str[i];
        }
        Console.WriteLine("Reversed string of {0} is {1}.", str, reversedStr);
    }
}
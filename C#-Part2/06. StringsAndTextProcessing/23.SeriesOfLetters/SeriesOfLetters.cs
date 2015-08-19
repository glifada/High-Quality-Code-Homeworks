using System;

class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Please enter a string: ");
        string str = Console.ReadLine();

        for (int i = 0; i < str.Length - 1 ; i++)
        {
            while (str[i] == str[i + 1])
            {
                str = str.Remove(i + 1, 1);
                if (i == str.Length - 1)
                {
                    break;
                }
            }
        }
        Console.WriteLine(str);
    }
}

using System;

class LettersCount
{
    static void Main()
    {
        Console.Write("Please enter a string: ");
        string str = Console.ReadLine();

        for (int i = 0; i < str.Length; i++)
        {
            int counter = 1;
            for (int j = i + 1; j < str.Length; j++)
            {
                if (str[i] == str[j])
                {
                    counter++;
                    str = str.Remove(j, 1);
                }
            }
            Console.WriteLine("Letter \"{0}\" is found {1} times.", str[i], counter);
        }
    }
}

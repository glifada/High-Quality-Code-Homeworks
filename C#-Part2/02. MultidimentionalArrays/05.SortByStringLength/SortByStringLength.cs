using System;

class SortByStringLength
{
    static void Main()
    {
        Console.Write("Please enter a length of a string: ");
        int length = int.Parse(Console.ReadLine());
        string[] text = new string[length];
        Console.Write("Please enter a string of integers, separated by space: ");
        text = Console.ReadLine().Split(' ');

        string temp = string.Empty;
        for (int i = 0; i < text.Length - 1; i++)
        {
            int firstCounter = 0;
            int secondCounter = 0;
            foreach (char symbol in text[i])
            {
                firstCounter++;
            }
            foreach (char symbol in text[i + 1])
            {
                secondCounter++;
            }
            if (secondCounter < firstCounter)
            {
                temp = text[i];
                text[i] = text[i + 1];
                text[i + 1] = temp;
                i = -1;
            }
        }
        Console.WriteLine(string.Join(", ", text));
    }
}
using System;

class Palindromes
{
    static void Main()
    {
        Console.WriteLine("Please enter the text:");
        string text = Console.ReadLine();
        string[] word = text.Split(' ');
        bool isPalindrome = false;

        for (int i = 0; i < word.Length; i++)
        {
            int counter = 0;
            for (int j = 0; j <= word[i].Length / 2; j++)
            {
                if (word[i][j] == word[i][word[i].Length - 1 - j])
                {
                    isPalindrome = true;
                    counter++;
                }
                else
                {
                    isPalindrome = false;
                }
            }

            if (isPalindrome && counter == (word[i].Length / 2) + 1)
            {
                Console.WriteLine("The word \"{0}\" is palindrome.", word[i]);
            }
        }
    }
}
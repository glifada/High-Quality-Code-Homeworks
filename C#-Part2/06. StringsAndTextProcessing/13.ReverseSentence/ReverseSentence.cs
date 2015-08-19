using System;
using System.Linq;
using System.Collections.Generic;

class ReverseSentence
{
    static void Main()
    {
        Console.Write("Please enter a sentence: ");
        string sentence = Console.ReadLine();
        int index = 0;
        int startIndex = 0;
        string str = string.Empty;
        List<string> wordsSub = new List<string>();
        List<string> words = new List<string>();
        char sign = sentence[sentence.Length - 1];

        for (int i = 0; i < sentence.Length; i++)
        {
            startIndex = index;
            index = sentence.IndexOf(',', i);
            if (sentence[index + 1] == ' ')
            {
                sentence = sentence.Remove(index + 1, 1);
            }
            if (index == -1)
            {
                str = sentence.Substring(startIndex, sentence.Length - 1 - startIndex);
            }
            else
            {
                str = sentence.Substring(startIndex, index - startIndex);
            }
            wordsSub = str.Split(' ').ToList();
            for (int j = 0; j < wordsSub.Count; j++)
            {
                words.Add(wordsSub[j]);
            }
            if (index == -1)
            {
                break;
            }
            i = index;
        }
        words.Reverse();
        words[words.Count - 1] += sign;
        sentence = string.Join(" ", words);
        for (int i = 0; i < sentence.Length; i++)
        {
            index = sentence.IndexOf(',', i);
            if (index == -1)
            {
                break;
            }
            sentence = sentence.Remove(index - 1, 1);
            sentence = sentence.Insert(index, " ");
            i = index;
        }
        Console.WriteLine(sentence);
    }
}

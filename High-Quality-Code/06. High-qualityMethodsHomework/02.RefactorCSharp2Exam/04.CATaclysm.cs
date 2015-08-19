using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class Program
{
    static void Main()
    {
        string line = Console.ReadLine();
        string[] words = line.Split(' ');

        List<string> outputWords = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            ulong code = 0;
            ulong number = 0;
            for (int j = 0; j < words[i].Length; j++)
            {
                switch (words[i][j])
                {
                    case 'a': code = 0; break;
                    case 'b': code = 1; break;
                    case 'c': code = 2; break;
                    case 'd': code = 3; break;
                    case 'e': code = 4; break;
                    case 'f': code = 5; break;
                    case 'g': code = 6; break;
                    case 'h': code = 7; break;
                    case 'i': code = 8; break;
                    case 'j': code = 9; break;
                    case 'k': code = 10; break;
                    case 'l': code = 11; break;
                    case 'm': code = 12; break;
                    case 'n': code = 13; break;
                    case 'o': code = 14; break;
                    case 'p': code = 15; break;
                    case 'q': code = 16; break;
                }
                number += code * (ulong)Math.Pow(17, words[i].Length - 1 - j);
            }


            ulong remainder = 0;
            List<char> output = new List<char>();
            char symbol = 'a';
            while (number > 0)
            {
                remainder = (number % 26);
                switch (remainder)
                {
                    case 0: symbol = 'a'; break;
                    case 1: symbol = 'b'; break;
                    case 2: symbol = 'c'; break;
                    case 3: symbol = 'd'; break;
                    case 4: symbol = 'e'; break;
                    case 5: symbol = 'f'; break;
                    case 6: symbol = 'g'; break;
                    case 7: symbol = 'h'; break;
                    case 8: symbol = 'i'; break;
                    case 9: symbol = 'j'; break;
                    case 10: symbol = 'k'; break;
                    case 11: symbol = 'l'; break;
                    case 12: symbol = 'm'; break;
                    case 13: symbol = 'n'; break;
                    case 14: symbol = 'o'; break;
                    case 15: symbol = 'p'; break;
                    case 16: symbol = 'q'; break;
                    case 17: symbol = 'r'; break;
                    case 18: symbol = 's'; break;
                    case 19: symbol = 't'; break;
                    case 20: symbol = 'u'; break;
                    case 21: symbol = 'v'; break;
                    case 22: symbol = 'w'; break;
                    case 23: symbol = 'x'; break;
                    case 24: symbol = 'y'; break;
                    case 25: symbol = 'z'; break;
                }
                output.Add(symbol);
                number /= 26;
            }
            output.Reverse();
            outputWords.Add(string.Join("", output));
            outputWords.Add(" ");
            output.Clear();
        }
        Console.WriteLine(string.Join("", outputWords));
    }
}
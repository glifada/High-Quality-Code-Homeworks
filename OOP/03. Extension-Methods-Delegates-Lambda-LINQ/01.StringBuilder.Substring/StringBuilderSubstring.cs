using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilderSubstring
{
    static class StringBuilderSubstring
    {
        public static StringBuilder Substring (this StringBuilder text, int index, int length)
        {
            if (text.Length == 0)
            {
                throw new ArgumentNullException("The StringBuilder is empty!");
            }
            if (index < 0 || text.Length - 1 < index)
            {
                throw new ArgumentOutOfRangeException("The index is out of range!");
            }
            if (length < 1 || text.Length - index < length)
            {
                throw new ArgumentOutOfRangeException("The lenght of the substring is out of range!");
            }

            string str = text.ToString();
            StringBuilder newText = new StringBuilder();

            for (int i = index; i < index + length; i++)
            {
                newText.Append(str[i]);
            }
            return newText;
        }
        static void Main()
        {
            StringBuilder text = new StringBuilder();
            text.Append("Test for extension method Substring for StringBuilder");
            StringBuilder textSubstring = text.Substring(9, 16);
            Console.WriteLine(textSubstring);
        }
    }
}

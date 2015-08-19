using System;

class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Please enter an expression to check: ");
        string expresion = Console.ReadLine();
        int counterOpenBrackets = 0;
        int counterCloseBrackets = 0;
        foreach (char symbol in expresion)
        {
            if (symbol == '(')
            {
                counterOpenBrackets++;
            }
            else if (symbol == ')')
            {
                counterCloseBrackets++;
            }
        }

        if (counterOpenBrackets == counterCloseBrackets)
        {
            Console.WriteLine("The brackets are put corectly!");
        }
        else
        {
            Console.WriteLine("The brackets are not put corectly!");
        }
    }
}

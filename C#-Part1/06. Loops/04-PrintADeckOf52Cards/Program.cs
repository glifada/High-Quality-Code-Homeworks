using System;

class Program
{
    static void Main()
    {
        for (int card = 1; card <= 13; card++)
        {
            for (int suit = 1; suit <= 4; suit++)
            {
                switch (card)
                {
                    case 1: Console.Write("2 of ");
                        break;
                    case 2: Console.Write("3 of ");
                        break;
                    case 3: Console.Write("4 of ");
                        break;
                    case 4: Console.Write("5 of ");
                        break;
                    case 5: Console.Write("6 of ");
                        break;
                    case 6: Console.Write("7 of ");
                        break;
                    case 7: Console.Write("8 of ");
                        break;
                    case 8: Console.Write("9 of ");
                        break;
                    case 9: Console.Write("10 of ");
                        break;
                    case 10: Console.Write("J of ");
                        break;
                    case 11: Console.Write("Q of ");
                        break;
                    case 12: Console.Write("K of ");
                        break;
                    case 13: Console.Write("A of ");
                        break;
                }
                switch (suit)
                {
                    case 1: Console.Write("{0}, ", '\u2660');
                        break;
                    case 2: Console.Write("{0}, ", '\u2666');
                        break;
                    case 3: Console.Write("{0}, ", '\u2665');
                        break;
                    case 4: Console.Write("{0}", '\u2663');
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}

using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Please enter a score in the range [1...9]: ");
        int score = Int32.Parse(Console.ReadLine());
        if ((score >= 1) && (score <= 9))
        {
            if (score <= 3)
            {
                score = 10 * score;
            }
            else if (score <= 6)
            {
                score = 100 * score;
            }
            else
            {
                score = 1000 * score;
            }
            Console.WriteLine("The bonus score is {0}", score);
        }
        else
        {
            Console.WriteLine("Invalid score!");
        }
    }
}

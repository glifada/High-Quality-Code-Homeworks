using System;

namespace _02.RefactorIfStatements
{
    class IfStatements
    {
        static void Main(string[] args)
        {
            //First IF statement
            Potato potato;
            //... 
            if (potato != null)
            {
                if (!potato.IsRotten && potato.HasBeenPeeled)
                {
                    Cook(potato);
                }
            }


            //Second IF statement
            bool isXcorrect = MIN_X <= x && x <= MAX_X;
            bool isYcorrect = MIN_Y <= y && y <= MAX_Y;
            if (shouldVisitCell && isXcorrect && isYcorrect)
            {
                VisitCell();
            }
        }
    }
}

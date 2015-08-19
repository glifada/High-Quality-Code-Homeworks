using System;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        Console.WriteLine("Please enter the x coordinate:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter the y coordinate:");
        double y = Convert.ToDouble(Console.ReadLine());
        bool insideCircle = (Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2)) <= Math.Pow((1.5), 2);
        bool outsideRect = ((x < -1) || (x > (-1 + 6))) || ((y > 1) || (y < (1 - 2)));
        if (insideCircle && outsideRect)
        {
            Console.WriteLine("The point ({0}, {1}) is inside a circle K((1, 1), 1.5) and is out of a rectangle R(top=1, left=-1, width=6, height=2) at the same time.", x, y);
        }
        else
        {
            Console.WriteLine("The point ({0}, {1}) is not inside a circle K((1, 1), 1.5) and is not out of a rectangle R(top=1, left=-1, width=6, height=2) at the same time.", x, y);
        }
    }
}

using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Please enter the x coordinate:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter the y coordinate:");
        double y = Convert.ToDouble(Console.ReadLine());
        if (((x*x) + (y*y)) <= (2*2))
        {
            Console.WriteLine("The point ({0}, {1}) is inside a circle K((0, 0), 2).", x, y);
        }
        else
        {
            Console.WriteLine("The point ({0}, {1}) is not inside a circle K((0, 0), 2).", x, y);
        }
    }
}

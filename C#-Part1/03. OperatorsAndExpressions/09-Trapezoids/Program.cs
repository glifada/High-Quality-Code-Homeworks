using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Please enter the first trapezoid's side in mm a=");
        float a = Single.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second trapezoid's side in mm b=");
        float b = Single.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the trapezoid's height in mm h=");
        float h = Single.Parse(Console.ReadLine());
        if ((a>0) && (b>0) && (h>0))
        {
            float area = ((float)(a + b) * h / 2);
            Console.WriteLine("The trapezoid's area is {0} mm^2.", area);
        }
        else
        {
            Console.WriteLine("The trapezoid's sides or height must be positive number!");
        }
    }
}

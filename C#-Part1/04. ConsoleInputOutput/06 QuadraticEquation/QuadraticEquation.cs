using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Please enter the coefficients of a quadratic equation ax{0}+bx+c=0.", '\u0032');
        Console.Write("Enter coefficient a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient c= ");
        double c = double.Parse(Console.ReadLine());
        double d = Math.Pow(b, 2) - (4 * a * c);
        if (d > 0)
        {
            Console.WriteLine("The real roots of the quadratic equation are:");
            double x1 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1 = {0}", x1);
            double x2 = (-b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x2 = {0}", x2);
        }
        else if (d == 0)
        {
            Console.WriteLine("The real roots of the quadratic equation are:");
            double x = (-b) / (2 * a);
            Console.WriteLine("x1 = x2 = {0}", x);
        }
        else
        {
            Console.WriteLine("The quadratic equation has no real roots!");
        }
    }
}

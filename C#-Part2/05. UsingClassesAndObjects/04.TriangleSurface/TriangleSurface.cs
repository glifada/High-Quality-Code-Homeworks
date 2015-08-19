using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Please enter the sides of the triangle:");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the altitude to side \"a\":");
        Console.Write("h = ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the angle in degrees between sides \"b\" and \"c\":");
        Console.Write("angle = ");
        double angle = double.Parse(Console.ReadLine());
        CalculateAreaBySideAndAltitude(a, h);
        CalculateAreaByThreeSides(a, b, c);
        CalculateAreaByTwoSidesAndAngle(b, c, angle);
    }

    static void CalculateAreaBySideAndAltitude(double side, double altitude)
    {
        double area = side * altitude / 2;
        area = Math.Round(area, 2);
        Console.WriteLine("The surface of the triangle calculated by side and altitude to it is {0}", area);
    }

    static void CalculateAreaByThreeSides(double a, double b, double c)
    {
        double halfPerimeter = (a + b + c) / 2;
        double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
        area = Math.Round(area, 2);
        Console.WriteLine("The surface of the triangle calculated by three sides is {0}", area);
    }

    static void CalculateAreaByTwoSidesAndAngle(double b, double c, double angle)
    {
        angle = angle * Math.PI / 180;
        double area = b * c * Math.Sin(angle) / 2;
        area = Math.Round(area, 2);
        Console.WriteLine("The surface of the triangle calculated by two sides and an angle between them is {0}", area);
    }
}
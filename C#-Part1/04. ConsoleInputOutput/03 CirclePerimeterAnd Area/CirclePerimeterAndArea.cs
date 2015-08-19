using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please enter the circle radius in mm: ");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = Math.Round(2 * Math.PI * radius, 2);
        double area = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        char sup = '\u0032';
        Console.WriteLine("The perimeter is: {0} mm", perimeter);
        Console.WriteLine("The area is: {0} mm{1}", area, sup);
    }
}

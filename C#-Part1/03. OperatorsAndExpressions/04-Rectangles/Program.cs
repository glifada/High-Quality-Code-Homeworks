using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Please enter rectangle's width in mm:");
        float width = Single.Parse(Console.ReadLine());
        Console.WriteLine("Please enter rectangle's height in mm:");
        float height = Single.Parse(Console.ReadLine());
        float perimeter = 2 * (width + height);
        float area = width * height;
        Console.WriteLine("The rectangle's perimeter is {0} mm and the area is {1} mm^2.", perimeter, area);
    }
}

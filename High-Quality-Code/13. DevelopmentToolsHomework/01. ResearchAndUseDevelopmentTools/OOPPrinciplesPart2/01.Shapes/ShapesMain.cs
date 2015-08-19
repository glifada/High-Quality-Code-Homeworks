using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class ShapesMain
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Square (2),
                new Rectangle(2, 3),
                new Triangle (2, 3)
            };

            foreach (Shape item in shapes)
            {
                Console.WriteLine("The {0} surface is {1:F2}", item.GetType().Name.ToLower(), item.CalculateSurface());
            }
        }
    }
}

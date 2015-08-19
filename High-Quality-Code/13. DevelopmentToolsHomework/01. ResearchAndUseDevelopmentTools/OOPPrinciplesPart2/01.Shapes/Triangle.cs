using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Triangle : Shape
    {
        public Triangle(double width, double height)
            : base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height / 2;
        }

        public override string ToString()
        {
            return string.Format("The triangle surface (width {0}, height {1}) is {2}", this.Width, this.Height, this.CalculateSurface());
        }
    }
}

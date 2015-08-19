using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Square : Shape
    {
        public Square (double width)
            : base(width, width)
        {

        }

        public override double CalculateSurface()
        {
            return this.Width * this.Width;
        }
    }
}

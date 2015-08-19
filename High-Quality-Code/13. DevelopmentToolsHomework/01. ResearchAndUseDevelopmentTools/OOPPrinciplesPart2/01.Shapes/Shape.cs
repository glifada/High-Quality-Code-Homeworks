using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width 
        {
            get { return this.width; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The width can not be negative value!");
                }
                this.width = value;
            }
        }
        public double Height 
        {
            get { return this.height; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The height can not be negative value!");
                }
                this.height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}

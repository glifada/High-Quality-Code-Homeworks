//Refactor the following code to use proper variable naming and simplified expressions:

using System;

namespace _01.ClassSizeInC
{
    public class Size
    {
        public double width, hight;
        public Size(double width, double hight)
        {
            this.width = width;
            this.hight = hight;
        }

        public static Size GetRotatedSize(Size figure, double angleOfRotation)
        {
            double rotatedWidth = 0;
            rotatedWidth = Math.Abs(Math.Cos(angleOfRotation)) * figure.width + Math.Abs(Math.Sin(angleOfRotation)) * figure.hight;

            double rotatedHight = 0;
            rotatedHight = Math.Abs(Math.Sin(angleOfRotation)) * figure.width + Math.Abs(Math.Cos(angleOfRotation)) * figure.hight;

            Size rotatedSize = new Size(rotatedWidth, rotatedHight);

            return rotatedSize;
        }
    }

}

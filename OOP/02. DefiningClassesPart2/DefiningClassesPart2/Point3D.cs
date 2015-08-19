using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public struct Point3D
    {
        private double x;
        private double y;
        private double z;

        // Static read-only field
        private static readonly Point3D o;
        
        static Point3D()
        {
            Point3D.o = new Point3D(0, 0, 0);
        }

        public Point3D(double x, double y, double z)
            : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        // Static property to return the point O
        public static Point3D O
        {
            get { return Point3D.o; }
        }

        // ToString()
        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
        }
    }
}

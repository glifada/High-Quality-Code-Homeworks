using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    // Static class
    public static class Distance
    {
        public static double CalculateDistance(Point3D p1, Point3D p2)
        {
            // 3 dimensional distance equation
            double distance = Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) +
                                        (p2.Y - p1.Y) * (p2.Y - p1.Y) +
                                        (p2.Z - p1.Z) * (p2.Z - p1.Z));
            return distance;
        }
    }
}

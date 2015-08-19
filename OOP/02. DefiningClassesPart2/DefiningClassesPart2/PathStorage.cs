using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DefiningClassesPart2
{
    static class PathStorage
    {
        // Static method to save path to a text file
        public static void SavePath(Path points)
        {
            using (StreamWriter writer = new StreamWriter("outputPath.txt"))
            {
                for (int i = 0; i < points.Points.Count; i++)
                {
                    writer.WriteLine("Point {0}", points.Points[i]);
                }
            }
        }

        // Static method to load path from a text file
        public static void LoadPath()
        {
            Path points = new Path();
            using (StreamReader reader = new StreamReader("inputPath.txt"))
            {
                int index = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    Point3D point = GetCoordinates(line);
                    points.Points.Add(point);
                    Console.WriteLine(points.Points[index]);
                    line = reader.ReadLine();
                    index++;
                }
            }
        }

        // Get point coordinates
        public static Point3D GetCoordinates(string text)
        {
            int indexOpenBracket = text.IndexOf('(');
            int indexCloseBracket = text.IndexOf(')');
            string coord = text.Substring(indexOpenBracket + 1, indexCloseBracket - indexOpenBracket - 1);
            int firstIndexComma = coord.IndexOf(',');
            double xCoord = double.Parse(coord.Substring(0, firstIndexComma));
            int secondIndexComma = coord.IndexOf(',', firstIndexComma + 1);
            double yCoord = double.Parse((coord.Substring(firstIndexComma + 1, secondIndexComma - firstIndexComma - 1)).Trim());
            double zCoord = double.Parse((coord.Substring(secondIndexComma + 1)).Trim());
            Point3D point = new Point3D(xCoord, yCoord, zCoord);
            return point;
        }
    }
}

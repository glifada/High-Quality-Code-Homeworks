using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class DefiningClassesPart2
    {
        static void Main()
        {
            // Test Path
            Path points = new Path();
            points.AddPoint(new Point3D(1, 2, 3));
            points.AddPoint(new Point3D(5, 2, 3));
            points.AddPoint(new Point3D(6, 3, 3));

            // Test PathStorage
            PathStorage.SavePath(points);
            PathStorage.LoadPath();

            // Test distance
            Console.WriteLine("Distance: {0}", Distance.CalculateDistance(new Point3D(1, 2, 3), new Point3D(5, 2, 3)));

            // Test Matrix operators
            Matrix<int> matrix1 = new Matrix<int>(3, 2);
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 3;
            matrix1[1, 0] = 1;
            matrix1[1, 1] = 0;
            matrix1[2, 0] = 1;
            matrix1[2, 1] = 2;
            Matrix<int> matrix2 = new Matrix<int>(3, 2);
            matrix2[0, 0] = 0;
            matrix2[0, 1] = 0;
            matrix2[1, 0] = 7;
            matrix2[1, 1] = 5;
            matrix2[2, 0] = 2;
            matrix2[2, 1] = 1;

            // Test +
            Console.WriteLine("The sum is");
            Console.WriteLine(matrix1 + matrix2);

            // Test -
            Console.WriteLine("The subtraction is");
            Console.WriteLine(matrix1 - matrix2);

            // Test *
            Matrix<int> matrix3 = new Matrix<int>(2, 3);
            matrix3[0, 0] = 1;
            matrix3[0, 1] = 2;
            matrix3[0, 2] = 3;
            matrix3[1, 0] = 4;
            matrix3[1, 1] = 5;
            matrix3[1, 2] = 6;
            Matrix<int> matrix4 = new Matrix<int>(3, 2);
            matrix4[0, 0] = 7;
            matrix4[0, 1] = 8;
            matrix4[1, 0] = 9;
            matrix4[1, 1] = 10;
            matrix4[2, 0] = 11;
            matrix4[2, 1] = 12;
            Console.WriteLine("The multiplication is");
            Console.WriteLine(matrix3 * matrix4);

            // Test True
            if (matrix1)
            {
                Console.WriteLine("The matrix has not zero element!");
            }
            else
            {
                Console.WriteLine("The matrix has zero element!");
            }

            if (matrix4)
            {
                Console.WriteLine("The matrix has not zero element!");
            }
            else
            {
                Console.WriteLine("The matrix has zero element!");
            }

            // Test Version attribute
            Console.WriteLine();
            VersionClass.TestVersion();
        }
    }
}

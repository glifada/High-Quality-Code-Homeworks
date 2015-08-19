using System;

namespace Methods
{
    class Methods
    {
        static long CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new System.ArgumentException("Parameter cannot be negative!");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new System.ArgumentException("The sides cannot form triangle!");
            }

            double s = (a + b + c) / 2;
            long area = (long)Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        static string NumberToDigit(int number)
        {
            if (number < 0 || 9 < number)
            {
                throw new System.ArgumentException("Invalid digit!");
            }

            string result = "";
            switch (number)
            {
                case 0: result = "zero"; break;
                case 1: result = "one"; break;
                case 2: result = "two"; break;
                case 3: result = "three"; break;
                case 4: result = "four"; break;
                case 5: result = "five"; break;
                case 6: result = "six"; break;
                case 7: result = "seven"; break;
                case 8: result = "eight"; break;
                case 9: result = "nine"; break;
            }
            return result;
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new System.ArgumentNullException("No parameters!");
            }

            int max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }
            return max;
        }

        static void PrintAsNumber(object number, string format)
        {
            if (number == null)
            {
                throw new System.ArgumentNullException("Not entered number!");
            }

            if (format == null)
            {
                throw new System.ArgumentNullException("Not entered format!");
            }

            if (format != "f" && format != "%" && format != "r")
            {
                throw new System.ArgumentException("Format is not correct!");
            }

            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }

            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }

            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }


        static long CalcDistance(double x1, double x2, double y1, double y2, 
            out bool isVertical, out bool isHorizontal)
        {
            isVertical = (x1 == x2);
            isHorizontal = (y1 == y2);

            long distance = (long)Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToDigit(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5, out vertical, out horizontal));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}

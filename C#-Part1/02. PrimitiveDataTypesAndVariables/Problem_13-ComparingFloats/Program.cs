using System;
class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Please enter a real number a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter a real number b:");
        double b = Convert.ToDouble(Console.ReadLine());
        bool isEqual = (Math.Abs(a - b)) < 0.000001;
        if (isEqual == true)
        {
            Console.WriteLine("The compared numbers a={0} and b={1} are equal.", a, b);
        }
        else
            Console.WriteLine("The compared numbers a={0} and b={1} are not equal.", a, b);
    }
}

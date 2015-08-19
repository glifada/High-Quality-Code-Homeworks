using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Please enter the weight of a man on the Earth in kg:");
        float weightEarth = Single.Parse(Console.ReadLine());
        float weightMoon = (float)Math.Round((weightEarth * 0.17),3);
        Console.WriteLine("The weight on the Earth is {0} kg and the weight on the Moon is {1} kg.", weightEarth, weightMoon);
    }
}

using System;
using System.Linq;

class StringLength
{
    static void Main()
    {
        Console.Write("Please enter a string of maximum 20 characters: ");
        string str = Console.ReadLine();
        if (str.Length < 20)
        {

            string fillString = new string('*', 20 - str.Length);
            str += fillString;
            Console.WriteLine("The ful string is {0}", str);
        }
        else
        {
            Console.WriteLine("The entered string is more than 20 characters!");
        }
    }
}

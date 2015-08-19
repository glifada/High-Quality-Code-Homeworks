using System;

class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object greet = hello + " " + world;
        string greeting = (string) greet;
        Console.WriteLine(greeting + "!");
    }
}
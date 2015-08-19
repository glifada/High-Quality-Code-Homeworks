using System;

class NullValuaesAritmethic
{
    static void Main()
    {
        int? intNull = null;
        double? doubleNull = null;
        Console.WriteLine("This is the integer with Null value {0}. \nThis is the real number with Null value {1}.", intNull, doubleNull);
        intNull = 123456789;
        doubleNull = 5232189.78342;
        Console.WriteLine("This is the integer with a value {0}. \nThis is the real number with a value {1}.", intNull, doubleNull);
    }
}

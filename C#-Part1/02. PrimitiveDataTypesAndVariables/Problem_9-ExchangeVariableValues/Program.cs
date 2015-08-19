using System;

class ExchangeVariableValues
{
    static void Main()
    {
        byte a = 5;
        byte b = 10;
        Console.WriteLine("The values of variables before exchange are a={0} and b={1}.", a, b);
        byte c = a;
        a = b;
        b = c;
        Console.WriteLine("The values of variables after exchange are a={0} and b={1}.", a, b);
    }
}

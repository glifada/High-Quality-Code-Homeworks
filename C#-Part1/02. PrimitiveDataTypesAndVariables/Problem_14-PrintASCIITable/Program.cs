using System;

class PrintASCIITable
{
    static void Main()
    {
        for (int i = 1; i <= 255; i++)
        {
            Console.WriteLine((char)i);
        }
    }
}

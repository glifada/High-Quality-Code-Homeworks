using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        string choise = Console.ReadLine();
        while ((choise != "1") && (choise != "2") && (choise != "3"))
        {
            Console.WriteLine("You did not enter the right number!");
            Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
            choise = Console.ReadLine();
        }
        switch (choise)
        {
            case "1":
                Console.Write("Please enter an int number: ");
                int varInt = Int32.Parse(Console.ReadLine());
                varInt = varInt + 1;
                Console.WriteLine(varInt);
                break;
            case "2":
                Console.Write("Please enter a double number: ");
                double varD = Double.Parse(Console.ReadLine());
                varD = varD + 1;
                Console.WriteLine(varD);
                break;
            case "3":
                Console.Write("Please enter a string: ");
                string varStr = Console.ReadLine();
                varStr = varStr + "*";
                Console.WriteLine(varStr);
                break;
            default:
                Console.WriteLine("You did not enter the right type!");
                break;
        }
    }
}

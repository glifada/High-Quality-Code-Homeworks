using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.Write("Please enter a valid card sign: ");
        string cardSign = Console.ReadLine();
        if ((cardSign == "2") || (cardSign == "3") || (cardSign == "4") || (cardSign == "5") || (cardSign == "6") || 
            (cardSign == "7") || (cardSign == "8") || (cardSign == "9") || (cardSign == "10") || (cardSign == "J") || 
            (cardSign == "Q") || (cardSign == "K") || (cardSign == "A"))
        {
            Console.WriteLine("Yes, {0} is a valid card sign.", cardSign);
        }
        else
        {
            Console.WriteLine("No, {0} is not a valid card sign.", cardSign);
        }
    }
}

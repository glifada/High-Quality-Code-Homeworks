using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string lastName = "Ivanov";
        decimal balance = 35672546.87M;
        string bankName = "First Investment Bank";
        string iban = "BG80 BNBG 9661 1020 3456 78";
        ulong cardNum1 = 4485171582963422;
        ulong cardNum2 = 4532192973122454;
        ulong cardNum3 = 4485846991038581;
        Console.WriteLine("Holder Data: \nName: {0} {1} {2} \nAvailable amout: {3} \nBank name: {4} \nIBAN: {5} \nCredit card numbers associated with the account: {6}, {7}, {8}", firstName, middleName, lastName, balance, bankName, iban, cardNum1, cardNum2, cardNum3);
    }
}

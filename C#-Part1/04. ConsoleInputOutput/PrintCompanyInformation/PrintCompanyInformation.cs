using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Please enter the company information!");
        Console.Write("Company name: ");
        string compName = Console.ReadLine();
        Console.Write("Company address: ");
        string compAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phone = Console.ReadLine();
        Console.Write("Fax number: ");
        string fax = Console.ReadLine();
        Console.Write("Web site: ");
        string site = Console.ReadLine();
        Console.Write("Manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Manager age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();
        if (fax.Length < 12)
        {
            fax = "(no fax)";
        }
        Console.WriteLine();
        Console.WriteLine("Company information:");
        Console.WriteLine(compName);
        Console.WriteLine("Address: {0}", compAddress);
        Console.WriteLine("Tel. {0}", phone);
        Console.WriteLine("Fax: {0}", fax);
        Console.WriteLine("Web site: {0}", site);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, managerPhone);
    }
}

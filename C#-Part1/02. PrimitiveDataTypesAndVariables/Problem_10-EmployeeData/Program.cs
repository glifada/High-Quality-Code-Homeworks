using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Ivanov";
        byte age = 30;
        char gender = 'm';
        ulong id = 8306112507;
        uint empNumber = 27560000;
        Console.WriteLine("Employee Data: \nName: {0} {1} \nAge: {2} \nGender: {3} \nID number: {4} \nEmployee number: {5}", firstName, lastName, age, gender, id, empNumber);
    }
}

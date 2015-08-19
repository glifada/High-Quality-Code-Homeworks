using System;

class NumbersAsWords
{
    static void Main()
    {
        Console.Write("Please enter an integer number in the range [1...999]: ");
        int number = Int32.Parse(Console.ReadLine());
        while ((number < 0) && (number > 999))
        {
            Console.Write("The entered number is not in the range!");            
            Console.Write("Please enter an integer number in the range [1...999]: ");
            number = Int32.Parse(Console.ReadLine());
        }

        int hundreds = number / 100;
        int tens = (number / 10)  % 10;
        int units = number % 10;
        int special = 10 + units;
        string specialText = "";
        string hundredsText = "";
        string tensText = "";
        string unitsText;

        switch (units)
        {
            case 1: unitsText = "one"; break;
            case 2: unitsText = "two"; break;
            case 3: unitsText = "three"; break;
            case 4: unitsText = "four"; break;
            case 5: unitsText = "five"; break;
            case 6: unitsText = "six"; break;
            case 7: unitsText = "seven"; break;
            case 8: unitsText = "eight"; break;
            case 9: unitsText = "nine"; break;
            default: unitsText = ""; break;
        }
        switch (special)
        {
            case 11: specialText = "eleven"; break;
            case 12: specialText = "twelve"; break;
            case 13: specialText = "thirteen"; break;
            case 14: specialText = "fourteen"; break;
            case 15: specialText = "fifteen"; break;
            case 16: specialText = "sixteen"; break;
            case 17: specialText = "seventeen"; break;
            case 18: specialText = "eighteen"; break;
            case 19: specialText = "nineteen"; break;
        }
        switch (tens)
        {
            case 1: tensText = "ten"; break;
            case 2: tensText = "twenty "; break;
            case 3: tensText = "thirty "; break;
            case 4: tensText = "fourty "; break;
            case 5: tensText = "fifty "; break;
            case 6: tensText = "sixty "; break;
            case 7: tensText = "seventy "; break;
            case 8: tensText = "eighty "; break;
            case 9: tensText = "ninety "; break;
            case 0: tensText = ""; break;
        }
        switch (hundreds)
        {
            case 1: hundredsText = "one hundred "; break;
            case 2: hundredsText = "two hundred "; break;
            case 3: hundredsText = "three hundred "; break;
            case 4: hundredsText = "four hundred "; break;
            case 5: hundredsText = "five hundred "; break;
            case 6: hundredsText = "six hundred "; break;
            case 7: hundredsText = "seven hundred "; break;
            case 8: hundredsText = "eight hundred "; break;
            case 9: hundredsText = "nine hundred "; break;
            case 0: hundredsText = ""; break;
        }
        if (number == 0)
        {
            Console.WriteLine("Zero");
        }
        else if (number < 10)
        {
            Console.WriteLine(UppercaseFirst(unitsText));
        }
        else if (number < 20)
        {
            if (number == 10)
            {
                Console.WriteLine(UppercaseFirst(tensText));
            }
            else
            {
                Console.WriteLine(UppercaseFirst(specialText));
            }
        }
        else if (number < 100)
        {
            Console.WriteLine(UppercaseFirst(tensText + unitsText));
        }
        else if (number % 100 == 0)
        {
            Console.WriteLine(UppercaseFirst(hundredsText));
        }
        else if ((number % 100 > 10) && (number % 100 < 20))
        {
            Console.WriteLine(UppercaseFirst(hundredsText + "and " + specialText));
        }
        else
        {
            Console.WriteLine(UppercaseFirst(hundredsText + "and " + tensText + unitsText));
        }

    }

    static string UppercaseFirst(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }
        return char.ToUpper(s[0]) + s.Substring(1);
    }
}
       
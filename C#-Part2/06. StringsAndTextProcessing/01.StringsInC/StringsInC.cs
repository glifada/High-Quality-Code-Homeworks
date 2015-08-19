using System;

class StringsInC
{
    static void Main()
    {
        Console.WriteLine("A string is an object of type String whose value is text. Internally, the text is stored as a sequential read-only collection of Char objects. There is no null-terminating character at the end of a C# string; therefore a C# string can contain any number of embedded null characters ('\0'). The Length property of a string represents the number of Char objects it contains, not the number of Unicode characters. To access the individual Unicode code points in a string, use the StringInfo object.");
        Console.WriteLine();
        Console.WriteLine("In C#, the string keyword is an alias for String. Therefore, String and string are equivalent, and you can use whichever naming convention you prefer. The String class provides many methods for safely creating, manipulating, and comparing strings. In addition, the C# language overloads some operators to simplify common string operations.");
        Console.WriteLine();
        Console.WriteLine("Metods of the String class:");
        Console.WriteLine("Insert - Returns a new string in which a specified string is inserted at a specified index position in this instance.");
        Console.WriteLine("IndexOf(Char) - Reports the zero-based index of the first occurrence of the specified Unicode character in this string.");
        Console.WriteLine("LastIndexOf(Char) - Reports the zero-based index position of the last occurrence of a specified Unicode character within this instance.");
        Console.WriteLine("Remove(Int32) - Returns a new string in which all the characters in the current instance, beginning at a specified position and continuing through the last position, have been deleted.");
        Console.WriteLine("Replace(Char, Char) - Returns a new string in which all occurrences of a specified Unicode character in this instance are replaced with another specified Unicode character.");
        Console.WriteLine("Split(Char[]) - Returns a string array that contains the substrings in this instance that are delimited by elements of a specified Unicode character array.");
        Console.WriteLine("Substring(Int32) - Retrieves a substring from this instance. The substring starts at a specified character position and continues to the end of the string.");
        Console.WriteLine("ToLower() - Returns a copy of this string converted to lowercase.");
        Console.WriteLine("ToUpper() - Returns a copy of this string converted to uppercase.");
        Console.WriteLine("Trim() - Removes all leading and trailing white-space characters from the current String object.");
    }
}

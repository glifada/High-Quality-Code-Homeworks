using System;
using System.IO;
using System.Text;
using System.Security;

class ReadFileContents
{
    static void Main()
    {
        Console.Write("Please enter the file path: ");
        string path = Console.ReadLine();

        try
        {
            string text = File.ReadAllText(path);
            Console.WriteLine();
            Console.WriteLine(text);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Path is null.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Path is a zero-length string, contains only white space, or contains one or more invalid characters as defined by InvalidPathChars.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in path was not found.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You have not access to this file.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in an invalid format.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("The caller does not have the required permission.");
        }
    }
}

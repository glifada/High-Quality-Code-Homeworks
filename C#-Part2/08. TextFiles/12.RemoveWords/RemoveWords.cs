using System;
using System.IO;
using System.Security;

class RemoveWords
{
    static void Main()
    {
        string newText = string.Empty;
        try
        {
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                string text = reader.ReadToEnd();

                using (StreamReader wordsReader = new StreamReader("words.txt"))
                {
                    string[] words = wordsReader.ReadToEnd().Split(' ');
                    newText = text;
                    for (int i = 0; i < words.Length; i++)
                    {
                        newText = newText.Replace(" " + words[i] + " ", " ");
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter("text.txt"))
            {
                writer.WriteLine(newText);
            }
        }
        // StreamReader Exceptions
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Argument is null!", ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Argument is an empty string!", ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("The file cannot be found!", ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("The specified path is invalid!", ex.Message);
        }
        // ReadToEnd Exceptions
        catch (OutOfMemoryException ex)
        {
            Console.WriteLine("There is insufficient memory to allocate a buffer for the returned string!", ex.Message);
        }
        // StreamWriter Exceptions
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine("Access is denied!", ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length!", ex.Message);
        }
        catch (SecurityException ex)
        {
            Console.WriteLine("The caller does not have the required permission!", ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine("An I/O error occurs!", ex.Message);
        }
    }
}

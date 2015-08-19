using System;
using System.IO;
using System.Security;
using System.Linq;

class CountWords
{
    static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader("test.txt"))
            {
                string text = reader.ReadToEnd();
                text = text.ToLower();

                using (StreamReader wordsReader = new StreamReader("words.txt"))
                {
                    string[] words = wordsReader.ReadToEnd().Split(' ');
                    int[] counter = new int[words.Length];
                    using (StreamWriter writer = new StreamWriter("result.txt"))
                    {
                        for (int i = 0; i < counter.Length; i++)
                        {
                            int index = 0;
                            while (index != -1)
                            {
                                index = text.IndexOf(words[i], index + 1);
                                counter[i]++;
                            }
                        }
                        for (int i = 0; i < counter.Length; i++)
                        {
                            int m = counter.Max();
                            int p = Array.IndexOf(counter, m);
                            writer.WriteLine("The word \"{0}\" is found {1} times.", words[p], counter[p] - 1);
                            counter[p] = 0;
                        }
                    }
                }
            }
        }
        // IndexOf Exceptions
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("StartIndex is less than 0 (zero) or greater than the length of this string!", ex.Message);
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
        catch (ObjectDisposedException ex)
        {
            Console.WriteLine("The TextWriter is closed!", ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Format is not a valid composite format string!", ex.Message);
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


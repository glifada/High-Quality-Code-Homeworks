using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        Console.Write("Please enter the path: ");
        string path = Console.ReadLine();
        string fileName = "ninja.gif";
        WebClient myWebClient = new WebClient();

        try
        {            
            myWebClient.DownloadFile(path, fileName);
            Console.WriteLine(@"The file is downloaded in Project\bin\Debug!");
        }
        catch (WebException)
        {
            Console.WriteLine("The adress is invalid.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The address parameter is null.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The method has been called simultaneously on multiple threads.");
        }
        finally
        {
            myWebClient.Dispose();
        }
    }
}

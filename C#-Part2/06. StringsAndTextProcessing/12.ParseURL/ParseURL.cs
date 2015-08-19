using System;

class ParseURL
{
    static void Main()
    {
        Console.Write("Please enter the URL: ");
        string url = Console.ReadLine();
        string protocol = url.Substring(0, url.IndexOf(':'));
        int startIndex = url.IndexOf('/') + 2;
        int endIndex = url.IndexOf('/', startIndex + 1);
        string server = url.Substring(startIndex, endIndex - startIndex);
        string resource = url.Substring(endIndex, url.Length - endIndex);
        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }
}
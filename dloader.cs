using System;
using System.Net;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: dloader.exe [URL] [Destination Path]");
            return;
        }

        string url = args[0];
        string destinationPath = args[1];

        try
        {
            using (WebClient client = new WebClient())
            {
                Console.WriteLine($"Downloading file from [ {url} ]");
                client.DownloadFile(url, destinationPath);
                Console.WriteLine($"File saved to [ {destinationPath} ]");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

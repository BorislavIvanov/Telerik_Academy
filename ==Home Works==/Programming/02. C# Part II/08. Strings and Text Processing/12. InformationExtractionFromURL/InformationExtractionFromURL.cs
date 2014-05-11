//12. Write a program that parses an URL address given in the format:
//    and extracts from it the [protocol], [server] and [resource] elements.
//    For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//    [protocol] = "http"
//    [server] = "www.devbg.org"
//    [resource] = "/forum/index.php"

using System;
using System.Text.RegularExpressions;

class InformationExtractionFromURL
{
    static void Main()
    {
        Console.WriteLine("Please enter The URL address: ");
        string urlInput = Console.ReadLine();

        var fragments = Regex.Match(urlInput, "(.*?)://(.*?)(/.*)").Groups;

        Console.WriteLine();
        Console.WriteLine("Result: ");
        Console.WriteLine("[protocol] = {0}", fragments[1]);
        Console.WriteLine("[server] = {0}", fragments[2]);
        Console.WriteLine("[resource] = {0}", fragments[3]);
        Console.WriteLine();
    }
}

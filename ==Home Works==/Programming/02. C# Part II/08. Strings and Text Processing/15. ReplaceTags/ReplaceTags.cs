//15. Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a>
//    with corresponding tags [URL=…]…/URL]. 
using System;
using System.Text.RegularExpressions;

class ReplaceTags
{
    static void Main()
    {
        Console.WriteLine("Please Enter some Text: ");
        string inputText = Console.ReadLine();

        inputText = Regex.Replace(inputText, "<a href=\"", "[URL=");
        inputText = Regex.Replace(inputText, "\">", "]");
        inputText = Regex.Replace(inputText, "</a>", "[URL]");

        Console.WriteLine();
        Console.WriteLine("Result: ");
        Console.WriteLine(inputText);
        Console.WriteLine();
    }
}


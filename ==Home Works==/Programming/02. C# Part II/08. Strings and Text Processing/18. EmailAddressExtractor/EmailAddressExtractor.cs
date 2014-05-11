//18. Write a program for extracting all email addresses from given text.
//    All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.IO;
using System.Text.RegularExpressions;

class EmailAddressExtractor
{
    static void Main()
    {
        StreamReader inputTextReader = new StreamReader(@"..\..\InputText.txt");
        using (inputTextReader)
        {
            string theInputText = inputTextReader.ReadToEnd();
            string[] splitedInputText = theInputText.Split(' ');
            string pattern = @"[\w.]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}";

            Console.WriteLine("Result: ");
            for (int i = 0; i < splitedInputText.Length; i++)
            {
                if (Regex.IsMatch(splitedInputText[i], pattern))
                {
                    Console.WriteLine("{0} - Valid Email", splitedInputText[i]);
                }
            }
            Console.WriteLine();
        }
    }
}


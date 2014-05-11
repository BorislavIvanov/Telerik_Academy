//19. Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//    Display them in the standard date format for Canada.

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

class DateExtractor
{
    static void Main()
    {
        StreamReader inputTextReader = new StreamReader(@"..\..\InputText.txt");
        using (inputTextReader)
        {
            string theInputText = inputTextReader.ReadToEnd();
            string[] splitedInputText = theInputText.Split(' ');
            string pattern = @"[0-3]?[0-9]\.[0-1]?[0-9]\.[0-9]{2,4}";

            Console.WriteLine("Result: ");
            for (int i = 0; i < splitedInputText.Length; i++)
            {
                if (Regex.IsMatch(splitedInputText[i], pattern))
                {
                    DateTime dateTime = DateTime.ParseExact(splitedInputText[i], "dd.MM.yyyy", new CultureInfo("en-Ca"));
                    Console.WriteLine("{0:d/MM/yyyy}", dateTime);
                }
            }
            Console.WriteLine();
        }
    }
}


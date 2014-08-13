//05. You are given a text. Write a program that changes the text in all regions surrounded by the tags
//    <upcase> and </upcase> to uppercase. The tags cannot be nested.

using System;
using System.Text;
using System.Text.RegularExpressions;

class UpcaseTextChange
{
    static void Main()
    {
        StringBuilder remakedText = new StringBuilder();

        Console.Write("Type a text: ");
        string inputText = Console.ReadLine();

        remakedText.Append(inputText);

        int firstPosition = inputText.IndexOf("<upcase>");
        int secondPosition = inputText.IndexOf("</upcase>");

        int textLenght = (secondPosition - (firstPosition + 8));
        string textForChange = inputText.Substring((firstPosition + 8), textLenght);
        string textForChangeToUpper = textForChange.ToUpper();


        while (true)
        {
            remakedText.Replace(textForChange, textForChangeToUpper);
            remakedText.Remove(secondPosition, 9);
            remakedText.Remove(firstPosition, 8);

            inputText = remakedText.ToString();

            firstPosition = inputText.IndexOf("<upcase>");
            secondPosition = inputText.IndexOf("</upcase>");

            if (firstPosition == -1)
            {
                break;
            }

            textLenght = (secondPosition - (firstPosition + 8));
            textForChange = inputText.Substring((firstPosition + 8), textLenght);
            textForChangeToUpper = textForChange.ToUpper();
        }
        Console.WriteLine();
        Console.WriteLine("Result: {0}", remakedText.ToString());
        Console.WriteLine();
    }
}


//06. Write a program that reads from the console a string of maximum 20 characters.
//    If the length of the string is less than 20, the rest of the characters should be filled with '*'.
//    Print the result string into the console.

using System;

class FillWithStars
{
    static void Main()
    {
        Console.Write("Enter some Text with max 20 characters: ");
        string userInput = Console.ReadLine();
        Console.WriteLine();

        if (userInput.Length > 20)
        {
            Console.WriteLine("Error! The Text is with more than 20 characters.");
            Console.WriteLine();
        }
        else if (userInput.Length == 20)
        {
            Console.Write("Result: ");
            Console.WriteLine(userInput);
            Console.WriteLine();
        }
        else
        {
            Console.Write("Result: ");
            string remakedUserInput = userInput.PadRight(20, '*');
            Console.WriteLine(remakedUserInput);
            Console.WriteLine();
        }
    }
}


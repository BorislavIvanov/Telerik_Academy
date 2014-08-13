//02. Write a program that reads a string, reverses it and prints the result at the console.
//    Example: "sample" - "elpmas".

using System;
using System.Text;

class StringReverse
{
    static void Main()
    {
        Console.Write("Please Enter String for Reverse: ");
        string userInput = Console.ReadLine();

        char[] inputString = new char[userInput.Length];

        for (int i = 0; i < userInput.Length; i++)
        {
            inputString[i] = userInput[(userInput.Length - 1) - i];
        }

        Console.WriteLine();
        Console.Write("Result: ");

        foreach (char character in inputString)
        {
            Console.Write(character);
        }

        Console.WriteLine("\n");
    }
}

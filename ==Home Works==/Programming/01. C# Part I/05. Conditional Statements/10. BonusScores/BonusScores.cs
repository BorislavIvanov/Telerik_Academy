//Write a program that applies bonus scores to given scores in the range [1..9]. The program reads a digit as an input.
//If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100;
//if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value is not a digit, the program must report an error.
//Use a switch statement and at the end print the calculated new value in the console.

using System;

class BonusScores
{
    static void Main()
    {
        Console.Title = "Bonus Scores";

        Console.Write("Enter Number (Score) from 1 to 9: ");
        string number = Console.ReadLine();

        Console.WriteLine(new string ('-', 35));

        switch (number)
        {
            case "1":
            case "2":
            case "3":
                {
                    Console.Write("\nThe Multiplier for {0} is 10 so {0}*10 is: ", number);
                    Console.WriteLine(byte.Parse(number) * 10);
                    break;
                }
            case "4":
            case "5":
            case "6":
                {
                    Console.Write("\nThe Multiplier for {0} is 100 so {0}*100 is: ", number);
                    Console.WriteLine(byte.Parse(number) * 100);
                    break;
                }
            case "7":
            case "8":
            case "9":
                {
                    Console.Write("\nThe Multiplier for {0} is 1000 so {0}*1000 is: ", number);
                    Console.WriteLine(byte.Parse(number) * 1000);
                    break;
                }
            default:
                Console.WriteLine("\nError! You must enter number from 1 to 9 not somenting else :)\n");
                break;
        }
        Console.WriteLine();
    }
}


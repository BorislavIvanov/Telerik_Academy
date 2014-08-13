//Write a program that, depending on the user's choice inputs int, double or string variable.
//If the variable is integer or double, increases it with 1.
//If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output.
//Use switch statement.

using System;

class TheUserChoice
{
    static void Main()
    {
        Console.Title = "The User Choice";

        Console.WriteLine("What you will use?");
        Console.Write("Enter 1 - for \"int\", 2 - for \"double\", 3 - for \"string\": ");
        
        int theChoice = int.Parse(Console.ReadLine());

        Console.WriteLine(new string ('-', 58));

        switch (theChoice)
        {
            case 1:
                {
                    Console.Write("Enter one Integer number: ");
                    int input = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nYour number + 1 is: " + (input + 1));
                    break;
                }

            case 2:
                {
                    Console.Write("Enter one \"double\" number: ");// If you have problem try with "," :)
                    double input = double.Parse(Console.ReadLine());
                    Console.WriteLine("\nYour number + 1 is: " + (input + 1));
                    break;
                }

            case 3:
                {
                    Console.Write("Enter something: ");
                    string input = (Console.ReadLine());
                    Console.WriteLine("\nYour string + * is: " + input + "*");
                    break;
                }

        }

        Console.WriteLine(new string ('-', 5));
    }
}

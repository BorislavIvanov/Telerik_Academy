//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

using System;

class TwoIntegerVariables
{
    static void Main()
    {
        Console.Title = "Two Integer Variables";

        Console.Write("Please type the First Integer Variable:  ");
        int firstVariable = int.Parse(Console.ReadLine());

        Console.Write("Please type the Second Integer Variable: ");
        int secondVariable = int.Parse(Console.ReadLine());

        Console.WriteLine(new string ('~', 40));

        int X;

        if (firstVariable > secondVariable)
        {
            X = firstVariable;
            firstVariable = secondVariable;
            secondVariable = X;

            Console.WriteLine("First Variable > Second Variable - so they must be exchanged: ");
            Console.WriteLine("\nFirst Variable now is {0}\nSecond Variable now is {1}", firstVariable, secondVariable);
        }
        else
        {
            Console.WriteLine("First Variable < Second Variable so everything is OK");
        }
    }
}


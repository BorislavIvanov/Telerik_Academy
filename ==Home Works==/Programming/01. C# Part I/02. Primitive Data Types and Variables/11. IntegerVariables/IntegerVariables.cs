//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class IntegerVariables
{
    static void Main()
    {
        Console.Title = "IntegerVariables";

        byte a;
        byte b;
        byte x;

        a = 5;
        b = 10;

        Console.WriteLine("Before exchange a = {0} and b = {1}", a, b);

        x = a;
        a = b;
        b = x;

        Console.WriteLine("After exchange a = {0} and b = {1}", a, b);


    }
}


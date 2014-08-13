//01.Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
//Write a program to test this method.

using System;

class Hello
{
    static void PrintName(string name)
    {
        Console.WriteLine("Hello " + name + "! :)");
    }
    static void Main()
    {
        Console.Write("Please Enter your First name: ");
        string name = Console.ReadLine();

        Console.WriteLine();

        PrintName(name);

        Console.WriteLine();
    }
}


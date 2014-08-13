//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class GreaterOfTwoNumbers
{
    static void Main()
    {
        Console.Title = "Greater Of Two Numbers";

        Console.Write("Type First Number:  ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.Write("Type Second Number: ");
        int secondNum = int.Parse(Console.ReadLine());

        Console.WriteLine(new string ('~', 10));

        Console.WriteLine("/_\\ Greater is " + Math.Max(firstNum, secondNum));
        
    }
}


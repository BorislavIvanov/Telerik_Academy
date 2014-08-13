//Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class ThreeIntegerNumbers
{
    static void Main()
    {
        Console.Title = "Three Integer Numbers";

        Console.Write("Type the first number:  ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Type the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Type the third number:  ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(new string ('-', 15));

        Console.Write("The sum of First + Second + Third numbers is: ");
        Console.WriteLine(firstNumber + secondNumber + thirdNumber);
    }
}


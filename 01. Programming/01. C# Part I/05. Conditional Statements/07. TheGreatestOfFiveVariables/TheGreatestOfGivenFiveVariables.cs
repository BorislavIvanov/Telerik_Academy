//Write a program that finds the greatest of given 5 variables.

using System;

class TheGreatestOfGivenFiveVariables
{
    static void Main()
    {
        Console.Title = "The Greatest Of Given Five Variables";

        Console.Write("Type the First number:  ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Type the Second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Type the Third number:  ");
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.Write("Type the Fourth number: ");
        double fourthNumber = double.Parse(Console.ReadLine());
        Console.Write("Type the Fifth number:  ");
        double fifthNumber = double.Parse(Console.ReadLine());

        Console.WriteLine(new string ('-', 24));

        double biggestNumber = firstNumber;
        if (biggestNumber < secondNumber)
        {
            biggestNumber = secondNumber;
        }
        if (biggestNumber < thirdNumber)
        {
            biggestNumber = thirdNumber;
        }
        if (biggestNumber < fourthNumber)
        {
            biggestNumber = fourthNumber;
        }
        if (biggestNumber < fifthNumber)
        {
            biggestNumber = fifthNumber;
        }
        Console.WriteLine("The Greatest Number is: {0}", biggestNumber);
    }
}


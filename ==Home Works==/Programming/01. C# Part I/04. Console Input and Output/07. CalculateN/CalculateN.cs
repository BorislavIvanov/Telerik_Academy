//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class CalculateN
{
    static void Main()
    {
        Console.Write("Enter how many numbers You will enter: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string ('~', 38));

        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter a number");
            int value = int.Parse(Console.ReadLine());
            sum += value;
        }
        Console.WriteLine(new string('~', 27));

        Console.WriteLine("The sum of the {0} numbers is {1}", n, sum);
    }
}


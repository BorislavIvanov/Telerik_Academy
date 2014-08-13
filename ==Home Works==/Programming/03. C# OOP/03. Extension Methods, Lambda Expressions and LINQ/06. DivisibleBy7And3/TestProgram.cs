// 06. Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestProgram
{
    static void Main()
    {
        int[] numbers = { 4, 8, 21, 43, 74, 99, 42, 26, 63 };

        FindNumbersLINQ linqMethod = new FindNumbersLINQ(numbers);
        FindNumbersLambda lambdaMethod = new FindNumbersLambda(numbers);

        Console.WriteLine("LINQ method:");
        linqMethod.LINQPrint();
        Console.WriteLine(new string ('-', 14));
        Console.WriteLine("Lambda method:");
        lambdaMethod.LambdaPrint();
        Console.WriteLine();
    }
}
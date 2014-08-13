//Write a program that calculates the greatest common divisor (GCD) of given two numbers.
//Use the Euclidean algorithm (find it in Internet).

using System;

class GCDofGivenTwoNumbers
{
    static void Main()
    {
        Console.Title = "GCD of Given Two Numbers";

        Console.WriteLine("Enter number A and number B");

        //Input for Number A;
        Console.Write("\nPlease Enter number A: ");
        string inputA = Console.ReadLine();
        double numberA;
        while (!double.TryParse(inputA, out numberA))
        {
            Console.Write("Please Enter Valid A Number: ");
            inputA = Console.ReadLine();
        }

        //Input for Number B;
        Console.Write("\nPlease Enter number B: ");
        string inputB = Console.ReadLine();
        double numberB;
        while (!double.TryParse(inputB, out numberB))
        {
            Console.Write("Please Enter Valid B Number: ");
            inputB = Console.ReadLine();
        }

        if (numberA < numberB)
        {
            double temp = numberA;
            numberA = numberB;
            numberB = temp;
        }

        double result;
        double resultRemainder;

        Console.WriteLine();
        while (true)
        {
            result = numberA / numberB;
            resultRemainder = numberA % numberB;
            if (resultRemainder != 0)
            {
                Console.WriteLine("{0} : {1} = {2} ; reminder = {3}", numberA, numberB, result, resultRemainder);
                numberA = numberB;
                numberB = resultRemainder;
            }
            else
            {
                Console.WriteLine("\nThe Greatest Common Divider is: {0}", numberB);
                break;
            }
        }

        Console.WriteLine("\n");
    }
}


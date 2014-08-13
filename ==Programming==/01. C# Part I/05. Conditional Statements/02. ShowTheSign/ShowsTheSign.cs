//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it.
//Use a sequence of if statements.

using System;

    class ShowsTheSign
    {
        static void Main()
        {
            Console.Title = "Show The Sign";

            Console.Write("Type the First Number:  ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Type the Second Number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Type the Third Number:  ");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(new string ('_', 7));

            if ((firstNumber < 0 && secondNumber < 0 && thirdNumber > 0) ||
                (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0) ||
                (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0))
            {
                Console.WriteLine("The Sign is +");
            }

            else if ((firstNumber < 0 && secondNumber > 0 && thirdNumber > 0) ||
                     (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0) ||
                     (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0))
            {
                Console.WriteLine("The sign is -");
            }

            else if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
            {
                Console.WriteLine("The Sign is +");
            }

            else if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
            {
                Console.WriteLine("The sign is -");
            }

            else if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                Console.WriteLine("One or more than one numbers are 0 so the sum will be 0!!!");
            }
        }
    }


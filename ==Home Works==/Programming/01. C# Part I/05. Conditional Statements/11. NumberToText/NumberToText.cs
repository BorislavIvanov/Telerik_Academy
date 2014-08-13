// Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation.
//Examples:
//0  "Zero"
//273  "Two hundred seventy three"
//400  "Four hundred"
//501  "Five hundred and one"
//711  "Seven hundred and eleven"

using System;

class NumberToText
{
    static void Main()
    {
        string[] numbersToTwenty = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eigth", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty" };
        int number;
        int checkHundreds = 0;
        int checkTens = 0;
        int lastTwoDigits = 0;
        int lastDigit = 0;
        Console.Write("Input an integer number in the range [0...999]:");
        bool check = Int32.TryParse(Console.ReadLine(), out number);

        Console.WriteLine(new string ('-', 47));

        if (check && 0 <= number && number <= 999)
        {
            Console.Write("\nIn English The Number {0} is: ", number);
            if (number == 0)
            {
                Console.WriteLine("zero");
            }
            checkHundreds = number / 100;
            checkTens = (number - checkHundreds * 100) / 10;
            lastTwoDigits = number - checkHundreds * 100;
            lastDigit = number - number / 10 * 10;
            if (checkHundreds > 0)
            {
                Console.Write("{0} hundred", numbersToTwenty[checkHundreds - 1]);
                if (checkTens >= 0 && checkTens < 2)
                {
                    Console.Write(" and ");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            switch (checkTens)
            {
                case 2:
                    {
                        Console.Write(numbersToTwenty[19]);
                        break;
                    }
                case 3:
                    {
                        Console.Write("thirty");
                        break;
                    }
                case 4:
                    {
                        Console.Write("forty");
                        break;
                    }
                case 5:
                    {
                        Console.Write("fifty");
                        break;
                    }
                case 6:
                case 7:
                case 8:
                case 9:
                    {
                        Console.Write("{0}ty", numbersToTwenty[checkTens - 1]);
                    }
                    break;
            }
            switch (checkTens)
            {
                case 0:
                case 1:
                    {
                        if (number != 0)
                        {
                            Console.WriteLine(numbersToTwenty[lastTwoDigits - 1]);
                        }
                        break;
                    }
                default:
                    {
                        if (lastDigit != 0)
                        {
                            Console.WriteLine(" {0}", numbersToTwenty[lastDigit - 1]);
                        }
                    }
                    break;
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("The data input is incorrect!");
        }
        Console.WriteLine();
    }
}
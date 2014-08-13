//Write an expression that checks for given integer if
//its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class TheThirdDigitCheck
{
    static void Main()
    {
        Console.Title = "The Third Digit Check";

        Console.Write("Type a number: ");
        int theNum = int.Parse(Console.ReadLine());

        int operationWhitNum = ((theNum / 100) % 10);

        Console.WriteLine(new string ('-', 10));

        bool thirdDigit = (operationWhitNum == 7);
        Console.WriteLine("The third digit is 7: " + thirdDigit);
    }
}


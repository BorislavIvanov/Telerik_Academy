using System;
using System.Collections.Generic;

class TribonacciTriangle
{
    static void Main()
    {
        long firstNum = int.Parse(Console.ReadLine());
        long secondNum = int.Parse(Console.ReadLine());
        long thirdNum = int.Parse(Console.ReadLine());
        long numberOfLines = int.Parse(Console.ReadLine());

        Console.WriteLine(firstNum);
        Console.WriteLine(secondNum + " " + thirdNum);

        int numbersOnLine = 3;

        for (int i = 3; i <= numberOfLines; i++)
        {
            for (int j = 1; j <= numbersOnLine; j++)
            {
                long xNum = firstNum + secondNum + thirdNum;

                if (j < numbersOnLine)
                {
                    Console.Write(xNum + " ");
                }
                else
                {
                    Console.WriteLine(xNum);
                }

                firstNum = secondNum;
                secondNum = thirdNum;
                thirdNum = xNum;
            }

            numbersOnLine++;
        }
    }
}
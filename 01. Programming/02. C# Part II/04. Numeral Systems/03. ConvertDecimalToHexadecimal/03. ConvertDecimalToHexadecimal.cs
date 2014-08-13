//03. Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;

class ConvertDecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter one Positive Decimal Number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        Print(DecimalToHexadecimal(decimalNumber));
    }

    static List<string> DecimalToHexadecimal(int decimalNumber)
    {
        List<string> hexadecimalNumber = new List<string>();

        while (decimalNumber > 0)
        {
            int theNum;
            theNum = decimalNumber % 16;
            decimalNumber = decimalNumber / 16;

            switch (theNum)
            {
                case 10:
                    hexadecimalNumber.Add("A");
                    break;
                case 11:
                    hexadecimalNumber.Add("B");
                    break;
                case 12:
                    hexadecimalNumber.Add("C");
                    break;
                case 13:
                    hexadecimalNumber.Add("D");
                    break;
                case 14:
                    hexadecimalNumber.Add("E");
                    break;
                case 15:
                    hexadecimalNumber.Add("F");
                    break;
                default:
                    hexadecimalNumber.Add(Convert.ToString(theNum));
                    break;
            }
            
        }

        hexadecimalNumber.Reverse();

        return hexadecimalNumber;
    }

    static void Print(List<string> binaryNumber)
    {
        Console.WriteLine();

        Console.Write("Result: ");
        for (int i = 0; i < binaryNumber.Count; i++)
        {
            Console.Write("{0}", binaryNumber[i]);
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}


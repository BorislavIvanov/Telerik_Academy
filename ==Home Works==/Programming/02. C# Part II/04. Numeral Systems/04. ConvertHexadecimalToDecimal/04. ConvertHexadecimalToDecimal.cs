//04. Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;

class ConvertHexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter one Hexadecimal Number (without 0x...): ");
        string hexadecimalNumber = Console.ReadLine();

        int mathPower = hexadecimalNumber.Length - 1;
        int decimalNumber = 0;

        for (int i = 0; i < hexadecimalNumber.Length; i++)
        {
            int digit = 0;
            
            switch (hexadecimalNumber[i])
            {
                case 'A':
                case 'a':
                    digit = 10;
                    break;
                case 'B':
                case 'b':
                    digit = 11;
                    break;
                case 'C':
                case 'c':
                    digit = 12;
                    break;
                case 'D':
                case 'd':
                    digit = 13;
                    break;
                case 'E':
                case 'e':
                    digit = 14;
                    break;
                case 'F':
                case 'f':
                    digit = 15;
                    break;
                default:
                    digit = int.Parse(Convert.ToString(hexadecimalNumber[i]));
                    break;
            }

            decimalNumber += digit * ((int)Math.Pow(16, mathPower));
            mathPower--;
        }
        Console.WriteLine();
        Console.WriteLine("Result: {0}", decimalNumber);
        Console.WriteLine();
    }
}


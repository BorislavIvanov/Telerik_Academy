//06. Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Text;

class ConvertBinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter one Binary Number: ");
        string binaryNumber = Console.ReadLine();

        string simbol;

        List<string> arr = new List<string>();

        if (binaryNumber.Length % 4 == 1)
        {
            binaryNumber = "000" + binaryNumber;
        }
        else if (binaryNumber.Length % 4 == 2)
        {
            binaryNumber = "00" + binaryNumber;
        }
        else if (binaryNumber.Length % 4 == 3)
        {
            binaryNumber = "0" + binaryNumber;
        }

        int i = 0;

        while (i < binaryNumber.Length)
        {
            simbol = binaryNumber.Substring(i, 4);
            switch (simbol)
            {
                case "0000":
                    arr.Add("0");
                    break;
                case "0001":
                    arr.Add("1");
                    break;
                case "0010":
                    arr.Add("2");
                    break;
                case "0011":
                    arr.Add("3");
                    break;
                case "0100":
                    arr.Add("4");
                    break;
                case "0101":
                    arr.Add("5");
                    break;
                case "0110":
                    arr.Add("6");
                    break;
                case "0111":
                    arr.Add("7");
                    break;
                case "1000":
                    arr.Add("8");
                    break;
                case "1001":
                    arr.Add("9");
                    break;
                case "1010":
                    arr.Add("A");
                    break;
                case "1011":
                    arr.Add("B");
                    break;
                case "1100":
                    arr.Add("C");
                    break;
                case "1101":
                    arr.Add("D");
                    break;
                case "1110":
                    arr.Add("E");
                    break;
                case "1111":
                    arr.Add("F");
                    break;
            }

            i = i + 4;
        }

        StringBuilder builder = new StringBuilder();
        foreach (string n in arr)
        {
            builder.Append(n);
        }
        Console.WriteLine();
        Console.Write("Result: ");
        Console.WriteLine(builder.ToString());
        Console.WriteLine();
    }
}


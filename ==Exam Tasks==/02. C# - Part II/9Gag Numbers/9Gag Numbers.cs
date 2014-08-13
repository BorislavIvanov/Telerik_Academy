using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string nineGagWord = "";

        StringBuilder nineBaseNumber = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            nineGagWord += input[i];

            if (nineGagWord.Length >= 2)
            {
                switch (nineGagWord)
                {
                    case "-!": nineBaseNumber.Append("0"); nineGagWord = ""; break;
                    case "**": nineBaseNumber.Append("1"); nineGagWord = ""; break;
                    case "!!!": nineBaseNumber.Append("2"); nineGagWord = ""; break;
                    case "&&": nineBaseNumber.Append("3"); nineGagWord = ""; break;
                    case "&-": nineBaseNumber.Append("4"); nineGagWord = ""; break;
                    case "!-": nineBaseNumber.Append("5"); nineGagWord = ""; break;
                    case "*!!!": nineBaseNumber.Append("6"); nineGagWord = ""; break;
                    case "&*!": nineBaseNumber.Append("7"); nineGagWord = ""; break;
                    case "!!**!-": nineBaseNumber.Append("8"); nineGagWord = ""; break;
                    default: break;
                }
            }
        }

        BigInteger decimalNumber = default(BigInteger);
        int mathPower = nineBaseNumber.Length - 1;

        for (int c = 0; c < nineBaseNumber.Length; c++)
        {
            BigInteger mathPowerResult = 1;
            for (int j = 0; j < mathPower; j++)
            {
                mathPowerResult *= 9;
            }

            ulong calculation = (ulong)(int.Parse(nineBaseNumber[c].ToString()) * mathPowerResult);
            decimalNumber += calculation;

            mathPower--;
        }

        Console.WriteLine(decimalNumber);
    }
}
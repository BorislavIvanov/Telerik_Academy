using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string inputString = Console.ReadLine();

        int alienDigitsCount = inputString.Length / 3;
        int currentAlienDigit = 0;

        string[] alienDigitsFromMesage = new string[alienDigitsCount];

        for (int i = 0; i < alienDigitsCount; i++)
        {
            alienDigitsFromMesage[i] = String.Format("{0}{1}{2}", 
                inputString[currentAlienDigit], inputString[currentAlienDigit + 1], inputString[currentAlienDigit + 2]);
            
            currentAlienDigit += 3;
        }

        int[] fromAlienTo13Based = new int[alienDigitsFromMesage.Length];

        for (int d = 0; d < alienDigitsFromMesage.Length; d++)
        {
            switch (alienDigitsFromMesage[d])
            {
                case "CHU": fromAlienTo13Based[d] = 0; break;
                case "TEL": fromAlienTo13Based[d] = 1; break;
                case "OFT": fromAlienTo13Based[d] = 2; break;
                case "IVA": fromAlienTo13Based[d] = 3; break;
                case "EMY": fromAlienTo13Based[d] = 4; break;
                case "VNB": fromAlienTo13Based[d] = 5; break;
                case "POQ": fromAlienTo13Based[d] = 6; break;
                case "ERI": fromAlienTo13Based[d] = 7; break;
                case "CAD": fromAlienTo13Based[d] = 8; break;
                case "K-A": fromAlienTo13Based[d] = 9; break;
                case "IIA": fromAlienTo13Based[d] = 10; break;
                case "YLO": fromAlienTo13Based[d] = 11; break;
                case "PLA": fromAlienTo13Based[d] = 12; break;
                default: break;
            }
        }

        BigInteger decimalNumber = default(BigInteger);
        int mathPower = fromAlienTo13Based.Length - 1;

        for (int i = 0; i < fromAlienTo13Based.Length; i++)
        {
            ulong calculation = (ulong)(fromAlienTo13Based[i] * Math.Pow(13, mathPower));
            decimalNumber += calculation;
            mathPower--;
        }

        Console.WriteLine(decimalNumber);
    }
}


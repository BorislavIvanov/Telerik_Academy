using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string sentence = input;
        int wordsCount = input.Length / 4;

        string[] wordsDigits = new string[wordsCount];
        string[] wordsNumbers = new string[wordsCount];

        for (int i = 1; i <= wordsCount; i++)
        {
            string theWord = "";

            theWord = sentence.Substring(0, 4);

            switch (theWord)
            {
                case "Rawr":
                    wordsDigits[i - 1] = "0";
                    wordsNumbers[i - 1] = "0";
                    break;
                case "Rrrr":
                    wordsDigits[i - 1] = "1";
                    wordsNumbers[i - 1] = "1";
                    break;
                case "Hsst":
                    wordsDigits[i - 1] = "2";
                    wordsNumbers[i - 1] = "2";
                    break;
                case "Ssst":
                    wordsDigits[i - 1] = "3";
                    wordsNumbers[i - 1] = "3";
                    break;
                case "Grrr":
                    wordsDigits[i - 1] = "4";
                    wordsNumbers[i - 1] = "4";
                    break;
                case "Rarr":
                    wordsDigits[i - 1] = "5";
                    wordsNumbers[i - 1] = "5";
                    break;
                case "Mrrr":
                    wordsDigits[i - 1] = "6";
                    wordsNumbers[i - 1] = "6";
                    break;
                case "Psst":
                    wordsDigits[i - 1] = "7";
                    wordsNumbers[i - 1] = "7";
                    break;
                case "Uaah":
                    wordsDigits[i - 1] = "8";
                    wordsNumbers[i - 1] = "8";
                    break;
                case "Uaha":
                    wordsDigits[i - 1] = "9";
                    wordsNumbers[i - 1] = "9";
                    break;
                case "Zzzz":
                    wordsDigits[i - 1] = "A";
                    wordsNumbers[i - 1] = "10";
                    break;
                case "Bauu":
                    wordsDigits[i - 1] = "B";
                    wordsNumbers[i - 1] = "11";
                    break;
                case "Djav":
                    wordsDigits[i - 1] = "C";
                    wordsNumbers[i - 1] = "12";
                    break;
                case "Myau":
                    wordsDigits[i - 1] = "D";
                    wordsNumbers[i - 1] = "13";
                    break;
                case "Gruh":
                    wordsDigits[i - 1] = "E";
                    wordsNumbers[i - 1] = "14";
                    break;
                default:
                    break;
            }

            sentence = sentence.Remove(0, 4);
        }

        BigInteger decimalNumber = default(BigInteger);
        int mathPower = wordsCount - 1;

        for (int i = 0; i < wordsNumbers.Length; i++)
        {
            ulong calculation = (ulong)(int.Parse(wordsNumbers[i]) * Math.Pow(15, mathPower));
            decimalNumber += calculation;
            mathPower--;
            
        }

        Console.Write(decimalNumber);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.NegativeIntegersRemover
{
    class NegativeIntegersRemover
    {
        static void Main()
        {
            List<int> sequenceOfNumbers = new List<int>();

            ReadNumbers(sequenceOfNumbers);

            for (int i = sequenceOfNumbers.Count - 1; i >= 0; i--)
            {
                if (sequenceOfNumbers[i] < 0)
                {
                    sequenceOfNumbers.RemoveAt(i);
                }
            }

            Console.WriteLine("After clearing process: " + string.Join(", ", sequenceOfNumbers));
        }

        private static void ReadNumbers(List<int> sequenceOfNumbers)
        {
            while (true)
            {
                string inputLine = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(inputLine))
                {
                    break;
                }
                else
                {
                    int inputNumber = int.Parse(inputLine);
                    sequenceOfNumbers.Add(inputNumber);
                }
            }
        }
    }
}

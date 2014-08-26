using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.IncreasingSortedNumbers
{
    class IncreasingSort
    {
        static void Main()
        {
            List<int> sequenceOfNumbers = new List<int>();

            ReadNumbers(sequenceOfNumbers);

            sequenceOfNumbers.Sort();

            Console.WriteLine(string.Join(", ", sequenceOfNumbers));
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

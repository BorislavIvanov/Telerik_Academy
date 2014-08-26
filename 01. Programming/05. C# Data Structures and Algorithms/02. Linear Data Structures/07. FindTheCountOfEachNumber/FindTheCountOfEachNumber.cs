using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FindTheCountOfEachNumber
{
    class FindTheCountOfEachNumber
    {
        static void Main()
        {
            List<int> sequenceOfNumbers = new List<int>();

            ReadNumbers(sequenceOfNumbers);

            Dictionary<int, int> numberOccurs = new Dictionary<int, int>();

            foreach (int number in sequenceOfNumbers)
            {
                if (numberOccurs.ContainsKey(number))
                {
                    numberOccurs[number]++;
                }
                else
                {
                    numberOccurs.Add(number, 1);
                }
            }

            foreach (var pair in numberOccurs)
            {
                Console.WriteLine("Number {0} -> {1} Time/s", pair.Key, pair.Value);
            }
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

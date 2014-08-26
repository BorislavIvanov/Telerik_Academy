using System;
using System.Collections.Generic;

namespace _01.SumAndAverageOfTheElementsOfSequence
{
    class ConsoleNumbersOperator
    {
        static void Main()
        {
            List<int> sequenceOfNumbers = new List<int>();

            ReadNumbers(sequenceOfNumbers);

            int sumOfNumbers = OperationsWithIntegers.SumTheNumbers(sequenceOfNumbers);
            Console.WriteLine("The sum is: " + sumOfNumbers.ToString());

            var averageOfNumbers = OperationsWithIntegers.FindTheAverageNumber(sequenceOfNumbers);
            Console.WriteLine("The average is: " + averageOfNumbers);
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

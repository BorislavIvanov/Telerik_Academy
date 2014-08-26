using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverceNumbersWithStack
{
    class StackRevercer
    {
        static void Main()
        {
            Stack<int> sequenceOfNumbers = new Stack<int>();

            ReadNumbers(sequenceOfNumbers);

            Console.WriteLine(string.Join(", ", sequenceOfNumbers));
        }

        private static void ReadNumbers(Stack<int> sequenceOfNumbers)
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
                    sequenceOfNumbers.Push(inputNumber);
                }
            }
        }
    }
}

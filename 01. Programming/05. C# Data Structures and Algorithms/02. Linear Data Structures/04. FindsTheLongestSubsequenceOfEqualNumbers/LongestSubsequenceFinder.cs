using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindsTheLongestSubsequenceOfEqualNumbers
{
    public class LongestSubsequenceFinder
    {
        static void Main()
        {
            List<int> sequenceOfNumbers = new List<int>();

            ReadNumbers(sequenceOfNumbers);

            List<int> bestLargestSequence = FindLongestSubsequence(sequenceOfNumbers);

            Console.WriteLine(string.Join(", ", bestLargestSequence));
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

        public static List<int> FindLongestSubsequence(List<int> sequenceOfNumbers)
        {
            int currentLongestNumber = 0;
            int currentNumberCount = 0;

            int bestLongestNumber = 0;
            int bestNumberCount = 0;

            for (int i = 0; i < sequenceOfNumbers.Count; i++)
            {
                if (i == 0)
                {
                    currentLongestNumber = sequenceOfNumbers[i];
                    currentNumberCount++;
                }
                else
                {
                    if (sequenceOfNumbers[i] == currentLongestNumber)
                    {
                        currentNumberCount++;

                        if (i == sequenceOfNumbers.Count - 1)
                        {
                            if (currentNumberCount > bestNumberCount)
                            {
                                bestLongestNumber = currentLongestNumber;
                                bestNumberCount = currentNumberCount;
                            }
                        }
                    }
                    else
                    {
                        if (currentNumberCount > bestNumberCount)
                        {
                            bestLongestNumber = currentLongestNumber;
                            bestNumberCount = currentNumberCount;
                        }

                        currentLongestNumber = sequenceOfNumbers[i];
                        currentNumberCount = 1;
                    }
                }
            }

            List<int> bestLargestSequence = new List<int>();

            for (int i = 0; i < bestNumberCount; i++)
            {
                bestLargestSequence.Add(bestLongestNumber);
            }

            return bestLargestSequence;
        }
    }
}

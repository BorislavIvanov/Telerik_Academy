using System.Collections.Generic;

namespace _01.SumAndAverageOfTheElementsOfSequence
{
    static class OperationsWithIntegers
    {
        public static int SumTheNumbers(List<int> numbers)
        {
            int sumResult = 0;

            foreach (int number in numbers)
            {
                sumResult += number;
            }

            return sumResult;
        }

        public static int FindTheAverageNumber(List<int> numbers)
        {
            int sumOfNubers = SumTheNumbers(numbers);
            var result = sumOfNubers / numbers.Count;

            return result;
        }
    }
}

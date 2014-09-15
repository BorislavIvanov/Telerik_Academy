using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AllCombinationsWithDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the count of numbers: ");
            string firstConsoleInputCountOfNumbers = Console.ReadLine();
            int countOfNumbers = int.Parse(firstConsoleInputCountOfNumbers);

            Console.Write("Enter the count in set: ");
            string secondConsoleInputCountInSet = Console.ReadLine();
            int countInSet = int.Parse(secondConsoleInputCountInSet);

            int[] arr = new int[countInSet];

            ShowAllCombinationsInSets(arr, 1, countOfNumbers, 0);
        }

        private static void ShowAllCombinationsInSets(int[] array, int startNumber, int endNumber, int index)
        {
            if (index >= array.Length)
            {
                Console.WriteLine(String.Join(", ", array));
            }
            else
            {
                for (int i = startNumber; i <= endNumber; i++)
                {
                    array[index] = startNumber;
                    ShowAllCombinationsInSets(array, startNumber, endNumber, index + 1);
                    startNumber++;
                }
            }
        }
    }
}

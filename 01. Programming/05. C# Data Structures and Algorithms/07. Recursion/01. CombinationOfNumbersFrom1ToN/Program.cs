using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CombinationOfNumbersFrom1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the count: ");
            string consoleInput = Console.ReadLine();
            int countOfNumbers = int.Parse(consoleInput);
            Console.WriteLine();

            int[] arr = new int[countOfNumbers];

            GetAllCombinations(arr, 1, countOfNumbers, 0);
        }

        private static void GetAllCombinations(int[] arr, int startNumber, int endNumber, int index)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(String.Join(", ", arr));
            }
            else
            {
                for (int i = startNumber; i <= endNumber; i++)
                {
                    arr[index] = i;
                    GetAllCombinations(arr, 1, endNumber, index + 1);
                    startNumber++;
                }
            }
        }
    }
}

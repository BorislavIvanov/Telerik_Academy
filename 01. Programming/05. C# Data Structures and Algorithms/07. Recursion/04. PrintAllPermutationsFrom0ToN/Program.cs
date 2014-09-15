using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintAllPermutationsFrom0ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the count of numbers: ");
            string consoleInput = Console.ReadLine();
            int countOfNumbers = int.Parse(consoleInput);

            int[] permutations = new int[countOfNumbers];
            bool[] usedNumbers = new bool[countOfNumbers];

            GetAllPermutations(countOfNumbers, 0, permutations, usedNumbers);
        }

        private static void GetAllPermutations(int countOfNumbers, int index, int[] permutations, bool[] usedNumbers)
        {
            if (index >= permutations.Length)
            {
                Console.WriteLine(String.Join(", ", permutations));
            }
            else
            {
                for (int i = 0; i < countOfNumbers; i++)
                {
                    if (usedNumbers[i])
                    {
                        continue;
                    }

                    usedNumbers[i] = true;
                    permutations[index] = i + 1;
                    GetAllPermutations(countOfNumbers, index + 1, permutations, usedNumbers);
                    usedNumbers[i] = false;
                }
            }
        }
    }
}

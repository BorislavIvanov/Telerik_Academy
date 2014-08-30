using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountTheOccurrencesOfGivenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] arrayOfInputNumbers = inputLine.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> occurences = new Dictionary<string, int>();
            
            foreach (var number in arrayOfInputNumbers)
            {
                if (occurences.ContainsKey(number))
                {
                    occurences[number]++;
                }
                else
                {
                    occurences.Add(number, 1);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Result: ");

            foreach (var pair in occurences)
            {
                Console.WriteLine("{0} -> {1} time/s", pair.Key, pair.Value);
            }

            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OccurrencesOddNumberOfTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] arrayOfInputWords = inputLine.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> occurences = new Dictionary<string, int>();

            foreach (var word in arrayOfInputWords)
            {
                if (occurences.ContainsKey(word.ToUpper()))
                {
                    occurences[word.ToUpper()]++;
                }
                else
                {
                    occurences.Add(word.ToUpper(), 1);
                }
            }

            Console.WriteLine();
            Console.Write("Result: ");

            foreach (var pair in occurences)
            {
                if (pair.Value % 2 == 0)
                {
                    Console.Write("{0} ", pair.Key);
                }
            }

            Console.WriteLine();
        }
    }
}

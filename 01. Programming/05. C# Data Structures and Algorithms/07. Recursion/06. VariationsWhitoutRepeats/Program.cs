using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.VariationsWhitoutRepeats
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Count of words: ");
            //string inputCountOfWords = Console.ReadLine();
            //int countOfWords = int.Parse(inputCountOfWords);

            //int countOfWordsInSet = default(int);
            //do
            //{
            //    Console.Write("Number of words in one set(must be lower than words count): ");
            //    string inputCountOfWordsInSet = Console.ReadLine();
            //    countOfWordsInSet = int.Parse(inputCountOfWordsInSet);
            //} while (countOfWordsInSet >= countOfWords);
            

            //Console.Write("Enter " + countOfWords + " words separeted with ', ': ");
            //string allWords = Console.ReadLine();
            //string[] arrayOfWords = new string[countOfWords];
            //arrayOfWords = allWords.Split(new string[]{", "}, StringSplitOptions.RemoveEmptyEntries);

            int countOfWordsInSet = 2;
            string[] arrayOfWords = {"test", "rock", "fun"};

            string[] variationsArray = new string[countOfWordsInSet];

            GetAllViariationsWithoutRepeats(arrayOfWords, variationsArray, countOfWordsInSet, 0, 0);
        }

        private static void GetAllViariationsWithoutRepeats(string[] words, string[] variations, int wordsInSet, int startIndex, int depth)
        {
            if (depth >= variations.Length)
            {
                Console.WriteLine("< " + String.Join(", ", variations) + " >");
            }
            else
            {
                for (int i = startIndex; i < words.Length; i++, startIndex++)
                {
                    variations[depth] = words[i];
                    GetAllViariationsWithoutRepeats(words, variations, wordsInSet, startIndex + 1, depth + 1);
                }
            }
        }
    }
}

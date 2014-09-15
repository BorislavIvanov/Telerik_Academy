using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.VariationsWithRepeats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Count of words: ");
            string inputCountOfWords = Console.ReadLine();
            int countOfWords = int.Parse(inputCountOfWords);

            int countOfWordsInSet = default(int);
            do
            {
                Console.Write("Number of words in one set(must be lower than words count): ");
                string inputCountOfWordsInSet = Console.ReadLine();
                countOfWordsInSet = int.Parse(inputCountOfWordsInSet);
            } while (countOfWordsInSet >= countOfWords);
            

            Console.Write("Enter " + countOfWords + " words separeted with ', ': ");
            string allWords = Console.ReadLine();
            string[] arrayOfWords = new string[countOfWords];
            arrayOfWords = allWords.Split(new string[]{", "}, StringSplitOptions.RemoveEmptyEntries);

            string[] variationsArray = new string[countOfWordsInSet];

            GetAllViariationsWithRepeats(arrayOfWords, variationsArray, countOfWordsInSet, 0);
        }

        private static void GetAllViariationsWithRepeats(string[] words, string[] variations, int wordsInSet, int index)
        {
            if (index >= variations.Length)
            {
                Console.WriteLine("< " + String.Join(", ", variations) + " >");
            }
            else
            {
                for (int i = 0; i < words.Length; i++)
                {
                    variations[index] = words[i];
                    GetAllViariationsWithRepeats(words, variations, wordsInSet, index + 1);
                }
            }
        }
    }
}

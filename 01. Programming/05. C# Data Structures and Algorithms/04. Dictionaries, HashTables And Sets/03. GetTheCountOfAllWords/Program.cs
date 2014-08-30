using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.GetTheCountOfAllWords
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader textReader = new StreamReader(@"..\..\words.txt");

            string allText = default(string);

            using (textReader)
            {
                allText = textReader.ReadToEnd();
            }

            string[] arrayOfWords =
                allText.Split(new char[] { ' ', '-', '!', ',', '?', '.' },
                StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> occurences = new Dictionary<string, int>();

            foreach (var word in arrayOfWords)
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

            var sortedDictionary =
                from w in occurences
                orderby w.Value ascending
                select w;

            Console.WriteLine("Result:");

            foreach (var pair in sortedDictionary)
            {
                Console.WriteLine("{0} -> {1} Time/s", pair.Key, pair.Value);
            }
        }
    }
}

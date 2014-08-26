using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.FindMajorantOfArray
{
    class FindMajorantOfArray
    {
        public static void Main()
        {
            List<int> numbers = new List<int>() { 3, 4, 4, 2, 3, 3, 3, 3, 3, 2, 5, 3, 5, 6, 3, 5, 3 };
            Dictionary<int, int> occures = new Dictionary<int, int>();
            foreach (var item in numbers)
            {
                if (occures.ContainsKey(item))
                {
                    occures[item]++;
                }
                else
                {
                    occures.Add(item, 1);
                }
            }

            int maxOccures = occures.Max(x => x.Value);
            int countAllElements = numbers.Count;
            if (maxOccures >= countAllElements / 2 + 1)
            {
                Console.WriteLine("majorant is: {0}", maxOccures);
            }
            else
            {
                Console.WriteLine("majorant not exist");
            }
        }


        private static List<int> ReadNumbers()
        {
            int n;
            string str;
            List<int> numbers = new List<int>();
            do
            {
                Console.WriteLine("Enter number:");
                str = Console.ReadLine();
                if (int.TryParse(str, out n))
                {
                    numbers.Add(n);
                }
            }
            while (str != "");

            return numbers;
        }
    }
}

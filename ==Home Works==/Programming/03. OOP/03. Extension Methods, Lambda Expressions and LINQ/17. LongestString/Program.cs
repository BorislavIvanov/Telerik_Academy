using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            List<string> listOfStrings = new List<string>(){
                "awdawdawdwavvawb",
                "   ",
                "",
                "awoevjriwuevriwuevjriwujv",
                "awve234235b"
            };

            string longestString =
                (from str in listOfStrings
                 orderby str.Length descending
                 select str).ElementAt(0);

            Console.WriteLine(longestString);
        }
    }

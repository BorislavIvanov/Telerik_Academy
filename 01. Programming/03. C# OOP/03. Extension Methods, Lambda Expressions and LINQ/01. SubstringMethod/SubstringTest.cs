// 01. Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder
//and has the same functionality as Substring in the class String.

using System;
using System.Text;

namespace _01.SubstringMethod
{
    class SubstringTest
    {
        static void Main()
        {
            StringBuilder theString = new StringBuilder();
            theString.Append("0123456789");

            Console.WriteLine(theString.SubString(5));
            Console.WriteLine(theString.SubString(2, 5));
        }
    }
}

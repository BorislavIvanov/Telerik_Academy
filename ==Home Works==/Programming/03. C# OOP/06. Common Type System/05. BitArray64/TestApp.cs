// 05. Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> and 
//Equals(…), GetHashCode(), [], == and !=.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        BitArray64 num = new BitArray64(99);

        foreach (var bit in num)
        {
            Console.Write(bit);
        }
        Console.WriteLine();

        BitArray64 number2 = new BitArray64(7);

        Console.WriteLine(num.Equals(number2));

        Console.WriteLine(num[2]);

        Console.WriteLine(num.GetHashCode());

        num[8] = 1;
        num[50] = 1;

        Console.WriteLine(num.Number);
        foreach (var bit in num)
        {
            Console.Write(bit);
        }
        Console.WriteLine();
    }
}
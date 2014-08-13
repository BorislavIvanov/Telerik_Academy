// 02. Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Test
{
    static void Main()
    {
        int[] numbers = { 5, 6, 7, 8, 9, 0 };
        Console.WriteLine("Result: ");
        Console.Write("Sum: ");
        Console.WriteLine(numbers.Sum());
        Console.Write("Product: ");
        Console.WriteLine(numbers.Product());
        Console.Write("Max: ");
        Console.WriteLine(numbers.Max());
        Console.Write("Min: ");
        Console.WriteLine(numbers.Min());
        Console.Write("Average: ");
        Console.WriteLine(numbers.Average());
        Console.WriteLine();
    }
}
//Create a program that assigns null values to an integer and to double variables.
//Try to print them on the console, try to add some values or the null literal to them and see the result.

using System;

class NullValues
{
    static void Main()
    {
        Console.Title = "NullValues";

        int? value1 = null;
        double? value2 = null;
        
        Console.WriteLine("Value1 int - {0}  and Value2 double - {1} ", value1, value2);

        value1 += null;
        value2 += 5.621454;

        Console.WriteLine("Value1 int - {0}  and Value2 double - {1} ", value1, value2);
    }
}


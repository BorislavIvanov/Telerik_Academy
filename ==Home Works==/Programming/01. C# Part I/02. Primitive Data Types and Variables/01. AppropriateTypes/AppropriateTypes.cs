//Declare five variables choosing for each of them the most appropriate
//of the types byte, sbyte, short, ushort, int, uint, long, ulong
//to represent the following values: 52130, -115, 4825932, 97, -10000.

using System;

class AppropriateTypes
{
    static void Main()
    {
        Console.Title = "AppropriateTypes";

        ushort one = 52130;
        sbyte two = -115;
        int three = 4825932;
        byte four = 97;
        short five = -10000;

        Console.WriteLine("{0} > ushort\n{1} > sbyte\n{2} > int\n{3} > byte\n{4} > short", one, two, three, four, five);

        // or :) ...
        //Console.WriteLine("{0}   > ushort", one);
        //Console.WriteLine("{0}    > sbyte", two);
        //Console.WriteLine("{0} > int", three);
        //Console.WriteLine("{0}      > byte", four);
        //Console.WriteLine("{0}  > short", five);
    }
}


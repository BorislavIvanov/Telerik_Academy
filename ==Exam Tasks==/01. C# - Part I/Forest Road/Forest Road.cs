using System;

class ForestRoad
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberN; i++)
        {
            Console.Write(new string ('.', i));
            Console.Write("*");
            Console.Write(new string ('.', (numberN - 1) - i));
            Console.WriteLine();
        }

        for (int i = numberN - 1; i > 0; i--)
        {
            Console.Write(new string ('.', i - 1));
            Console.Write("*");
            Console.WriteLine(new string ('.', (numberN - i)));
        }
    }
}


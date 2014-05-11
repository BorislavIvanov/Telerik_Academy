using System;

class Trapezoid
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        Console.Write(new string ('.', numberN));
        Console.Write(new string ('*', numberN));
        Console.WriteLine();

        int beforeStar = numberN - 1;
        int afterStar = numberN - 1;

        for (int i = 1; i < numberN; i++)
            {
                Console.Write(new string ('.', beforeStar));
                Console.Write("*");
                Console.Write(new string ('.', afterStar));
                Console.Write("*");
                Console.WriteLine();

                beforeStar--;
                afterStar++;
            }
        Console.WriteLine(new string ('*', numberN + numberN));
    }
}
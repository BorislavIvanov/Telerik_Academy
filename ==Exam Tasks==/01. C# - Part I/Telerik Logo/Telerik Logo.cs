using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());

        int y = x;

        int z = (x / 2) + 1;

        Console.Write(new string('.', z - 1));
        Console.Write("*");
        Console.Write(new string('.', (x + x) - 3));
        Console.Write("*");
        Console.WriteLine(new string('.', z - 1));

        int midHorn = 1;
        int midV = (x + x) - 5;

        for (int i = 1; i < z; i++)
        {
            Console.Write(new string('.', z - 1 - i));
            Console.Write("*");
            Console.Write(new string('.', midHorn));
            Console.Write("*");
            Console.Write(new string('.', midV));
            Console.Write("*");
            Console.Write(new string('.', midHorn));
            Console.Write("*");
            Console.WriteLine(new string('.', z - 1 - i));

            midHorn += 2;
            midV -= 2;
        }

        for (int i = 0; i < x - z - 1; i++)
        {
            Console.Write(new string('.', midHorn));
            Console.Write("*");
            Console.Write(new string('.', midV));
            Console.Write("*");
            Console.WriteLine(new string('.', midHorn));

            midHorn++;
            midV -= 2;
        }

        Console.Write(new string('.', midHorn));
        Console.Write("*");
        Console.WriteLine(new string('.', midHorn));

        midHorn--;
        midV += 2;

        for (int i = 0; i < x - 2; i++)
        {
            Console.Write(new string('.', midHorn));
            Console.Write("*");
            Console.Write(new string('.', midV));
            Console.Write("*");
            Console.WriteLine(new string('.', midHorn));

            midHorn--;
            midV += 2;
        }

        for (int i = 0; i < x - 1; i++)
        {
            Console.Write(new string('.', midHorn));
            Console.Write("*");
            Console.Write(new string('.', midV));
            Console.Write("*");
            Console.WriteLine(new string('.', midHorn));

            midHorn++;
            midV -= 2;
        }

        Console.Write(new string('.', midHorn));
        Console.Write("*");
        Console.Write(new string('.', midHorn));
    }
}
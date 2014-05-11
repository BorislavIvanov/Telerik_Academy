using System;

class Tower
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());

        int before = height - 1;
        int after = height - 1;
        int middle = 2;

        Console.Write(new string('.', before));
        Console.Write('/');
        Console.Write('\\');
        Console.WriteLine(new string('.', after));

        for (int i = 2; i < height + 1; i++)
        {
            if (i == 2 || i == 4 || i == 7 || i == 11 || i == 16 || i == 22 || i == 29 || i == 37 || i == 46)
            {
            before--;
            after--;
            Console.Write(new string('.', before));
            Console.Write('/');
            Console.Write(new string('-', middle));
            Console.Write('\\');
            Console.WriteLine(new string('.', after));

            middle += 2;
            }

            else
            {
            before--;
            after--;
            Console.Write(new string('.', before));
            Console.Write('/');
            Console.Write(new string('.', middle));
            Console.Write('\\');
            Console.WriteLine(new string('.', after));

            middle += 2;
            }
            
        }
    }
}
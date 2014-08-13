using System;

class UKFlag
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        for (int i = size / 2; i > 0; i--)
        {
            Console.Write(new string('.', size / 2 - i));
            Console.Write("\\");
            Console.Write(new string('.', i - 1));
            Console.Write("|");
            Console.Write(new string('.', i - 1));
            Console.Write("/");
            Console.WriteLine(new string('.', size / 2 - i));
        }

        string midLine = String.Format(("{0}*{1}"), new string('-', (size / 2)), new string('-', (size / 2)));
        Console.WriteLine(midLine);

        for (int i = size / 2; i > 0; i--)
        {
            Console.Write(new string('.', i - 1));
            Console.Write("/");
            Console.Write(new string('.', size / 2 - i));
            Console.Write("|");
            Console.Write(new string('.', size / 2 - i));
            Console.Write("\\");
            Console.WriteLine(new string('.', i - 1));
        }
    }
}
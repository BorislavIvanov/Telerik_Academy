using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dots = 0;
        int stars = n;

        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.Write(new string('.', dots));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('.', dots));
            dots++;
            stars -= 2; 
        }

        dots -= 2;
        stars += 4;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', dots));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('.', dots));
            dots--;
            stars += 2;
        }
    }
}